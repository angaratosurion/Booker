namespace Booker
{
    partial class BookerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookerMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.����������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������������������ScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���������������ScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���������������������HydorbaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WtServerConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalCommansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���������������������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�����������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsLabelRecordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statlabeRecval = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openScriptArch = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtgDataGrd = new System.Windows.Forms.DataGridView();
            this.tlspToolBar = new System.Windows.Forms.ToolStrip();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnBackup = new System.Windows.Forms.ToolStripButton();
            this.btnRestore = new System.Windows.Forms.ToolStripButton();
            this.btnImportTable = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataGrd)).BeginInit();
            this.tlspToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.������ToolStripMenuItem,
            this.��������ToolStripMenuItem,
            this.additionalCommansToolStripMenuItem,
            this.�������ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip1_ItemAdded);
            // 
            // ������ToolStripMenuItem
            // 
            this.������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.���������ToolStripMenuItem,
            this.��������������ToolStripMenuItem,
            this.������������ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.����������������ToolStripMenuItem,
            this.������ToolStripMenuItem});
            this.������ToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.������ToolStripMenuItem.Name = "������ToolStripMenuItem";
            resources.ApplyResources(this.������ToolStripMenuItem, "������ToolStripMenuItem");
            // 
            // ���������ToolStripMenuItem
            // 
            this.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem";
            resources.ApplyResources(this.���������ToolStripMenuItem, "���������ToolStripMenuItem");
            this.���������ToolStripMenuItem.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ��������������ToolStripMenuItem
            // 
            this.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem";
            resources.ApplyResources(this.��������������ToolStripMenuItem, "��������������ToolStripMenuItem");
            this.��������������ToolStripMenuItem.Click += new System.EventHandler(this.��������������ToolStripMenuItem_Click);
            // 
            // ������������ToolStripMenuItem
            // 
            this.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem";
            resources.ApplyResources(this.������������ToolStripMenuItem, "������������ToolStripMenuItem");
            this.������������ToolStripMenuItem.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.UpgradeDataBase_Click);
            // 
            // ����������������ToolStripMenuItem
            // 
            this.����������������ToolStripMenuItem.Name = "����������������ToolStripMenuItem";
            resources.ApplyResources(this.����������������ToolStripMenuItem, "����������������ToolStripMenuItem");
            this.����������������ToolStripMenuItem.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // ������ToolStripMenuItem
            // 
            this.������ToolStripMenuItem.Name = "������ToolStripMenuItem";
            resources.ApplyResources(this.������ToolStripMenuItem, "������ToolStripMenuItem");
            this.������ToolStripMenuItem.Click += new System.EventHandler(this.Exit_click);
            // 
            // ��������ToolStripMenuItem
            // 
            this.��������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.������������������ToolStripMenuItem,
            this.������������������ToolStripMenuItem,
            this.���������ToolStripMenuItem,
            this.��������ToolStripMenuItem,
            this.������������������ScriptsToolStripMenuItem,
            this.���������������ScriptToolStripMenuItem,
            this.���������������������HydorbaseToolStripMenuItem,
            this.WtServerConnect});
            this.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem";
            resources.ApplyResources(this.��������ToolStripMenuItem, "��������ToolStripMenuItem");
            // 
            // ������������������ToolStripMenuItem
            // 
            this.������������������ToolStripMenuItem.Name = "������������������ToolStripMenuItem";
            resources.ApplyResources(this.������������������ToolStripMenuItem, "������������������ToolStripMenuItem");
            this.������������������ToolStripMenuItem.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // ������������������ToolStripMenuItem
            // 
            this.������������������ToolStripMenuItem.Name = "������������������ToolStripMenuItem";
            resources.ApplyResources(this.������������������ToolStripMenuItem, "������������������ToolStripMenuItem");
            this.������������������ToolStripMenuItem.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // ���������ToolStripMenuItem
            // 
            this.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem";
            resources.ApplyResources(this.���������ToolStripMenuItem, "���������ToolStripMenuItem");
            this.���������ToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ��������ToolStripMenuItem
            // 
            this.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem";
            resources.ApplyResources(this.��������ToolStripMenuItem, "��������ToolStripMenuItem");
            this.��������ToolStripMenuItem.Click += new System.EventHandler(this.��������ToolStripMenuItem_Click);
            // 
            // ������������������ScriptsToolStripMenuItem
            // 
            this.������������������ScriptsToolStripMenuItem.Name = "������������������ScriptsToolStripMenuItem";
            resources.ApplyResources(this.������������������ScriptsToolStripMenuItem, "������������������ScriptsToolStripMenuItem");
            this.������������������ScriptsToolStripMenuItem.Click += new System.EventHandler(this.������������������ScriptsToolStripMenuItem_Click);
            // 
            // ���������������ScriptToolStripMenuItem
            // 
            this.���������������ScriptToolStripMenuItem.Name = "���������������ScriptToolStripMenuItem";
            resources.ApplyResources(this.���������������ScriptToolStripMenuItem, "���������������ScriptToolStripMenuItem");
            this.���������������ScriptToolStripMenuItem.Click += new System.EventHandler(this.���������������ScriptToolStripMenuItem_Click);
            // 
            // ���������������������HydorbaseToolStripMenuItem
            // 
            this.���������������������HydorbaseToolStripMenuItem.Name = "���������������������HydorbaseToolStripMenuItem";
            resources.ApplyResources(this.���������������������HydorbaseToolStripMenuItem, "���������������������HydorbaseToolStripMenuItem");
            this.���������������������HydorbaseToolStripMenuItem.Click += new System.EventHandler(this.���������������������HydorbaseToolStripMenuItem_Click);
            // 
            // WtServerConnect
            // 
            this.WtServerConnect.Name = "WtServerConnect";
            resources.ApplyResources(this.WtServerConnect, "WtServerConnect");
            this.WtServerConnect.Click += new System.EventHandler(this.WtServerConnect_Click);
            // 
            // additionalCommansToolStripMenuItem
            // 
            this.additionalCommansToolStripMenuItem.Name = "additionalCommansToolStripMenuItem";
            resources.ApplyResources(this.additionalCommansToolStripMenuItem, "additionalCommansToolStripMenuItem");
            // 
            // �������ToolStripMenuItem
            // 
            this.�������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.���������������������ToolStripMenuItem,
            this.�����������ToolStripMenuItem});
            this.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem";
            resources.ApplyResources(this.�������ToolStripMenuItem, "�������ToolStripMenuItem");
            // 
            // ���������������������ToolStripMenuItem
            // 
            this.���������������������ToolStripMenuItem.Name = "���������������������ToolStripMenuItem";
            resources.ApplyResources(this.���������������������ToolStripMenuItem, "���������������������ToolStripMenuItem");
            this.���������������������ToolStripMenuItem.Click += new System.EventHandler(this.���������������������ToolStripMenuItem_Click);
            // 
            // �����������ToolStripMenuItem
            // 
            this.�����������ToolStripMenuItem.Name = "�����������ToolStripMenuItem";
            resources.ApplyResources(this.�����������ToolStripMenuItem, "�����������ToolStripMenuItem");
            this.�����������ToolStripMenuItem.Click += new System.EventHandler(this.�����������ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLabelRecordsCount,
            this.statlabeRecval});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // stsLabelRecordsCount
            // 
            this.stsLabelRecordsCount.Name = "stsLabelRecordsCount";
            resources.ApplyResources(this.stsLabelRecordsCount, "stsLabelRecordsCount");
            // 
            // statlabeRecval
            // 
            this.statlabeRecval.Name = "statlabeRecval";
            resources.ApplyResources(this.statlabeRecval, "statlabeRecval");
            // 
            // openScriptArch
            // 
            resources.ApplyResources(this.openScriptArch, "openScriptArch");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtgDataGrd
            // 
            this.dtgDataGrd.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDataGrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDataGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDataGrd.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dtgDataGrd, "dtgDataGrd");
            this.dtgDataGrd.Name = "dtgDataGrd";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDataGrd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDataGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDataGrd_CellContentClick);
            // 
            // tlspToolBar
            // 
            resources.ApplyResources(this.tlspToolBar, "tlspToolBar");
            this.tlspToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnSearch,
            this.btnBackup,
            this.btnRestore,
            this.btnImportTable,
            this.btnOptions});
            this.tlspToolBar.Name = "tlspToolBar";
            this.tlspToolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlspToolBar_ItemClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnRestore, "btnRestore");
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnImportTable
            // 
            this.btnImportTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnImportTable, "btnImportTable");
            this.btnImportTable.Name = "btnImportTable";
            this.btnImportTable.Click += new System.EventHandler(this.��������������ToolStripMenuItem_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnOptions, "btnOptions");
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Click += new System.EventHandler(this.��������ToolStripMenuItem_Click);
            // 
            // BookerMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgDataGrd);
            this.Controls.Add(this.tlspToolBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookerMain";
            this.Activated += new System.EventHandler(this.BookerMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookerMain_FormClosed);
            this.Load += new System.EventHandler(this.BookerMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataGrd)).EndInit();
            this.tlspToolBar.ResumeLayout(false);
            this.tlspToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ���������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ������������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ������������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ���������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ����������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        // WareForms.WareTimer tmrTimer;
        //private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
       // private System.Windows.Forms.ToolStripProgressBar tlstrpProgressBar;
        //private WareForms.WareTimer tmrProgressBarWatcher;
        public System.Windows.Forms.ToolStripMenuItem ������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �����������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��������ToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripMenuItem additionalCommansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ���������������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��������������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ������������������ScriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ���������������ScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ���������������������HydorbaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stsLabelRecordsCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel statlabeRecval;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.OpenFileDialog openScriptArch;
        private System.Windows.Forms.ToolStripMenuItem WtServerConnect;
        public System.Windows.Forms.DataGridView dtgDataGrd;
        public System.Windows.Forms.ToolStrip tlspToolBar;
        public System.Windows.Forms.ToolStripButton btnUpdate;
        public System.Windows.Forms.ToolStripButton btnSearch;
        public System.Windows.Forms.ToolStripButton btnBackup;
        public System.Windows.Forms.ToolStripButton btnRestore;
        public System.Windows.Forms.ToolStripButton btnImportTable;
        public System.Windows.Forms.ToolStripButton btnOptions;
        //private System.Windows.Forms.ToolStripStatusLabel toolStripTimersstatus;
        //private WareForms.WareToolStripStatusLabel toolStripStatusLabel2;
        
    }
}