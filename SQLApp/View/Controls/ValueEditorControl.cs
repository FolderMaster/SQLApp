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
                command += " " + _condition.String;
            }
            if(!_sorting.IsEmpty)
            {
                command += " " + _sorting.String;
            }
            command += ";";

            try
            {
                DataGridView.DataSource = SqlManager.ExecuteDataAdapter(command).Tables[0];

            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void TableListControl_SelectedNameTableChanged(object sender, EventArgs e)
        {
            _condition.Clear();
            _sorting.Clear();
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

        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorManager.AddColor;
        }

        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            MessageBoxManager.ShowInformation(e.RowIndex.ToString());
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
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

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}