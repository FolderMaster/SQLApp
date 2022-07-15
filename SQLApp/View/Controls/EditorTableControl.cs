using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using SQLApp.Model.Classes;

namespace SQLApp.View.Controls
{
    public partial class EditorTableControl : UserControl
    {
        public SqlConnectionStringBuilder ConnectionBuilder { get; set; } = null;

        public EditorTableControl()
        {
            InitializeComponent();

            ((DataGridViewComboBoxColumn)DataGridView.Columns["TypeColumn"]).DataSource = Enum.GetNames(typeof(SqlDbType));
        }

        public string CreateCommand()
        {
            string result = "CREATE TABLE " + TextBox.Text + "(";
            for (int n = 0; n < DataGridView.Rows.Count - 1; ++n)
            {
                result += (string)DataGridView.Rows[n].Cells["NameColumn"].Value + " " + (string)DataGridView.Rows[n].Cells["TypeColumn"].Value;
                if (DataGridView.Rows[n].Cells["NullColumn"].Value == null)
                {
                    result += " NOT NULL";
                }
                if ((string)DataGridView.Rows[n].Cells["DefaultColumn"].Value != null)
                {
                    result += " DEFAULT " + (string)DataGridView.Rows[n].Cells["DefaultColumn"].Value;
                }
                if (n < DataGridView.Rows.Count - 2)
                {
                    result += ",";
                }
            }
            result += ");";
            return result;
        }
    }
}