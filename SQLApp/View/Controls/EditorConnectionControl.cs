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

namespace SQLApp.View.Controls
{
    public partial class EditorConnectionControl : UserControl
    {
        private SqlConnectionStringBuilder _connectionBuilder = new SqlConnectionStringBuilder();
        public SqlConnectionStringBuilder ConnectionBuilder
        {
            get
            {
                return _connectionBuilder;
            }
            set
            {
                _connectionBuilder = value;
                DataSourceTextBox.Text = _connectionBuilder.DataSource;
                UserTextBox.Text = _connectionBuilder.UserID;
                PasswordTextBox.Text = _connectionBuilder.Password;
            }
        }

        public event EventHandler ConnectionBuilderChanged;

        public EditorConnectionControl()
        {
            InitializeComponent();
        }

        private void DataSourceTextBox_TextChanged(object sender, EventArgs e)
        {
            ConnectionBuilder.DataSource = DataSourceTextBox.Text;

            ConnectionBuilderChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            ConnectionBuilder.UserID = UserTextBox.Text;

            ConnectionBuilderChanged?.Invoke(this, EventArgs.Empty);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ConnectionBuilder.Password = PasswordTextBox.Text;

            ConnectionBuilderChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}