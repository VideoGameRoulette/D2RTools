using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DRIPTool
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
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
                        if (line.Contains("ESTABLISHED") && !line.Contains("127.0.0.1") && !line.Contains("24.105.29.76"))
                        {
                            IPList.Add(line);
                        }
                    }

                    string[] currentServerData = Regex.Split(IPList.Last(), ",");
                    CurrentIP.Text = currentServerData.Last();
                    SetTextColor();
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
            }
            else if (CheckedIPList.Items.Contains(CurrentIP.Text) || SearchBar.Text != string.Empty && SearchBar.Text != "0.0.0.0" && SearchBar.Text != CurrentIP.Text)
            {
                CurrentIP.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                CurrentIP.ForeColor = System.Drawing.Color.White;
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
            if (result == DialogResult.OK)
            {
                CheckedIPList.Items.RemoveAt(CheckedIPList.SelectedIndex);
                SetTextColor();
            }
        }

        private void twitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.twitch.tv/videogameroulette");
        }
    }
}
