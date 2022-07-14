using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp.View.Controls
{
    public partial class TableListControl : UserControl
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

                if (_connectionBuilderList.Count > 0)
                {
                    SelectedIndex = 0;
                }
            }
        }

        public SqlConnectionStringBuilder SelectedTable
        {
            get
            {
                if (ComboBox.SelectedIndex == -1)
                {
                    return null;
                }
                else
                {
                    return ConnectionBuilderList[ComboBox.SelectedIndex];
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

                SelectedTableChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler SelectedTableChanged;

        public TableListControl()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
