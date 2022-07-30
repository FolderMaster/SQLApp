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
        public CommandControl()
        {
            InitializeComponent();
        }

        private void UpdateData(DataSet dataSet)
        {
            TabControl.TabPages.Clear();
            for (int n = 0; n < dataSet.Tables.Count; ++n)
            {
                DataGridView dataGridView = new DataGridView();
                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.DataSource = dataSet.Tables[n];
                dataGridView.Dock = DockStyle.Fill;

                TabPage tabPage = new TabPage((n + 1).ToString());
                tabPage.Controls.Add(dataGridView);

                TabControl.TabPages.Add(tabPage);
            }
        }

        private void CommmandExecute()
        {
            try
            {
                UpdateData(SqlManager.ExecuteDataAdapter(TextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            CommmandExecute();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CommmandExecute();
            }
        }
    }
}