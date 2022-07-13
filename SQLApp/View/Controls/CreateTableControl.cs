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

namespace SQLApp.View.Controls
{
    public partial class CreateTableControl : UserControl
    {
        public SqlConnectionStringBuilder ConnectionBuilder { get; set; } = null;

        public CreateTableControl()
        {
            InitializeComponent();

            ((DataGridViewComboBoxColumn)DataGridView.Columns["TypeColumn"]).DataSource = Enum.GetNames(typeof(SqlDbType));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionBuilder.ConnectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand(CreateCommand(), connection);
                }
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private string CreateCommand()
        {
            string result = "CREATE TABLE " + TextBox.Text + "(";
            for(int n = 0; n < DataGridView.Rows.Count - 1; ++n)
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