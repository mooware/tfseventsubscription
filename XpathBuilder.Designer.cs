namespace SubscriptionManager
{
    partial class XPathBuilderForm
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
            this.fieldValueDataGridView = new System.Windows.Forms.DataGridView();
            this.FieldNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnNewOldValue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UseExpressionButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fieldValueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldValueDataGridView
            // 
            this.fieldValueDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldValueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldValueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldNameColumn,
            this.ColumnNewOldValue,
            this.OperatorColumn,
            this.ValueColumn});
            this.fieldValueDataGridView.Location = new System.Drawing.Point(12, 12);
            this.fieldValueDataGridView.Name = "fieldValueDataGridView";
            this.fieldValueDataGridView.Size = new System.Drawing.Size(591, 184);
            this.fieldValueDataGridView.TabIndex = 1;
            this.fieldValueDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.fieldValueDataGridView_UserAddedRow);
            this.fieldValueDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.fieldValueDataGridView_UserDeletedRow);
            this.fieldValueDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.fieldValueDataGridView_CurrentCellDirtyStateChanged);
            this.fieldValueDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldValueDataGridView_CellValueChanged);
            // 
            // FieldNameColumn
            // 
            this.FieldNameColumn.HeaderText = "Field Name";
            this.FieldNameColumn.Items.AddRange(new object[] {
            "PortfolioProject",
            "System.AreaPath",
            "System.AssignedTo",
            "System.AuthorizedAs",
            "System.ChangedBy",
            "System.ChangedDate",
            "System.Id",
            "System.IterationPath",
            "System.OpenedBy",
            "System.Reason",
            "System.State",
            "System.Title",
            "System.WorkItemType"});
            this.FieldNameColumn.Name = "FieldNameColumn";
            this.FieldNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FieldNameColumn.Sorted = true;
            this.FieldNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FieldNameColumn.Width = 150;
            // 
            // ColumnNewOldValue
            // 
            this.ColumnNewOldValue.HeaderText = "New\\Old Value";
            this.ColumnNewOldValue.Items.AddRange(new object[] {
            "New Value",
            "Old Value",
            "New or Old Value"});
            this.ColumnNewOldValue.Name = "ColumnNewOldValue";
            this.ColumnNewOldValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNewOldValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnNewOldValue.Width = 120;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.HeaderText = "Operator";
            this.OperatorColumn.Items.AddRange(new object[] {
            "=",
            "<>",
            "<",
            "<=",
            ">",
            ">="});
            this.OperatorColumn.Name = "OperatorColumn";
            this.OperatorColumn.Width = 75;
            // 
            // ValueColumn
            // 
            this.ValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExpression.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpression.Location = new System.Drawing.Point(12, 220);
            this.textBoxExpression.Multiline = true;
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(591, 156);
            this.textBoxExpression.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Note: Values can be comma separated to \"OR\" the values";
            // 
            // UseExpressionButton
            // 
            this.UseExpressionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UseExpressionButton.Location = new System.Drawing.Point(398, 377);
            this.UseExpressionButton.Name = "UseExpressionButton";
            this.UseExpressionButton.Size = new System.Drawing.Size(124, 23);
            this.UseExpressionButton.TabIndex = 11;
            this.UseExpressionButton.Text = "&Use This Expression";
            this.UseExpressionButton.UseVisualStyleBackColor = true;
            this.UseExpressionButton.Click += new System.EventHandler(this.UseExpressionButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(528, 377);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // XPathBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 412);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.UseExpressionButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.fieldValueDataGridView);
            this.MinimumSize = new System.Drawing.Size(540, 375);
            this.Name = "XPathBuilderForm";
            this.Text = "XPath Expression Builder";
            ((System.ComponentModel.ISupportInitialize)(this.fieldValueDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fieldValueDataGridView;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewComboBoxColumn FieldNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnNewOldValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.Button UseExpressionButton;
        private System.Windows.Forms.Button closeButton;
    }
}

