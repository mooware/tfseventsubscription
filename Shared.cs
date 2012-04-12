using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// TFS dependencies
using Microsoft.TeamFoundation.Proxy;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.Client;

namespace WorkitemEventSubscriptionTool
{
    public class TFSInstanceChangedArgs : EventArgs
    {
        public readonly TeamFoundationServer Server;

        public TFSInstanceChangedArgs(TeamFoundationServer tfsInstance)
        {
            this.Server = tfsInstance;
        }
    }

    public delegate void ServerChangedHandler(Object sender, TFSInstanceChangedArgs serverArgs);

    static class Shared
    {

        static public TeamFoundationServer Server = null;
        static public ICommonStructureService CSSProxy = null;
        static public IEventService EventService = null;
        static public string UserDomain;
        static public string UserName;

        // nasty Q&D hack for passing data between forms 
        static public string FormSharedData;

        public static void ConnectServer()
        {
            if (Shared.Server == null)
            {
                return;
            }

            try
            {
                Shared.EventService = (IEventService)Shared.Server.GetService(typeof(IEventService));
                Shared.CSSProxy = (ICommonStructureService)Shared.Server.GetService(typeof(ICommonStructureService));                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Cannot Connect to Server");
                return;
            }
        }

        private static void GetProjects(ComboBox cb)
        {
            cb.Items.Clear();

            // Get the list of projects on the server and populate the projects combo box            
            ProjectInfo[] projects = Shared.CSSProxy.ListProjects();

            foreach (ProjectInfo project in projects)
            {
                cb.Items.Add(project.Name);
            }

            // If there is at least one item add it to the selected list
            if (projects.Length > 0)
            {
                cb.Text = projects[0].Name;
            }
        }

    }
}
