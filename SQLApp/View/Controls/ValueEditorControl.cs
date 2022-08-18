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

using SQLApp.View.Forms;
using SQLApp.Model.Classes;

namespace SQLApp.View.Controls
{
    public partial class ValueEditorControl : UserControl
    {
        private Condition _condition = new Condition();

        private Sorting _sorting = new Sorting();

        private ValueTableEditor _valueTableEditor = new ValueTableEditor();

        private Row _formerRow = new Row();

        private bool _isUpdating = true;

        public ValueEditorControl()
        {
            InitializeComponent();
        }

        public void UpdateConnection()
        {
            TableListControl.UpdateList();
        }

        private void UpdateTable()
        {
            string command = CommandManager.SelectAll + " " + CommandManager.From
                + " " + TableListControl.SelectedTableName;
            if (!_condition.IsEmpty)
            {
                command += " " + _condition.Command;
            }
            if(!_sorting.IsEmpty)
            {
                command += " " + _sorting.Command;
            }
            command += ";";

            _isUpdating = true;
            try
            {
                DataGridView.DataSource = SqlManager.ExecuteDataAdapter(command).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
            _isUpdating = false;
            
        }

        private Row GetRow(DataGridViewRow dgvRow)
        {
            Row row = new Row();
            foreach (DataGridViewCell cell in dgvRow.Cells)
            {
                if(cell.Value != null)
                {
                    row.Data.Add(cell.OwningColumn.Name, cell.Value.ToString());
                }
            }
            return row;
        }

        private void TableListControl_SelectedNameTableChanged(object sender, EventArgs e)
        {
            _condition.Clear();
            _sorting.Clear();

            _valueTableEditor.TableName = TableListControl.SelectedTableName;

            UpdateTable();
        }

        private void ConditionButton_Click(object sender, EventArgs e)
        {
            ConditionForm form = new ConditionForm(TableListControl.SelectedTableName);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _condition = form.Condition;
                UpdateTable();
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            SortForm form = new SortForm(TableListControl.SelectedTableName);
            if(form.ShowDialog() == DialogResult.OK)
            {
                _sorting = form.Sorting;
                UpdateTable();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView.DataSource = SqlManager.ExecuteDataAdapter(_valueTableEditor.Command).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
            UpdateTable();
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow dgvRow = DataGridView.Rows[e.RowIndex];
            if (_isUpdating)
            {
                dgvRow.DefaultCellStyle.BackColor = ColorManager.ActualColor;
            }
        }

        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(!_isUpdating)
            {
                _formerRow = GetRow(DataGridView.Rows[e.RowIndex]);
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isUpdating)
            {
                DataGridViewRow dgvRow = DataGridView.Rows[e.RowIndex];
                Row modifiedRow = GetRow(dgvRow);

                if (_formerRow.Data != modifiedRow.Data)
                {
                    _valueTableEditor.Edit(_formerRow, modifiedRow);

                    if (dgvRow.DefaultCellStyle.BackColor == ColorManager.ActualColor)
                    {
                        dgvRow.DefaultCellStyle.BackColor = ColorManager.UpdateColor;
                        dgvRow.Cells[e.ColumnIndex].Style.BackColor = ColorManager.CurrentUpdateColor;
                    }
                    else if (dgvRow.DefaultCellStyle.BackColor == ColorManager.UpdateColor)
                    {
                        dgvRow.Cells[e.ColumnIndex].Style.BackColor = ColorManager.CurrentUpdateColor;
                    }
                }
            }
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor
                = ColorManager.IncorrectColor;
        }

        private void DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow dgvRow = e.Row;
            Row row = GetRow(dgvRow);

            _valueTableEditor.Add(row);

            dgvRow.DefaultCellStyle.BackColor = ColorManager.AddColor;
        }

        private void DataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = e.Row;
            Row row = GetRow(dgvRow);

            _valueTableEditor.Remove(row);
        }
    }
}