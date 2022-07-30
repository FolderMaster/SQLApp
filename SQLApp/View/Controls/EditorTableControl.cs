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
    public partial class EditorTableControl : UserControl
    {
        private bool _isEditing = false;

        public string TableName
        {
            get
            {
                return TextBox.Text;
            }
            set
            {
                TextBox.Text = value;
                TextBox.ReadOnly = true;
                _isEditing = true;

                try
                {
                    foreach (DataRow row in SqlManager.GetSchema("Columns", null).Select())
                    {
                        DataGridView.Rows.Add((string)row["COLUMN_NAME"], (string)row["DATA_TYPE"], (string)row["IS_NULLABLE"] == "NO", null, row["COLUMN_DEFAULT"]);
                        DataGridView.Rows[DataGridView.Rows.Count - 2].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
                catch(Exception ex)
                {
                    MessageBoxManager.ShowError(ex.Message);
                }
            }
        }

        public string Command
        {
            get
            {
                string result = "";
                if(_isEditing)
                {
                    result = "CREATE TABLE " + TextBox.Text + "(";
                    for (int n = 0; n < DataGridView.Rows.Count - 1; ++n)
                    {
                        result += (string)DataGridView.Rows[n].Cells["NameColumn"].Value + " " + (string)DataGridView.Rows[n].Cells["TypeColumn"].Value;
                        if (DataGridView.Rows[n].Cells["NullColumn"].Value == null)
                        {
                            result += " NOT NULL";
                        }
                        if (DataGridView.Rows[n].Cells["NullColumn"].Value != null)
                        {
                            result += " PRIMARY KEY";
                        }
                        if(!string.IsNullOrEmpty((string)DataGridView.Rows[n].Cells["DefaultColumn"].Value))
                        {
                            result += " DEFAULT " + (string)DataGridView.Rows[n].Cells["DefaultColumn"].Value;
                        }
                        if (n < DataGridView.Rows.Count - 2)
                        {
                            result += ",";
                        }
                    }
                    result += ");";
                }
                else
                {
                    result = "CREATE TABLE " + TextBox.Text + "(";
                    for (int n = 0; n < DataGridView.Rows.Count - 1; ++n)
                    {
                        result += (string)DataGridView.Rows[n].Cells["NameColumn"].Value + " " + (string)DataGridView.Rows[n].Cells["TypeColumn"].Value;
                        if (DataGridView.Rows[n].Cells["NullColumn"].Value == null)
                        {
                            result += " NOT NULL";
                        }
                        if (DataGridView.Rows[n].Cells["NullColumn"].Value != null)
                        {
                            result += " PRIMARY KEY";
                        }
                        if (!string.IsNullOrEmpty((string)DataGridView.Rows[n].Cells["DefaultColumn"].Value))
                        {
                            result += " DEFAULT " + (string)DataGridView.Rows[n].Cells["DefaultColumn"].Value;
                        }
                        if (n < DataGridView.Rows.Count - 2)
                        {
                            result += ",";
                        }
                    }
                    result += ");";
                }
                return result;
            }
        }

        public EditorTableControl()
        {
            InitializeComponent();

            ((DataGridViewComboBoxColumn)DataGridView.Columns["TypeColumn"]).DataSource = Enum.GetNames(typeof(SqlDbType)).Select((s) => s.ToLower()).ToList();
        }
    }
}