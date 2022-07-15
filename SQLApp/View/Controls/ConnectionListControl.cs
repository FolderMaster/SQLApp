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
using SQLApp.View.Forms;

namespace SQLApp.View.Controls
{
    [Serializable]
    public partial class ConnectionListControl : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<SqlConnectionStringBuilder> _connectionBuilderList = new List<SqlConnectionStringBuilder>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<SqlConnectionStringBuilder> ConnectionBuilderList
        {
            get
            {
                return _connectionBuilderList;
            }
            set
            {
                _connectionBuilderList = value;
                _bindingSource.DataSource = _connectionBuilderList;

                if(_connectionBuilderList.Count > 0)
                {
                    SelectedIndex = 0;
                }
            }
        }

        public SqlConnectionStringBuilder SelectedConnectionBuilder
        {
            get
            {
                if(ComboBox.SelectedIndex == -1)
                {
                    return null;
                }
                else
                {
                    return ConnectionBuilderList[SelectedIndex];
                }
            }
        }

        public int SelectedIndex
        {
            get
            {
                return ComboBox.SelectedIndex;
            }
            set
            {
                ComboBox.SelectedIndex = value;

                ConnectionBuilderChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ConnectionBuilderChanged;

        public ConnectionListControl()
        {
            InitializeComponent();

            _bindingSource.DataSource = ConnectionBuilderList;
            ComboBox.DataSource = _bindingSource;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ConnectionForm form = new ConnectionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ConnectionBuilderList.Add(form.ConnectionBuilder);
                _bindingSource.ResetBindings(false);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ComboBox.SelectedIndex != -1)
            {
                ConnectionForm form = new ConnectionForm(SelectedConnectionBuilder);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ConnectionBuilderList[SelectedIndex] = form.ConnectionBuilder;
                    _bindingSource.ResetBindings(false);

                    ConnectionBuilderChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(ComboBox.SelectedIndex != -1)
            {
                ConnectionBuilderList.RemoveAt(SelectedIndex);
                _bindingSource.ResetBindings(false);

                ConnectionBuilderChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionBuilderChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxManager.ShowInformation(SqlManager.ConnectionState(SelectedConnectionBuilder).ToString());
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
