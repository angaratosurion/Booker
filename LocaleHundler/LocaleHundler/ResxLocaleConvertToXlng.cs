using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Xml;
using System.Configuration;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Resources;

using Hydrobase;

namespace LocaleHundler
{
   public  class ResxLocaleConvertToXlng
    {
       DataSet set = new DataSet();
     
       hydrobaseADO ado = new hydrobaseADO();
       public void ConvertToXlng(string source, string target)
       {
           try
           {
               DataSet set2 = new DataSet();
               //DataSet set3 = new DataSet();
               //MessageBox.Show(target);
          if((source !=null )||(target !=null))
               {
                 XmlDataDocument xmldoc = new XmlDataDocument();
                   FileStream file = new FileStream(source, FileMode.Open, FileAccess.Read);
                   //xmldoc.DataSet.ReadXmlSchema(source);
                 // xmldoc.Load(file);
                   //string[] cells;

                   set.ReadXml(source);
                   if (set.Tables["data"].Columns.Contains("type") == true)
                   {


                       set.Tables["data"].Columns.Remove("type");
                   }
             /* if(set.Tables["data"].Columns.Contains ("comment") ==true )
               {
                   set.Tables["data"].Columns.Remove("comment");
              }*/
              if (set.Tables["data"].Columns.Contains ("space") == true)
              {
                  set.Tables["data"].Columns.Remove("space");
              }
                   set.Tables.Remove("resheader");
                   set.Tables.Remove("assembly");
                   set.Tables.Remove("metadata");
                   int j;
                 set2.Tables.Add("data");

                   string[] colmn = new string[set.Tables["data"].Columns.Count];
                   for (j = 0; j < set.Tables["data"].Columns.Count; j++)
                   {
                      // colmn[j] = set.Tables["data"].Columns[j].ColumnName;
                       set2.Tables["data"].Columns.Add(set.Tables["data"].Columns[j].ColumnName);

                   }


                  // MessageBox.Show(Convert.ToString(set.Tables["data"].Columns .Count));
                   foreach (DataRow row in set.Tables["data"].Rows )
                   {
                       object[] val = row.ItemArray;
                    
                       if (Convert.ToString(val[0]).Contains("Text") == true)
                       {

                           object[] nval = row.ItemArray;
                          // MessageBox.Show(Convert.ToString(val[0]));
                           set2.Tables["data"].Rows.Add(nval);                
                           
 

                       }
                       
                   }
                 
                   
               
                


                ado.SaveTable(set2, target, set2.Tables.IndexOf("data"), "LocaleHundler " + LocaleHundlerCore.GetVersion());
                   file.Close();
                   ado.CloseDataBase(set);
                   ado.CloseDataBase(set2);


               }
           }

           catch (Exception e)
           {
               program.errorreport(e);
               //return null;
           }


       }
      /* void RemovenonUsablecolumns(DataTable table)
       {

           try
           {
               if ((table !=null ) ||(table.Columns !=null))
               {
                   foreach (DataColumn col in table.Columns)
                   {
                       if (col["name"]
                       {

                           table.Columns.Remove(col);

                       }

                   }

               }
           }

           catch (Exception e)
           {
               //hdBugger.TakeTheException2XmlLog(e, "LocaleHundler", LocaleHundlerCore.GetVersion());
              // return null;
           }

       }*/
    }
}
