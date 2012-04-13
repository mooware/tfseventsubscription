using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EventSubscriptionTool;

// TFS dependencies
using Microsoft.TeamFoundation.Proxy;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.Client;

namespace EventSubscriptionTool
{
    public partial class XPathBuilderForm : Form
    {
        public XPathBuilderForm()
        {

            Shared.FormSharedData = "";

            this.Font = SystemInformation.MenuFont;
            InitializeComponent();
            //Shared.PopulateServer(serverListComboBox);
            //eventComboBox.SelectedIndex = 13;

            // Clear the grid view
            fieldValueDataGridView.Rows.Clear();

            //Object[] projectRow = { PortfolioProject, NewValue, "=", projectsComboBox.Text };
            //fieldValueDataGridView.Rows.Add(projectRow);
        }

        #region "Generate Expression"
        enum Val
        {
            New = 0,
            Old = 1,
            NewOrOld = 2
        }

        private StringBuilder xPathExpression;
        private const string StringFieldPath = "\"CoreFields/StringFields/Field[ReferenceName='";
        private const string IntegerFieldPath = "\"CoreFields/IntegerFields/Field[ReferenceName='";
        private const string NewValuePath = "']/NewValue\"";
        private const string OldValuePath = "']/OldValue\"";
        private const string OperatorAnd = " AND ";
        private const string OperatorOr = " OR ";
        private const string NewValue = "New Value";
        private const string OldValue = "Old Value";
        private const string NewOrOldValue = "New or Old Value";
        private const char ValueSeparator = ',';

        // Special fields
        private const string SystemIdField = "System.Id";
        private const string PortfolioProject = "PortfolioProject";

        // Special operators
        //private const string OperatorContains = "contains";

        // Special functions
        //private const string FunctionContains = "contains";

        private void GenerateExpressionButton_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void Generate()
        {
            xPathExpression = new StringBuilder();

            int rowCount = fieldValueDataGridView.RowCount;

            // Check if the last row is empty if it is don't use it
            if (fieldValueDataGridView.Rows[rowCount - 1].Cells[0].Value == null ||
                fieldValueDataGridView.Rows[rowCount - 1].Cells[1].Value == null ||
                fieldValueDataGridView.Rows[rowCount - 1].Cells[2].Value == null ||
                fieldValueDataGridView.Rows[rowCount - 1].Cells[3].Value == null)
            {
                rowCount--;
            }

            for (int i = 0; i < rowCount; i++)
            {
                // Make sure data was entered into each column for this row
                if (fieldValueDataGridView.Rows[i].Cells[0].Value == null ||
                    fieldValueDataGridView.Rows[i].Cells[1].Value == null ||
                    fieldValueDataGridView.Rows[i].Cells[2].Value == null ||
                    fieldValueDataGridView.Rows[i].Cells[3].Value == null)
                {
                    //MessageBox.Show("Some columns are empty, please fix and try again.");
                    return;
                }

                if (String.IsNullOrEmpty(fieldValueDataGridView.Rows[i].Cells[0].Value.ToString().Trim()) ||
                    String.IsNullOrEmpty(fieldValueDataGridView.Rows[i].Cells[1].Value.ToString().Trim()) ||
                    String.IsNullOrEmpty(fieldValueDataGridView.Rows[i].Cells[2].Value.ToString().Trim()))
                {
                    // MessageBox.Show("Some columns are empty, please fix and try again.");
                    return;
                }

                // Determine if this field is a string field or integer field
                // Currently the only system field includes is System.Id that is an integer
                bool stringField = true;
                if (string.Compare(fieldValueDataGridView.Rows[i].Cells[0].Value.ToString(), SystemIdField) == 0)
                {
                    stringField = false;
                }

                // Determine if we are testing for "NewValue", "OldValue" or both
                // Default to new value
                Val newOldvalue = Val.New;

                // If it's a old value use "OldValue"
                if (string.Compare(fieldValueDataGridView.Rows[i].Cells[1].Value.ToString(), OldValue) == 0)
                {
                    newOldvalue = Val.Old;
                }

                // If it's a new or old value then construct an "OR" clause
                else if (string.Compare(fieldValueDataGridView.Rows[i].Cells[1].Value.ToString(), NewOrOldValue) == 0)
                {
                    newOldvalue = Val.NewOrOld;
                }

                // Build the expression
                string field = fieldValueDataGridView.Rows[i].Cells[0].Value.ToString();
                string expressionOperator = fieldValueDataGridView.Rows[i].Cells[2].Value.ToString();
                string value = fieldValueDataGridView.Rows[i].Cells[3].Value.ToString();

                // Look for the separator in the value, this is how we will do an "OR" on the field
                string[] values = value.Split(ValueSeparator);
                for (int j = 0; j < values.Length; j++)
                {
                    // If it's the first value and there are greater than 1 values then add an opening bracket
                    if (j == 0 && values.Length > 1)
                    {
                        xPathExpression.Append("(");
                    }
                    /*
                    // If it's a special string expression generate it
                    // If this is a special string operator
                    if (expressionOperator.CompareTo(OperatorContains) == 0)
                    {
                        if (!stringField)
                        {
                            MessageBox.Show("String functions can only be used on string fields.");
                            return;
                        }
                        xPathExpression.Append(GenerateSpecialStringExpression(field, values[j], FunctionContains, newOldvalue));
                    }*/

                    xPathExpression.Append(GenerateExpression(field, values[j], expressionOperator, newOldvalue, stringField));

                    // If there are more than one value add an or between clauses except the last one
                    if (values.Length > 1)
                    {
                        // If it's the last value add a closing bracket
                        if (j == values.Length - 1)
                        {
                            xPathExpression.Append(")");
                        }
                        else
                        {
                            // Otherwise add an "OR" to separate the expressions
                            xPathExpression.Append(OperatorOr);
                        }
                    }
                }

                // If it's not the last expression item then add an "AND"
                if (i < rowCount - 1)
                {
                    xPathExpression.Append(OperatorAnd);
                }
            }

            textBoxExpression.Text = xPathExpression.ToString();
        }

