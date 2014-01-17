namespace WindowsApplication3
{
    partial class frmBusBuddy
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drpDir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSrch = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabNumber = new System.Windows.Forms.TabPage();
            this.tabStops = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabTimes = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabFaves = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabs.SuspendLayout();
            this.tabNumber.SuspendLayout();
            this.tabStops.SuspendLayout();
            this.tabTimes.SuspendLayout();
            this.tabFaves.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(208, 73);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(65, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Line Number";
            // 
            // drpDir
            // 
            this.drpDir.FormattingEnabled = true;
            this.drpDir.Items.AddRange(new object[] {
            "North",
            "South",
            "East",
            "West"});
            this.drpDir.Location = new System.Drawing.Point(208, 111);
            this.drpDir.Name = "drpDir";
            this.drpDir.Size = new System.Drawing.Size(65, 21);
            this.drpDir.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direction";
            // 
            // btnSrch
            // 
            this.btnSrch.Location = new System.Drawing.Point(188, 149);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(75, 23);
            this.btnSrch.TabIndex = 4;
            this.btnSrch.Text = "Search";
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabNumber);
            this.tabs.Controls.Add(this.tabStops);
            this.tabs.Controls.Add(this.tabTimes);
            this.tabs.Controls.Add(this.tabFaves);
            this.tabs.Location = new System.Drawing.Point(1, 1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(447, 499);
            this.tabs.TabIndex = 6;
            // 
            // tabNumber
            // 
            this.tabNumber.Controls.Add(this.drpDir);
            this.tabNumber.Controls.Add(this.txtNumber);
            this.tabNumber.Controls.Add(this.btnSrch);
            this.tabNumber.Controls.Add(this.label1);
            this.tabNumber.Controls.Add(this.label2);
            this.tabNumber.Location = new System.Drawing.Point(4, 22);
            this.tabNumber.Name = "tabNumber";
            this.tabNumber.Padding = new System.Windows.Forms.Padding(3);
            this.tabNumber.Size = new System.Drawing.Size(439, 473);
            this.tabNumber.TabIndex = 0;
            this.tabNumber.Text = "Select Bus Line";
            this.tabNumber.UseVisualStyleBackColor = true;
            // 
            // tabStops
            // 
            this.tabStops.Controls.Add(this.label3);
            this.tabStops.Controls.Add(this.panel1);
            this.tabStops.Location = new System.Drawing.Point(4, 22);
            this.tabStops.Name = "tabStops";
            this.tabStops.Padding = new System.Windows.Forms.Padding(3);
            this.tabStops.Size = new System.Drawing.Size(439, 473);
            this.tabStops.TabIndex = 1;
            this.tabStops.Text = "Select Stop";
            this.tabStops.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select a stop";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(48, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 391);
            this.panel1.TabIndex = 10;
            // 
            // tabTimes
            // 
            this.tabTimes.Controls.Add(this.panel3);
            this.tabTimes.Controls.Add(this.button1);
            this.tabTimes.Controls.Add(this.webBrowser1);
            this.tabTimes.Controls.Add(this.lblStop);
            this.tabTimes.Controls.Add(this.lblTime3);
            this.tabTimes.Controls.Add(this.lblTime2);
            this.tabTimes.Controls.Add(this.lblTime1);
            this.tabTimes.Controls.Add(this.label4);
            this.tabTimes.Location = new System.Drawing.Point(4, 22);
            this.tabTimes.Name = "tabTimes";
            this.tabTimes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimes.Size = new System.Drawing.Size(439, 473);
            this.tabTimes.TabIndex = 2;
            this.tabTimes.Text = "Times";
            this.tabTimes.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(284, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 71);
            this.panel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(14, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 51);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBrowser1.Location = new System.Drawing.Point(87, 193);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(263, 262);
            this.webBrowser1.TabIndex = 5;

            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStop.Location = new System.Drawing.Point(3, 3);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(57, 20);
            this.lblStop.TabIndex = 4;
            this.lblStop.Text = "label5";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime3.Location = new System.Drawing.Point(281, 146);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(51, 16);
            this.lblTime3.TabIndex = 3;
            this.lblTime3.Text = "label7";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(193, 143);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(57, 20);
            this.lblTime2.TabIndex = 2;
            this.lblTime2.Text = "label6";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(82, 139);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(76, 25);
            this.lblTime1.TabIndex = 1;
            this.lblTime1.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Next Passages";
            // 
            // tabFaves
            // 
            this.tabFaves.Controls.Add(this.panel2);
            this.tabFaves.Location = new System.Drawing.Point(4, 22);
            this.tabFaves.Name = "tabFaves";
            this.tabFaves.Size = new System.Drawing.Size(439, 473);
            this.tabFaves.TabIndex = 3;
            this.tabFaves.Text = "Favourites";
            this.tabFaves.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(51, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 391);
            this.panel2.TabIndex = 11;
            // 
            // frmBusBuddy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 501);
            this.Controls.Add(this.tabs);
            this.Name = "frmBusBuddy";
            this.Text = "Bus Times";
            this.Load += new System.EventHandler(this.frmBusBuddy_Load);
            this.tabs.ResumeLayout(false);
            this.tabNumber.ResumeLayout(false);
            this.tabNumber.PerformLayout();
            this.tabStops.ResumeLayout(false);
            this.tabStops.PerformLayout();
            this.tabTimes.ResumeLayout(false);
            this.tabTimes.PerformLayout();
            this.tabFaves.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabNumber;
        private System.Windows.Forms.TabPage tabStops;
        private System.Windows.Forms.TabPage tabTimes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabFaves;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

    }
}

