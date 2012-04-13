using System;
using System.Windows.Forms;

// TFS dependencies
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.Client;

namespace WorkitemEventSubscriptionTool
{
    public class TFSInstanceChangedArgs : EventArgs
    {
        public readonly TfsTeamProjectCollection Collection;

        public TFSInstanceChangedArgs(TfsTeamProjectCollection tfsInstance)
        {
            this.Collection = tfsInstance;
        }
    }

    public delegate void ServerChangedHandler(Object sender, TFSInstanceChangedArgs serverArgs);

    static class Shared
    {

        static public TfsTeamProjectCollection Collection = null;
        static public ICommonStructureService CSSProxy = null;
        static public IEventService EventService = null;
        static public string UserName;

        // nasty Q&D hack for passing data between forms 
        static public string FormSharedData;

        public static void ConnectServer()
        {
            if (Shared.Collection == null)
            {
                return;
            }

            try
            {
                Shared.EventService = (IEventService)Shared.Collection.GetService(typeof(IEventService));
                Shared.CSSProxy = (ICommonStructureService)Shared.Collection.GetService(typeof(ICommonStructureService));                
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
