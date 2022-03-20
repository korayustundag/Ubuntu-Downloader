namespace Ubuntu_Downloader
{
    partial class MainFrm
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEdition = new System.Windows.Forms.ComboBox();
            this.comboBoxArc = new System.Windows.Forms.ComboBox();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRec = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalFromat = new System.Windows.Forms.Label();
            this.linkLabelSysReq = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.Location = new System.Drawing.Point(489, 401);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 23);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Download Ubuntu now";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Architecture:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quickly download the latest ubuntu version.";
            // 
            // comboBoxEdition
            // 
            this.comboBoxEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxEdition.FormattingEnabled = true;
            this.comboBoxEdition.Items.AddRange(new object[] {
            "Ubuntu Desktop",
            "Ubuntu Server"});
            this.comboBoxEdition.Location = new System.Drawing.Point(182, 130);
            this.comboBoxEdition.Name = "comboBoxEdition";
            this.comboBoxEdition.Size = new System.Drawing.Size(220, 23);
            this.comboBoxEdition.TabIndex = 4;
            // 
            // comboBoxArc
            // 
            this.comboBoxArc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxArc.FormattingEnabled = true;
            this.comboBoxArc.Items.AddRange(new object[] {
            "64-bit (AMD64)"});
            this.comboBoxArc.Location = new System.Drawing.Point(182, 174);
            this.comboBoxArc.Name = "comboBoxArc";
            this.comboBoxArc.Size = new System.Drawing.Size(220, 23);
            this.comboBoxArc.TabIndex = 5;
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(12, 372);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(566, 23);
            this.progressBarMain.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 354);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 15);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Downloading: %0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Location = new System.Drawing.Point(142, 354);
            this.lblRec.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(13, 15);
            this.lblRec.TabIndex = 8;
            this.lblRec.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "-";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(182, 354);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(22, 15);
            this.lblFormat.TabIndex = 9;
            this.lblFormat.Text = "GB";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(219, 354);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 15);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0";
            // 
            // lblTotalFromat
            // 
            this.lblTotalFromat.AutoSize = true;
            this.lblTotalFromat.Location = new System.Drawing.Point(247, 354);
            this.lblTotalFromat.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalFromat.Name = "lblTotalFromat";
            this.lblTotalFromat.Size = new System.Drawing.Size(22, 15);
            this.lblTotalFromat.TabIndex = 12;
            this.lblTotalFromat.Text = "GB";
            // 
            // linkLabelSysReq
            // 
            this.linkLabelSysReq.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelSysReq.AutoSize = true;
            this.linkLabelSysReq.LinkColor = System.Drawing.Color.White;
            this.linkLabelSysReq.Location = new System.Drawing.Point(12, 412);
            this.linkLabelSysReq.Name = "linkLabelSysReq";
            this.linkLabelSysReq.Size = new System.Drawing.Size(201, 15);
            this.linkLabelSysReq.TabIndex = 15;
            this.linkLabelSysReq.TabStop = true;
            this.linkLabelSysReq.Text = "Recommended system requirements";
            this.linkLabelSysReq.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabelSysReq.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSysReq_LinkClicked);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(590, 436);
            this.Controls.Add(this.linkLabelSysReq);
            this.Controls.Add(this.lblTotalFromat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.comboBoxArc);
            this.Controls.Add(this.comboBoxEdition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownload);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Ubuntu_Downloader.Properties.Resources.ubuntu_logo;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubuntu Downloader [Ubuntu 20.04.4 LTS]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEdition;
        private System.Windows.Forms.ComboBox comboBoxArc;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalFromat;
        private System.Windows.Forms.LinkLabel linkLabelSysReq;
    }
}

