namespace EventSubscriptionTool
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tfsCollectionTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.subscriptionslistView = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExpression = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSchedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuSubscription = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unsubscribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSchedule = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEventType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.textBoxSendTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.buildButton = new System.Windows.Forms.Button();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.contextMenuSubscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tfsCollectionTextBox);
            this.splitContainer.Panel1.Controls.Add(this.connectButton);
            this.splitContainer.Panel1.Controls.Add(this.subscriptionslistView);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.userTextBox);
            this.splitContainer.Panel1.Controls.Add(this.refreshButton);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.textBoxName);
            this.splitContainer.Panel2.Controls.Add(this.label8);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxSchedule);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxEventType);
            this.splitContainer.Panel2.Controls.Add(this.label7);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxFormat);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.subscribeButton);
            this.splitContainer.Panel2.Controls.Add(this.textBoxSendTo);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.unsubscribeButton);
            this.splitContainer.Panel2.Controls.Add(this.buildButton);
            this.splitContainer.Panel2.Controls.Add(this.textBoxExpression);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Size = new System.Drawing.Size(739, 522);
            this.splitContainer.SplitterDistance = 223;
            this.splitContainer.TabIndex = 30;
            // 
            // tfsCollectionTextBox
            // 
            this.tfsCollectionTextBox.Location = new System.Drawing.Point(13, 11);
            this.tfsCollectionTextBox.Name = "tfsCollectionTextBox";
            this.tfsCollectionTextBox.ReadOnly = true;
            this.tfsCollectionTextBox.Size = new System.Drawing.Size(241, 20);
            this.tfsCollectionTextBox.TabIndex = 9;
            this.tfsCollectionTextBox.Text = "(not connected)";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(260, 9);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(74, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "&Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // subscriptionslistView
            // 
            this.subscriptionslistView.AllowColumnReorder = true;
            this.subscriptionslistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subscriptionslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderTag,
            this.columnHeaderEventType,
            this.columnHeaderExpression,
            this.columnHeaderFormat,
            this.columnHeaderSchedule,
            this.columnHeaderAddress});
            this.subscriptionslistView.ContextMenuStrip = this.contextMenuSubscription;
            this.subscriptionslistView.FullRowSelect = true;
            this.subscriptionslistView.GridLines = true;
            this.subscriptionslistView.HideSelection = false;
            this.subscriptionslistView.Location = new System.Drawing.Point(8, 55);
            this.subscriptionslistView.Name = "subscriptionslistView";
            this.subscriptionslistView.Size = new System.Drawing.Size(721, 167);
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
            // columnHeaderTag
            // 
            this.columnHeaderTag.Text = "Name";
            this.columnHeaderTag.Width = 100;
            // 
            // columnHeaderEventType
            // 
            this.columnHeaderEventType.Text = "Event";
            this.columnHeaderEventType.Width = 90;
            // 
            // columnHeaderExpression
            // 
            this.columnHeaderExpression.Text = "Expression";
            this.columnHeaderExpression.Width = 200;
            // 
            // columnHeaderFormat
            // 
            this.columnHeaderFormat.Text = "Format";
            this.columnHeaderFormat.Width = 90;
            // 
            // columnHeaderSchedule
            // 
            this.columnHeaderSchedule.Text = "Schedule";
            this.columnHeaderSchedule.Width = 80;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Delivery Address";
            this.columnHeaderAddress.Width = 206;
            // 
            // contextMenuSubscription
            // 
            this.contextMenuSubscription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unsubscribeToolStripMenuItem});
            this.contextMenuSubscription.Name = "contextMenuStrip1";
            this.contextMenuSubscription.Size = new System.Drawing.Size(140, 26);
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
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subscriptions:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userTextBox.Location = new System.Drawing.Point(417, 11);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(194, 20);
            this.userTextBox.TabIndex = 3;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Enabled = false;
            this.refreshButton.Location = new System.Drawing.Point(617, 9);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(112, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "&Get Subscriptions";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxName.Location = new System.Drawing.Point(62, 210);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 20);
            this.textBoxName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name:";
            // 
            // comboBoxSchedule
            // 
            this.comboBoxSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSchedule.FormattingEnabled = true;
            this.comboBoxSchedule.Location = new System.Drawing.Point(291, 262);
            this.comboBoxSchedule.Name = "comboBoxSchedule";
            this.comboBoxSchedule.Size = new System.Drawing.Size(199, 21);
            this.comboBoxSchedule.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Schedule:";
            // 
            // comboBoxEventType
            // 
            this.comboBoxEventType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEventType.FormattingEnabled = true;
            this.comboBoxEventType.Items.AddRange(new object[] {
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
            this.comboBoxEventType.Location = new System.Drawing.Point(291, 210);
            this.comboBoxEventType.Name = "comboBoxEventType";
            this.comboBoxEventType.Size = new System.Drawing.Size(199, 21);
            this.comboBoxEventType.Sorted = true;
            this.comboBoxEventType.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Event:";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(62, 262);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(162, 21);
            this.comboBoxFormat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Format:";
            // 
            // subscribeButton
            // 
            this.subscribeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subscribeButton.Enabled = false;
            this.subscribeButton.Location = new System.Drawing.Point(642, 230);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(85, 23);
            this.subscribeButton.TabIndex = 9;
            this.subscribeButton.Text = "&Subscribe";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // textBoxSendTo
            // 
            this.textBoxSendTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSendTo.Location = new System.Drawing.Point(62, 237);
            this.textBoxSendTo.Name = "textBoxSendTo";
            this.textBoxSendTo.Size = new System.Drawing.Size(428, 20);
            this.textBoxSendTo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Send To:";
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unsubscribeButton.Enabled = false;
            this.unsubscribeButton.Location = new System.Drawing.Point(642, 260);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(85, 23);
            this.unsubscribeButton.TabIndex = 10;
            this.unsubscribeButton.Text = "&Unsubscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.deleteSubscriptionButton_Click);
            // 
            // buildButton
            // 
            this.buildButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buildButton.Location = new System.Drawing.Point(602, 8);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(127, 23);
            this.buildButton.TabIndex = 2;
            this.buildButton.Text = "Expression &Builder...";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExpression.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpression.Location = new System.Drawing.Point(8, 37);
            this.textBoxExpression.Multiline = true;
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(721, 167);
            this.textBoxExpression.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Expression:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 522);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(755, 400);
            this.Name = "MainForm";
            this.Text = "Event Subscription Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.contextMenuSubscription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
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
        private System.Windows.Forms.ComboBox comboBoxEventType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.TextBox textBoxSendTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuSubscription;
        private System.Windows.Forms.ToolStripMenuItem unsubscribeToolStripMenuItem;
        private System.Windows.Forms.TextBox tfsCollectionTextBox;
        private System.Windows.Forms.ColumnHeader columnHeaderTag;
        private System.Windows.Forms.ComboBox comboBoxSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeaderSchedule;


    }
}