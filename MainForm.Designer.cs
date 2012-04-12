namespace SubscriptionManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.connectButton = new System.Windows.Forms.Button();
      this.TFSNameLabel = new System.Windows.Forms.Label();
      this.subscriptionslistView = new System.Windows.Forms.ListView();
      this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderEventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderExpression = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.unsubscribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.userTextBox = new System.Windows.Forms.TextBox();
      this.refreshButton = new System.Windows.Forms.Button();
      this.eventComboBox = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.comboBoxFormat = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.subscribeButton = new System.Windows.Forms.Button();
      this.textBoxSendTo = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.unsubscribeButton = new System.Windows.Forms.Button();
      this.closeButton = new System.Windows.Forms.Button();
      this.buildButton = new System.Windows.Forms.Button();
      this.textBoxExpression = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.connectButton);
      this.splitContainer1.Panel1.Controls.Add(this.TFSNameLabel);
      this.splitContainer1.Panel1.Controls.Add(this.subscriptionslistView);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.userTextBox);
      this.splitContainer1.Panel1.Controls.Add(this.refreshButton);
      this.splitContainer1.Panel1MinSize = 150;
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.eventComboBox);
      this.splitContainer1.Panel2.Controls.Add(this.label7);
      this.splitContainer1.Panel2.Controls.Add(this.comboBoxFormat);
      this.splitContainer1.Panel2.Controls.Add(this.label3);
      this.splitContainer1.Panel2.Controls.Add(this.subscribeButton);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxSendTo);
      this.splitContainer1.Panel2.Controls.Add(this.label4);
      this.splitContainer1.Panel2.Controls.Add(this.unsubscribeButton);
      this.splitContainer1.Panel2.Controls.Add(this.closeButton);
      this.splitContainer1.Panel2.Controls.Add(this.buildButton);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxExpression);
      this.splitContainer1.Panel2.Controls.Add(this.label6);
      this.splitContainer1.Size = new System.Drawing.Size(751, 519);
      this.splitContainer1.SplitterDistance = 235;
      this.splitContainer1.SplitterWidth = 6;
      this.splitContainer1.TabIndex = 30;
      // 
      // connectButton
      // 
      this.connectButton.Location = new System.Drawing.Point(243, 9);
      this.connectButton.Name = "connectButton";
      this.connectButton.Size = new System.Drawing.Size(74, 23);
      this.connectButton.TabIndex = 8;
      this.connectButton.Text = "&Connect";
      this.connectButton.UseVisualStyleBackColor = true;
      this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
      // 
      // TFSNameLabel
      // 
      this.TFSNameLabel.AutoSize = true;
      this.TFSNameLabel.Location = new System.Drawing.Point(10, 13);
      this.TFSNameLabel.Name = "TFSNameLabel";
      this.TFSNameLabel.Size = new System.Drawing.Size(82, 13);
      this.TFSNameLabel.TabIndex = 7;
      this.TFSNameLabel.Text = "(not connected)";
      // 
      // subscriptionslistView
      // 
      this.subscriptionslistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.subscriptionslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderEventType,
            this.columnHeaderExpression,
            this.columnHeaderFormat,
            this.columnHeaderAddress});
      this.subscriptionslistView.ContextMenuStrip = this.contextMenuStrip1;
      this.subscriptionslistView.FullRowSelect = true;
      this.subscriptionslistView.GridLines = true;
      this.subscriptionslistView.Location = new System.Drawing.Point(8, 63);
      this.subscriptionslistView.Name = "subscriptionslistView";
      this.subscriptionslistView.Size = new System.Drawing.Size(736, 157);
      this.subscriptionslistView.TabIndex = 6;
      this.subscriptionslistView.UseCompatibleStateImageBehavior = false;
      this.subscriptionslistView.View = System.Windows.Forms.View.Details;
      this.subscriptionslistView.SelectedIndexChanged += new System.EventHandler(this.subscriptionslistView_SelectedIndexChanged);
      // 
      // columnHeaderID
      // 
      this.columnHeaderID.Text = "ID";
      this.columnHeaderID.Width = 33;
      // 
      // columnHeaderEventType
      // 
      this.columnHeaderEventType.Text = "Event";
      this.columnHeaderEventType.Width = 111;
      // 
      // columnHeaderExpression
      // 
      this.columnHeaderExpression.Text = "Expression";
      this.columnHeaderExpression.Width = 319;
      // 
      // columnHeaderFormat
      // 
      this.columnHeaderFormat.Text = "Format";
      // 
      // columnHeaderAddress
      // 
      this.columnHeaderAddress.Text = "Delivery Address";
      this.columnHeaderAddress.Width = 206;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unsubscribeToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(140, 26);
      // 
      // unsubscribeToolStripMenuItem
      // 
      this.unsubscribeToolStripMenuItem.Name = "unsubscribeToolStripMenuItem";
      this.unsubscribeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
      this.unsubscribeToolStripMenuItem.Text = "Unsubscribe";
      this.unsubscribeToolStripMenuItem.Click += new System.EventHandler(this.unsubscribeToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Subscriptions:";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(336, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Username";
      // 
      // userTextBox
      // 
      this.userTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.userTextBox.Location = new System.Drawing.Point(395, 11);
      this.userTextBox.Name = "userTextBox";
      this.userTextBox.Size = new System.Drawing.Size(226, 20);
      this.userTextBox.TabIndex = 3;
      this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
      // 
      // refreshButton
      // 
      this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.refreshButton.Enabled = false;
      this.refreshButton.Location = new System.Drawing.Point(627, 9);
      this.refreshButton.Name = "refreshButton";
      this.refreshButton.Size = new System.Drawing.Size(112, 23);
      this.refreshButton.TabIndex = 4;
      this.refreshButton.Text = "&Get Subscriptions";
      this.refreshButton.UseVisualStyleBackColor = true;
      this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
      // 
      // eventComboBox
      // 
      this.eventComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.eventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.eventComboBox.FormattingEnabled = true;
      this.eventComboBox.Items.AddRange(new object[] {
            "BranchMovedEvent",
            "BuildCompletionEvent",
            "BuildStatusChangedEvent",
            "CheckinEvent",
            "CommonStructureChangedEvent",
            "DataChangedEvent",
            "IdentityChangedEvent",
            "NodeCreatedEvent",
            "NodePropertiesChangedEvent",
            "NodeRenamedEvent",
            "NodesDeletedEvent",
            "ProjectCreatedEvent",
            "ProjectDeletedEvent",
            "WorkItemChangedEvent"});
      this.eventComboBox.Location = new System.Drawing.Point(62, 167);
      this.eventComboBox.Name = "eventComboBox";
      this.eventComboBox.Size = new System.Drawing.Size(199, 21);
      this.eventComboBox.Sorted = true;
      this.eventComboBox.TabIndex = 4;
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(5, 170);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(38, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "Event:";
      // 
      // comboBoxFormat
      // 
      this.comboBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.comboBoxFormat.FormattingEnabled = true;
      this.comboBoxFormat.Items.AddRange(new object[] {
            "EmailHtml",
            "PlainText",
            "Soap"});
      this.comboBoxFormat.Location = new System.Drawing.Point(62, 219);
      this.comboBoxFormat.Name = "comboBoxFormat";
      this.comboBoxFormat.Size = new System.Drawing.Size(121, 21);
      this.comboBoxFormat.TabIndex = 8;
      this.comboBoxFormat.Text = "EmailHtml";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(5, 222);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Format:";
      // 
      // subscribeButton
      // 
      this.subscribeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.subscribeButton.Enabled = false;
      this.subscribeButton.Location = new System.Drawing.Point(8, 243);
      this.subscribeButton.Name = "subscribeButton";
      this.subscribeButton.Size = new System.Drawing.Size(75, 23);
      this.subscribeButton.TabIndex = 9;
      this.subscribeButton.Text = "&Subscribe";
      this.subscribeButton.UseVisualStyleBackColor = true;
      this.subscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
      // 
      // textBoxSendTo
      // 
      this.textBoxSendTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.textBoxSendTo.Location = new System.Drawing.Point(62, 194);
      this.textBoxSendTo.Name = "textBoxSendTo";
      this.textBoxSendTo.Size = new System.Drawing.Size(552, 20);
      this.textBoxSendTo.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(5, 197);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Send To:";
      // 
      // unsubscribeButton
      // 
      this.unsubscribeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.unsubscribeButton.Enabled = false;
      this.unsubscribeButton.Location = new System.Drawing.Point(89, 243);
      this.unsubscribeButton.Name = "unsubscribeButton";
      this.unsubscribeButton.Size = new System.Drawing.Size(84, 23);
      this.unsubscribeButton.TabIndex = 10;
      this.unsubscribeButton.Text = "&Unsubscribe";
      this.unsubscribeButton.UseVisualStyleBackColor = true;
      this.unsubscribeButton.Click += new System.EventHandler(this.deleteSubscriptionButton_Click);
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.Location = new System.Drawing.Point(669, 243);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 11;
      this.closeButton.Text = "&Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // buildButton
      // 
      this.buildButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buildButton.Location = new System.Drawing.Point(664, 11);
      this.buildButton.Name = "buildButton";
      this.buildButton.Size = new System.Drawing.Size(75, 23);
      this.buildButton.TabIndex = 2;
      this.buildButton.Text = "&Build...";
      this.buildButton.UseVisualStyleBackColor = true;
      this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
      // 
      // textBoxExpression
      // 
      this.textBoxExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxExpression.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxExpression.Location = new System.Drawing.Point(62, 11);
      this.textBoxExpression.Multiline = true;
      this.textBoxExpression.Name = "textBoxExpression";
      this.textBoxExpression.Size = new System.Drawing.Size(597, 150);
      this.textBoxExpression.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(5, 11);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(48, 17);
      this.label6.TabIndex = 0;
      this.label6.Text = "XPath:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(751, 519);
      this.Controls.Add(this.splitContainer1);
      this.MinimumSize = new System.Drawing.Size(700, 460);
      this.Name = "MainForm";
      this.Text = "Event Subscription Tool";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView subscriptionslistView;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderEventType;
        private System.Windows.Forms.ColumnHeader columnHeaderExpression;
        private System.Windows.Forms.ColumnHeader columnHeaderFormat;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.TextBox textBoxSendTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label TFSNameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unsubscribeToolStripMenuItem;


    }
}