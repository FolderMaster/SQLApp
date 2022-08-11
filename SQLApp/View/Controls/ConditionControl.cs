using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SQLApp.Model.Classes;
using static SQLApp.Model.Classes.Condition;

namespace SQLApp.View.Controls
{
    public partial class ConditionControl : UserControl
    {

        public string TableName
        {
            set
            {
                try
                {
                    ColumnColumn.DataSource= SqlManager.GetSchema("Columns", null).AsEnumerable()
                        .Where(s => s["TABLE_NAME"].ToString() == value)
                        .Select(s => s["COLUMN_NAME"].ToString()).ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public Condition Condition
        {
            get
            {
                Condition result = new Condition();
                for(int n = 0; n < DataGridView.Rows.Count - 1; ++n)
                {
                    DataGridViewRow curretnRow = DataGridView.Rows[n];
                    if(n == 0)
                    {
                        result.Start((bool)curretnRow.Cells[NotColumn.Index].Value,
                            (string)curretnRow.Cells[ColumnColumn.Index].Value,
                            (Operation)Enum.Parse(typeof(Operation),
                                (string)curretnRow.Cells[OperationColumn.Index].Value),
                            (string)curretnRow.Cells[ValueColumn.Index].Value);
                    }
                    else
                    {
                        DataGridViewRow backRow = DataGridView.Rows[n - 1];
                        result.Add((Conjunction)Enum.Parse(typeof(Conjunction),
                                (string)backRow.Cells[ConjunctionColumn.Index].Value),
                            (bool)curretnRow.Cells[NotColumn.Index].Value,
                            (string)curretnRow.Cells[ColumnColumn.Index].Value,
                            (Operation)Enum.Parse(typeof(Operation),
                                (string)curretnRow.Cells[OperationColumn.Index].Value),
                            (string)curretnRow.Cells[ValueColumn.Index].Value);
                    }
                }
                return result;
            }
        }

        public ConditionControl()
        {
            InitializeComponent();

            OperationColumn.DataSource = Enum.GetNames(typeof(Operation));
            ConjunctionColumn.DataSource = Enum.GetNames(typeof(Conjunction));
        }
    }
}
