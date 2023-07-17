using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Configuration;
using System.Globalization;
using System.Diagnostics;
//using System.Timers;
using Hydrobase;
using HydrobaseSDK;
// 
using PluginHundler;
using TimeLimitedWindow;
using WareForms;
using HydroMultyUser;
using LocaleHundler;
using RSSApplicationUpdater;
using Scrabler;

//using Hydrobase_Advanced_Config;


namespace Booker
{
 // public partial class BookerMain : Form
 public partial class BookerMain : WareForm
    {
        LocaleHundlerCore locale;
        
        BookerKernel kernel = new BookerKernel();
        
     
   
        
        optionsGUI optionsGui;
      
        protected override void OnLoad(EventArgs ev)
        {
            try
            {
                
                this.DefaultDataset = BookerKernel.dtsData;
                BookerKernel.hbbackup = new Maintenance_Backup();

              

                DefaultCulture = LocaleHundlerCore.SelectedCulture;
               

                DefaultStatusStrip = this.statusStrip1;
                DefaultDataset = BookerKernel.dtsData;
                ExistingDataSets = new DataSet[1];
                ExistingDataSets[0] = BookerKernel.dtsData;
                DefaultDataGridView = this.dtgDataGrd;
                ExistingDataGridView = new DataGridView[1];
                ExistingDataGridView[0] = this.dtgDataGrd;
                this.DefaultAdditionalCommandsMenu = this.additionalCommansToolStripMenuItem;


                kernel.OnLoad(this);
                base.OnLoad(ev);
                


                //MessageBox.Show(tmp);
            }
            catch (Exception e)
            {

                 program.errorreport(e);

            }

            
            

            
        }
       

        public BookerMain()
        {
            InitializeComponent();
           locale = new LocaleHundlerCore();
           //locale.ReadconfigXml();
           //this.ControlDB = new ControlDB();

           locale.Translate(this.Name, this);

            //HBClass = new XMLhydrobase();
            BookerKernel.HBClassADO = new hydrobaseADO(true);
            BookerKernel.bclass = new BaseClass();
            BookerKernel.hbCryptrijndael = new Cryptography();
            BookerKernel.pluginHundel = new PluginHundler.PluginHundler();
            //SDKBase.UserMainPath =  Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", " ");
            //this.Tag = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", " ");
            //SDKBase.UserMainPath = Convert.ToString(this.Tag);
            /*this.tlstrpProgressBar.Minimum = 0;
            this.tlstrpProgressBar.Maximum = this.tmrTimer.Interval;
            this.tlstrpProgressBar.Step = multiplyTimer;
           this.DefaultTimersStatus = this.toolStripStatusLabel2;*/
            this.DefaultAdditionalCommandsMenu = this.additionalCommansToolStripMenuItem;

            optionsCore.OptGeneralTags = BookerKernel.generaltags;
            optionsCore.OptSecurityTags = BookerKernel.securitytags;
           program.appupdater = BookerKernel.appudate;

            

        }
        void BookerMain_RowChanged(object sender, EventArgs Ev)
            { 
                try 
                {
                    BookerKernel.HBClassADO.CloseDataBase(BookerKernel.dtsData);
                    BookerKernel.dtsData = new DataSet();
                int i;


                i = BookerKernel.HBClassADO.SendtoDataGrid(this.dtgDataGrd, BookerKernel.dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + BookerKernel.bookdb + "\\" + BookerKernel.booktable + BaseClass.defualt_encryptedtableextensionwithSha384, 0);
               
               
                //this.ClearProgressBagValue();
                //MessageBox.Show("check");
                this.ReconnectEvents();

            }
            catch (Exception ex)
            {

                 program.errorreport(ex);
            }


            }
        void BookerMain_TableNewRow(object sender, EventArgs ev)
        {
            try
            {
                BookerKernel.HBClassADO.CloseDataBase(BookerKernel.dtsData);
                BookerKernel.dtsData = new DataSet();
                int i;


                i = BookerKernel.HBClassADO.SendtoDataGrid(this.dtgDataGrd, BookerKernel.dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + BookerKernel.bookdb + "\\" + BookerKernel.booktable + BaseClass.defualt_encryptedtableextensionwithSha384, 0);


                //this.ClearProgressBagValue();
                //MessageBox.Show("check");
                this.ReconnectEvents();


            }
            catch (Exception ex)
            {

                  program.errorreport(ex);
            }

        }
           

        
       
        
        
