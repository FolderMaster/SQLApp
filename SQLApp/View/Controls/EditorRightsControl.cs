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
        public EditorRightsControl()
        {
            InitializeComponent();
        }

        public void UpdateConnection()
        {
            TableListBox.UpdateList();
            UserListBox.UpdateList();
        }

        private void GrantButton_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "GRANT ALL ON " + string.Join(", ", TableListBox.SelectedTableNames) + " TO " + string.Join(", ", UserListBox.SelectedUsers) + ";";
                SqlManager.ExecuteDataAdapter(command);
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
                SqlManager.ExecuteDataAdapter(command);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
