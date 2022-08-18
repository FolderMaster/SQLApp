using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using SQLApp.Model.Classes;

namespace SQLApp.View.Controls
{
    public partial class TableEditorControl : UserControl
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
                    foreach (DataRow row in SqlManager.GetSchema(CommandManager.Columns, null)
                        .AsEnumerable().Where(s => s[CommandManager.TableName].ToString() == value))
                    {
                        DataGridView.Rows.Add((string)row[CommandManager.ColumnName],
                            (string)row[CommandManager.DataType],
                            (string)row[CommandManager.IsNullable] == CommandManager.No,
                            null, row[CommandManager.ColumnDefault]);
                        DataGridView.Rows[DataGridView.Rows.Count - 2].DefaultCellStyle.BackColor
                            = ColorManager.ActualColor;
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
                    
                }
                else
                {

                }
                return result;
            }
        }

        public TableEditorControl()
        {
            InitializeComponent();

            TypeColumn.DataSource = Enum.GetNames(typeof(SqlDbType)).Select((s) => s.ToLower()).ToList();
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (_isEditing)
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];
                if (row.DefaultCellStyle.BackColor == ColorManager.ActualColor)
                {
                    row.DefaultCellStyle.BackColor = ColorManager.UpdateColor;
                    row.Cells[e.ColumnIndex].Style.BackColor = ColorManager.CurrentUpdateColor;
                }
                else if (row.DefaultCellStyle.BackColor == ColorManager.UpdateColor)
                {
                    row.Cells[e.ColumnIndex].Style.BackColor = ColorManager.CurrentUpdateColor;
                }
            }
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (_isEditing)
            {
                DataGridView.Rows[DataGridView.Rows.Count - 2].DefaultCellStyle.BackColor
                    = ColorManager.AddColor;
            }
        }

        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (_isEditing)
            {
                MessageBoxManager.ShowInformation(e.RowIndex.ToString());
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor
                = ColorManager.IncorrectColor;
        }
    }
}