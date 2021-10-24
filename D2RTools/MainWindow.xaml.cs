using GameOverlay.Drawing;
using GameOverlay.Windows;
using SharpDX.Direct2D1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace D2RTools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer countdownTimer;
        private DispatcherTimer refreshTimer;
        private DispatcherTimer overlayUpdate;

        public MainWindow()
        {
            InitializeComponent();
            countdownTimer = new DispatcherTimer();
            countdownTimer.Interval = TimeSpan.FromSeconds(1);
            countdownTimer.Tick += countdownTimer_Tick;

            refreshTimer = new DispatcherTimer();
            refreshTimer.Interval = TimeSpan.FromSeconds(1);
            refreshTimer.Tick += refreshTimer_Tick;

            overlayUpdate = new DispatcherTimer();
            overlayUpdate.Interval = TimeSpan.FromSeconds(1);
            overlayUpdate.Tick += overlayUpdate_Tick;
        }

        private OverlayWindow _window;
        private Graphics _graphics;
        private WindowRenderTarget _device;

        private Process GetProcess() => ProcessBar.Text != "0" ? Process.GetProcessesByName("d2r")?[ConvertStringToInt(ProcessBar.Text)] : Process.GetProcessesByName("d2r")?.FirstOrDefault();
        private Process gameProcess;
        private IntPtr gameWindowHandle;

        public int currentTime;

        private Font _consolasBold;

        private SolidBrush _white;
        private SolidBrush _red;
        private SolidBrush _green;
        private SolidBrush _gold;

        private SolidBrush _currentBrush;

        private string[] FilteredIP = {
            "24.105.29.76", // GLOBAL??
            "34.117.122.6", // GLOBAL??
            "37.244.28.", // US
            "37.244.54.", // US
            "117.52.35.", // ASIA
            "127.0.0.1", // LOCAL
            "137.221.105.", // EU
            "137.221.106." // EU
        };

        [STAThread]
        public int Startup()
        {
            gameProcess = GetProcess();
            if (gameProcess == default)
                return 1;
            gameWindowHandle = gameProcess.MainWindowHandle;

            DEVMODE devMode = default;
            devMode.dmSize = (short)Marshal.SizeOf<DEVMODE>();
            PInvoke.EnumDisplaySettings(null, -1, ref devMode);

            // Create and initialize the overlay window.
            _window = new OverlayWindow(0, 0, devMode.dmPelsWidth, devMode.dmPelsHeight);
            _window?.Create();

            // Create and initialize the graphics object.
            _graphics = new Graphics()
            {
                MeasureFPS = false,
                PerPrimitiveAntiAliasing = false,
                TextAntiAliasing = true,
                UseMultiThreadedFactories = false,
                VSync = false,
                Width = _window.Width,
                Height = _window.Height,
                WindowHandle = _window.Handle
            };
            _graphics?.Setup();

            // Get a refernence to the underlying RenderTarget from SharpDX. This'll be used to draw portions of images.
            _device = (WindowRenderTarget)typeof(Graphics).GetField("_device", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_graphics);

            _consolasBold = _graphics?.CreateFont(CustomFontFamily.Text, ConvertStringToInt(CustomFontSize.Text), true);

            _white = _graphics?.CreateSolidBrush(255, 255, 255);
            _red = _graphics?.CreateSolidBrush(255, 0, 0);
            _green = _graphics?.CreateSolidBrush(0, 255, 0);
            _gold = _graphics?.CreateSolidBrush(212, 196, 145);

            _currentBrush = _gold;

            return 0;
        }

        public int Shutdown()
        {

            _white?.Dispose();
            _red?.Dispose();
            _green?.Dispose();
            _gold?.Dispose();

            _currentBrush?.Dispose();

            _consolasBold?.Dispose();

            _device = null; // We didn't create this object so we probably shouldn't be the one to dispose of it. Just set the variable to null so the reference isn't held.
            _graphics?.Dispose(); // This should technically be the one to dispose of the _device object since it was pulled from this instance.
            _graphics = null;
            _window?.Dispose();
            _window = null;

            gameProcess?.Dispose();
            gameProcess = null;

            return 0;
        }

        public int ReceiveData()
        {
            if (gameProcess.HasExited)
            {
                checkBox1.IsChecked = false;
                return 0;
            }
            _window?.PlaceAbove(gameWindowHandle);
            _window?.FitTo(gameWindowHandle, true);

            try
            {
                _graphics?.BeginScene();
                _graphics?.ClearScene();
                _device.Transform = new SharpDX.Mathematics.Interop.RawMatrix3x2(ConvertStringToInt(CustomScale.Text), 0f, 0f, ConvertStringToInt(CustomScale.Text), 0f, 0f);
                DrawOverlay();
            }
            catch (Exception ex)
            {
                checkBox2.IsChecked = false;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                _graphics?.EndScene();
            }

            return 0;
        }

        private void DrawOverlay()
        {
            float xOffset = ConvertStringToInt(CustomX.Text);
            float yOffset = ConvertStringToInt(CustomY.Text);

            string[] args = CurrentIP.Text.Split('.');
            DrawTextBlock(ref xOffset, ref yOffset, "IP: ", args.Last(), _currentBrush);
            DrawTextBlock(ref xOffset, ref yOffset, "Time: ", CountdownLabel.Text, _gold);
        }

        private float GetStringSize(string str, float size = 20f)
        {
            return (float)_graphics?.MeasureString(_consolasBold, size, str).X;

        }

        private void DrawTextBlock(ref float dx, ref float dy, string label, string val, SolidBrush color)
        {
            _graphics?.DrawText(_consolasBold, ConvertStringToFloat(CustomFontSize.Text), _gold, dx, dy += 24, label);
            var dx2 = dx + GetStringSize(label) + 5f;
            _graphics?.DrawText(_consolasBold, ConvertStringToFloat(CustomFontSize.Text), color, dx2, dy, val); //110f
        }

        public void GetServerDetails()
        {
            try
            {
                using (Process p = new Process())
                {

                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.Arguments = "-c -n d2r";
                    ps.FileName = "tcpvcon64.exe";
                    if (!File.Exists(ps.FileName))
                    {
                        checkBox2.IsChecked = false;
                        return;
                    }
                    ps.UseShellExecute = false;
                    ps.CreateNoWindow = true;
                    ps.WindowStyle = ProcessWindowStyle.Hidden;
                    ps.RedirectStandardInput = true;
                    ps.RedirectStandardOutput = true;
                    ps.RedirectStandardError = true;

                    p.StartInfo = ps;
                    p.Start();

                    StreamReader stdOutput = p.StandardOutput;
                    StreamReader stdError = p.StandardError;

                    string content = stdOutput.ReadToEnd() + stdError.ReadToEnd();
                    //Get The Rows
                    string[] lines = Regex.Split(content, "\r\n");

                    List<string> IPList = new List<string>();

                    if (gameProcess == default) gameProcess = GetProcess();

                    foreach (string line in lines)
                    {
                        if (line.Contains("ESTABLISHED"))
                        {
                            if (!line.Contains(FilteredIP[0]) &&
                                !line.Contains(FilteredIP[1]) &&
                                !line.Contains(FilteredIP[2]) &&
                                !line.Contains(FilteredIP[3]) &&
                                !line.Contains(FilteredIP[4]) &&
                                !line.Contains(FilteredIP[5]) &&
                                !line.Contains(FilteredIP[6]) &&
                                !line.Contains(FilteredIP[7]) &&
                                line.Contains(gameProcess.Id.ToString()))
                            {
                                IPList.Add(line);
                            }
                        }
                    }

                    if (IPList.Count > 0)
                    {
                        string[] currentServerData = Regex.Split(IPList.Last(), ",");
                        if (CurrentIP.Text != currentServerData.Last())
                        {
                            CurrentIP.Text = currentServerData.Last();
                            StartTimer();
                        }
                        SetTextColor();
                    }
                    else if (IPList.Count == 0)
                    {
                        CurrentIP.Text = "0.0.0.0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetTextColor()
        {
            if (SearchBar.Text != string.Empty && SearchBar.Text != "0.0.0.0" && SearchBar.Text == CurrentIP.Text)
            {
                CurrentIP.Foreground = Brushes.Green;
                _currentBrush = _green;
            }
            else if (CheckedIPList.Items.Contains(CurrentIP.Text) || SearchBar.Text != string.Empty && SearchBar.Text != "0.0.0.0" && SearchBar.Text != CurrentIP.Text)
            {
                CurrentIP.Foreground = Brushes.Red;
                _currentBrush = _red;
            }
            else
            {
                CurrentIP.Foreground = Brushes.White;
                _currentBrush = _gold;
            }
        }

        private void FetchIP_Click(object sender, EventArgs e)
        {
            GetServerDetails();
        }

        private void CopyIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CurrentIP.Text);
        }

        private void CheckedIP_Click(object sender, EventArgs e)
        {
            if (!CheckedIPList.Items.Contains(CurrentIP.Text))
            {
                CheckedIPList.Items.Add(CurrentIP.Text);
                SetCount(CheckedIPList.Items.Count);
                SetTextColor();
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            CheckedIPList.Items.Clear();
        }

        private void RemoveIP_Click(object sender, EventArgs e)
        {
            if (CheckedIPList.SelectedIndex != -1)
            {
                CheckedIPList.Items.RemoveAt(CheckedIPList.SelectedIndex);
                SetTextColor();
            }
        }

        private void StartTimer()
        {
            currentTime = ConvertStringToInt(CustomCooldown.Text);
            SetTime(currentTime);
            countdownTimer.Start();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (currentTime > 0)
            {
                currentTime -= 1;
                SetTime(currentTime);
            }
            else
            {
                SetTime(0);
                countdownTimer.Stop();
            }
        }

        private void SetTime(int i)
        {
            CountdownLabel.Text = string.Format("{0}", i);
        }

        private void SetCount(int i)
        {
            ServersCheckedLabel.Text = string.Format("Servers Checked: {0}", i);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            GetServerDetails();
        }

        private void overlayUpdate_Tick(object sender, EventArgs e)
        {
            ReceiveData();
        }

        private void RestartTimer_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox2.IsChecked == true) refreshTimer.Start();
            else refreshTimer.Stop();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                Startup();
                overlayUpdate.Start();
            }
            else
            {
                Shutdown();
                overlayUpdate.Stop();
            }
        }

        private int ConvertStringToInt(string s)
        {
            int i = 0;
            var result = int.TryParse(s, out i);
            if (result) return i;
            return 0;
        }

        private float ConvertStringToFloat(string s)
        {
            float i = 0;
            var result = float.TryParse(s, out i);
            if (result) return i;
            return 0f;
        }

        private void ProcessBar_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex r = new Regex("[^0-9]+");
            e.Handled = r.IsMatch(e.Text);
        }

        private void ProcessBar_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string s = ProcessBar.Text;
            string s2 = s.TrimStart('0');
            int i = ConvertStringToInt(s2);
            Process[] p = Process.GetProcessesByName("d2r");
            int l = p.Length - 1;
            if (i > p.Length)
            {
                ProcessBar.Text = l == -1 ? "0" : l.ToString();
            }
        }
    }
}
