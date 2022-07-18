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
                    dataGridView.ReadOnly = true;
                    dataGridView.AllowUserToAddRows = false;
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
                DataSet = SqlManager.ExecuteDataAdapter(ConnectionBuilder, TextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}