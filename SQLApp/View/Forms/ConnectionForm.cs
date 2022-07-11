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

using SQLApp.View.Controls;

namespace SQLApp.View.Forms
{
    public partial class ConnectionForm : Form
    {
        public SqlConnectionStringBuilder ConnectionBuilder { get; private set; }

        public ConnectionForm()
        {
            InitializeComponent();
        }

        public ConnectionForm(SqlConnectionStringBuilder connetionBuilder)
        {
            InitializeComponent();

            EditorConnectionControl.ConnectionBuilder = connetionBuilder;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(EditorConnectionControl.ConnectionBuilder.ConnectionString))
                {
                    connection.Open();
                    MessageBoxManager.ShowInformation(connection.State.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ConnectionBuilder = EditorConnectionControl.ConnectionBuilder;
        }
    }
}
