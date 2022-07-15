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
        private SqlConnectionStringBuilder _connectionBuilder = null;

        public DataTable DataTable
        {
            set
            {
                DataGridView.DataSource = value;
            }
        }

        public EditorValueOfTableControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
        }
    }
}
