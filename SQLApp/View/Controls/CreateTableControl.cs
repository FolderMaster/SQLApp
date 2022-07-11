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

            ((DataGridViewComboBoxColumn)DataGridView.Columns["TypeColumn"]).DataSource = Enum.GetNames(typeof(SqlType));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionBuilder.ConnectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand(CreateCommand(), connection);
                    MessageBoxManager.ShowInformation(sqlCommand.ExecuteNonQuery().ToString());
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
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                result += (string)row.Cells["NameColumn"].Value + " " + (string)row.Cells["TypeColumn"].Value;
                if(row.Cells["NullColumn"].Value == null)
                {
                    result += " NOT NULL";
                }
                if ((string)row.Cells["DefaultColumn"].Value != null)
                {
                    result += " DEFAULT " + (string)row.Cells["DefaultColumn"].Value;
                }
                result += ",";
            }
            result += ");";
            return result;
        }
    }
}
