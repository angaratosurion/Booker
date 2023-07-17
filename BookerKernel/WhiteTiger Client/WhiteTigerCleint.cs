using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

using Booker;


using Hydrobase;
using HydrobaseSDK;
using Booker.WhiteTiger_Client;
namespace Booker.White_Tiger_Client
{
    public class WhiteTigerCleint 
    { internal static string configfilename="WhiteTigerClientSettings.xml";
    public static WhiteTigerService.WhiteTigerServiceClient client ;
      string pass;
      BookerKernel kernel = new BookerKernel();
      Tools tools = new Tools();
       
      public WhiteTigerCleint()
      {
          client = new WhiteTigerService.WhiteTigerServiceClient();
          client.Open();


      }
    
      void ReadOpt()
      {
          try
          {

              if (File.Exists(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\" + configfilename) == true)
              {

                  DataSet set = new DataSet();
                  hydrobaseADO ado = new hydrobaseADO();
                  ado.AttachDataBaseinDataSet(set, Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\" + configfilename);
                  object[] vals=null;
                  if (set.Tables != null)
                  {
                      vals = set.Tables[0].Rows[0].ItemArray;

                  }
                  pass = Convert.ToString(vals[set.Tables[0].Columns["password"].Ordinal]);
              }

          }
          catch (Exception ex)
          {

              program.errorreport(ex);

          }

      }
     public  void Load(	BookerMain form)
      {
          try
          {
              
              this.ReadOpt();
             if (BookerKernel.enable_white_tiger_serverclient)
              {
                 
                  //client.Open();
                 if (client.ListDatabases(Environment.UserName, pass).Contains(BookerKernel.bookdb) == false)
                  {
                      client.CreateDataBase(Environment.UserName, pass, BookerKernel.bookdb);


                  }
                  
             if (client.ListTables(Environment.UserName, pass, BookerKernel.bookdb).Contains(BookerKernel.booktable) == false)
                  {
                      List<string> kell = new List<string>();
                      for (int i = 0; i < BookerKernel.Bookkelia.Length; i++)
                      {
                          kell.Add(BookerKernel.Bookkelia[i]);
                      }
                      client.CreateTable(BaseClass.tabletag, BaseClass.recordtag, Environment.UserName, pass, BookerKernel.bookdb
                          , BookerKernel.booktable, kell);

                  }
                  if (BookerKernel.useencryptedtables == true)
                  {



                      string vals = client.Decrypt(BaseClass.tabletag, BaseClass.recordtag, Environment.UserName, BookerKernel.bookdb, BookerKernel.booktable,
                           pass, Cryptography.CryptograhyAlgorithm.rijdael, Cryptography.HashingAlogrithm.SHA384);
                      if (vals != null)
                      {
                          MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(vals.ToCharArray()));
                          hydrobaseADO ado = new hydrobaseADO();
                          
                          BookerKernel.dtsData.ReadXml(ms);
                          form.dtgDataGrd.DataSource = BookerKernel.dtsData;
                          form.dtgDataGrd.DataMember = BookerKernel.dtsData.Tables[0].TableName;
                          ado.ConnectEventstoDataTable(BookerKernel.dtsData.Tables[0]);


                      }


                  }
                  else
                  {

                      string vals = client.LoadTable(BaseClass.recordtag, Environment.UserName,pass, BookerKernel.bookdb, BookerKernel.booktable);
                    //  if (vals != null)
                      {
                          MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(vals.ToCharArray()));
                    BookerKernel.dtsData.ReadXml(ms);
                    //  BookerKernel.dtsData.Tables[0].ReadXml(ms);
                          form.dtgDataGrd.DataSource = BookerKernel.dtsData;
                          form.dtgDataGrd.DataMember = BookerKernel.dtsData.Tables[0].TableName;
                          hydrobaseADO ado = new hydrobaseADO();
                         
                          ado.ConnectEventstoDataTable(BookerKernel.dtsData.Tables[0]);
                          ado.ConnectEventstoDataGrid(form.dtgDataGrd);

                      }


                  }
              }
          }
          catch (Exception ex)
          {

              program.errorreport(ex);

          }

      }
    public void Update(object o , EventArgs ev)
      {
          try
          {
              if (BookerKernel.useencryptedtables == true)
              {

                  List<List<object>> vals = new List<List<object>>();
                  foreach (DataRow r in BookerKernel.dtsData.Tables[0].Rows)
                  {

                      List<object> v = new List<object>();
                      tools.ReplaceNulls(r);
                      v.AddRange(r.ItemArray);
                      vals.Add(v);

                  }
                  client.Encrypt(BaseClass.tabletag, BaseClass.recordtag, Environment.UserName, BookerKernel.bookdb, BookerKernel.booktable, vals, pass,
                      Cryptography.CryptograhyAlgorithm.rijdael, Cryptography.HashingAlogrithm.SHA384);

              }
              else
              {

                  List<List<object>> vals = new List<List<object>>();
                  foreach (DataRow r in BookerKernel.dtsData.Tables[0].Rows)
                  {

                      List<object> v = new List<object>();
                      tools.ReplaceNulls(r);
                      v.AddRange(r.ItemArray);
                      vals.Add(v);
                      

                  }
                  client.AddRows(BaseClass.tabletag,BaseClass.recordtag,Environment.UserName,pass,BookerKernel.bookdb, BookerKernel.booktable,vals,true);
                  
                  //client.UpdateTable(BaseClass.tabletag, BaseClass.recordtag, Environment.UserName, pass, BookerKernel.bookdb, BookerKernel.booktable,vals  );
             
                  
              
              }

              //kernel.Encrypt(program.Activewin);
              
          }
          catch (Exception ex)
          {

              program.errorreport(ex);

          }


      }
    public void Backup(object o, EventArgs ev)
    {
        try
        {
          

                client.Backup(Environment.UserName, BookerKernel.bookdb, BookerKernel.booktable, pass);

        }
        catch (Exception ex)
        {

            program.errorreport(ex);

        }


    }
    public void ImportTable(object o, EventArgs ev)
    {
        try
        {
            kernel.ImportTable(program.Activewin);
            this.Update(o, ev);
        }
        catch (Exception ex)
        {

            program.errorreport(ex);

        }


    }
    
    }
   
}
