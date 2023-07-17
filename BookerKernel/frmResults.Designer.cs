namespace Booker
{
    partial class frmResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResults));
            this.dgrResults = new System.Windows.Forms.DataGridView();
            this.btnSaveInHydrobase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgrResults)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrResults
            // 
            this.dgrResults.AccessibleDescription = null;
            this.dgrResults.AccessibleName = null;
            resources.ApplyResources(this.dgrResults, "dgrResults");
            this.dgrResults.BackgroundImage = null;
            this.dgrResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrResults.Font = null;
            this.dgrResults.Name = "dgrResults";
            // 
            // btnSaveInHydrobase
            // 
            this.btnSaveInHydrobase.AccessibleDescription = null;
            this.btnSaveInHydrobase.AccessibleName = null;
            resources.ApplyResources(this.btnSaveInHydrobase, "btnSaveInHydrobase");
            this.btnSaveInHydrobase.BackgroundImage = null;
            this.btnSaveInHydrobase.Font = null;
            this.btnSaveInHydrobase.Name = "btnSaveInHydrobase";
            this.btnSaveInHydrobase.UseVisualStyleBackColor = true;
            this.btnSaveInHydrobase.Click += new System.EventHandler(this.btnSaveInHydrobase_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.panel1.Controls.Add(this.btnSaveInHydrobase);
            this.panel1.Font = null;
            this.panel1.Name = "panel1";
            // 
            // saveFileDialog
            // 
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            // 
            // frmResults
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrResults);
            this.Font = null;
            this.Icon = null;
            this.Name = "frmResults";
            this.Load += new System.EventHandler(this.frmResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgrResults;
        private System.Windows.Forms.Button btnSaveInHydrobase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}