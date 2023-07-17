using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Windows.Forms;
using Hydrobase;
using HydrobaseSDK;
 
using System.Globalization;
using RSSApplicationUpdater;
using LocaleHundler;
using WareForms;
namespace Booker
{
    public partial class optionsGUI : WareForm
    { 
         string filename;
       public  string[] Tags;
        const string greeklang = "Greek(Ελληνικά)";
        const string engllsng = "English(Αγγλικά)";
        LocaleHundlerCore locahndler = new LocaleHundlerCore();
        DataSet optionsSet = new DataSet();
        ApplicationUpdater appudater = new ApplicationUpdater(true);
        public optionsGUI()
        {
            InitializeComponent();
            int i;
           this.DefaultTabControl = this.tabControl;
          
           this.ExistedPanels = new Panel[3];
           
               this.ExistedPanels[0] = panel1;
               this.ExistedPanels[1] = panel2;
               this.ExistedPanels[2] = panel3;
               
            
           
         

           if (locahndler.ReadconfigXml().ExternalLanguageFileEnabled == true)
           {
               locahndler.Translate(this.Name, this);

           }// this.filename = filenam;
           else
           {

               locahndler.Translate();
           }
          
        }

        private void optionsGUI_Load(object sender, EventArgs e)
        {
            //if (Core.settingDir != null)
            {
               
               // this.Text += Convert.ToString(this.ExistedPanels.Length);
               

                optionsCore.CreateSettingsFiles();
                optionsCore.LoadSettings();
                tabControl.SelectedTab = tabControl.TabPages[0];
                this.LoadActiveSectionsVal();
                this.cbxUseExternalLangFile.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs ev)
        {
            try
            {
                this.Close();

            }
            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }
        }



