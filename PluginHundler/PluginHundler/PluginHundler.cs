using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using Hydrobase;
using HydrobaseSDK;

using NLog;

namespace PluginHundler
{
    public class PluginHundler : IConfigurationSectionHandler
    {
        internal static Logger logman = NLog.LogManager.GetCurrentClassLogger();
        public static void errorreport(Exception e)
        {
            // MessageBox.Show(e.ToString());

         
                logman.Fatal(e.Message, e);

        }
        public PluginHundler()
        {
            
        }
        #region IConfigurationSectionHandler Members
        BaseClass hbclas = new BaseClass();
       
        //static public PluginCollection Loaded_plugins ;
        /// <summary>
        /// Iterate through all the child nodes
        ///	of the XMLNode that was passed in and create instances
        ///	of the specified Types by reading the attribite values of the nodes
        ///	we use a try/Catch here because some of the nodes
        ///	might contain an invalid reference to a plugin type
        ///	</summary>
        /// <param name="parent"></param>
        /// <param name="configContext"></param>
        /// <param name="section">The XML section we will iterate against</param>
        /// <returns></returns>
        public object Create(object parent, object configContext, System.Xml.XmlNode section)
        {
            PluginCollection Loaded_plugins = new PluginCollection();

            foreach (XmlNode node in section.ChildNodes)
            {
                try
                {
                    //Use the Activator class's 'CreateInstance' method
                    //to try and create an instance of the plugin by
                    //passing in the type name specified in the attribute value
                    object plugObject = Activator.CreateInstance(Type.GetType(node.Attributes["type"].Value));

                    //Cast this to an GeneralPluginSDK interface and add to the collection
                    GeneralPluginSDK plugin = (GeneralPluginSDK)plugObject;
                    Loaded_plugins.Add(plugin);
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.ToString());
                    //hbclas.errorhandling(e);
                    //Catch any exceptions
                    //but continue iterating for more plugins
                    errorreport(e);
                }
            }

            return Loaded_plugins;
        }
        public string[] GetHydrobasePluginsInfo(PluginCollection HyPlugColl)
        {
            try
            {
                string[] PluginNamesAndVersions = null;
                int Ply8osPlugins, i = 0;

                if (HyPlugColl != null)
                {
                    Ply8osPlugins = HyPlugColl.Count;
                    PluginNamesAndVersions = new string[Ply8osPlugins];
                    foreach (GeneralPluginSDK plugin in HyPlugColl)
                    {
                        if (i < Ply8osPlugins)
                        {
                            PluginNamesAndVersions[i] = plugin.Name + " - " + plugin.GetHydroPluginVersion();

                            i++;
                        }



                    }

                }
                return PluginNamesAndVersions;


            }
            catch (Exception e)
            {
                errorreport(e);

                return null;
            }


        }
        #endregion
        public string GetPluginHundlerVersion()
        {
            try
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();


            }
            catch (Exception e)
            {
                errorreport(e);
                return null;

            }




        }
        public GeneralPluginSDK FindAPlugin(PluginCollection plugColl, string PluginName)
        {

            try
            {
                GeneralPluginSDK plugret = null;
                if ((plugColl != null) && (PluginName != null))
                {

                    foreach (GeneralPluginSDK plugin in plugColl)
                    {
                        if (plugin.Name == PluginName)
                        {

                            plugret = plugin;

                        }


                    }



                }
                return plugret;


            }

            catch (Exception e)
            {

                errorreport(e);
                return null;

            }



        }
        public bool ExistPlugin(PluginCollection plugColl, string PluginName)
        {


            try
            {
                bool res = false;
                int i, Plh8osPlug;
                if ((plugColl != null) && (PluginName != null))
                {
                    Plh8osPlug = plugColl.Count;
                    //foreach (GeneralPluginSDK plugin in plugColl)
                    for (i = 0; i < Plh8osPlug; i++)
                    {
                        if (plugColl[i].Name.Equals(PluginName) == true)
                        {


                            res = true;
                            //MessageBox.Show(Convert.ToString(res));
                            break;

                        }


                    }



                }
                return res;


            }

            catch (Exception e)
            {

                errorreport(e);
                return false;

            }



        }
        public bool ExistPluginStartsWith(PluginCollection plugColl, string PluginName)
        {
            try
            {
                bool res = false;
                int i, Plh8osPlug;
                if ((plugColl != null) && (PluginName != null))
                {
                    Plh8osPlug = plugColl.Count;
                    //foreach (GeneralPluginSDK plugin in plugColl)
                    for (i = 0; i < Plh8osPlug; i++)
                    {
                        if (plugColl[i].Name.StartsWith(PluginName) == true)
                        {


                            res = true;
                            //MessageBox.Show(Convert.ToString(res));
                            break;

                        }


                    }



                }
                return res;


            }

            catch (Exception e)
            {

                errorreport(e);
                return false;

            }


        }
        public void ClearPluginsCollection(PluginCollection plugcoll)
        {
            try
            {
                if (plugcoll != null)
                {
                    plugcoll.Clear();


                }



            }
            catch (Exception e)
            {
                errorreport(e);

            }


        }
        public void DeleteSelectedPlugin(PluginCollection plugcoll, string plugname)
        {

            try
            {
                if ((plugcoll != null) && (plugname != null))
                {
                    this.FindAPlugin(plugcoll, plugname).Dispose();
                    plugcoll.Remove(this.FindAPlugin(plugcoll, plugname));


                }



            }
            catch (Exception e)
            {
                errorreport(e);

            }
        }
        public GeneralPluginSDK FindAPluginBasedOnKind(PluginCollection plugcoll, string pluginkind)
        {
            try
            {
                GeneralPluginSDK plug = null;
                int i;
                if ((plugcoll != null) || (pluginkind != null))
                {
                    for (i = 0; i < plugcoll.Count; i++)
                    {
                        if (plugcoll[i].HydroPluginKind == pluginkind)
                        {
                            plug = plugcoll[i];
                            break;

                        }

                    }


                }
                return plug;

            }
            catch (Exception e)
            {

                errorreport(e);
                return null;
            }

        }
        public PluginCollection FindAPluginsBasedOnKind(PluginCollection plugcoll, string pluginkind)
        {
            try
            {
                PluginCollection plug = null;
                int i;
                if ((plugcoll != null) || (pluginkind != null))
                {
                    plug = new PluginCollection();
                    for (i = 0; i < plugcoll.Count; i++)
                    {
                        if (plugcoll[i].HydroPluginKind == pluginkind)
                        {
                            plug.Add(plugcoll[i]);


                        }

                    }


                }
                return plug;

            }
            catch (Exception e)
            {

                errorreport(e);
                return null;
            }

        }
        public void CopyPlugin(PluginCollection source, PluginCollection target, string plugname)
        {
            try
            {
                GeneralPluginSDK plg;
                if ((source != null) || (target != null) || (plugname != null))
                {
                    plg = this.FindAPlugin(source, plugname);
                    target.Add(plg);
                }

            }
            catch (Exception e)
            {

                errorreport(e);
            }
        }
        public void CopyPluginBasedOnKind(PluginCollection source, PluginCollection target, string plugkind)
        {
            try
            {
                GeneralPluginSDK plg;
                if ((source != null) || (target != null) || (plugkind != null))
                {
                    plg = this.FindAPluginBasedOnKind(source, plugkind);
                    if ( plg!= null)
                    {
                        target.Add(plg);
                    }

                }

            }
            catch (Exception e)
            {

                errorreport(e);
            }








        }
    }
}
