namespace Booker
{
    partial class LoadedScripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadedScripts));
            this.dataScriptsInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataScriptsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataScriptsInfo
            // 
            this.dataScriptsInfo.AccessibleDescription = null;
            this.dataScriptsInfo.AccessibleName = null;
            resources.ApplyResources(this.dataScriptsInfo, "dataScriptsInfo");
            this.dataScriptsInfo.BackgroundImage = null;
            this.dataScriptsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataScriptsInfo.Font = null;
            this.dataScriptsInfo.Name = "dataScriptsInfo";
            // 
            // LoadedScripts
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.dataScriptsInfo);
            this.Font = null;
            this.Icon = null;
            this.Name = "LoadedScripts";
            this.Load += new System.EventHandler(this.LoadedScripts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataScriptsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataScriptsInfo;
    }
}