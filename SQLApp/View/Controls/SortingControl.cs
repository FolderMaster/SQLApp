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
    public partial class SortingControl : UserControl
    {
        public string TableName
        {
            set
            {
                try
                {
                    ColumnColumn.DataSource = SqlManager.GetSchema("Columns", null).AsEnumerable()
                        .Where(s => s["TABLE_NAME"].ToString() == value)
                        .Select(s => s["COLUMN_NAME"].ToString()).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public Sorting Sorting
        {
            get
            {
                Sorting result = new Sorting();
                for(int n = 0; n < DataGridView.Rows.Count - 1; ++n)
                {
                    DataGridViewRow row = DataGridView.Rows[n];
                    result.Add((string)row.Cells[ColumnColumn.Index].Value,
                        (Sorting.Mode)Enum.Parse(typeof(Sorting.Mode),
                            (string)row.Cells[ModeColumn.Index].Value));
                }
                return result;
            }
        }

        public SortingControl()
        {
            InitializeComponent();

            ModeColumn.DataSource = Enum.GetNames(typeof(Sorting.Mode));
        }
    }
}
