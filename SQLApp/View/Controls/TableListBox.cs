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
    public partial class TableListBox : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<string> _tableNameList = new List<string>();

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

                if (_connectionBuilder != null)
                {
                    try
                    {
                        NameTableList = SqlManager.GetSchema(_connectionBuilder).AsEnumerable().Select(s => s["TABLE_NAME"].ToString()).ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBoxManager.ShowError(ex.Message);
                    }
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> NameTableList
        {
            get
            {
                return _tableNameList;
            }
            private set
            {
                _tableNameList = value;
                _bindingSource.DataSource = _tableNameList;
            }
        }

        public List<string> SelectedTableNames
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

        public TableListBox()
        {
            InitializeComponent();

            ListBox.DataSource = _bindingSource;
        }
    }
}
