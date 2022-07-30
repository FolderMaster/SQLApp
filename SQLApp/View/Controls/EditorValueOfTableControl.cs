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
    public partial class EditorValueOfTableControl : UserControl
    {
        public EditorValueOfTableControl()
        {
            InitializeComponent();
        }

        public void UpdateConnection()
        {
            TableListControl.UpdateList();
        }

        private void TableListControl_SelectedNameTableChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView.DataSource = SqlManager.ExecuteDataAdapter("SELECT * FROM " + TableListControl.SelectedTableName + ";").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView.DataSource = SqlManager.ExecuteDataAdapter("SELECT * FROM " + TableListControl.SelectedTableName + " WHERE " + ";").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void CreateConditionButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
