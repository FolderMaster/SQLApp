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
    public partial class CommandControl : UserControl
    {
        private DataSet DataSet
        {
            set
            {
                TabControl.TabPages.Clear();
                for (int n = 0; n < value.Tables.Count; ++n)
                {
                    DataGridView dataGridView = new DataGridView();
                    dataGridView.DataSource = value.Tables[n];
                    dataGridView.Dock = DockStyle.Fill;

                    TabPage tabPage = new TabPage((n + 1).ToString());
                    tabPage.Controls.Add(dataGridView);

                    TabControl.TabPages.Add(tabPage);
                }
            }
        }

        public SqlConnectionStringBuilder ConnectionBuilder { get; set; } = null;

        public CommandControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionBuilder.ConnectionString))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(TextBox.Text, connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    DataSet = dataSet;
                }
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
