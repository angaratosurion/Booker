using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Hydrobase;
using HydrobaseSDK;


namespace Hydrobase_Advanced_Config
{
    public partial class frmGui : Form
    {
        hydrobaseADO ado = new hydrobaseADO();
        DataSet set = new DataSet();
        string LoadedConfigFile;
        bool loaded_fromothepp = false;
        public frmGui()
        {
            InitializeComponent();
        }
        public frmGui(bool loaded_fromothepp)
        {
            InitializeComponent();
            if (loaded_fromothepp == true)
            {
                this.btnLoad.Visible = false;


                LoadedConfigFile =Path.GetDirectoryName( Application.ExecutablePath).Replace("file:\\"," ") + "\\" + BaseClass.ConfigFile;
                if (File.Exists(LoadedConfigFile) == true)
                {
                    ado.AttachDataBaseinDataSet(set, LoadedConfigFile);
                    if ((set.Tables.Count > 0) || (set.Tables[0] != null))
                    {

                        DataRow row = set.Tables[0].Rows[0];
                        object[] vals = row.ItemArray;
                        txtDriveLetter.Text = Convert.ToString(vals[0]);
                        txtRootFolder.Text = Convert.ToString(vals[1]);
                        cbxMirrorBckFolder.Checked = Convert.ToBoolean(vals[2]);
                        txtMirrorFolder.Text = Convert.ToString(vals[3]);
                        cbxEnableLog.Checked = Convert.ToBoolean(vals[4]);
                        cbxMirroring.Checked = Convert.ToBoolean(vals[5]);
                        txtMirrorFold.Text = Convert.ToString(vals[6]);


                    }
                }

            }
            
            
        }

        private void frmGui_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Application.ProductName;


            }
            catch (Exception ex)
            {
                Program.errorhandling(ex);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                Program.errorhandling(ex);

            }
        }

        private void btnBrowserFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if ((folderBrowserDialog1.ShowDialog() != DialogResult.OK)||(folderBrowserDialog1.SelectedPath !=null))
                {
                  //  txtRootFolder.Text = Path.GetDirectoryName(folderBrowserDialog1.SelectedPath);
                    
                    
                    //folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf(":") + 1).Replace("file:\\", " ");

                    txtRootFolder.Text = folderBrowserDialog1.SelectedPath.Substring(folderBrowserDialog1.SelectedPath.LastIndexOf("\\") + 1).Replace("file:\\", " ");


                }
            }
            catch (Exception ex)
            {
                Program.errorhandling(ex);

            }
        }

        private void btnBrowserDrive_Click(object sender, EventArgs e)
        {
            try
            {
                if ((folderBrowserDialog1.ShowDialog() != DialogResult.OK) || (folderBrowserDialog1.SelectedPath != null))
                {
                    txtDriveLetter.Text = folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf(":") + 1).Replace("file:\\", " ");



                }
            }
            catch (Exception ex)
            {
                Program.errorhandling(ex);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if ((folderBrowserDialog1.ShowDialog() != DialogResult.OK) || (folderBrowserDialog1.SelectedPath != null))
                {
                    LoadedConfigFile=folderBrowserDialog1.SelectedPath + "\\" + BaseClass.ConfigFile;
                    if (File.Exists(LoadedConfigFile) == true)
                    {
                        ado.AttachDataBaseinDataSet(set, LoadedConfigFile);
                        if ((set.Tables.Count > 0) || (set.Tables[0] != null))
                        {

                            DataRow row = set.Tables[0].Rows[0];
                            object[] vals = row.ItemArray;
                            txtDriveLetter.Text = Convert.ToString(vals[0]);
                            txtRootFolder.Text = Convert.ToString(vals[1]);
                            cbxMirrorBckFolder.Checked = Convert.ToBoolean(vals[2]);
                            txtMirrorFolder.Text = Convert.ToString(vals[3]);
                            cbxEnableLog.Checked = Convert.ToBoolean(vals[4]);
                            cbxMirroring.Checked = Convert.ToBoolean(vals[5]);
                            txtMirrorFold.Text = Convert.ToString(vals[6]);

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                Program.errorhandling(ex);

            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                
                    //LoadedConfigFile = folderBrowserDialog1.SelectedPath + "\\" + BaseClass.ConfigFile;
                    if ((LoadedConfigFile !=null)||File.Exists(LoadedConfigFile) == true)
                    {
                       
                        if ((set.Tables.Count > 0) || (set.Tables[0] != null))
                        {

                            DataRow row = set.Tables[0].Rows[0];
                            object[] vals = new object [row.ItemArray.Length];
                            vals[0] = txtDriveLetter.Text;
                            vals[1] = txtRootFolder.Text;
                            vals[2] = cbxMirrorBckFolder.Checked.ToString();
                            vals[3] = txtMirrorFolder.Text;
                            vals[4] = cbxEnableLog.Checked.ToString();
                            vals[5] = cbxMirroring.Checked.ToString();
                            vals[6] = txtMirrorFold.Text;
                            row.ItemArray = vals;
                            ado.SaveTable(set, LoadedConfigFile, 0, Application.ProductName + " - " + Application.ProductVersion);


                        }
                    }
                    Application.Exit();


                
            }
            catch (Exception ex)
            {
                Program.errorhandling(ex);

            }
        }

        private void btnBrowserMirrorFolder_Click(object sender, EventArgs e)
        {

            try
            {
                if ((folderBrowserDialog1.ShowDialog() != DialogResult.OK) || (folderBrowserDialog1.SelectedPath != null))
                {
                    //  txtRootFolder.Text = Path.GetDirectoryName(folderBrowserDialog1.SelectedPath);


                    //folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf(":") + 1).Replace("file:\\", " ");

                  txtMirrorFolder.Text= folderBrowserDialog1.SelectedPath.Substring(folderBrowserDialog1.SelectedPath.LastIndexOf("\\") + 1).Replace("file:\\", " ");


                }
            }
            catch (Exception ex)
            {
                Program.errorhandling(ex);

            }
        }

        private void btnMirrorFoldBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if ((folderBrowserDialog1.ShowDialog() != DialogResult.OK) || (folderBrowserDialog1.SelectedPath != null))
                {
                    //  txtRootFolder.Text = Path.GetDirectoryName(folderBrowserDialog1.SelectedPath);


                    //folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf(":") + 1).Replace("file:\\", " ");

                    txtMirrorFold.Text = folderBrowserDialog1.SelectedPath.Substring(folderBrowserDialog1.SelectedPath.LastIndexOf("\\") + 1).Replace("file:\\", " ");


                }
            }
            catch (Exception ex)
            {
                Program.errorhandling(ex);

            }
        }
    }
}
