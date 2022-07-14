﻿using System;
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
    public partial class EditTableControl : UserControl
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
            }
        }

        public EditTableControl()
        {
            InitializeComponent();
        }

        private void SelectTableContol_NameCurrentTableChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView.DataSource = SqlManager.ExecuteDataAdapter(ConnectionBuilder, "SELECT * FROM " + ";").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlManager.ExecuteDataAdapter(ConnectionBuilder, "");
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