        void LoadActiveSectionsVal()
        {

            try
            {
               
                if ((optionsCore.GeneralSet != null) && (optionsCore.SecuritySet != null) && (optionsCore.GeneralSet.Tables[0] != null) && (optionsCore.SecuritySet.Tables[0] != null))
                {
                    int i;
                    if (tabControl.SelectedTab.Tag == "General")
                    {
                        object[] vals = optionsCore.GeneralSet.Tables[0].Rows[0].ItemArray;
                        cbxenableEncryptedTables.Checked = optionsCore.CheckandFixBooleanValues(vals[0]);
                        cbxEnableEncryptedBackup.Checked = optionsCore.CheckandFixBooleanValues(vals[1]);
                        cbxExecuteScripts.Checked = optionsCore.CheckandFixBooleanValues(vals[2]);
                        cbxEnableToolbar.Checked = optionsCore.CheckandFixBooleanValues(vals[3]);
                        cbxWhiteTigerServer.Checked = optionsCore.CheckandFixBooleanValues(vals[4]);
                        
                        if (locahndler.ReadconfigXml().LanguageCode == "en")
                        {
                            cmbLanguage.Text = engllsng;


                        }
                        else if ((locahndler.ReadconfigXml().LanguageCode == "el-GR") || (locahndler.ReadconfigXml().LanguageCode == "el"))
                        {
                            cmbLanguage.Text = greeklang;


                        }
                        cbxUseExternalLangFile.Checked = locahndler.ReadconfigXml().ExternalLanguageFileEnabled;

                    }
                    else if (tabControl.SelectedTab.Tag == "Security")
                    {
                        object[] vals = optionsCore.SecuritySet.Tables[0].Rows[0].ItemArray;
                        cbxUsersPassPhrase.Checked = optionsCore.CheckandFixBooleanValues(vals[0]);
                        txtPassphrase.Text = Convert.ToString(vals[1]);

                    }
                    else if (tabControl.SelectedTab.Tag == "Update")
                    {
                        
                        RSSApplicationUpdater.Properties proper = appudater.properties;
                        if (proper != null)
                        {

                            txtupdatefeed.Text = proper.URI;
                            cmbRealeseState.SelectedText = proper.Release_State;
                            cbxAutoCheckUpdate.Checked = proper.AutoCheck;

                        }


                    }
                    else if (tabControl.SelectedTab.Tag == "Debug")
                    {
                       // if (program.Bugger.mailaddress_from != null)
                        {
                          

                        }

                    }
                }

            }

            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }


        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs ev)
        {
            try
            {
                this.LoadActiveSectionsVal();

            }
            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }
           
        }

        private void General_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaveSecurity_Click(object sender, EventArgs ev)
        {
            try
            {
                DataTable table = optionsCore.SecuritySet.Tables[0];
                object[] vals = table.Rows[0].ItemArray;
                vals[0] = (object)optionsCore.BoolToString(cbxUsersPassPhrase.Checked);
                vals[1] = (object)txtPassphrase.Text;
                table.Rows[0].ItemArray = vals;
                optionsCore.hbado.SaveTable(optionsCore.SecuritySet, SDKBase.ApplicationPreferencesDir + "\\" + optionsCore.securityfile + BaseClass.default_fileextension, 0, Application.ProductName + " - " + Application.ProductVersion);

                BookerKernel.statreadoptionvalues();
                this.Close();


            }

            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }

        }

        private void btnCancelSecurity_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveGeneral_Click(object sender, EventArgs ev)
        {
            try
            {
                DataTable table = optionsCore.GeneralSet.Tables[0];
                object[] vals = table.Rows[0].ItemArray;
                vals[0] = (object)optionsCore.BoolToString(this.cbxenableEncryptedTables.Checked);
                vals[1] = (object)optionsCore.BoolToString(cbxEnableEncryptedBackup.Checked);
                vals[2] = (object)optionsCore.BoolToString(cbxExecuteScripts.Checked);
                vals[3] = (object)optionsCore.BoolToString(cbxEnableToolbar.Checked);
                vals[4] = (object)optionsCore.BoolToString(cbxWhiteTigerServer.Checked);



                table.Rows[0].ItemArray = vals;
                optionsCore.hbado.SaveTable(optionsCore.GeneralSet, SDKBase.ApplicationPreferencesDir + "\\" + optionsCore.generalfile + BaseClass.default_fileextension, 0, Application.ProductName + " - " + Application.ProductVersion);
                if (cmbLanguage.Text == engllsng)
                {
                    locahndler.SaveLangconfigXml("en",cbxUseExternalLangFile.Checked);
                   

                }
                else if (cmbLanguage.Text == greeklang)
                {

                    locahndler.SaveLangconfigXml("el-GR", cbxUseExternalLangFile.Checked);
                }
                else
                {
                    if (cmbLanguage.Text != null)
                    {

                        locahndler.SaveLangconfigXml(cmbLanguage.Text, cbxUseExternalLangFile.Checked);

                    }

                    BookerKernel.statreadoptionvalues();
                }
                this.Close();


            }

            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs ev)
        {

            try
            {


                this.LoadActiveSectionsVal();

            }


            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs ev)
        {
            try
            {


                RSSApplicationUpdater.Properties proper = new RSSApplicationUpdater.Properties();
                if ((txtupdatefeed.Text != null) && (cmbRealeseState.SelectedText!=null))
                {
                proper.ApplicationName = ProductName;
                proper.URI = txtupdatefeed.Text;
                proper.Release_State = cmbRealeseState.Text;
                proper.AutoCheck = cbxAutoCheckUpdate.Checked;

                appudater.properties = proper;
                appudater.SaveConfig();
                BookerKernel.statreadoptionvalues();
                this.Close();

                }
                

            }


            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }
        }

        private void btnChangeFeed_Click(object sender, EventArgs ev)
        {
            try
            {
                appudater.ChangeConfigFeed();

            }
            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }
        }

        private void btnDebugCancel_Click(object sender, EventArgs ev)
        {
            try
            {
                this.Close();

            }
            catch (Exception e)
            {
                optionsCore.Bugtracking(e);
            }
        }

       


       
    }
}