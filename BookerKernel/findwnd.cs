using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hydrobase;
 
using LocaleHundler;
using WareForms;

namespace Booker
{
    public partial class findwnd : WareForm
    {
        DataSet DtsResults, DtsData;
        //XMLhydrobase HBClass;
        hydrobaseADO HBClassADO;
        //TheDarkOwlLogger.TheDarkOwlLogger Bugger;
     //   string SDKBase.UserMainPath;
        LocaleHundlerCore locahndler = new LocaleHundlerCore();
        public static bool timirdbSearchForeMatching, timirdbSearchEndsWith, timirdbSearchStartsWith;

        public findwnd()
        {
            InitializeComponent();
            if (locahndler.ReadconfigXml().ExternalLanguageFileEnabled == true)
            {
                locahndler.Translate(this.Name, this);

            }// this.filename = filenam;
            else
            {

                locahndler.Translate();
            }
        }

        private void btnSearch_click(object sender, EventArgs er)
        {
            try
            {
                
                //MessageBox.Show(txtSearched.Text);
                //MessageBox.Show(this.lstFields.Text);
               if ((this.txtSearched.Text != null)||(this.lstFields.Text!=null))
               {
                   frmResults frmRes = new frmResults();
                    frmRes.KeimenoAnaz = this.txtSearched.Text;
                    frmRes.PedAnaz = this.lstFields.Text;

                    ////MessageBox.Show(frmRes.PedAnaz);
                    
                    timirdbSearchEndsWith = rdbSearchEndsWith.Checked;
                    timirdbSearchStartsWith = rdbSearchStartsWith.Checked;
                    timirdbSearchForeMatching = rdbSearchForeMatching.Checked;
                    frmRes.Casesensitive = cbxCaseSensitive.Checked;
                    frmRes.lowercase = cbxCaseSensitive.Checked;
                   frmRes.Show();
                    this.Close();

                }


            }
            catch (Exception e)
            {
                program.errorreport(e);;

            }


        }
        private void findwnd_Load(object sender, EventArgs e)
        {
            int i;
            this.Text = "Ψάξε το βιβλίο που θές.";
            BookerMain bokmain = new BookerMain();
            
                

                    this.lstFields.Items.AddRange(BookerKernel.Bookkelia);

          
        }
        private void lstFields_Click(object sender, EventArgs er)
        {
            try
            {
                this.lblMsg.Text = "Αναζήτηση στο πεδίο " + lstFields.Text + " για: ";


            }
            catch (Exception e)
            {
                program.errorreport(e);;

            }



        }
        private void lstFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFields_Click(sender, e);
        }
    }
}