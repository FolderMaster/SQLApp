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
            string command = "SELECT * FROM " + TableListControl.SelectedTableName;
            if (!_condition.IsEmpty)
            {
                command += " WHERE " + _condition.String;
            }
            if(!_sorting.IsEmpty)
            {
                command += " ORDER BY " + _sorting.String;
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
            if (DataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor == ColorManager.ActualColor)
            {
                DataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorManager.UpdateColor;
                DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorManager.CurrentUpdateColor;
            }
            else if (DataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor == ColorManager.UpdateColor)
            {
                DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorManager.CurrentUpdateColor;
            }
        }
    }
}
