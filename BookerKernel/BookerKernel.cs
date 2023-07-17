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
 
using PluginHundler;
using TimeLimitedWindow;
using WareForms;
using HydroMultyUser;
using LocaleHundler;
using RSSApplicationUpdater;
using Scrabler;
//using Booker.SDK;

using System.ServiceModel;
using White_Tiger;
using White_Tiger.UserManagment;

namespace Booker
{
    public class BookerKernel
    {
        //internal static PluginLoader bookLogPlug = new PluginLoader();
        internal static ApplicationUpdater appudate = new ApplicationUpdater(true);
        public const string tbookdb = "tbookdb";
        public const string booktable = "books";
        public const string ebookdb = "books.lck";
        public const string bookdb = "books";
        public const string cpassPhrase = "Booker@!angarato surion1984";
        //public static string passPhrase;
        public string[] Kelia = { BaseClass.FileTagPrimKey + "Κωδικός", 
                                    "Τίτλος", 
                                    "Σειρά", "Αριθμός_Τόμου",
                                    "Συγγραφέας", "Είδος", 
                                    "Εκδοτικός", 
                                    "Έτος", "Γλώσσα",
                                    "ISBN", "Τύπος_Εντυπού",
                                    "Αριθμός_Σελίδων", 
                                    "Αριθμός_Ραφιού", 
                                    "Συνοδευτικό_Υλικό","Κόσμος",
                                    "Μεταφρασμένο", "Έκδοση","Διαβασμένο", 
                                    "Βαθμολόγηση", 
                                    "Σημειώσεις" };
        public string[] Cells = { BaseClass.FileTagPrimKey + "Code", 
                                    "Title", "Series", 
                                    "Number_of_Volume", 
                                    "Author", "Kind", "Publisher", 
                                    "Year", "Language", "ISBN",
                                    "Type", "Number_of_Pages", 
                                    "Number_of_Bookshelf", 
                                    "Accompanying_Meterial","World", 
                                    "Translated","Version",
                                    "isread","Ranking",  "Notes" };

        // string[] Times ={ "Βάλτε κάποιον τίττλο", "Βάλτε καποιον συγγραφεα", "βάλτε ειδος", "βαλτε εκδοτικο οικο", "ετος κικλοφοριας", "0", "κωδικοςisbn" };
        public static string[] generaltags = { "enable_encrypted_tables", "enable_encrypted_backup", 
                                                 "enable_execute_scripts", "enable_toolbar","enable_White_tiger_server" };
        public static string[] securitytags = { "enable_users_passphrase", "passphrase" };
        public static Boolean useencryptedtables, encryptedbackup, useuserspassphrase, execute_escripts,
            enable_toolbar, enable_white_tiger_server, enable_white_tiger_serverclient=false;
        public static string passphrase;

        public static ServiceHost jsonhost;

        //frmGui hydrobaseAdvanceconfGui;

        bool enablemirror = true;
   //     public static string AppFolder;
        public static DataSet dtsData = new DataSet();
        //public DataSet usersTable = new DataSet();
        //public Logger LogClass = new Logger();
        //XMLhydrobase  HBClass;
        internal static hydrobaseADO HBClassADO= new hydrobaseADO();
        internal static Cryptography hbCryptrijndael;
        internal static BaseClass bclass;
        internal static Maintenance_Backup hbbackup;
        findwnd frmFind;
        //  optionsCore optionseditorCore = new optionsCore();

        public static PluginHundler.PluginHundler pluginHundel = new PluginHundler.PluginHundler();
        static public PluginCollection Loaded_plugins;
        CultureInfo GreekCult1 = new CultureInfo("el");
        CultureInfo GreekCult2 = new CultureInfo("el-GR");
        //timeLimitedMessageBox tlMessabox;
      
