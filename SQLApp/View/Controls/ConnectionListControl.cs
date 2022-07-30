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

                ComboBox.Text = "";
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

                UpdateConnection();
            }
        }

        public event EventHandler ConnectionChanged;

        public ConnectionListControl()
        {
            InitializeComponent();

            _bindingSource.DataSource = ConnectionBuilderList;
            ComboBox.DataSource = _bindingSource;
        }

        private void UpdateConnection()
        {
            try
            {
                SqlManager.Connect(SelectedConnectionBuilder);
                if(SqlManager.ConnectionState == ConnectionState.Open)
                {
                    MessageBoxManager.ShowInformation("Connection open!");
                    ConnectionChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
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

                    UpdateConnection();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(ComboBox.SelectedIndex != -1)
            {
                ConnectionBuilderList.RemoveAt(SelectedIndex);
                _bindingSource.ResetBindings(false);

                UpdateConnection();
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateConnection();
        }
    }
}
