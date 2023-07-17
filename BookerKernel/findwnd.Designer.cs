namespace Booker
{
    partial class findwnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findwnd));
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstFields = new System.Windows.Forms.ListBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtSearched = new System.Windows.Forms.TextBox();
            this.rdbSearchStartsWith = new System.Windows.Forms.RadioButton();
            this.rdbSearchEndsWith = new System.Windows.Forms.RadioButton();
            this.rdbSearchForeMatching = new System.Windows.Forms.RadioButton();
            this.cbxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_click);
            // 
            // lstFields
            // 
            resources.ApplyResources(this.lstFields, "lstFields");
            this.lstFields.FormattingEnabled = true;
            this.lstFields.Name = "lstFields";
            this.lstFields.SelectedIndexChanged += new System.EventHandler(this.lstFields_SelectedIndexChanged);
            // 
            // lblMsg
            // 
            resources.ApplyResources(this.lblMsg, "lblMsg");
            this.lblMsg.Name = "lblMsg";
            // 
            // txtSearched
            // 
            resources.ApplyResources(this.txtSearched, "txtSearched");
            this.txtSearched.Name = "txtSearched";
            // 
            // rdbSearchStartsWith
            // 
            resources.ApplyResources(this.rdbSearchStartsWith, "rdbSearchStartsWith");
            this.rdbSearchStartsWith.Name = "rdbSearchStartsWith";
            this.rdbSearchStartsWith.TabStop = true;
            this.rdbSearchStartsWith.UseVisualStyleBackColor = true;
            // 
            // rdbSearchEndsWith
            // 
            resources.ApplyResources(this.rdbSearchEndsWith, "rdbSearchEndsWith");
            this.rdbSearchEndsWith.Name = "rdbSearchEndsWith";
            this.rdbSearchEndsWith.TabStop = true;
            this.rdbSearchEndsWith.UseVisualStyleBackColor = true;
            // 
            // rdbSearchForeMatching
            // 
            resources.ApplyResources(this.rdbSearchForeMatching, "rdbSearchForeMatching");
            this.rdbSearchForeMatching.Name = "rdbSearchForeMatching";
            this.rdbSearchForeMatching.TabStop = true;
            this.rdbSearchForeMatching.UseVisualStyleBackColor = true;
            // 
            // cbxCaseSensitive
            // 
            resources.ApplyResources(this.cbxCaseSensitive, "cbxCaseSensitive");
            this.cbxCaseSensitive.Name = "cbxCaseSensitive";
            this.cbxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // findwnd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxCaseSensitive);
            this.Controls.Add(this.rdbSearchForeMatching);
            this.Controls.Add(this.rdbSearchEndsWith);
            this.Controls.Add(this.rdbSearchStartsWith);
            this.Controls.Add(this.txtSearched);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lstFields);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "findwnd";
            this.Load += new System.EventHandler(this.findwnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtSearched;
        private System.Windows.Forms.RadioButton rdbSearchStartsWith;
        private System.Windows.Forms.RadioButton rdbSearchEndsWith;
        private System.Windows.Forms.RadioButton rdbSearchForeMatching;
        private System.Windows.Forms.CheckBox cbxCaseSensitive;
    }
}