        HydroMultyUserCore MulyUser = new HydroMultyUserCore();
        public static string[] Bookkelia;
        /// <summary>
        /// Read the configuration of booker and aplly settings
        /// </summary>
         public static void statreadoptionvalues()
        {
            try
            {
                int i;
                optionsCore.LoadSettings();
                if ((optionsCore.SecuritySet != null) && (optionsCore.GeneralSet != null)
                    && (optionsCore.GeneralSet.Tables.Count > 0) && (optionsCore.SecuritySet.Tables.Count > 0))
                {
                    if ((optionsCore.GeneralSet.Tables[0].Columns.Count <= optionsCore.OptGeneralTags.Length) && (optionsCore.SecuritySet.Tables[0].Columns.Count <= optionsCore.OptSecurityTags.Length))
                    {
                        i = optionsCore.GeneralSet.Tables[0].Columns.IndexOf(optionsCore.OptGeneralTags[0]);

                        useencryptedtables = optionsCore.CheckandFixBooleanValues(optionsCore.GeneralSet.Tables[0].Rows[0].ItemArray[i]);

                        i = optionsCore.GeneralSet.Tables[0].Columns.IndexOf(optionsCore.OptGeneralTags[1]);

                        encryptedbackup = optionsCore.CheckandFixBooleanValues(optionsCore.GeneralSet.Tables[0].Rows[0].ItemArray[i]);


                        i = optionsCore.GeneralSet.Tables[0].Columns.IndexOf(optionsCore.OptGeneralTags[2]);

                        execute_escripts = optionsCore.CheckandFixBooleanValues(optionsCore.GeneralSet.Tables[0].Rows[0].ItemArray[i]);


                        i = optionsCore.GeneralSet.Tables[0].Columns.IndexOf(optionsCore.OptGeneralTags[3]);
                        enable_toolbar = optionsCore.CheckandFixBooleanValues(optionsCore.GeneralSet.Tables[0].Rows[0].ItemArray[i]);

                        i = optionsCore.GeneralSet.Tables[0].Columns.IndexOf(optionsCore.OptGeneralTags[4]);
                        enable_white_tiger_server = optionsCore.CheckandFixBooleanValues(optionsCore.GeneralSet.Tables[0].Rows[0].ItemArray[i]);
                        i = optionsCore.SecuritySet.Tables[0].Columns.IndexOf(optionsCore.OptSecurityTags[0]);

                        useuserspassphrase = optionsCore.CheckandFixBooleanValues(optionsCore.SecuritySet.Tables[0].Rows[0].ItemArray[0]);

                        i = optionsCore.SecuritySet.Tables[0].Columns.IndexOf(optionsCore.OptSecurityTags[1]);

                        passphrase = Convert.ToString(optionsCore.SecuritySet.Tables[0].Rows[0].ItemArray[1]);



                    }
                }

            }
            catch (Exception e)
            {
                 program.errorreport(e);

            }


        }
        /// <summary>
        /// Applies the hydrobasesdk settings
        /// </summary>
        /// <param name="form">the main form of booker</param>
         public void SetHydrobaseSDksettings(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    HydrobaseSDK.SDKBase.DataBasePath = form.ApplicationFolder + "\\" + BaseClass.DataFolder + "\\" + bookdb;
                    HydrobaseSDK.SDKBase.DataBasesName = bookdb;
                    HydrobaseSDK.SDKBase.UserBackupFolder = form.ApplicationFolder + "\\" + Maintenance_Backup.fakbackup;
                    HydrobaseSDK.SDKBase.UserMainPath = form.ApplicationFolder;
                    HydrobaseSDK.SDKBase.UserPassword = passphrase;
                    HydrobaseSDK.SDKBase.UserReportFolder = form.ApplicationFolder + "\\" + BaseClass.ReportFolder;
                    HydrobaseSDK.SDKBase.UserBasesPath = form.ApplicationFolder + "\\" + BaseClass.DataFolder;


                }

            }
            catch (Exception e)
            {
                 program.errorreport(e);


            }


        }
        /// <summary>
        /// Starts and inintializes Booker
        /// </summary>
        /// <param name="form">the main form of booker</param>
        public void OnLoad(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    string tmp, tmp2;
                    char[] tmchar;
                    string[] infoparam = new string[6];
                    infoparam[0] = SDKBase.UserMainPath;
                    infoparam[1] = Application.ProductName + " - " + Application.ProductVersion;
                    infoparam[2] = SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + BookerKernel.bookdb;
                    infoparam[3] = SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + BookerKernel.bookdb + "\\" + BookerKernel.booktable + BaseClass.defualt_encryptedtableextensionwithSha384;
                    infoparam[4] = BookerKernel.booktable;
                    infoparam[5] = BookerKernel.cpassPhrase;
                    MulyUser.initialiseMultyUserInterface(false, form);
                //  MultyUser.ReadConfig();
                    this.SetHydrobaseSDksettings(form);
                    optionsCore.OptGeneralTags = BookerKernel.generaltags;
                    optionsCore.OptSecurityTags = BookerKernel.securitytags;

                    optionsCore.settingDir = SDKBase.ApplicationPreferencesDir;


                    optionsCore.CreateSettingsFiles();
                    BookerKernel.HBClassADO.TableCreation(SDKBase.ApplicationPreferencesDir + "\\" + optionsCore.securityfile + BaseClass.default_upgrdbextesion, optionsCore.OptSecurityTags, " ");
                    BookerKernel.HBClassADO.TableCreation(SDKBase.ApplicationPreferencesDir + "\\" + optionsCore.generalfile + BaseClass.default_upgrdbextesion, optionsCore.OptGeneralTags, " ");
                    DataSet setGen = new DataSet();
                    DataSet setSec = new DataSet();
                    BookerKernel.HBClassADO.AttachDataBaseinDataSet(setGen, SDKBase.ApplicationPreferencesDir + "\\" + optionsCore.generalfile + BaseClass.default_upgrdbextesion);
                    BookerKernel.HBClassADO.AttachDataBaseinDataSet(setSec, SDKBase.ApplicationPreferencesDir + "\\" + optionsCore.securityfile + BaseClass.default_upgrdbextesion);



                    optionsCore.LoadSettings();
                    BookerKernel.HBClassADO.UpgradeDataBase(setGen.Tables[0], optionsCore.GeneralSet.Tables[0]);
                    BookerKernel.HBClassADO.UpgradeDataBase(setSec.Tables[0], optionsCore.SecuritySet.Tables[0]);
                    optionsCore.SecuritySet.WriteXml(SDKBase.ApplicationPreferencesDir + "\\" 
                        + optionsCore.securityfile + BaseClass.default_fileextension);
                    optionsCore.GeneralSet.WriteXml(SDKBase.ApplicationPreferencesDir +
                        "\\" + optionsCore.generalfile + BaseClass.default_fileextension);


                    statreadoptionvalues();

                    LoadPlugins(form);

                    if (appudate.properties.AutoCheck == true)
                    {
                        appudate.GetExeCutingApplicationVersion(Assembly.LoadFile(Application.ExecutablePath));
                        appudate.CheckforNewVersionsChangeLog();

                    }

                    tmp = Convert.ToString(form.Tag);

                    if (SDKBase.UserMainPath != null)
                    {
                        if (Directory.Exists(SDKBase.UserMainPath) == false)
                        {

                            hbbackup.CreateFolder(SDKBase.UserMainPath);
                            hbbackup.CreateFolder(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder);


                        }
                    }

                    if (Directory.Exists(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder) == false)
                    {


                    }






                }

            }
            catch (Exception e)
            {

                 program.errorreport(e);

            }

        }
        /// <summary>
        /// Executes the main fuction of plugins
        /// </summary>
        /// <param name="form">the main form of booke</param>
        /// <param name="tparam">params for the plugins to have as arguments</param>
        public void ExecutePlugins(BookerMain form, params string[] tparam)
        {

            try
            {
                string tmp;
                if (form != null)
                {

                   
                    if (Loaded_plugins != null)
                    {
                        //MessageBox.Show("hi");

                        foreach (GeneralPluginSDK plugin in Loaded_plugins)
                        {
                            PluginContent context = new PluginContent();
                            //MessageBox.Show(context.ToString());
                            /* if (context == null)
                            {
                                MessageBox.Show("hi1");


                            }
                            if (tparam == null)
                            {

                                MessageBox.Show("hi2"); 

                            }
                            if (this == null)
                            {

                                MessageBox.Show("hi3");

                            }
                            if (plugin == null)
                            {
                                MessageBox.Show("hi3");

                            }*/
                            plugin.MakeAction(context, form, null, tparam);
                            //MessageBox.Show(Convert.ToString(this.Tag));
                            /*if (this.Tag != null)
                            {
                                SDKBase.UserMainPath = Convert.ToString(this.Tag);

                            }*/
                            tmp = Convert.ToString(form.Tag);
                            //MessageBox.Show(tmp);



                        }
                        /*if (HBClassADO.GetSpeficiUserInfoFromCentralUserDataBase (Environment.UserName, Convert.ToString(hydrobaseADO.User.UserPassword)) != null)
                        {

                            passPhrase = HBClassADO.GetSpeficiUserInfoFromCentralUserDataBase(Environment.UserName, (Convert.ToString(hydrobaseADO.User.UserPassword)));
                            //MessageBox.Show(passPhrase);
                        }
                        else
                        {
                            DataRow[] tRow;
                            object[] values;
                            if (HydrobaseSDK.SDKBase.UsersTable == null)
                            {
                                HydrobaseSDK.SDKBase.UsersTable = new DataSet(BaseClass.recordtag);
                            }
                            HBClassADO.LoadCentralUserDatabase  ();
                            passPhrase = cpassPhrase;

                            if (HydrobaseSDK.SDKBase.UsersTable.Tables[0].Columns.Contains(Convert.ToString(hydrobaseADO.User.UserPassword)) == false)
                            {
                                HydrobaseSDK.SDKBase.UsersTable.Tables[0].Columns.Add(Convert.ToString(hydrobaseADO.User.UserPassword));
                                HBClassADO.UpdateCentralDatabase();

                            }


                            tRow = HydrobaseSDK.SDKBase.UsersTable.Tables[0].Select(Convert.ToString(hydrobaseADO.User.UserName) + "=" + "'" + Environment.UserName + "'");
                            
                            
                            values = tRow[0].ItemArray;
                            
                            values[6] = cpassPhrase;
                            //MessageBox.Show("hi");
                            //HBClassADO.CloseDataBase(usersTable);
                            usersTable = new DataSet();
                            HBClassADO.EditUsersInfo(Environment.UserName,  values);

                        }*/

                        //MessageBox.Show(Convert.ToString(Loaded_plugins.Count));

                    }
                }
            }




            catch (Exception e)
            {
                 program.errorreport(e);


            }



        }
        /// <summary>
        /// Loads the plugins
        /// </summary>
        /// <param name="form">the main form of booke</param>
        
        public void LoadPlugins(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    
                    //Retrieve a plugin collection using our custom Configuration section handler
                    Loaded_plugins = (PluginCollection)ConfigurationSettings.GetConfig("plugins");
                    //FillPluginMenu();
                    //bookLogPlug.LoadPlugins();
                    SDKBase.UserMainPath = SDKBase.UserMainPath;
                    string[] infoparam = new string[6];
                    infoparam[0] = SDKBase.UserMainPath;
                    infoparam[1] = Application.ProductName + " - " + Application.ProductVersion;
                    infoparam[2] = SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb;
                    infoparam[3] = SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384;
                    infoparam[4] = booktable;
                    infoparam[5] = cpassPhrase;
                    SDKBase.ActiveDbsPath = SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384;
                    ExecutePlugins(form, infoparam);
                }

            }
            catch (Exception e)
            {

                 program.errorreport(e);

            }

        }
        /// <summary>
        /// Executes after onload function and confiures booker
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public void Load(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    int resinfo, i;
                    program core = new program();

                    form.openFileDialog.Filter = "Hydrobase Tables  ( *" + BaseClass.default_fileextension + ")|*" + BaseClass.default_fileextension;



                    string tmp, tmp2;




                    tmp = Convert.ToString(form.Tag);
                    //MessageBox.Show(tmp);
                    SDKBase.UserMainPath = tmp;

                 //   MessageBox.Show(SDKBase.UserMainPath);
                    if (Directory.Exists(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder) == false)
                    {
                        Directory.CreateDirectory(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder);

                    }
                    SetHydrobaseSDksettings(form);
                    ShowToolBar(form);
                   
                    if (enable_white_tiger_serverclient == false)
                    {


                        //LogClass.CheckAndCreateLogFolder(SDKBase.UserMainPath + "\\" + Logger.LogsFolder);


                        HBClassADO.DataBaseCreation(bookdb, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder);
                        //  if (!useencryptedtables)
                        {
                            if ((LocaleHundlerCore.SelectedCulture.DisplayName != GreekCult1.DisplayName) && (LocaleHundlerCore.SelectedCulture.DisplayName != this.GreekCult2.DisplayName))
                            {


                                resinfo = HBClassADO.TableCreation(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, Cells, Application.ProductName + " - " + Application.ProductVersion);

                            }
                            else
                            {



                                //SDKBase.UserMainPath = "\\\\Teiresias\\Επιφάνεια εργασίας";
                                resinfo = HBClassADO.TableCreation(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, Kelia, Application.ProductName + " - " + Application.ProductVersion);
                                //dtsData = new DataSet();

                            }
                        }



                        if (useencryptedtables == true)
                        {

                            DataSet temp = new DataSet();
                            HBClassADO.AttachDataBaseinDataSet(temp, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384);
                            if ((useuserspassphrase) && (passphrase != null))
                            {
                                hbCryptrijndael.rijndael_SaveDecryptedDataTable(temp, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, passphrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384);
                                HBClassADO.SendtoDataGrid(form.dtgDataGrd, dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0);
                            }
                            else
                            {
                                hbCryptrijndael.rijndael_SaveDecryptedDataTable(temp, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, cpassPhrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384);
                                HBClassADO.SendtoDataGrid(form.dtgDataGrd, dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0);
                            }

                            //   this.Decrypt(form);
                            HBClassADO.SendtoDataGrid(form.dtgDataGrd, dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0);






                        }
                        else
                        {
                            HBClassADO.SendtoDataGrid(form.dtgDataGrd, dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0);


                        }

                        //this.tmrTimer.Start();



                        hbbackup = new Maintenance_Backup();

                        //MessageBox.Show(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder);

                        hbbackup.CreateFolder(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder);


                        hbbackup.CreateFolder(SDKBase.UserMainPath + "\\" + BaseClass.ReportFolder);
                        //HBClassADO.SendtoDataGrid(dtgDataGrd, dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, 0);
                        //this.tmrTimer.SendCurrentValueToProgrssBar(this.DefaultToolStripProgressBar, 500);

                        Bookkelia = new string[dtsData.Tables[bookdb].Columns.Count];
                        for (i = 0; i < dtsData.Tables[bookdb].Columns.Count; i++)
                        {
                            Bookkelia[i] = dtsData.Tables[bookdb].Columns[i].ColumnName;

                        }
                        this.StartWhiteTigerServer();
                    }
                   else
                    {
                      
                        if ((LocaleHundlerCore.SelectedCulture.DisplayName != GreekCult1.DisplayName) && (LocaleHundlerCore.SelectedCulture.DisplayName != this.GreekCult2.DisplayName))
                        {


                            Bookkelia= Cells;

                        }
                        else
                        {



                            Bookkelia = Kelia;
                        }
                       
                       
                       
                      
                      //  HBClassADO.SendtoDataGrid2(form.dtgDataGrd, dtsData, booktable, 0);


                    }
                    //this.ReconnectEvents();
                    SDKBase.HBLoadedPlugins = Loaded_plugins;
                    
                    core.createScriptsDirectory();
                    core.createScripts_DLLDirectory();
                    if (execute_escripts == true)
                    {
                        core.Autoexecutescripts();
                    }


                }

            }
            catch (Exception er)
            {

                  program.errorreport(er);
            }


        }
        /// <summary>
        /// Updates the Booker's table
        /// </summary>
        /// <param name="form">the main form of booker</param>
        public void Update(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    if (BookerKernel.useencryptedtables == true)
                    {
                       
                            

                                HBClassADO.SaveTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0, Application.ProductName + " - " + Application.ProductVersion, BookerKernel.Bookkelia[0], enumSortType.ASC,this.enablemirror);

                                Encrypt(form);
                           
                           
                         Decrypt(form);
                       
                    }
                    else
                    {
                        HBClassADO.SaveTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0, Application.ProductName + " - " + Application.ProductVersion, BookerKernel.Bookkelia[0], enumSortType.ASC,this.enablemirror);


                    }
                   
                }

            }
            catch (Exception er)
            {

                  program.errorreport(er);
            }


        }
        /// <summary>
        /// Opens the search form window and allows you to search your books in your table
        /// </summary>
        public void Search()
        {
            try
            {


                dtsData.WriteXml(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder + "\\" + "tbookdb" + BaseClass.default_fileextension);
                //dtsData.EndInit();
                this.frmFind = new findwnd();
                frmFind.Show();
            }
            catch (Exception er)
            {

                  program.errorreport(er);
            }

        }
        /// <summary>
        /// Encrypts the contents of the table
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public void Encrypt(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    if ((BookerKernel.useuserspassphrase == true) && (BookerKernel.passphrase != null))
                    {



                        hbCryptrijndael.rijndael_SaveEncryptedDataTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, BookerKernel.passphrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384,this.enablemirror);
                    }
                    else
                    {
                        hbCryptrijndael.rijndael_SaveEncryptedDataTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, cpassPhrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384,this.enablemirror);
                    }



                }
            }
            catch (Exception ex)
            {
                //bclass.GetHydrobaseLibraryversion (ex);
                  program.errorreport(ex);

            }
        }
        /// <summary>
        /// Decrypts the contents of the tables
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public void Decrypt(BookerMain form)
        {
            try
            {
                if (form != null)
                {



                    //HBClassADO.CloseDataBase(this.dtsData);
                    //this.tmrTimer.Stop();
                    //this.tmrProgressBarWatcher.Stop();

                    //hbCryptrijndael.rijndael_SaveDecryptedFile(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\"+bookdb +"\\"+ ebookdb, cpassPhrase);
                    DataSet temp = new DataSet();
                    HBClassADO.AttachDataBaseinDataSet(temp, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384);
                   // MessageBox.Show(BookerKernel.passphrase);
                    if ((BookerKernel.useuserspassphrase == true) && (BookerKernel.passphrase != null))
                    {

                        hbCryptrijndael.rijndael_SaveDecryptedDataTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, BookerKernel.passphrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384,this.enablemirror);





                    }

                    else
                    {
                        hbCryptrijndael.rijndael_SaveDecryptedDataTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension , cpassPhrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384,this.enablemirror);

                    }

                    /* if (File.Exists(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384)==true)
                     {
                         File.Move (SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384);
                    


                     }*/
                    //dtsData = new DataSet();




                    HBClassADO.SendtoDataGrid(form.dtgDataGrd, dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0);



                }
            }
            catch (Exception ex)
            {

                  program.errorreport(ex);
            }


        }
        /// <summary>
        /// Backups your table
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public void Backup(BookerMain form)
        {
            try
            {
               // MessageBox.Show("hi2");
            if (form != null)
                {
                   // MessageBox.Show("hi3");
                    hbbackup = new Maintenance_Backup();
                   // MultyUser.ReadConfig();
                    hbbackup.CreateBackupofDB(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + BookerKernel.bookdb, "", SDKBase.UserMainPath, BookerKernel.bookdb,true );

                }
            }
          catch (Exception ex)
            {
             //MessageBox.Show(ex.ToString());
               program.errorreport(ex);
            }
        }
        /// <summary>
        /// Shows a message box with available 
        /// backups and restores it
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public void Restore(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    hbbackup = new Maintenance_Backup();
                    string baxckupfoldr;
                    HBClassADO.CloseDataBase(dtsData);
                    DataSet temp = new DataSet();


                    Hydrobase.SelectBackupDialog.DtaBasefolder = SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\";
                    baxckupfoldr = hbbackup.RecoverBackupStpA(SDKBase.UserMainPath + "\\" + Maintenance_Backup.fakbackup, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\books\\", bookdb);
                    dtsData = new DataSet();
                    HBClassADO.AttachDataBaseinDataSet(temp, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384);


                    if (SelectBackupDialog.statResult == DialogResult.OK)
                    {
                        if (BookerKernel.useencryptedtables == true)
                        {
                            Decrypt(form);

                            HBClassADO.SendtoDataGrid(form.dtgDataGrd, dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0);


                        }
                        else
                        {

                            HBClassADO.SendtoDataGrid(form.dtgDataGrd, dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 0);

                        }
                    }

                    /*SelecetBackup backpdlg = new SelecetBackup(bookdb,SDKBase.UserMainPath + "\\" + Maintenance_Backup.fakbackup, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\books\\", form.dtgDataGrd, this.dtsData);
                    backpdlg.Show();*/

                }

            }
            catch (Exception ex)
            {
                  program.errorreport(ex);
            }

        }
        /// <summary>
        /// Upgrades db in latest version
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public void UpgradeDb(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    string infofile1, infofile2;
                    string[] WraMera1, WraMera2;
                    DataSet sData = new DataSet();
                    infofile1 = HBClassADO.FindApplicationInfo(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension, 2);


                    if ((LocaleHundlerCore.SelectedCulture.DisplayName != GreekCult1.DisplayName) || (LocaleHundlerCore.SelectedCulture.DisplayName != GreekCult2.DisplayName))
                    {



                        HBClassADO.TableCreation(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder + "\\books2" + BaseClass.default_upgrdbextesion, Cells, Application.ProductName + " - " + Application.ProductVersion);



                    }
                    else
                    {
                        HBClassADO.TableCreation(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder + "\\books2" + BaseClass.default_upgrdbextesion, Kelia, Application.ProductName + " - " + Application.ProductVersion);

                    }

                    infofile2 = HBClassADO.FindApplicationInfo(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder + "\\books2" + BaseClass.default_upgrdbextesion, 1);
                    if ((infofile1 != infofile2) || (sData != null) || (sData.Tables.Count > 0))
                    {
                        WraMera1 = HBClassADO.GetTimeAndDateTableLastUpdated(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension);
                        WraMera2 = HBClassADO.GetTimeAndDateTableLastUpdated(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder + "\\books2" + BaseClass.default_fileextension);
                        if (WraMera1 != WraMera2)
                        {

                            sData.ReadXml(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder + "\\books2" + BaseClass.default_upgrdbextesion);

                            HBClassADO.UpgradeDataBase(sData.Tables[0], dtsData.Tables[0]);
                            HBClassADO.CloseDataBase(sData);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.ToString());
                  program.errorreport(ex);
            }
        }
        /// <summary>
        /// executes when booker exits
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public void Exit(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    if (BookerKernel.useencryptedtables == true)
                    {
                        Encrypt(form);
                        if (File.Exists(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension) == true)
                        {
                            File.Delete(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension);
                        }
                        string[] list = Directory.GetFiles(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb);
                        foreach (string arx in list)
                        {

                            if (Path.GetExtension(arx) == BaseClass.default_fileextension)
                            {

                                File.Delete(arx);

                            }

                        }


                    }
                    Application.Exit();
                }
            }
            catch (Exception er)
            {
                  program.errorreport(er);

            }
        }
        /// <summary>
        /// Shows the toolbar in booker main window
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public static  void ShowToolBar(BookerMain form)
        {

            try
            {
                if (form != null)
                {
                    
                        if (BookerKernel.enable_toolbar == true)
                        {
                            form.tlspToolBar.Visible = true;

                        }
                        else
                        {
                            form.tlspToolBar.Visible = !true;

                        }
                    
                    

                }
            }
            catch (Exception e)
            {
                 program.errorreport(e);

            }

        }
        /// <summary>
        /// Cleans temp folder
        /// </summary>
        public void CleanFolder()
        {
            try
            {
                string[] FileList, FileList2;
                ///string SDKBase.UserMainPath2;

                int i;
                //SDKBase.UserMainPath2 = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", " ");
                FileList = Directory.GetFiles(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder);

                /*if (File.Exists(SDKBase.UserMainPath + "\\" + bookdb + "\\" + BaseClass.tmpFolder +"\\books2" + BaseClass.default_upgrdbextesion) == true)
                {
                    File.Delete(SDKBase.UserMainPath + "\\" + bookdb + "\\" + BaseClass.tmpFolder +"\\books2" + BaseClass.default_upgrdbextesion);

                }*/
                if (FileList.Length > 0)
                {
                    for (i = 0; i < FileList.Length; i++)
                    {
                        if (File.Exists(FileList[i]) == true)
                        {

                            File.Delete(FileList[i]);
                        }


                    }


                }
                pluginHundel.ClearPluginsCollection(Loaded_plugins);



                if (Directory.Exists(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder) == true)
                {
                    Directory.Delete(SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder);
                    //Directory.Delete(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", " ") + "\\" + BaseClass.tmpFolder,true);
                }
               


            }
            catch (Exception er)
            {
                  program.errorreport(er);

            }

        }
     /// <summary>
     /// Occures when main windows is closed
     /// </summary>
        /// <param name="form">the main form of booke</param>
        public void Formclose(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    if (BookerKernel.useencryptedtables == true)
                    {
                        if (BookerKernel.useuserspassphrase == true)
                        {
                            if (BookerKernel.passphrase != null)
                            {
                                hbCryptrijndael.rijndael_SaveEncryptedDataTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, BookerKernel.passphrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384,this.enablemirror);

                            }
                            else
                            {
                                hbCryptrijndael.rijndael_SaveEncryptedDataTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, BookerKernel.cpassPhrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384,this.enablemirror);

                            }

                        }
                        else
                        {

                            hbCryptrijndael.rijndael_SaveEncryptedDataTable(dtsData, SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.defualt_encryptedtableextensionwithSha384, BookerKernel.cpassPhrase, 0, form.dtgDataGrd, Cryptography.HashingAlogrithm.SHA384,this.enablemirror);

                        }
                        if (File.Exists(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension) == true)
                        {
                            File.Delete(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb + "\\" + booktable + BaseClass.default_fileextension);
                        }
                        string[] list = Directory.GetFiles(SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\" + bookdb);
                        foreach (string arx in list)
                        {

                            if (Path.GetExtension(arx) == BaseClass.default_fileextension)
                            {

                                File.Delete(arx);

                            }

                        }


                    }
                    Application.Exit();
                }
            }
            catch (Exception er)
            {
                  program.errorreport(er);

            }
        }
        /// <summary>
        /// Imports the given table to booker's table
        /// </summary>
        /// <param name="form">the main form of booke</param>
        public void ImportTable(BookerMain form)
        {
            try
            {
                if (form != null)
                {
                    DataSet sData = new DataSet();


                    /// HBClassADO.UpgradeDataBase(sData.Tables[0], dtsData.Tables[0]);

                    if ((form.openFileDialog.ShowDialog() == DialogResult.OK) && (form.openFileDialog.FileName != null))
                    {


                        HBClassADO.AttachDataBaseinDataSet(sData, form.openFileDialog.FileName);
                        HBClassADO.UpgradeDataBase(sData.Tables[0], dtsData.Tables[0]);
                        // ShowCorrectTableWarning();


                    }
                }


            }
            catch (Exception ex)
            {

                  program.errorreport(ex);


            }

        }
        public void StartWhiteTigerServer()
        {
            try
            {
                if (BookerKernel.enable_white_tiger_server)
                {
                    BookerKernel.jsonhost = new ServiceHost(typeof(WhiteTigerServiceJson));
                    UserManager userman = new UserManager();
                    White_Tiger.Config conf = new Config();
                    conf.ReadConfig();
                    jsonhost.Credentials.WindowsAuthentication.AllowAnonymousLogons = true;
                    jsonhost.Credentials.WindowsAuthentication.IncludeWindowsGroups = true;
                    jsonhost.Open();
                }

            }
            catch (Exception ex)
            {

                  program.errorreport(ex);


            }
        }
    }
}
    

