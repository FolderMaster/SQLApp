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
    public partial class EditorRightsControl : UserControl
    {
        private SqlConnectionStringBuilder _connectionBuilder = null;

        public SqlConnectionStringBuilder ConnectionBuilder
        {
            set
            {
                _connectionBuilder = UserListBox.ConnectionBuilder = TableListBox.ConnectionBuilder = value;
            }
        }
        public EditorRightsControl()
        {
            InitializeComponent();
        }

        private void GrantButton_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "GRANT ALL ON " + string.Join(", ", TableListBox.SelectedTableNames) + " TO " + string.Join(", ", UserListBox.SelectedUsers) + ";";
                SqlManager.ExecuteDataAdapter(_connectionBuilder, command);
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void RevokeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "REVOKE ALL ON " + string.Join(", ", TableListBox.SelectedTableNames) + " TO " + string.Join(", ", UserListBox.SelectedUsers) + ";";
                SqlManager.ExecuteDataAdapter(_connectionBuilder, command);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