        private void BookerMain_Close(object sender, EventArgs er)
        {
            try
            {
                //btnEncrypt_Click(sender, er);
                
                //btnUpdate_Click(sender, er);
                //hbCryptrijndael.SaveEncryptedFile(SDKBase.UserMainPath +  bookdb + "\\"+booktable++ BaseClass.defualt_encryptedtableextensionwithSha384, SDKBase.UserMainPath +  bookdb + "\\"+booktable++ BaseClass.defualt_encryptedtableextensionwithSha384, passPhrase);
                //this.btnBackup_Click(sender, er);
                //File.Delete(SDKBase.UserMainPath +  bookdb + "\\"+booktable++ BaseClass.defualt_encryptedtableextensionwithSha384);
                

            }
            catch (Exception e)
            {
                program.errorreport(e);

            }


        }
     


        public  void BookerMain_Load(object sender, EventArgs e)
        {

            try
            {

               
                program.Activewin = this;

                kernel.Load(this);
                

               
               
                
            }
            catch (Exception er)
            {

                  program.errorreport(er);
            }
            
            
            


        }
        void ReconnectEvents()
        {
            try
            {

                BookerKernel.dtsData.Tables[BookerKernel.bookdb].RowChanged += new DataRowChangeEventHandler(BookerMain_RowChanged);
                //dtsData.Tables[bookdb].RowDeleted += new DataRowChangeEventHandler(BookerMain_RowChanged);
                //dtsData.Tables[bookdb].TableNewRow+=new DataTableNewRowEventHandler(BookerMain_TableNewRow);
            }
            catch (Exception e)
            {
                 program.errorreport(e);
            

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookerKernel.enable_white_tiger_serverclient == false)
                {
                    kernel.Update(this);
                    //this.EnableTimer();
                    //HBClassADO.AttachDataBaseinDataSet(this.dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384);
                    // HBClassADO.SendtoDataGrid(this.dtgDataGrd, this.dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, 0);
                }
                else
                {
                    WTbtnUpdate_Click(sender, e);
                    
                }
            }
            catch (Exception er)
            {

                  program.errorreport(er);
            }
          

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                kernel.Search();

            }
            catch (Exception er)
            {

                  program.errorreport(er);
            }
            
            //HBClass.Anazitisi(bookdb, "‘ﬂÙÎÔÚ", "Poems Collection");
            

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {




                kernel.Encrypt(this);

            }
            catch (Exception ex)
            {
                //bclass.GetHydrobaseLibraryversion (ex);
                 program.errorreport(ex);

            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {


                kernel.Decrypt(this);
                //this.tmrTimer.Start();
                //this.tmrProgressBarWatcher.Start();



            
}

            catch (Exception ex)
            {

                 program.errorreport(ex);
            }
        
}

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {

               // MessageBox.Show("hi1");
                if (BookerKernel.enable_white_tiger_serverclient == false)
                {

                    kernel.Backup(this);
                }
                else
                {
                    WTbtnBackup_Click(sender, e);

                }
            }
            catch (Exception ex)
            {

                 program.errorreport(ex);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookerKernel.enable_white_tiger_serverclient == false)
                {
                    kernel.Restore(this);
                }
                else
                {

                    WTbtnRestore_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                 program.errorreport(ex);
            }

