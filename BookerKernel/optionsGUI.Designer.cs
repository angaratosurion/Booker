namespace Booker
{
    partial class optionsGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(optionsGUI));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.cbxWhiteTigerServer = new System.Windows.Forms.CheckBox();
            this.cbxEnableToolbar = new System.Windows.Forms.CheckBox();
            this.cbxUseExternalLangFile = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelGeneral = new System.Windows.Forms.Button();
            this.btnSaveGeneral = new System.Windows.Forms.Button();
            this.cbxExecuteScripts = new System.Windows.Forms.CheckBox();
            this.cbxEnableEncryptedBackup = new System.Windows.Forms.CheckBox();
            this.cbxenableEncryptedTables = new System.Windows.Forms.CheckBox();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.lblPassphrase = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelSecurity = new System.Windows.Forms.Button();
            this.btnSaveSecurity = new System.Windows.Forms.Button();
            this.cbxUsersPassPhrase = new System.Windows.Forms.CheckBox();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.lblHelpChangeFeed = new System.Windows.Forms.Label();
            this.btnChangeFeed = new System.Windows.Forms.Button();
            this.cbxAutoCheckUpdate = new System.Windows.Forms.CheckBox();
            this.cmbRealeseState = new System.Windows.Forms.ComboBox();
            this.txtupdatefeed = new System.Windows.Forms.TextBox();
            this.lblReleaseState = new System.Windows.Forms.Label();
            this.lblupdatefeed = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabSecurity);
            this.tabControl.Controls.Add(this.tabUpdate);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.cbxWhiteTigerServer);
            this.tabGeneral.Controls.Add(this.cbxEnableToolbar);
            this.tabGeneral.Controls.Add(this.cbxUseExternalLangFile);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.cmbLanguage);
            this.tabGeneral.Controls.Add(this.panel2);
            this.tabGeneral.Controls.Add(this.cbxExecuteScripts);
            this.tabGeneral.Controls.Add(this.cbxEnableEncryptedBackup);
            this.tabGeneral.Controls.Add(this.cbxenableEncryptedTables);
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Tag = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            this.tabGeneral.Click += new System.EventHandler(this.General_Click);
            // 
            // cbxWhiteTigerServer
            // 
            resources.ApplyResources(this.cbxWhiteTigerServer, "cbxWhiteTigerServer");
            this.cbxWhiteTigerServer.Name = "cbxWhiteTigerServer";
            this.cbxWhiteTigerServer.UseVisualStyleBackColor = true;
            // 
            // cbxEnableToolbar
            // 
            resources.ApplyResources(this.cbxEnableToolbar, "cbxEnableToolbar");
            this.cbxEnableToolbar.Name = "cbxEnableToolbar";
            this.cbxEnableToolbar.UseVisualStyleBackColor = true;
            // 
            // cbxUseExternalLangFile
            // 
            resources.ApplyResources(this.cbxUseExternalLangFile, "cbxUseExternalLangFile");
            this.cbxUseExternalLangFile.Name = "cbxUseExternalLangFile";
            this.cbxUseExternalLangFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            resources.GetString("cmbLanguage.Items"),
            resources.GetString("cmbLanguage.Items1")});
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.Name = "cmbLanguage";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelGeneral);
            this.panel2.Controls.Add(this.btnSaveGeneral);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnCancelGeneral
            // 
            resources.ApplyResources(this.btnCancelGeneral, "btnCancelGeneral");
            this.btnCancelGeneral.Name = "btnCancelGeneral";
            this.btnCancelGeneral.UseVisualStyleBackColor = true;
            this.btnCancelGeneral.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveGeneral
            // 
            resources.ApplyResources(this.btnSaveGeneral, "btnSaveGeneral");
            this.btnSaveGeneral.Name = "btnSaveGeneral";
            this.btnSaveGeneral.UseVisualStyleBackColor = true;
            this.btnSaveGeneral.Click += new System.EventHandler(this.btnSaveGeneral_Click);
            // 
            // cbxExecuteScripts
            // 
            resources.ApplyResources(this.cbxExecuteScripts, "cbxExecuteScripts");
            this.cbxExecuteScripts.Name = "cbxExecuteScripts";
            this.cbxExecuteScripts.UseVisualStyleBackColor = true;
            // 
            // cbxEnableEncryptedBackup
            // 
            resources.ApplyResources(this.cbxEnableEncryptedBackup, "cbxEnableEncryptedBackup");
            this.cbxEnableEncryptedBackup.Name = "cbxEnableEncryptedBackup";
            this.cbxEnableEncryptedBackup.UseVisualStyleBackColor = true;
            // 
            // cbxenableEncryptedTables
            // 
            resources.ApplyResources(this.cbxenableEncryptedTables, "cbxenableEncryptedTables");
            this.cbxenableEncryptedTables.Name = "cbxenableEncryptedTables";
            this.cbxenableEncryptedTables.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.txtPassphrase);
            this.tabSecurity.Controls.Add(this.lblPassphrase);
            this.tabSecurity.Controls.Add(this.panel1);
            this.tabSecurity.Controls.Add(this.cbxUsersPassPhrase);
            resources.ApplyResources(this.tabSecurity, "tabSecurity");
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Tag = "Security";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // txtPassphrase
            // 
            resources.ApplyResources(this.txtPassphrase, "txtPassphrase");
            this.txtPassphrase.Name = "txtPassphrase";
            // 
            // lblPassphrase
            // 
            resources.ApplyResources(this.lblPassphrase, "lblPassphrase");
            this.lblPassphrase.Name = "lblPassphrase";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelSecurity);
            this.panel1.Controls.Add(this.btnSaveSecurity);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnCancelSecurity
            // 
            resources.ApplyResources(this.btnCancelSecurity, "btnCancelSecurity");
            this.btnCancelSecurity.Name = "btnCancelSecurity";
            this.btnCancelSecurity.UseVisualStyleBackColor = true;
            this.btnCancelSecurity.Click += new System.EventHandler(this.btnCancelSecurity_Click);
            // 
            // btnSaveSecurity
            // 
            resources.ApplyResources(this.btnSaveSecurity, "btnSaveSecurity");
            this.btnSaveSecurity.Name = "btnSaveSecurity";
            this.btnSaveSecurity.UseVisualStyleBackColor = true;
            this.btnSaveSecurity.Click += new System.EventHandler(this.btnSaveSecurity_Click);
            // 
            // cbxUsersPassPhrase
            // 
            resources.ApplyResources(this.cbxUsersPassPhrase, "cbxUsersPassPhrase");
            this.cbxUsersPassPhrase.Name = "cbxUsersPassPhrase";
            this.cbxUsersPassPhrase.UseVisualStyleBackColor = true;
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.lblHelpChangeFeed);
            this.tabUpdate.Controls.Add(this.btnChangeFeed);
            this.tabUpdate.Controls.Add(this.cbxAutoCheckUpdate);
            this.tabUpdate.Controls.Add(this.cmbRealeseState);
            this.tabUpdate.Controls.Add(this.txtupdatefeed);
            this.tabUpdate.Controls.Add(this.lblReleaseState);
            this.tabUpdate.Controls.Add(this.lblupdatefeed);
            this.tabUpdate.Controls.Add(this.panel3);
            resources.ApplyResources(this.tabUpdate, "tabUpdate");
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Tag = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // lblHelpChangeFeed
            // 
            resources.ApplyResources(this.lblHelpChangeFeed, "lblHelpChangeFeed");
            this.lblHelpChangeFeed.Name = "lblHelpChangeFeed";
            // 
            // btnChangeFeed
            // 
            resources.ApplyResources(this.btnChangeFeed, "btnChangeFeed");
            this.btnChangeFeed.Name = "btnChangeFeed";
            this.btnChangeFeed.UseVisualStyleBackColor = true;
            this.btnChangeFeed.Click += new System.EventHandler(this.btnChangeFeed_Click);
            // 
            // cbxAutoCheckUpdate
            // 
            resources.ApplyResources(this.cbxAutoCheckUpdate, "cbxAutoCheckUpdate");
            this.cbxAutoCheckUpdate.Name = "cbxAutoCheckUpdate";
            this.cbxAutoCheckUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbRealeseState
            // 
            this.cmbRealeseState.FormattingEnabled = true;
            this.cmbRealeseState.Items.AddRange(new object[] {
            resources.GetString("cmbRealeseState.Items"),
            resources.GetString("cmbRealeseState.Items1"),
            resources.GetString("cmbRealeseState.Items2"),
            resources.GetString("cmbRealeseState.Items3")});
            resources.ApplyResources(this.cmbRealeseState, "cmbRealeseState");
            this.cmbRealeseState.Name = "cmbRealeseState";
            // 
            // txtupdatefeed
            // 
            resources.ApplyResources(this.txtupdatefeed, "txtupdatefeed");
            this.txtupdatefeed.Name = "txtupdatefeed";
            // 
            // lblReleaseState
            // 
            resources.ApplyResources(this.lblReleaseState, "lblReleaseState");
            this.lblReleaseState.Name = "lblReleaseState";
            // 
            // lblupdatefeed
            // 
            resources.ApplyResources(this.lblupdatefeed, "lblupdatefeed");
            this.lblupdatefeed.Name = "lblupdatefeed";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelUpdate);
            this.panel3.Controls.Add(this.btnSaveUpdate);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnCancelUpdate
            // 
            resources.ApplyResources(this.btnCancelUpdate, "btnCancelUpdate");
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSaveUpdate
            // 
            resources.ApplyResources(this.btnSaveUpdate, "btnSaveUpdate");
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // optionsGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "optionsGUI";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.optionsGUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.CheckBox cbxEnableEncryptedBackup;
        private System.Windows.Forms.CheckBox cbxenableEncryptedTables;
        private System.Windows.Forms.CheckBox cbxExecuteScripts;
        private System.Windows.Forms.CheckBox cbxUsersPassPhrase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelSecurity;
        private System.Windows.Forms.Button btnSaveSecurity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelGeneral;
        private System.Windows.Forms.Button btnSaveGeneral;
        private System.Windows.Forms.Label lblPassphrase;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Label lblupdatefeed;
        private System.Windows.Forms.Label lblReleaseState;
        private System.Windows.Forms.TextBox txtupdatefeed;
        private System.Windows.Forms.ComboBox cmbRealeseState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.CheckBox cbxUseExternalLangFile;
        private System.Windows.Forms.CheckBox cbxAutoCheckUpdate;
        private System.Windows.Forms.Button btnChangeFeed;
        private System.Windows.Forms.Label lblHelpChangeFeed;
        private System.Windows.Forms.CheckBox cbxEnableToolbar;
        private System.Windows.Forms.CheckBox cbxWhiteTigerServer;
    }
}