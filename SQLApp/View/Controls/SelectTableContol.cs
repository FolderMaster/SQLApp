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
    public partial class SelectTableContol : UserControl
    {
        private SqlConnectionStringBuilder _connectionBuilder = null;
        public SqlConnectionStringBuilder ConnectionBuilder
        {
            get
            {
                return _connectionBuilder;
            }
            set
            {
                _connectionBuilder = value;

                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionBuilder.ConnectionString))
                    {
                        connection.Open();

                        ComboBox.DataSource = connection.GetSchema("Tables").AsEnumerable().Select(s => s["TABLE_NAME"].ToString()).ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxManager.ShowError(ex.Message);
                }
            }
        }

        public SelectTableContol()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {

        }
    }
}
