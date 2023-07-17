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
            this.αρχείοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ενημέρωσηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εισαγωγήΠίνακαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.κρυπογράφησηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.αποκρυπτογράφησηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εργαλείαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αντίγραφαΑσφάλειαςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ανάκτησηΑντυγράφωνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αναζήτησηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.επιλογέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εμφάνισηΦορτωμένωνScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εγκατάστασηΝέουScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WtServerConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalCommansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βοήθειαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ενημέρωσηΠρογράμματοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.πληροφορίεςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.αρχείοToolStripMenuItem,
            this.εργαλείαToolStripMenuItem,
            this.additionalCommansToolStripMenuItem,
            this.βοήθειαToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip1_ItemAdded);
            // 
            // αρχείοToolStripMenuItem
            // 
            this.αρχείοToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ενημέρωσηToolStripMenuItem,
            this.εισαγωγήΠίνακαToolStripMenuItem,
            this.κρυπογράφησηToolStripMenuItem,
            this.toolStripMenuItem1,
            this.αποκρυπτογράφησηToolStripMenuItem,
            this.έξοδοςToolStripMenuItem});
            this.αρχείοToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            resources.ApplyResources(this.αρχείοToolStripMenuItem, "αρχείοToolStripMenuItem");
            // 
            // ενημέρωσηToolStripMenuItem
            // 
            this.ενημέρωσηToolStripMenuItem.Name = "ενημέρωσηToolStripMenuItem";
            resources.ApplyResources(this.ενημέρωσηToolStripMenuItem, "ενημέρωσηToolStripMenuItem");
            this.ενημέρωσηToolStripMenuItem.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // εισαγωγήΠίνακαToolStripMenuItem
            // 
            this.εισαγωγήΠίνακαToolStripMenuItem.Name = "εισαγωγήΠίνακαToolStripMenuItem";
            resources.ApplyResources(this.εισαγωγήΠίνακαToolStripMenuItem, "εισαγωγήΠίνακαToolStripMenuItem");
            this.εισαγωγήΠίνακαToolStripMenuItem.Click += new System.EventHandler(this.εισαγωγήΠίνακαToolStripMenuItem_Click);
            // 
            // κρυπογράφησηToolStripMenuItem
            // 
            this.κρυπογράφησηToolStripMenuItem.Name = "κρυπογράφησηToolStripMenuItem";
            resources.ApplyResources(this.κρυπογράφησηToolStripMenuItem, "κρυπογράφησηToolStripMenuItem");
            this.κρυπογράφησηToolStripMenuItem.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.UpgradeDataBase_Click);
            // 
            // αποκρυπτογράφησηToolStripMenuItem
            // 
            this.αποκρυπτογράφησηToolStripMenuItem.Name = "αποκρυπτογράφησηToolStripMenuItem";
            resources.ApplyResources(this.αποκρυπτογράφησηToolStripMenuItem, "αποκρυπτογράφησηToolStripMenuItem");
            this.αποκρυπτογράφησηToolStripMenuItem.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // έξοδοςToolStripMenuItem
            // 
            this.έξοδοςToolStripMenuItem.Name = "έξοδοςToolStripMenuItem";
            resources.ApplyResources(this.έξοδοςToolStripMenuItem, "έξοδοςToolStripMenuItem");
            this.έξοδοςToolStripMenuItem.Click += new System.EventHandler(this.Exit_click);
            // 
            // εργαλείαToolStripMenuItem
            // 
            this.εργαλείαToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αντίγραφαΑσφάλειαςToolStripMenuItem,
            this.ανάκτησηΑντυγράφωνToolStripMenuItem,
            this.αναζήτησηToolStripMenuItem,
            this.επιλογέςToolStripMenuItem,
            this.εμφάνισηΦορτωμένωνScriptsToolStripMenuItem,
            this.εγκατάστασηΝέουScriptToolStripMenuItem,
            this.προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem,
            this.WtServerConnect});
            this.εργαλείαToolStripMenuItem.Name = "εργαλείαToolStripMenuItem";
            resources.ApplyResources(this.εργαλείαToolStripMenuItem, "εργαλείαToolStripMenuItem");
            // 
            // αντίγραφαΑσφάλειαςToolStripMenuItem
            // 
            this.αντίγραφαΑσφάλειαςToolStripMenuItem.Name = "αντίγραφαΑσφάλειαςToolStripMenuItem";
            resources.ApplyResources(this.αντίγραφαΑσφάλειαςToolStripMenuItem, "αντίγραφαΑσφάλειαςToolStripMenuItem");
            this.αντίγραφαΑσφάλειαςToolStripMenuItem.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // ανάκτησηΑντυγράφωνToolStripMenuItem
            // 
            this.ανάκτησηΑντυγράφωνToolStripMenuItem.Name = "ανάκτησηΑντυγράφωνToolStripMenuItem";
            resources.ApplyResources(this.ανάκτησηΑντυγράφωνToolStripMenuItem, "ανάκτησηΑντυγράφωνToolStripMenuItem");
            this.ανάκτησηΑντυγράφωνToolStripMenuItem.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // αναζήτησηToolStripMenuItem
            // 
            this.αναζήτησηToolStripMenuItem.Name = "αναζήτησηToolStripMenuItem";
            resources.ApplyResources(this.αναζήτησηToolStripMenuItem, "αναζήτησηToolStripMenuItem");
            this.αναζήτησηToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // επιλογέςToolStripMenuItem
            // 
            this.επιλογέςToolStripMenuItem.Name = "επιλογέςToolStripMenuItem";
            resources.ApplyResources(this.επιλογέςToolStripMenuItem, "επιλογέςToolStripMenuItem");
            this.επιλογέςToolStripMenuItem.Click += new System.EventHandler(this.επιλογέςToolStripMenuItem_Click);
            // 
            // εμφάνισηΦορτωμένωνScriptsToolStripMenuItem
            // 
            this.εμφάνισηΦορτωμένωνScriptsToolStripMenuItem.Name = "εμφάνισηΦορτωμένωνScriptsToolStripMenuItem";
            resources.ApplyResources(this.εμφάνισηΦορτωμένωνScriptsToolStripMenuItem, "εμφάνισηΦορτωμένωνScriptsToolStripMenuItem");
            this.εμφάνισηΦορτωμένωνScriptsToolStripMenuItem.Click += new System.EventHandler(this.εμφάνισηΦορτωμένωνScriptsToolStripMenuItem_Click);
            // 
            // εγκατάστασηΝέουScriptToolStripMenuItem
            // 
            this.εγκατάστασηΝέουScriptToolStripMenuItem.Name = "εγκατάστασηΝέουScriptToolStripMenuItem";
            resources.ApplyResources(this.εγκατάστασηΝέουScriptToolStripMenuItem, "εγκατάστασηΝέουScriptToolStripMenuItem");
            this.εγκατάστασηΝέουScriptToolStripMenuItem.Click += new System.EventHandler(this.εγκατάστασηΝέουScriptToolStripMenuItem_Click);
            // 
            // προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem
            // 
            this.προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem.Name = "προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem";
            resources.ApplyResources(this.προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem, "προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem");
            this.προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem.Click += new System.EventHandler(this.προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem_Click);
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
            // βοήθειαToolStripMenuItem
            // 
            this.βοήθειαToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ενημέρωσηΠρογράμματοςToolStripMenuItem,
            this.πληροφορίεςToolStripMenuItem});
            this.βοήθειαToolStripMenuItem.Name = "βοήθειαToolStripMenuItem";
            resources.ApplyResources(this.βοήθειαToolStripMenuItem, "βοήθειαToolStripMenuItem");
            // 
            // ενημέρωσηΠρογράμματοςToolStripMenuItem
            // 
            this.ενημέρωσηΠρογράμματοςToolStripMenuItem.Name = "ενημέρωσηΠρογράμματοςToolStripMenuItem";
            resources.ApplyResources(this.ενημέρωσηΠρογράμματοςToolStripMenuItem, "ενημέρωσηΠρογράμματοςToolStripMenuItem");
            this.ενημέρωσηΠρογράμματοςToolStripMenuItem.Click += new System.EventHandler(this.ενημέρωσηΠρογράμματοςToolStripMenuItem_Click);
            // 
            // πληροφορίεςToolStripMenuItem
            // 
            this.πληροφορίεςToolStripMenuItem.Name = "πληροφορίεςToolStripMenuItem";
            resources.ApplyResources(this.πληροφορίεςToolStripMenuItem, "πληροφορίεςToolStripMenuItem");
            this.πληροφορίεςToolStripMenuItem.Click += new System.EventHandler(this.πληροφορίεςToolStripMenuItem_Click);
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
            this.btnImportTable.Click += new System.EventHandler(this.εισαγωγήΠίνακαToolStripMenuItem_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnOptions, "btnOptions");
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Click += new System.EventHandler(this.επιλογέςToolStripMenuItem_Click);
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

        private System.Windows.Forms.ToolStripMenuItem ενημέρωσηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εργαλείαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αντίγραφαΑσφάλειαςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ανάκτησηΑντυγράφωνToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αναζήτησηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem κρυπογράφησηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αποκρυπτογράφησηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem έξοδοςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        // WareForms.WareTimer tmrTimer;
        //private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
       // private System.Windows.Forms.ToolStripProgressBar tlstrpProgressBar;
        //private WareForms.WareTimer tmrProgressBarWatcher;
        public System.Windows.Forms.ToolStripMenuItem αρχείοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem βοήθειαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem πληροφορίεςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem επιλογέςToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripMenuItem additionalCommansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ενημέρωσηΠρογράμματοςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εισαγωγήΠίνακαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εμφάνισηΦορτωμένωνScriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εγκατάστασηΝέουScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem προχωριμένεςΡιθμίσειςHydorbaseToolStripMenuItem;
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