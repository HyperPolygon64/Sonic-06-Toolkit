﻿namespace Sonic_06_Toolkit
{
    partial class XNO_Studio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XNO_Studio));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Backdrop = new System.Windows.Forms.Panel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_DeselectAll = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.clb_XNOs = new System.Windows.Forms.CheckedListBox();
            this.check_XNM = new System.Windows.Forms.CheckBox();
            this.split_XNMStudio = new System.Windows.Forms.SplitContainer();
            this.clb_XNOs_XNM = new System.Windows.Forms.CheckedListBox();
            this.clb_XNMs = new System.Windows.Forms.CheckedListBox();
            this.tm_ItemCheck = new System.Windows.Forms.Timer(this.components);
            this.pnl_Backdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split_XNMStudio)).BeginInit();
            this.split_XNMStudio.Panel1.SuspendLayout();
            this.split_XNMStudio.Panel2.SuspendLayout();
            this.split_XNMStudio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Title.Location = new System.Drawing.Point(14, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(215, 47);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "XNO Studio";
            // 
            // pnl_Backdrop
            // 
            this.pnl_Backdrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Backdrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(43)))));
            this.pnl_Backdrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Backdrop.Controls.Add(this.pic_Logo);
            this.pnl_Backdrop.Controls.Add(this.lbl_Title);
            this.pnl_Backdrop.Location = new System.Drawing.Point(-3, -2);
            this.pnl_Backdrop.Name = "pnl_Backdrop";
            this.pnl_Backdrop.Size = new System.Drawing.Size(418, 69);
            this.pnl_Backdrop.TabIndex = 16;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Logo.BackgroundImage")));
            this.pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Logo.Location = new System.Drawing.Point(341, 1);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(67, 67);
            this.pic_Logo.TabIndex = 11;
            this.pic_Logo.TabStop = false;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(43)))));
            this.btn_Convert.Enabled = false;
            this.btn_Convert.FlatAppearance.BorderSize = 0;
            this.btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Convert.Location = new System.Drawing.Point(329, 387);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 20;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = false;
            this.btn_Convert.Click += new System.EventHandler(this.Btn_Decompile_Click);
            // 
            // btn_DeselectAll
            // 
            this.btn_DeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeselectAll.BackColor = System.Drawing.Color.Tomato;
            this.btn_DeselectAll.FlatAppearance.BorderSize = 0;
            this.btn_DeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeselectAll.Location = new System.Drawing.Point(90, 387);
            this.btn_DeselectAll.Name = "btn_DeselectAll";
            this.btn_DeselectAll.Size = new System.Drawing.Size(75, 23);
            this.btn_DeselectAll.TabIndex = 19;
            this.btn_DeselectAll.Text = "Deselect All";
            this.btn_DeselectAll.UseVisualStyleBackColor = false;
            this.btn_DeselectAll.Click += new System.EventHandler(this.Btn_DeselectAll_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SelectAll.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_SelectAll.FlatAppearance.BorderSize = 0;
            this.btn_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectAll.Location = new System.Drawing.Point(8, 387);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectAll.TabIndex = 18;
            this.btn_SelectAll.Text = "Select All";
            this.btn_SelectAll.UseVisualStyleBackColor = false;
            this.btn_SelectAll.Click += new System.EventHandler(this.Btn_SelectAll_Click);
            // 
            // clb_XNOs
            // 
            this.clb_XNOs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_XNOs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clb_XNOs.CheckOnClick = true;
            this.clb_XNOs.FormattingEnabled = true;
            this.clb_XNOs.Location = new System.Drawing.Point(8, 76);
            this.clb_XNOs.Name = "clb_XNOs";
            this.clb_XNOs.Size = new System.Drawing.Size(396, 304);
            this.clb_XNOs.TabIndex = 17;
            this.clb_XNOs.SelectedIndexChanged += new System.EventHandler(this.Clb_XNOs_SelectedIndexChanged);
            // 
            // check_XNM
            // 
            this.check_XNM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_XNM.AutoSize = true;
            this.check_XNM.Location = new System.Drawing.Point(174, 391);
            this.check_XNM.Name = "check_XNM";
            this.check_XNM.Size = new System.Drawing.Size(127, 17);
            this.check_XNM.TabIndex = 21;
            this.check_XNM.Text = "Export with Animation";
            this.check_XNM.UseVisualStyleBackColor = true;
            this.check_XNM.CheckedChanged += new System.EventHandler(this.Check_XNM_CheckedChanged);
            // 
            // split_XNMStudio
            // 
            this.split_XNMStudio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.split_XNMStudio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.split_XNMStudio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_XNMStudio.Location = new System.Drawing.Point(8, 76);
            this.split_XNMStudio.Name = "split_XNMStudio";
            // 
            // split_XNMStudio.Panel1
            // 
            this.split_XNMStudio.Panel1.Controls.Add(this.clb_XNOs_XNM);
            // 
            // split_XNMStudio.Panel2
            // 
            this.split_XNMStudio.Panel2.Controls.Add(this.clb_XNMs);
            this.split_XNMStudio.Size = new System.Drawing.Size(396, 304);
            this.split_XNMStudio.SplitterDistance = 197;
            this.split_XNMStudio.TabIndex = 29;
            // 
            // clb_XNOs_XNM
            // 
            this.clb_XNOs_XNM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_XNOs_XNM.CheckOnClick = true;
            this.clb_XNOs_XNM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_XNOs_XNM.FormattingEnabled = true;
            this.clb_XNOs_XNM.Location = new System.Drawing.Point(0, 0);
            this.clb_XNOs_XNM.Name = "clb_XNOs_XNM";
            this.clb_XNOs_XNM.Size = new System.Drawing.Size(195, 302);
            this.clb_XNOs_XNM.TabIndex = 0;
            this.clb_XNOs_XNM.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Clb_XNOs_XNM_ItemCheck);
            this.clb_XNOs_XNM.SelectedIndexChanged += new System.EventHandler(this.Clb_XNOs_XNM_SelectedIndexChanged);
            // 
            // clb_XNMs
            // 
            this.clb_XNMs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_XNMs.CheckOnClick = true;
            this.clb_XNMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_XNMs.FormattingEnabled = true;
            this.clb_XNMs.Location = new System.Drawing.Point(0, 0);
            this.clb_XNMs.Name = "clb_XNMs";
            this.clb_XNMs.Size = new System.Drawing.Size(193, 302);
            this.clb_XNMs.TabIndex = 0;
            this.clb_XNMs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Clb_XNMs_ItemCheck);
            this.clb_XNMs.SelectedIndexChanged += new System.EventHandler(this.Clb_XNMs_SelectedIndexChanged);
            // 
            // tm_ItemCheck
            // 
            this.tm_ItemCheck.Tick += new System.EventHandler(this.Tm_ItemCheck_Tick);
            // 
            // XNO_Studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 419);
            this.Controls.Add(this.check_XNM);
            this.Controls.Add(this.pnl_Backdrop);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.btn_DeselectAll);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.clb_XNOs);
            this.Controls.Add(this.split_XNMStudio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(429, 458);
            this.Name = "XNO_Studio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XNO Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XNO_Studio_FormClosing);
            this.Load += new System.EventHandler(this.XNO_Studio_Load);
            this.pnl_Backdrop.ResumeLayout(false);
            this.pnl_Backdrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.split_XNMStudio.Panel1.ResumeLayout(false);
            this.split_XNMStudio.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_XNMStudio)).EndInit();
            this.split_XNMStudio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Backdrop;
        internal System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_DeselectAll;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.CheckedListBox clb_XNOs;
        private System.Windows.Forms.CheckBox check_XNM;
        private System.Windows.Forms.SplitContainer split_XNMStudio;
        private System.Windows.Forms.CheckedListBox clb_XNOs_XNM;
        private System.Windows.Forms.CheckedListBox clb_XNMs;
        private System.Windows.Forms.Timer tm_ItemCheck;
    }
}