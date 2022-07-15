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
    public partial class TableListControl : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<string> _nameTableList = new List<string>();

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

                if(_connectionBuilder != null)
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
                return _nameTableList;
            }
            set
            {
                _nameTableList = value;
                _bindingSource.DataSource = _nameTableList;

                if (_nameTableList.Count > 0)
                {
                    SelectedIndex = 0;
                }
            }
        }

        public string SelectedNameTable
        {
            get
            {
                if (ComboBox.SelectedIndex == -1)
                {
                    return null;
                }
                else
                {
                    return NameTableList[SelectedIndex];
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

                SelectedNameTableChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler SelectedNameTableChanged;

        public TableListControl()
        {
            InitializeComponent();

            _bindingSource.DataSource = NameTableList;
            ComboBox.DataSource = _bindingSource;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedNameTableChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlManager.ExecuteDataAdapter(ConnectionBuilder, form.Command);

                    NameTableList.Add(form.NameTable);
                    _bindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBoxManager.ShowError(ex.Message);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ComboBox.SelectedIndex != -1)
            {
                TableForm form = new TableForm(SelectedNameTable);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        NameTableList[SelectedIndex] = form.NameTable;
                        _bindingSource.ResetBindings(false);

                        SelectedNameTableChanged?.Invoke(this, EventArgs.Empty);
                    }
                    catch(Exception ex)
                    {
                        MessageBoxManager.ShowError(ex.Message);
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ComboBox.SelectedIndex != -1)
            {
                try
                {
                    SqlManager.ExecuteDataAdapter(ConnectionBuilder, "DROP TABLE " + SelectedNameTable + ";");

                    NameTableList.RemoveAt(SelectedIndex);
                    _bindingSource.ResetBindings(false);

                    SelectedNameTableChanged?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBoxManager.ShowError(ex.Message);
                }
            }
        }
    }
}