using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using Hydrobase;
using HydrobaseSDK;
 
//using TimeLimitedWindow;
using WareForms;
using HydroMultyUser;
using RSSApplicationUpdater;
using Scrabler;
using LocaleHundler;

namespace Booker
{
    partial class AboutBox : WareForm
    {
        
        SDKBase hbsdkBase = new SDKBase();
        BookerMain bokmain = new BookerMain();
       
        timeLimitedMessageBox tlMessageBox = new timeLimitedMessageBox(0, null, null, null);
        WareForm tWrForm = new WareForm();
        HydroMultyUserCore multyuser = new HydroMultyUserCore();

        LocaleHundlerCore locale = new LocaleHundlerCore();
        public AboutBox()
        {
            InitializeComponent();

            //  Initialize the AboutBox to display the product information from the assembly information.
            //  Change assembly information settings for your application through either:
            //  - Project->Properties->Application->Assembly Information
            //  - AssemblyInfo.cs
            BaseClass hbclass= new BaseClass();
           
            //PluginHundler PlugHunter = new PluginHundler();
            //string[] HydroPluginsInfo;
            CultureInfo GreekCult1= new CultureInfo("el");
            CultureInfo GreekCult2 = new CultureInfo("el-GR");

            //if (locale.ReadconfigXml().ExternalLanguageFileEnabled == true)
            {

              //  locale.Translate(this.Name, this);


            }
            //else
           // {

              //  locale.Translate();

         //   }
            PluginHundler.PluginHundler plughundler = new PluginHundler.PluginHundler(); 

            
            if ((LocaleHundlerCore.SelectedCulture.DisplayName!= GreekCult1.DisplayName)&&(LocaleHundlerCore.SelectedCulture.DisplayName!= GreekCult2.DisplayName ))
            {
                this.Text = String.Format("About {0}", AssemblyTitle);
                this.labelProductName.Text = AssemblyProduct;
                this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
                this.labelCopyright.Text = AssemblyCopyright;
                this.labelCompanyName.Text = AssemblyCompany;
                //MessageBox.Show(LocaleHundlerCore.SelectedCulture.DisplayName);
                //MessageBox.Show(GreekCult.DisplayName);
                this.textBoxDescription.Text = AssemblyDescription + "Loaded Libraries: " + Environment.NewLine + "Υδοβάση: " + BaseClass.GetHydrobaseLibraryversion() + Environment.NewLine + "Υδοβάση SDK : " + hbsdkBase.GetHydrobaseSDKversion() + Environment.NewLine +  " PluginHundler version: " + plughundler.GetPluginHundlerVersion() + Environment.NewLine + "Time Limited MessageBox Version : " + tlMessageBox.GetTimilimitedMessaboxVersion() + Environment.NewLine + "WareForms Version : " + this.tWrForm.GetWareFormsVersion() + Environment.NewLine + "HydroMultyUser Version : " + multyuser.GetHydroMultyUserVersion() + Environment.NewLine + "RSS Application Updater Version: " + ApplicationUpdater.GetVersion() + Environment.NewLine + "Scrabler Version: " + ScrablerCore.GetVersion() + Environment.NewLine + "LocaleHundler Version : "+ LocaleHundlerCore.GetVersion() + Environment.NewLine;
                this.textBoxDescription.Text = this.textBoxDescription.Text + Environment.NewLine + "Plugins that had been Loaded: " + Environment.NewLine;
             }
            else
             {
                 this.Text = String.Format("Πληροφορίες για  {0}", AssemblyTitle);
                 this.labelProductName.Text = AssemblyProduct;
                 this.labelVersion.Text = String.Format("Έκδοση {0}", AssemblyVersion);
                 this.labelCopyright.Text = AssemblyCopyright;
                 this.labelCompanyName.Text = AssemblyCompany;
                 //MessageBox.Show(LocaleHundlerCore.SelectedCulture.DisplayName);
                 //MessageBox.Show(GreekCult.DisplayName);

                 this.textBoxDescription.Text = AssemblyDescription + "Βιβλιοθήκες οι Οποίες φορτώθηκαν " + Environment.NewLine + "Υδοβάση: " + BaseClass.GetHydrobaseLibraryversion() + Environment.NewLine + "Υδοβάση SDK : " + hbsdkBase.GetHydrobaseSDKversion() + Environment.NewLine +  " Έκδοση PluginHundler: " + plughundler.GetPluginHundlerVersion() + Environment.NewLine + "Έκδοση Time Limited MessageBox : " + tlMessageBox.GetTimilimitedMessaboxVersion() + Environment.NewLine + "Έκδοση WareForms :" + tWrForm.GetWareFormsVersion() + Environment.NewLine + "Έκδοση HydroMultyUser  : " + multyuser.GetHydroMultyUserVersion() + Environment.NewLine + "Έκδοση RSS Application Updater : " + ApplicationUpdater.GetVersion() + Environment.NewLine + "Έκδοση Scrabler : " + ScrablerCore.GetVersion() + Environment.NewLine + "Έκδοση LocaleHundler :" + LocaleHundlerCore.GetVersion() + Environment.NewLine;
                 this.textBoxDescription.Text = this.textBoxDescription.Text + Environment.NewLine + "Πρόσθετα που φορτώθηκαν: " + Environment.NewLine;

            
            
            }
            this.labelProductName.Text  += " [" + LocaleHundlerCore.SelectedCulture.DisplayName  + " ]";

                
                this.GetPluginsInfo();
        
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                // Get all Title attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // If there is at least one Title attribute
                if (attributes.Length > 0)
                {
                    // Select the first one
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // If it is not an empty string, return it
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // Get all Description attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // If there aren't any Description attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Description attribute, return its value
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // Get all Product attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // If there aren't any Product attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Product attribute, return its value
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // Get all Copyright attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // If there aren't any Copyright attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Copyright attribute, return its value
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // Get all Company attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // If there aren't any Company attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Company attribute, return its value
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
        void GetPluginsInfo()
        {
            try
            {
                int i, plh8osplug;
                string[] HydroPluginsInfo, bookerPlugsinf;
                if (SDKBase.HBLoadedPlugins != null)
                {
                    PluginHundler.PluginHundler pluginHundler = new PluginHundler.PluginHundler();
                    //HydroPluginsInfo = pluginHundler.GetHydrobasePluginsInfo(BookerKernel.Loaded_plugins);
                    HydroPluginsInfo = pluginHundler.GetHydrobasePluginsInfo(SDKBase.HBLoadedPlugins) ;
                  //  bookerPlugsinf = PluginLoader.GetHydrobasePluginsInfo();
                    plh8osplug = BookerKernel.Loaded_plugins.Count;
                    for (i = 0; i < HydroPluginsInfo.Length; i++)
                    {
                        this.textBoxDescription.Text = this.textBoxDescription.Text + Environment.NewLine + HydroPluginsInfo[i];


                    }
                    
                }


            }
            catch (Exception e)
            {
                program.errorreport(e);
            }


        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {

                this.Close();
            }
            catch (Exception ex)
            {
                 program.errorreport(ex);

            }
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {

           
        }
    }
}
