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

        private List<string> _tableNameList = new List<string>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> TableNameList
        {
            get
            {
                return _tableNameList;
            }
            private set
            {
                _tableNameList = value;
                _bindingSource.DataSource = _tableNameList;

                if (_tableNameList.Count > 0)
                {
                    SelectedIndex = 0;
                }
            }
        }

        public string SelectedTableName
        {
            get
            {
                if (ComboBox.SelectedIndex == -1)
                {
                    return null;
                }
                else
                {
                    return TableNameList[SelectedIndex];
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

            _bindingSource.DataSource = TableNameList;
            ComboBox.DataSource = _bindingSource;
        }

        public void UpdateList()
        {
            try
            {
                TableNameList = SqlManager.GetSchema("Tables", null).AsEnumerable().Select(s => s["TABLE_NAME"].ToString()).ToList();
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
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
                    SqlManager.ExecuteDataAdapter(form.Command);

                    TableNameList.Add(form.TableName);
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
                TableForm form = new TableForm(SelectedTableName);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SqlManager.ExecuteDataAdapter(form.Command);

                        TableNameList[SelectedIndex] = form.TableName;
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
                    SqlManager.ExecuteDataAdapter("DROP TABLE " + SelectedTableName + ";");

                    TableNameList.RemoveAt(SelectedIndex);
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