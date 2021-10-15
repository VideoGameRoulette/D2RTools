
namespace DRIPTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.CurrentIP = new System.Windows.Forms.Label();
            this.FetchIP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.CheckedIPList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearAll = new System.Windows.Forms.Button();
            this.RemoveIP = new System.Windows.Forms.Button();
            this.twitch = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentIP
            // 
            this.CurrentIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentIP.AutoSize = true;
            this.CurrentIP.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIP.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentIP.Location = new System.Drawing.Point(149, 185);
            this.CurrentIP.Name = "CurrentIP";
            this.CurrentIP.Size = new System.Drawing.Size(286, 32);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrentIP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SearchBar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CheckedIPList, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.twitch, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 561);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FetchIP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(149, 116);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 30);
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
            this.button2.Size = new System.Drawing.Size(132, 23);
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
            this.button1.Location = new System.Drawing.Point(215, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Copy IP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CopyIP_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DRIPTool.Properties.Resources.D2R;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(149, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 107);
            this.panel1.TabIndex = 4;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBar.ForeColor = System.Drawing.SystemColors.Control;
            this.SearchBar.Location = new System.Drawing.Point(149, 152);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(286, 20);
            this.SearchBar.TabIndex = 5;
            this.SearchBar.Text = "0.0.0.0";
            // 
            // CheckedIPList
            // 
            this.CheckedIPList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CheckedIPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckedIPList.ForeColor = System.Drawing.SystemColors.Control;
            this.CheckedIPList.FormattingEnabled = true;
            this.CheckedIPList.Location = new System.Drawing.Point(149, 229);
            this.CheckedIPList.Name = "CheckedIPList";
            this.CheckedIPList.Size = new System.Drawing.Size(286, 273);
            this.CheckedIPList.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ClearAll, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.RemoveIP, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(149, 508);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(286, 30);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // ClearAll
            // 
            this.ClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAll.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearAll.Location = new System.Drawing.Point(146, 3);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(137, 23);
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
            this.RemoveIP.Location = new System.Drawing.Point(3, 3);
            this.RemoveIP.Name = "RemoveIP";
            this.RemoveIP.Size = new System.Drawing.Size(137, 23);
            this.RemoveIP.TabIndex = 8;
            this.RemoveIP.Text = "Remove Selected IP";
            this.RemoveIP.UseVisualStyleBackColor = false;
            this.RemoveIP.Click += new System.EventHandler(this.RemoveIP_Click);
            // 
            // twitch
            // 
            this.twitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.twitch.AutoSize = true;
            this.twitch.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.twitch.Location = new System.Drawing.Point(149, 544);
            this.twitch.Name = "twitch";
            this.twitch.Size = new System.Drawing.Size(286, 13);
            this.twitch.TabIndex = 10;
            this.twitch.TabStop = true;
            this.twitch.Text = "Follow Me On Twitch";
            this.twitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitch_LinkClicked);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Diablo II Resurrected Server IP Tracker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
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
    }
}

