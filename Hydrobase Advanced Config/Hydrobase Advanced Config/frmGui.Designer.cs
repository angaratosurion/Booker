namespace Hydrobase_Advanced_Config
{
    partial class frmGui
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblDriveLetter = new System.Windows.Forms.Label();
            this.txtDriveLetter = new System.Windows.Forms.TextBox();
            this.btnBrowserDrive = new System.Windows.Forms.Button();
            this.btnBrowserFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRootFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbxMirrorBckFolder = new System.Windows.Forms.CheckBox();
            this.lblMirrorFolder = new System.Windows.Forms.Label();
            this.txtMirrorFolder = new System.Windows.Forms.TextBox();
            this.btnBrowserMirrorFolder = new System.Windows.Forms.Button();
            this.cbxEnableLog = new System.Windows.Forms.CheckBox();
            this.cbxMirroring = new System.Windows.Forms.CheckBox();
            this.lblMirroingfold = new System.Windows.Forms.Label();
            this.txtMirrorFold = new System.Windows.Forms.TextBox();
            this.btnMirrorFoldBrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 340);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 114);
            this.panel2.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(14, 70);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(14, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblDriveLetter
            // 
            this.lblDriveLetter.AutoSize = true;
            this.lblDriveLetter.Location = new System.Drawing.Point(12, 22);
            this.lblDriveLetter.Name = "lblDriveLetter";
            this.lblDriveLetter.Size = new System.Drawing.Size(54, 13);
            this.lblDriveLetter.TabIndex = 1;
            this.lblDriveLetter.Text = "Hard Disk";
            // 
            // txtDriveLetter
            // 
            this.txtDriveLetter.Location = new System.Drawing.Point(80, 19);
            this.txtDriveLetter.Name = "txtDriveLetter";
            this.txtDriveLetter.Size = new System.Drawing.Size(223, 20);
            this.txtDriveLetter.TabIndex = 2;
            // 
            // btnBrowserDrive
            // 
            this.btnBrowserDrive.Location = new System.Drawing.Point(319, 22);
            this.btnBrowserDrive.Name = "btnBrowserDrive";
            this.btnBrowserDrive.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserDrive.TabIndex = 3;
            this.btnBrowserDrive.Text = "Browse";
            this.btnBrowserDrive.UseVisualStyleBackColor = true;
            this.btnBrowserDrive.Click += new System.EventHandler(this.btnBrowserDrive_Click);
            // 
            // btnBrowserFolder
            // 
            this.btnBrowserFolder.Location = new System.Drawing.Point(319, 68);
            this.btnBrowserFolder.Name = "btnBrowserFolder";
            this.btnBrowserFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserFolder.TabIndex = 4;
            this.btnBrowserFolder.Text = "Browse";
            this.btnBrowserFolder.UseVisualStyleBackColor = true;
            this.btnBrowserFolder.Click += new System.EventHandler(this.btnBrowserFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Root Folder";
            // 
            // txtRootFolder
            // 
            this.txtRootFolder.Location = new System.Drawing.Point(80, 68);
            this.txtRootFolder.Name = "txtRootFolder";
            this.txtRootFolder.Size = new System.Drawing.Size(223, 20);
            this.txtRootFolder.TabIndex = 6;
            // 
            // cbxMirrorBckFolder
            // 
            this.cbxMirrorBckFolder.AutoSize = true;
            this.cbxMirrorBckFolder.Location = new System.Drawing.Point(12, 97);
            this.cbxMirrorBckFolder.Name = "cbxMirrorBckFolder";
            this.cbxMirrorBckFolder.Size = new System.Drawing.Size(146, 17);
            this.cbxMirrorBckFolder.TabIndex = 7;
            this.cbxMirrorBckFolder.Text = "Mirror The Backup Folder";
            this.cbxMirrorBckFolder.UseVisualStyleBackColor = true;
            // 
            // lblMirrorFolder
            // 
            this.lblMirrorFolder.AutoSize = true;
            this.lblMirrorFolder.Location = new System.Drawing.Point(12, 129);
            this.lblMirrorFolder.Name = "lblMirrorFolder";
            this.lblMirrorFolder.Size = new System.Drawing.Size(65, 13);
            this.lblMirrorFolder.TabIndex = 8;
            this.lblMirrorFolder.Text = "Mirror Folder";
            // 
            // txtMirrorFolder
            // 
            this.txtMirrorFolder.Location = new System.Drawing.Point(83, 126);
            this.txtMirrorFolder.Name = "txtMirrorFolder";
            this.txtMirrorFolder.Size = new System.Drawing.Size(220, 20);
            this.txtMirrorFolder.TabIndex = 9;
            // 
            // btnBrowserMirrorFolder
            // 
            this.btnBrowserMirrorFolder.Location = new System.Drawing.Point(319, 129);
            this.btnBrowserMirrorFolder.Name = "btnBrowserMirrorFolder";
            this.btnBrowserMirrorFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserMirrorFolder.TabIndex = 10;
            this.btnBrowserMirrorFolder.Text = "Browse";
            this.btnBrowserMirrorFolder.UseVisualStyleBackColor = true;
            this.btnBrowserMirrorFolder.Click += new System.EventHandler(this.btnBrowserMirrorFolder_Click);
            // 
            // cbxEnableLog
            // 
            this.cbxEnableLog.AutoSize = true;
            this.cbxEnableLog.Location = new System.Drawing.Point(15, 178);
            this.cbxEnableLog.Name = "cbxEnableLog";
            this.cbxEnableLog.Size = new System.Drawing.Size(94, 17);
            this.cbxEnableLog.TabIndex = 11;
            this.cbxEnableLog.Text = "Enable Loging";
            this.cbxEnableLog.UseVisualStyleBackColor = true;
            // 
            // cbxMirroring
            // 
            this.cbxMirroring.AutoSize = true;
            this.cbxMirroring.Location = new System.Drawing.Point(12, 201);
            this.cbxMirroring.Name = "cbxMirroring";
            this.cbxMirroring.Size = new System.Drawing.Size(101, 17);
            this.cbxMirroring.TabIndex = 12;
            this.cbxMirroring.Text = "Enable mirroring";
            this.cbxMirroring.UseVisualStyleBackColor = true;
            // 
            // lblMirroingfold
            // 
            this.lblMirroingfold.AutoSize = true;
            this.lblMirroingfold.Location = new System.Drawing.Point(9, 243);
            this.lblMirroingfold.Name = "lblMirroingfold";
            this.lblMirroingfold.Size = new System.Drawing.Size(65, 13);
            this.lblMirroingfold.TabIndex = 13;
            this.lblMirroingfold.Text = "Mirror Folder";
            // 
            // txtMirrorFold
            // 
            this.txtMirrorFold.Location = new System.Drawing.Point(80, 240);
            this.txtMirrorFold.Name = "txtMirrorFold";
            this.txtMirrorFold.Size = new System.Drawing.Size(223, 20);
            this.txtMirrorFold.TabIndex = 14;
            // 
            // btnMirrorFoldBrowse
            // 
            this.btnMirrorFoldBrowse.Location = new System.Drawing.Point(309, 243);
            this.btnMirrorFoldBrowse.Name = "btnMirrorFoldBrowse";
            this.btnMirrorFoldBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnMirrorFoldBrowse.TabIndex = 15;
            this.btnMirrorFoldBrowse.Text = "Browse";
            this.btnMirrorFoldBrowse.UseVisualStyleBackColor = true;
            this.btnMirrorFoldBrowse.Click += new System.EventHandler(this.btnMirrorFoldBrowse_Click);
            // 
            // frmGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 340);
            this.Controls.Add(this.btnMirrorFoldBrowse);
            this.Controls.Add(this.txtMirrorFold);
            this.Controls.Add(this.lblMirroingfold);
            this.Controls.Add(this.cbxMirroring);
            this.Controls.Add(this.cbxEnableLog);
            this.Controls.Add(this.btnBrowserMirrorFolder);
            this.Controls.Add(this.txtMirrorFolder);
            this.Controls.Add(this.lblMirrorFolder);
            this.Controls.Add(this.cbxMirrorBckFolder);
            this.Controls.Add(this.txtRootFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowserFolder);
            this.Controls.Add(this.btnBrowserDrive);
            this.Controls.Add(this.txtDriveLetter);
            this.Controls.Add(this.lblDriveLetter);
            this.Controls.Add(this.panel1);
            this.Name = "frmGui";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGui_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblDriveLetter;
        private System.Windows.Forms.TextBox txtDriveLetter;
        private System.Windows.Forms.Button btnBrowserDrive;
        private System.Windows.Forms.Button btnBrowserFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRootFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox cbxMirrorBckFolder;
        private System.Windows.Forms.Label lblMirrorFolder;
        private System.Windows.Forms.TextBox txtMirrorFolder;
        private System.Windows.Forms.Button btnBrowserMirrorFolder;
        private System.Windows.Forms.CheckBox cbxEnableLog;
        private System.Windows.Forms.CheckBox cbxMirroring;
        private System.Windows.Forms.Label lblMirroingfold;
        private System.Windows.Forms.TextBox txtMirrorFold;
        private System.Windows.Forms.Button btnMirrorFoldBrowse;
    }
}

