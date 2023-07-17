using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Hydrobase;
using HydrobaseSDK;
using System.Globalization;
 
using LocaleHundler;


namespace Booker
{      
        
    public partial  class frmResults : Form
    { 
        DataSet DtsResults,DtsData;
        //XMLhydrobase HBClass;
        hydrobaseADO HBClassADO;
       // public  string   SDKBase.UserMainPath;
        internal bool lowercase = false;
        public string KeimenoAnaz,PedAnaz;
        CultureInfo GrCult1 = new CultureInfo("el-GR");
        CultureInfo GrCult2 = new CultureInfo("el");
     
        public bool Casesensitive;

        MultyUser  multyuser = new MultyUser ();
        const int searchEndsWith = 1;
        const int searchStartsWith = 2;
        const int searchMatchesWith = 3;

        public frmResults()
        {
            //HBClass = new XMLhydrobase();
            HBClassADO = new hydrobaseADO();
            InitializeComponent();
        }
        public frmResults(DataColumnCollection columncol)
        {

            if (columncol != null)
            {

                //HBClass = new XMLhydrobase();
                HBClassADO = new hydrobaseADO();
                InitializeComponent();
            }
        }
        private int findWhoRadioButtonisChecked()
        {
            try
            {
                int ap=0;
                if (Booker.findwnd.timirdbSearchEndsWith == true)
                {
                    ap = searchEndsWith;

                }
                else if (Booker.findwnd.timirdbSearchStartsWith == true)
                {
                    ap = searchStartsWith;

                }
                else if (Booker.findwnd.timirdbSearchForeMatching  == true)
                {
                    ap = searchMatchesWith;

                }
                return ap;


            }
            catch (Exception e)
            { 
                  program.errorreport(e);
                return -1;
            }


        }
        private void frmResults_Load(object sender, EventArgs e)
        {
            try
            {
               
                
                if ((SDKBase.UserMainPath == "") || (SDKBase.UserMainPath==null))
                {
                    SDKBase.UserMainPath = MultyUser.GetUsersMainFolder(Environment.UserName);

                }

                if ((LocaleHundlerCore.SelectedCulture.DisplayName == GrCult1.DisplayName) || (LocaleHundlerCore.SelectedCulture.DisplayName == GrCult2.DisplayName))
                {
                    this.Text = "Αποτελέσματα";

                }
                else
                {
                    this.Text = "Results";


                }

                //this.SDKBase.UserMainPath = GeneralPluginSDK.SDKBase.UserMainPath;
                saveFileDialog.Filter = "Hydrobase Tables  ( *" + BaseClass.default_fileextension + ")|*" + BaseClass.default_fileextension;






                int j,i;
                BookerMain tBookm = new BookerMain();

                //SDKBase.UserMainPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", " ");
                //MessageBox.Show(this.SDKBase.UserMainPath);
                //DataRow dtrRows;
                DtsResults = new DataSet();
                DtsData = new DataSet();
               //DtsData.ReadXml(SDKBase.UserMainPath+"\\books\\" +BookerKernel.bookdb);
                //MessageBox.Show(Convert.ToString(this.DtsData.Tables.Count ));
              // HBClassADO.AttachDataBaseinDataSet(DtsData, this.SDKBase.UserMainPath + "\\" + BaseClass.DataFolder + "\\books\\" + BookerKernel.bookdb + BaseClass.defualt_encryptedtableextensionwithSha384);

                HBClassADO.AttachDataBaseinDataSet(DtsData, SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder + "\\" + BookerKernel.tbookdb + BaseClass.default_fileextension,this.Casesensitive);

                //DtsData.ReadXml(this.SDKBase.UserMainPath + "\\" + BaseClass.tmpFolder + "\\" + BookerKernel.tbookdb + BaseClass.defualt_encryptedtableextensionwithSha384);

                ////MessageBox.Show(DtsData.Tables[0].TableName );
                ////MessageBox.Show(DtsData.Tables[0].Columns[0].ColumnName);
                //KeimenoAnaz = null;
                j = BookerKernel.bookdb.IndexOf(".");


                i = this.findWhoRadioButtonisChecked();
                switch(i)
                {
                    
                    
                    case searchEndsWith:
                        {

                            
                            HBClassADO.SeatchEndsWith(DtsData, this.PedAnaz, this.KeimenoAnaz, "books", dgrResults, DtsResults, 0,lowercase);

                            break;

                        }
                    case searchStartsWith:
                        {
                            HBClassADO.SeatchStartsWith(DtsData, this.PedAnaz, this.KeimenoAnaz, "books", dgrResults, DtsResults, 0, lowercase);
                            break;

                        }
                    case searchMatchesWith:
                        {
                            HBClassADO.Search(DtsData, this.PedAnaz, this.KeimenoAnaz, "books", dgrResults, DtsResults, 0, lowercase);
                            break;
                        }



            }


                //DtsResults.Tables.Add(dtbTable);
                //DtsResults.ReadXml(hydrobase.arxapotel);
                //this.dgrResults.DataSource=this.dgrResults;
                // this.dgrResults.DataMember = hydrobase.eggrafi;


                //HBClassADO.SendtoDataGrid(this.dgrResults, this.DtsResults , hydrobase.eggrafi + "_" + "_" + tBookm.Kelia[0] + " " + hydrobase.arxapotel);

            }
            catch (Exception ex)
            {
                program.errorreport(ex);

            }


        }

        private void btnSaveInHydrobase_Click(object sender, EventArgs e)
        {
            try
            {
                if ((saveFileDialog.ShowDialog() == DialogResult.OK) && (saveFileDialog.FileNames != null))
                {
                    HBClassADO.SaveTable(DtsResults, saveFileDialog.FileName, 0, Application.ProductName + " - " + Application.ProductVersion);


                }


            }
            catch (Exception ex)
            {
                program.errorreport(ex);

            }
        }
    }
}