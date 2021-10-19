
namespace D2RIPTool
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.CurrentIP = new System.Windows.Forms.Label();
            this.FetchIP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearAll = new System.Windows.Forms.Button();
            this.RemoveIP = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ServersCheckedLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CheckedIPList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.RestartTimer = new System.Windows.Forms.Button();
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.CustomCooldown = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomScale = new System.Windows.Forms.TextBox();
            this.CustomFontSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomFontFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomY = new System.Windows.Forms.TextBox();
            this.CustomX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.twitch = new System.Windows.Forms.LinkLabel();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.overlayUpdate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentIP
            // 
            this.CurrentIP.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CurrentIP, 2);
            this.CurrentIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentIP.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIP.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentIP.Location = new System.Drawing.Point(3, 176);
            this.CurrentIP.Name = "CurrentIP";
            this.CurrentIP.Size = new System.Drawing.Size(444, 50);
            this.CurrentIP.TabIndex = 1;
            this.CurrentIP.Text = "0.0.0.0";
            this.CurrentIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FetchIP
            // 
            this.FetchIP.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FetchIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FetchIP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FetchIP.ForeColor = System.Drawing.SystemColors.Control;
            this.FetchIP.Location = new System.Drawing.Point(3, 3);
            this.FetchIP.Name = "FetchIP";
            this.FetchIP.Size = new System.Drawing.Size(68, 23);
            this.FetchIP.TabIndex = 2;
            this.FetchIP.Text = "Fetch IP";
            this.FetchIP.UseVisualStyleBackColor = false;
            this.FetchIP.Click += new System.EventHandler(this.FetchIP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SearchBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CurrentIP, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CheckedIPList, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.twitch, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 611);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableLayoutPanel1.SetColumnSpan(this.SearchBar, 2);
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBar.ForeColor = System.Drawing.SystemColors.Control;
            this.SearchBar.Location = new System.Drawing.Point(3, 116);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(444, 20);
            this.SearchBar.TabIndex = 5;
            this.SearchBar.Text = "0.0.0.0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FetchIP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(77, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Checked IP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CheckedIP_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(373, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Copy IP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CopyIP_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.ClearAll, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.RemoveIP, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 543);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(444, 35);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // ClearAll
            // 
            this.ClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAll.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearAll.Location = new System.Drawing.Point(225, 6);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(216, 23);
            this.ClearAll.TabIndex = 10;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // RemoveIP
            // 
            this.RemoveIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveIP.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RemoveIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveIP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveIP.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveIP.Location = new System.Drawing.Point(3, 6);
            this.RemoveIP.Name = "RemoveIP";
            this.RemoveIP.Size = new System.Drawing.Size(216, 23);
            this.RemoveIP.TabIndex = 8;
            this.RemoveIP.Text = "Remove Selected IP";
            this.RemoveIP.UseVisualStyleBackColor = false;
            this.RemoveIP.Click += new System.EventHandler(this.RemoveIP_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(294, 107);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::D2RIPTool.Properties.Resources.D2R;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 101);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.checkBox2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.ServersCheckedLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(150, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(141, 100);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox2.Location = new System.Drawing.Point(3, 82);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(135, 15);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Enable DX Overlay";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.dxOverlay_CheckedChanged);
            // 
            // ServersCheckedLabel
            // 
            this.ServersCheckedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServersCheckedLabel.AutoSize = true;
            this.ServersCheckedLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServersCheckedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ServersCheckedLabel.Location = new System.Drawing.Point(3, 21);
            this.ServersCheckedLabel.Name = "ServersCheckedLabel";
            this.ServersCheckedLabel.Size = new System.Drawing.Size(135, 15);
            this.ServersCheckedLabel.TabIndex = 14;
            this.ServersCheckedLabel.Text = "Servers Checked: 0";
            this.ServersCheckedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(3, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 15);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Enable Auto Fetch";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.autoFetch_CheckedChanged);
            // 
            // CheckedIPList
            // 
            this.CheckedIPList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableLayoutPanel1.SetColumnSpan(this.CheckedIPList, 2);
            this.CheckedIPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckedIPList.ForeColor = System.Drawing.SystemColors.Control;
            this.CheckedIPList.FormattingEnabled = true;
            this.CheckedIPList.Location = new System.Drawing.Point(3, 229);
            this.CheckedIPList.Name = "CheckedIPList";
            this.CheckedIPList.Size = new System.Drawing.Size(444, 308);
            this.CheckedIPList.TabIndex = 6;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.RestartTimer, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.CountdownLabel, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(303, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(144, 107);
            this.tableLayoutPanel6.TabIndex = 16;
            // 
            // RestartTimer
            // 
            this.RestartTimer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RestartTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartTimer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.RestartTimer.Location = new System.Drawing.Point(3, 76);
            this.RestartTimer.Name = "RestartTimer";
            this.RestartTimer.Size = new System.Drawing.Size(138, 28);
            this.RestartTimer.TabIndex = 5;
            this.RestartTimer.Text = "Restart Timer";
            this.RestartTimer.UseVisualStyleBackColor = false;
            this.RestartTimer.Click += new System.EventHandler(this.RestartTimer_Click);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountdownLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CountdownLabel.Location = new System.Drawing.Point(3, 0);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(138, 73);
            this.CountdownLabel.TabIndex = 13;
            this.CountdownLabel.Text = "30";
            this.CountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.CustomCooldown, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.CustomScale, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.CustomFontSize, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.CustomFontFamily, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.CustomY, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.CustomX, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(453, 229);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 8;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(178, 308);
            this.tableLayoutPanel7.TabIndex = 17;
            // 
            // CustomCooldown
            // 
            this.CustomCooldown.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CustomCooldown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomCooldown.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomCooldown.Location = new System.Drawing.Point(93, 153);
            this.CustomCooldown.Name = "CustomCooldown";
            this.CustomCooldown.Size = new System.Drawing.Size(82, 20);
            this.CustomCooldown.TabIndex = 24;
            this.CustomCooldown.Text = "30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cooldown:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Scale:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomScale
            // 
            this.CustomScale.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CustomScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomScale.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomScale.Location = new System.Drawing.Point(93, 128);
            this.CustomScale.Name = "CustomScale";
            this.CustomScale.Size = new System.Drawing.Size(82, 20);
            this.CustomScale.TabIndex = 19;
            this.CustomScale.Text = "1";
            // 
            // CustomFontSize
            // 
            this.CustomFontSize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CustomFontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomFontSize.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomFontSize.Location = new System.Drawing.Point(93, 103);
            this.CustomFontSize.Name = "CustomFontSize";
            this.CustomFontSize.Size = new System.Drawing.Size(82, 20);
            this.CustomFontSize.TabIndex = 18;
            this.CustomFontSize.Text = "14";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "FontSize:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "FontFamily:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomFontFamily
            // 
            this.CustomFontFamily.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CustomFontFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomFontFamily.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomFontFamily.Location = new System.Drawing.Point(93, 78);
            this.CustomFontFamily.Name = "CustomFontFamily";
            this.CustomFontFamily.Size = new System.Drawing.Size(82, 20);
            this.CustomFontFamily.TabIndex = 18;
            this.CustomFontFamily.Text = "Consolas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomY
            // 
            this.CustomY.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CustomY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomY.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomY.Location = new System.Drawing.Point(93, 53);
            this.CustomY.Name = "CustomY";
            this.CustomY.Size = new System.Drawing.Size(82, 20);
            this.CustomY.TabIndex = 18;
            this.CustomY.Text = "1000";
            // 
            // CustomX
            // 
            this.CustomX.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CustomX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomX.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomX.Location = new System.Drawing.Point(93, 28);
            this.CustomX.Name = "CustomX";
            this.CustomX.Size = new System.Drawing.Size(82, 20);
            this.CustomX.TabIndex = 18;
            this.CustomX.Text = "25";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel7.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "DX Overlay Settings";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // twitch
            // 
            this.twitch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.twitch.AutoSize = true;
            this.twitch.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.twitch.Location = new System.Drawing.Point(3, 589);
            this.twitch.Name = "twitch";
            this.twitch.Size = new System.Drawing.Size(177, 13);
            this.twitch.TabIndex = 10;
            this.twitch.TabStop = true;
            this.twitch.Text = "For Support Join Me Live On Twitch";
            this.twitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitch_LinkClicked);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // overlayUpdate
            // 
            this.overlayUpdate.Interval = 1000;
            this.overlayUpdate.Tick += new System.EventHandler(this.overlayUpdate_Tick);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 650);
            this.Name = "MainUI";
            this.Text = "Diablo II Resurrected Server IP Tracker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label CurrentIP;
        private System.Windows.Forms.Button FetchIP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.ListBox CheckedIPList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button RemoveIP;
        private System.Windows.Forms.LinkLabel twitch;
        public System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label ServersCheckedLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer overlayUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button RestartTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomFontSize;
        private System.Windows.Forms.TextBox CustomFontFamily;
        private System.Windows.Forms.TextBox CustomY;
        private System.Windows.Forms.TextBox CustomX;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomScale;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomCooldown;
        public System.Windows.Forms.Label label7;
    }
}

