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
    public partial class UserListBox : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<string> _userList = new List<string>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> UserList
        {
            get
            {
                return _userList;
            }
            private set
            {
                _userList = value;
                _bindingSource.DataSource = _userList;
            }
        }

        public List<string> SelectedUsers
        {
            get
            {
                if (ListBox.SelectedIndex == -1)
                {
                    return null;
                }
                else
                {
                    return ListBox.SelectedItems.Cast<string>().ToList();
                }
            }
        }

        public UserListBox()
        {
            InitializeComponent();

            ListBox.DataSource = _bindingSource;
        }

        public void UpdateList()
        {
            try
            {
                UserList = SqlManager.ExecuteDataAdapter("Select * From Master..SysUsers Where IsSqlUser = 1").Tables[0].AsEnumerable().Select(s => s["NAME"].ToString()).ToList();
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