           //hbbackup.RecoverBackupStpB(baxckupfoldr, SDKBase.UserMainPath + "\\books");
        }

        private void UpgradeDataBase_Click(object sender, EventArgs e)
        {

            try
            {
                kernel.UpgradeDb(this);
                
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.ToString());
                 program.errorreport(ex);
            }


        }

        private void Exit_click(object sender, EventArgs e)
        {
            try
            {
                kernel.CleanFolder();


                kernel.Exit(this);

            }
            catch (Exception er)
            {
                  program.errorreport(er);

            }
        }

        private void ÎÁÒÔˆÔÒﬂÂÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AboutBox abtBox = new AboutBox();
                abtBox.Show();
            }
            catch (Exception ex)
            {
                 program.errorreport(ex);

            }
        }


      
        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs ev)
        {
            try
            {
                

            }

            catch (Exception e)
            {
                 program.errorreport(e);

            }
        }

        private void BookerMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                kernel.CleanFolder();
                kernel.Formclose(this);

            }
            catch (Exception er)
            {
                  program.errorreport(er);

            }
        }

        private void dtgDataGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void „ÂÌÈÍ‹ToolStripMenuItem_Click(object sender, EventArgs ev)
        {
            try
            {
                /*this.optionsGui = new GUI(SDKBase.ApplicationPreferencesDir + "\\" + optionsCore.generalfile + BaseClass.default_fileextension);
                this.optionsGui.Tags = this.generaltags;
                optionsGui.Text = optionsCore.generalfile  + "settings";
                optionsGui.Show();*/

            }
            catch (Exception e)
            {
                 program.errorreport(e);
            }

        }

        private void ·Ûˆ‹ÎÂÈ·ToolStripMenuItem_Click(object sender, EventArgs ev)
        {
            try
            {
               /* this.optionsGui = new GUI(SDKBase.ApplicationPreferencesDir + "\\" + optionsCore.securityfile + BaseClass.default_fileextension );
                this.optionsGui.Tags = this.securitytags ;
                optionsGui.Text = optionsCore.securityfile + "settings";
                optionsGui.Show();*/
            }
            catch (Exception e)
            {
                 program.errorreport(e);
            }

        }

        private void BookerMain_Activated(object sender, EventArgs ev)
        {
            try
            {
                program.Activewin = this;
            }
            catch (Exception e)
            {
                 program.errorreport(e);
            }

        }

        private void ÂÌÁÏ›Ò˘ÛÁ–ÒÔ„Ò‹ÏÏ·ÙÔÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BookerKernel.appudate.GetExeCutingApplicationVersion(Assembly.LoadFile(Application.ExecutablePath));
                BookerKernel.appudate.CheckforNewVersionsChangeLog();


            }
            catch (Exception ex)
            {
                  program.errorreport(ex);
            }
        }

        

        private void ÂÈÎÔ„›ÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                optionsGui = new optionsGUI();
                optionsGui.Show();
            }
            catch (Exception ex)
            {
                  program.errorreport(ex);
            }
        }

        private void ÂÈÛ·„˘„ﬁ–ﬂÌ·Í·ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookerKernel.enable_white_tiger_serverclient == false)
            {
                kernel.ImportTable(this);
            }
            else
            {

                WTbtnImportTable_Click(sender, e);
            }
        }

        private void ÂÏˆ‹ÌÈÛÁ÷ÔÒÙ˘Ï›Ì˘ÌScriptsToolStripMenuItem_Click(object sender, EventArgs ev)
        {
            try
            {
                LoadedScripts scrpform = new LoadedScripts();
                scrpform.Show();

            }
            catch (Exception ex)
            {

                  program.errorreport(ex);


            }
        }

        private void Â„Í·Ù‹ÛÙ·ÛÁÕ›ÔıScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Scrabler.ScrablerInstaller scrInstaller = new Scrabler.ScrablerInstaller();
                if ((openScriptArch.ShowDialog() != DialogResult.Cancel) &&(openScriptArch.FileName !=null))
                {
                    scrInstaller.Install(openScriptArch.FileName, "C:\\Documents and Settings\\" + Environment.UserName + "\\Application Data\\" + Application.ProductName);


                }

            }
            catch (Exception ex)
            {

                  program.errorreport(ex);


            }
        }

        private void ÒÔ˜˘ÒÈÏ›ÌÂÚ—ÈËÏﬂÛÂÈÚHydorbaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Path.GetDirectoryName(Application.ExecutablePath).Replace("file:\\"," ")+"\\Hydrobase Advanced Config.exe";
                p.StartInfo.Arguments = true.ToString();
                p.Start();

            }
            catch (Exception ex)
            {

                  program.errorreport(ex);


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                
                this.statlabeRecval.Text = string.Format("{0}", this.dtgDataGrd.Rows.Count);
            }
            catch (Exception ex)
            {

                  program.errorreport(ex);


            }
        }

        private void WtServerConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //BookerKernel.wtclientcore = new WTClientCore();

                //BookerKernel.wtclientcore.MakeAction(this);
            }
            catch (Exception ex)
            {

                  program.errorreport(ex);


            }
        }

        private void WTbtnUpdate_Click(object sender, EventArgs e)
        {
           // WhiteTigerCleint cl = new WhiteTigerCleint();
            
            //cl.Update(sender, e);
            //cl.Load(this);
        }

        private void WTbtnBackup_Click(object sender, EventArgs e)
        {
           // WhiteTigerCleint cl = new WhiteTigerCleint();
            //cl.Backup(sender, e);
            //cl.Load(this);
        }

        private void WTbtnRestore_Click(object sender, EventArgs e)
        {
           // WhiteTigerCleint cl = new WhiteTigerCleint();
          
        }

        private void WTbtnImportTable_Click(object sender, EventArgs e)
        {
           // WhiteTigerCleint cl = new WhiteTigerCleint();
            //cl.ImportTable(sender, e);
            //cl.Load(this);
        }

        private void tlspToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

      

        
       

        
       

        

        

        

        
       
            
        

    
    }
}