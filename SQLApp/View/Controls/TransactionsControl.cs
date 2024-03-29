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
    public partial class TransactionsControl : UserControl
    {
        public TransactionsControl()
        {
            InitializeComponent();
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlManager.ExecuteDataAdapter("COMMIT;");
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void RollbackButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlManager.ExecuteDataAdapter("ROLLBACK;");
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void SavePointButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlManager.ExecuteDataAdapter("SAVEPOINT MySavePoint;");
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
