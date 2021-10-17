using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GameOverlay.Drawing;
using GameOverlay.Windows;
using SharpDX.Direct2D1;

namespace DRIPTool
{
    public partial class MainUI : Form
    {
        private OverlayWindow _window;
        private Graphics _graphics;
        private WindowRenderTarget _device;

        private Process GetProcess() => Process.GetProcessesByName("d2r")?.FirstOrDefault();
        private Process gameProcess;
        private IntPtr gameWindowHandle;

        public int defaultTime = 30;
        public int currentTime = 30;

        private Font _consolasBold;

        private SolidBrush _white;
        private SolidBrush _red;
        private SolidBrush _green;
        private SolidBrush _gold;

        private SolidBrush _currentBrush;

        public MainUI()
        {
            InitializeComponent();
        }

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
            _device = (SharpDX.Direct2D1.WindowRenderTarget)typeof(Graphics).GetField("_device", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_graphics);

            _consolasBold = _graphics?.CreateFont("Diablo", 14, true);

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
            _window?.PlaceAbove(gameWindowHandle);
            _window?.FitTo(gameWindowHandle, true);

            try
            {
                _graphics?.BeginScene();
                _graphics?.ClearScene();

                _device.Transform = new SharpDX.Mathematics.Interop.RawMatrix3x2(1f, 0f, 0f, 1f, 0f, 0f);

                DrawOverlay();
            }
            catch (Exception ex)
            {
                checkBox2.Checked = false;
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
            float xOffset = 25;
            float yOffset = 1000;

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
            _graphics?.DrawText(_consolasBold, 20f, _gold, 0 + 15f, dy += 24, label);
            dx = 0 + 15f + GetStringSize(label) + 10f;
            _graphics?.DrawText(_consolasBold, 20f, color, dx, dy, val); //110f
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

                    foreach (string line in lines)
                    {
                        if (line.Contains("ESTABLISHED") && !line.Contains("127.0.0.1") && !line.Contains("24.105.29.76") && !line.Contains("137.221."))
                        {
                            IPList.Add(line);
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
                CurrentIP.ForeColor = System.Drawing.Color.Green;
                _currentBrush = _green;
            }
            else if (CheckedIPList.Items.Contains(CurrentIP.Text) || SearchBar.Text != string.Empty && SearchBar.Text != "0.0.0.0" && SearchBar.Text != CurrentIP.Text)
            {
                CurrentIP.ForeColor = System.Drawing.Color.Red;
                _currentBrush = _red;
            }
            else
            {
                CurrentIP.ForeColor = System.Drawing.Color.White;
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
            var result = MessageBox.Show("Are you sure you want to delete the entire list?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                CheckedIPList.Items.Clear();
            }
        }

        private void RemoveIP_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove this ip from the list?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK && CheckedIPList.SelectedIndex != -1)
            {
                CheckedIPList.Items.RemoveAt(CheckedIPList.SelectedIndex);
                SetTextColor();
            }
        }

        private void twitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.twitch.tv/videogameroulette");
        }

        private void StartTimer()
        {
            currentTime = 30;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) refreshTimer.Start();
            else refreshTimer.Stop();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            GetServerDetails();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
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

        private void overlayUpdate_Tick(object sender, EventArgs e)
        {
            ReceiveData();
        }
    }
}
