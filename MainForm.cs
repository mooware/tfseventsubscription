using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace EventSubscriptionTool
{
    public partial class MainForm : Form
    {
        private int sortColumn = -1;
        private TfsTeamProjectCollection tfsCollection = null;
        private IEventService eventService = null;
        private string userName;

        public MainForm()
        {            
            InitializeComponent();
            CustomInit();

            this.Show();
            Application.DoEvents();

            connectButton_Click(this, null);
        }

        private void CustomInit()
        {
            // set default system font
            this.Font = SystemInformation.MenuFont;

            comboBoxFormat.Items.AddRange(Enum.GetNames(typeof(DeliveryType)));
            comboBoxFormat.SelectedItem = DeliveryType.EmailPlaintext.ToString();

            comboBoxSchedule.Items.AddRange(Enum.GetNames(typeof(DeliverySchedule)));
            comboBoxSchedule.SelectedItem = DeliverySchedule.Immediate.ToString();

            comboBoxEventType.SelectedItem = "CheckinEvent";
        }

        private void LoadUserSettings()
        {
            EventSubscriptionTool.Properties.Settings cfg = EventSubscriptionTool.Properties.Settings.Default;

            // has the config file been created before?
            if (! cfg.Initialized)
                return;

            this.Size = cfg.WindowSize;

            foreach (ColumnHeader col in subscriptionslistView.Columns)
            {
                int i = col.Index;

                if (i < cfg.ColumnWidths.Count)
                    col.Width = (int) cfg.ColumnWidths[i];

                if (i < cfg.ColumnDisplayIndices.Count)
                    col.DisplayIndex = (int) cfg.ColumnDisplayIndices[i];
            }

            if (cfg.WindowMaximized)
                this.WindowState = FormWindowState.Maximized;
        }

        private void SaveUserSettings()
        {
            EventSubscriptionTool.Properties.Settings cfg = EventSubscriptionTool.Properties.Settings.Default;

            cfg.Initialized = true;

            cfg.WindowMaximized = (this.WindowState == FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Normal)
            {
                cfg.WindowSize = this.Size;
            }

            ArrayList colWidths = new ArrayList();
            ArrayList colDisplayIndices = new ArrayList();

            foreach (ColumnHeader col in this.subscriptionslistView.Columns)
            {
                colWidths.Add(col.Width);
                colDisplayIndices.Add(col.DisplayIndex);
            }

            cfg.ColumnWidths = colWidths;
            cfg.ColumnDisplayIndices = colDisplayIndices;

            cfg.Save();
        }

        private void DisplayServerInfo()
        {
            Boolean connected = (tfsCollection != null);
            subscribeButton.Enabled = connected;
            refreshButton.Enabled = connected;

            if (!connected)
            {
                textBoxExpression.Text = "";
                textBoxSendTo.Text = "";

                tfsCollectionTextBox.Text = "(not connected)";
                subscriptionslistView.Items.Clear();
                return;
            }

            tfsCollectionTextBox.Text = tfsCollection.Name;
            userTextBox.Text = userName;
        }

        private void ShowSubscriptions()
        {
            Cursor.Current = Cursors.WaitCursor;
            subscriptionslistView.Items.Clear();

            if (eventService != null)
            {
                foreach (Subscription s in eventService.GetEventSubscriptions(userTextBox.Text))
                {
                    ListViewItem item = new ListViewItem(s.ID.ToString());

                    // store subscription with the item to use it later
                    item.Tag = s;

                    item.SubItems.Add(s.Tag);
                    item.SubItems.Add(s.EventType);
                    item.SubItems.Add(s.ConditionString);
                    item.SubItems.Add(s.DeliveryPreference.Type.ToString());
                    item.SubItems.Add(s.DeliveryPreference.Schedule.ToString());
                    item.SubItems.Add(s.DeliveryPreference.Address);

                    subscriptionslistView.Items.Add(item);
                }
            }

            Cursor.Current = Cursors.Default;
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
                eventService.UnsubscribeEvent(Int32.Parse(item.Text));
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

            if (tfsCollection == null)
            {
                MainForm.DisplayException("No Team Foundation Server selected");
                return;
            }

            if (comboBoxEventType.SelectedItem == null)
            {
              MessageBox.Show("No Event selected");
              return;
            }

            if (comboBoxFormat.SelectedItem == null)
            {
                MessageBox.Show("No Format selected");
                return;
            }

            if (comboBoxSchedule.SelectedItem == null)
            {
                MessageBox.Show("No Schedule selected");
                return;
            }

            DeliveryPreference preference = new DeliveryPreference();
            preference.Type = (DeliveryType) Enum.Parse(typeof(DeliveryType), comboBoxFormat.Text);
            preference.Schedule = (DeliverySchedule) Enum.Parse(typeof(DeliverySchedule), comboBoxSchedule.Text);
            preference.Address = textBoxSendTo.Text;

            try
            {
                string eventType = comboBoxEventType.Text;
                string filter = textBoxExpression.Text;
                string name = textBoxName.Text;

                eventService.SubscribeEvent(userName, eventType, filter, preference, name);
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
            if (!String.IsNullOrEmpty(f.QueryString))
            {
                textBoxExpression.Text = f.QueryString;
            }
        }

        private void subscriptionslistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool anySelection = (subscriptionslistView.SelectedItems.Count != 0);

            unsubscribeButton.Enabled = anySelection;

            if (!anySelection)
                return;

            Subscription subscription = (Subscription) subscriptionslistView.SelectedItems[0].Tag;

            textBoxName.Text = subscription.Tag;
            textBoxExpression.Text = subscription.ConditionString;
            textBoxSendTo.Text = subscription.DeliveryPreference.Address;
            comboBoxEventType.SelectedItem = subscription.EventType.ToString();
            comboBoxFormat.SelectedItem = subscription.DeliveryPreference.Type.ToString();
            comboBoxSchedule.SelectedItem = subscription.DeliveryPreference.Schedule.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserSettings();
        }

        /// <summary>
        /// Presents the TeamProjectPicker just as in Team Explorer to select the TFS Server and prompts for
        /// login information if needed.
        /// </summary>
        protected void ConnectToServer()
        {
            TeamProjectPicker tpp = new TeamProjectPicker();
            if (tpp.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    TfsTeamProjectCollection tfs = tpp.SelectedTeamProjectCollection;
                    tfs.Authenticate();

                    eventService = (IEventService) tfs.GetService(typeof(IEventService));
                    userName = IdentityHelper.GetDomainUserName(tfs.AuthorizedIdentity);
                    tfsCollection = tfs;
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
            ConnectToServer();
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUserSettings();
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
