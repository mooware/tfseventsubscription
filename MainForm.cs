using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkitemEventSubscriptionTool;
using System.Diagnostics;

using System.Net;

using Microsoft.TeamFoundation.Proxy;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation;
using Microsoft.TeamFoundation.Framework.Client;

namespace SubscriptionManager
{
    public partial class MainForm : Form
    {
        private int sortColumn = -1;

        public MainForm()
        {            
            // set default system font
            this.Font = SystemInformation.MenuFont;

            InitializeComponent();
            this.Show();
            Application.DoEvents();

            connectButton_Click(this, null);
        }

        void DisplayServerInfo()
        {
            Boolean connected = (Shared.Collection != null);
            subscribeButton.Enabled = connected;
            unsubscribeButton.Enabled = connected;
            refreshButton.Enabled = connected;
            
            if (!connected)
            {
                textBoxExpression.Text = "";
                textBoxSendTo.Text = "";

                TFSNameLabel.Text = "(not connected)";
                subscriptionslistView.Items.Clear();
                return;
            }

            TFSNameLabel.Text = Shared.Collection.Name;
            userTextBox.Text = Shared.UserName;
        }


        private void ShowSubscriptions()
        {
            Cursor.Current = Cursors.WaitCursor;
            subscriptionslistView.Items.Clear();

            Shared.ConnectServer();

            if (Shared.EventService == null)
            {
                return;
            }

            foreach (Subscription s in Shared.EventService.GetEventSubscriptions(userTextBox.Text))
            {
                ListViewItem item = new ListViewItem(s.ID.ToString());
                item.SubItems.Add(s.EventType);
                item.SubItems.Add(s.ConditionString);
                item.SubItems.Add(s.DeliveryPreference.Type.ToString());
                item.SubItems.Add(s.DeliveryPreference.Address);
                subscriptionslistView.Items.Add(item);
            }
            Cursor.Current = Cursors.Default;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ShowSubscriptions();
        }

        private void deleteSubscriptionButton_Click(object sender, EventArgs e)
        {
            Unsubscribe();
        }

        private void Unsubscribe()
        {
            if (subscriptionslistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No subscriptions are selected.");
                return;
            }

            foreach (ListViewItem item in subscriptionslistView.SelectedItems)
            {
                Shared.EventService.UnsubscribeEvent(Int32.Parse(item.Text));
            }

            ShowSubscriptions();
        }


        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            if (textBoxSendTo.Text.Trim().Length == 0)
            {
                MessageBox.Show("There are no email/SOAP addresses in the Send To box.");
                return;
            }

            if (textBoxExpression.Text.Trim().Length == 0)
            {
                MessageBox.Show("No XPath expression has been entered.");
                return;
            }

            if (Shared.Collection == null )
            {
                MainForm.DisplayException("No Team Foundation Server Selected");
                return;
            }

            DeliveryPreference preference = new DeliveryPreference();
            preference.Schedule = DeliverySchedule.Immediate;

            switch (comboBoxFormat.Text)
            {
                case "Soap":
                    preference.Type = DeliveryType.Soap;
                    break;
                case "PlainText":
                    preference.Type = DeliveryType.EmailPlaintext;
                    break;
                default:
                    preference.Type = DeliveryType.EmailHtml;
                    break;
            }

            preference.Address = textBoxSendTo.Text;

            string userName = Environment.UserDomainName + @"\" + Environment.UserName;

            try
            {
                int id = Shared.EventService.SubscribeEvent(userName, eventComboBox.SelectedItem.ToString(), textBoxExpression.Text, preference);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error subscribing to event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ShowSubscriptions();
        }

        private static void DisplayException(string message)
        {
            MessageBox.Show(message);
            return;
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            XPathBuilderForm f = new XPathBuilderForm();
            f.ShowDialog();
            if (!String.IsNullOrEmpty(Shared.FormSharedData))
            {
                textBoxExpression.Text = Shared.FormSharedData;
            }
        }

        private void subscriptionslistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subscriptionslistView.SelectedItems.Count == 0)
            {
                return;
            }
            textBoxExpression.Text = subscriptionslistView.SelectedItems[0].SubItems[2].Text;
            textBoxSendTo.Text = subscriptionslistView.SelectedItems[0].SubItems[4].Text;
            comboBoxFormat.SelectedItem = subscriptionslistView.SelectedItems[0].SubItems[3].Text;
            eventComboBox.SelectedItem = subscriptionslistView.SelectedItems[0].SubItems[1].Text;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // necessary hack due to bug in WinForms splitter control
            splitContainer1.Panel2MinSize = 310;
        }

        /// <summary>
        /// Presents the TeamProjectPicker just as in Team Explorer to select the TFS Server and prompts for
        /// login information if needed.
        /// </summary>
        protected void ChooseAppServer()
        {
            TeamProjectPicker tpp = new TeamProjectPicker();
            if (tpp.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    TfsTeamProjectCollection tfs = tpp.SelectedTeamProjectCollection;
                    tfs.Authenticate();

                    Shared.Collection = tfs;
                    Shared.UserName = IdentityHelper.GetDomainUserName(tfs.AuthorizedIdentity);
                }
                catch (Exception ex)
                {
                    DisplayException(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            DisplayServerInfo();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ChooseAppServer();
            ShowSubscriptions();
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            this.refreshButton.Enabled = (userTextBox.Text != String.Empty);
        }

        #region "listview sorting"

        private void subscriptionslistView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sort(subscriptionslistView, e);
        }

        private void Sort(ListView lv, ColumnClickEventArgs e)
        {

            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                lv.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (lv.Sorting == SortOrder.Ascending)
                    lv.Sorting = SortOrder.Descending;
                else
                    lv.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            lv.Sort();
            lv.ListViewItemSorter = new ListViewItemComparer(e.Column, lv.Sorting);
        }
        #endregion

        private void unsubscribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unsubscribe();
        }

    }

    #region "listview sorting"
    // Implements the manual sorting of items by columns.
    class ListViewItemComparer : System.Collections.IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            Debug.WriteLine(String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text));
            if (order == SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        }
    }
    #endregion

}
