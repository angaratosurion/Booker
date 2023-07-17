using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;
using Hydrobase;
using HydrobaseSDK;

namespace Booker
{
    public  class PluginHundler : IConfigurationSectionHandler
    {
        public PluginHundler()
		{
		}
		#region IConfigurationSectionHandler Members
        BaseClass hbclas = new BaseClass();
        HydroBugger.HydroBugger hdBugger = new HydroBugger.HydroBugger();
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
            
			foreach(XmlNode node in section.ChildNodes)
			{
				try
				{
					//Use the Activator class's 'CreateInstance' method
					//to try and create an instance of the plugin by
					//passing in the type name specified in the attribute value
					object plugObject =  Activator.CreateInstance( Type.GetType(node.Attributes["type"].Value));

					//Cast this to an GeneralPluginSDK interface and add to the collection
					GeneralPluginSDK plugin = (GeneralPluginSDK)plugObject;
                    Loaded_plugins.Add(plugin);
				}
				catch(Exception e)
                {
                    //MessageBox.Show(e.ToString());
                    //hbclas.errorhandling(e);
					//Catch any exceptions
					//but continue iterating for more plugins
                    this.hdBugger.TakeTheException2(e, Application.ProductName);
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
                this.hdBugger.TakeTheException2(e, Application.ProductName);

                return null;
            }


        }
		#endregion
        
        


    }
}
