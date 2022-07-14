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
    public partial class SelectTableContol : UserControl
    {
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
                        ComboBox.DataSource = SqlManager.GetSchema(ConnectionBuilder).AsEnumerable().Select(s => s["TABLE_NAME"].ToString()).ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBoxManager.ShowError(ex.Message);
                    }
                }
            }
        }

        public string NameCurrentTable { get; private set; }

        public event EventHandler NameCurrentTableChanged;

        public SelectTableContol()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameCurrentTable = ComboBox.SelectedItem.ToString();

            NameCurrentTableChanged?.Invoke(this, EventArgs.Empty);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox.DataSource = SqlManager.GetSchema(ConnectionBuilder).AsEnumerable().Select(s => s["TABLE_NAME"].ToString()).ToList();
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