        string GenerateExpression(
            string field,               // Field reference name
            string value,               // Value of field
            string expressionOperator,  // Operator to apply to value
            Val newOldvalue,    // Are we looking for new/old value or both
            bool stringField)           // String field or Integer field
        {
            StringBuilder expression = new StringBuilder();

            // If this field is the portfolio project we ignore the new/old value and just compose the
            // expression "PortfolioProject" = 'project'
            if (field.CompareTo(PortfolioProject) == 0)
            {
                return "\"" + PortfolioProject + "\" " + expressionOperator + " '" + value + "'";
            }
            
            // If we are testing for both new and old value need to combine in brackets
            if (newOldvalue == Val.NewOrOld)
            {
                expression.Append("(");
            }

            // If it's a string field use the string field path otherwise integer field path
            if (stringField)
            {
                expression.Append(StringFieldPath);
            }
            else
            {
                expression.Append(IntegerFieldPath);
            }

            expression.Append(field);

            // If we are testing for both new and old value or New Value the first clause will be New value
            if (newOldvalue == Val.NewOrOld || newOldvalue == Val.New)
            {
                expression.Append(NewValuePath);
            }
            else
            {
                expression.Append(OldValuePath);
            }

            expression.Append(" ");
            expression.Append(expressionOperator);
            expression.Append(" ");

            // If it's string field put single quotes around value
            if (stringField)
            {
                expression.Append("'");
            }

            expression.Append(value);

            // If it's string field put single quotes around value
            if (stringField)
            {
                expression.Append("'");
            }

            // If we are testing for both new and old then add the "OR" section
            // If we are testing for both new and old value need to combine in brackets
            if (newOldvalue == Val.NewOrOld)
            {
                expression.Append(OperatorOr);

                // If it's a string field use the string field path otherwise integer field path
                if (stringField)
                {
                    expression.Append(StringFieldPath);
                }
                else
                {
                    expression.Append(IntegerFieldPath);
                }

                expression.Append(field);
                expression.Append(OldValuePath);
                expression.Append(" ");
                expression.Append(expressionOperator);
                expression.Append(" ");

                // If it's string field put single quotes around value
                if (stringField)
                {
                    expression.Append("'");
                }

                expression.Append(value);
                if (stringField)
                {
                    expression.Append("'");
                }
                expression.Append(")");
            }

            return expression.ToString();
        }

        /*
        string GenerateSpecialStringExpression(
            string field,               // Field reference name
            string value,               // Value of field
            string function,            // Operator to apply to value
            NewOldValue newOldvalue)    // Are we looking for new/old value or both
        {
            StringBuilder expression = new StringBuilder();

            // If this field is the portfolio project we ignore the new/old value and just compose the
            // expression "PortfolioProject" = 'project'
            if (field.CompareTo(PortfolioProject) == 0)
            {
                expression.Append(function);
                expression.Append("(\"");
                expression.Append(PortfolioProject);
                expression.Append("\", '");
                expression.Append(value);
                expression.Append("')");
                return expression.ToString();
            }

            // If we are testing for both new and old value need to combine in brackets
            if (newOldvalue == NewOldValue.NewOrOldValue)
            {
                expression.Append("(");
            }

            // If this is a special string operator
            expression.Append(function);
            expression.Append("(");
            expression.Append(StringFieldPath);
            expression.Append(field);

            // If we are testing for both new and old value or New Value the first clause will be New value
            if (newOldvalue == NewOldValue.NewOrOldValue || newOldvalue == NewOldValue.NewValue)
            {
                expression.Append(NewValuePath);
            }
            else
            {
                expression.Append(OldValuePath);
            }

            expression.Append(", '");
            expression.Append(value);
            expression.Append("')");          
           
            // If we are testing for both new and old then add the "OR" section
            // If we are testing for both new and old value need to combine in brackets
            if (newOldvalue == NewOldValue.NewOrOldValue)
            {
                expression.Append(OperatorOr);

                expression.Append(function);
                expression.Append("(");
                expression.Append(StringFieldPath);
                expression.Append(field);
                expression.Append(OldValuePath);                
                expression.Append(", '");
                expression.Append(value);
                expression.Append("'))");
            }

            return expression.ToString();
        }*/
        #endregion

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fieldValueDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Generate();
        }

        private void fieldValueDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Generate();
        }

        private void fieldValueDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Generate();
        }

        private void fieldValueDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void UseExpressionButton_Click(object sender, EventArgs e)
        {
            Shared.FormSharedData = textBoxExpression.Text;
            this.Close();
        }
    
    }


}