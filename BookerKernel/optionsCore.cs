using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Windows.Forms;
using Hydrobase;
using HydrobaseSDK;
 


namespace Booker
{
    class optionsCore
    {
       
        public static string settingDir = SDKBase.ApplicationPreferencesDir;
        public const string generalfile = "General";
        public const string securityfile = "Security";
        public static DataSet SecuritySet = new DataSet();
        public static DataSet GeneralSet = new DataSet();
        public static hydrobaseADO hbado = new hydrobaseADO();
        public static string[] OptGeneralTags, OptSecurityTags;




        public static void Bugtracking(Exception e)
        {
            program.errorreport(e);

        }
        public static void CreateSettingsFiles()
        {

            try
            {
                // DataSet tmp1= new DataSet();
                //DataSet tmp2= new DataSet();
                //object[] values1, values2;
                optionsGUI generalGUI, securityGUI;
                if (settingDir != null)
                {


                    if ((File.Exists(settingDir + "\\" + generalfile + BaseClass.default_fileextension) == false) &&
                    (File.Exists(settingDir + "\\" + generalfile + BaseClass.default_fileextension) == false)
                    )
                    {

                        hbado.TableCreation(settingDir + "\\" + generalfile + BaseClass.default_fileextension, OptGeneralTags, Application.ProductName + " - " + Application.ProductVersion);

                        hbado.TableCreation(settingDir + "\\" + securityfile + BaseClass.default_fileextension, OptSecurityTags, Application.ProductName + " - " + Application.ProductVersion);

                        //hbado.AttachDataBaseinDataSet(tmp1, settingDir + "\\" + generalfile + BaseClass.default_fileextension);
                        //hbado.AttachDataBaseinDataSet(tmp2, settingDir + "\\" + securityfile + BaseClass.default_fileextension);
                        /* generalGUI = new GUI(settingDir + "\\" + generalfile + BaseClass.default_fileextension);
                         securityGUI = new GUI(settingDir + "\\" + securityfile + BaseClass.default_fileextension);
                         generalGUI.Text = generalfile + "settings";
                         securityGUI.Text = securityfile + "settings";
                         generalGUI.Show();
                         securityGUI.Show();*/
                        DataSet set = new DataSet();
                        hbado.AttachDataBaseinDataSet(set, settingDir + "\\" + generalfile + BaseClass.default_fileextension);
                        object[] vals;
                        if ((set.Tables != null) && (set.Tables.Count > 0))
                        {
                            try
                            {
                                vals = new object[set.Tables[0].Columns.Count];
                                vals[0] = "True";
                                vals[1] = "True";
                                vals[2] = "True";
                                vals[3] = "True";
                                vals[4] = "False";

                                set.Tables[0].Rows[0].ItemArray = vals;
                            }
                            catch (IndexOutOfRangeException ex)
                            {

                                File.Delete(settingDir + "\\" + generalfile + BaseClass.default_fileextension);

                                optionsCore.CreateSettingsFiles();
                            }
           


                        }
                        hbado.SaveTable(set, settingDir + "\\" + generalfile + BaseClass.default_fileextension, 0, "   ");
                        set = new DataSet();
                        hbado.AttachDataBaseinDataSet(set, settingDir + "\\" + securityfile + BaseClass.default_fileextension);
                        if ((set.Tables != null) && (set.Tables.Count > 0))
                        {
                            try
                            {
                                vals = new object[set.Tables[0].Columns.Count];
                                vals[0] = "True";
                                vals[1] = "True";
                                vals[2] = "True";
                                vals[3] = "True";
                                set.Tables[0].Rows[0].ItemArray = vals;
                            }
                            catch (IndexOutOfRangeException ex)
                            {

                                File.Delete(settingDir + "\\" + securityfile  + BaseClass.default_fileextension);

                                optionsCore.CreateSettingsFiles();
                            }
           

                        }




                    }

                }

            }
           
            catch (Exception e)
            {
                Bugtracking(e);
            }


        }
        public static void LoadSettings()
        {
            try
            {
                if (settingDir != null)
                {
                    if ((File.Exists(settingDir + "\\" + generalfile + BaseClass.default_fileextension) == false) || (File.Exists(settingDir + "\\" + securityfile + BaseClass.default_fileextension) == false))
                    {
                        hbado.TableCreation(settingDir + "\\" + generalfile + BaseClass.default_fileextension, optionsCore.OptGeneralTags, Application.ProductName + "- " + Application.ProductVersion);
                        hbado.TableCreation(settingDir + "\\" + securityfile + BaseClass.default_fileextension, optionsCore.OptSecurityTags, Application.ProductName + "- " + Application.ProductVersion);

                    }
                    SecuritySet = new DataSet();
                    GeneralSet = new DataSet();

                    hbado.AttachDataBaseinDataSet(GeneralSet, settingDir + "\\" + generalfile + BaseClass.default_fileextension);
                    hbado.AttachDataBaseinDataSet(SecuritySet, settingDir + "\\" + securityfile + BaseClass.default_fileextension);
                    // this.showValues();
                }
            }
            catch (Exception e)
            {
                Bugtracking(e);

            }

        }

        public static Boolean CheckandFixBooleanValues(object value)
        {

            try
            {
                Boolean ap = false;
                if (value != null)
                {
                    ap = Convert.ToBoolean(value);

                }
                return ap;
            }
            catch (Exception e)
            {
                Bugtracking(e);
                return false;
            }


        }
        public static string BoolToString(bool val)
        {
            try
            {
                string  ap = null;
                if (val != null)
                {
                    ap = Convert.ToString(val);

                }
                return ap;
            }
            catch (Exception e)
            {
                Bugtracking(e);
                return null;
            }


        }
        
    }
}
