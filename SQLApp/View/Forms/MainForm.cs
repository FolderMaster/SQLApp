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

using SQLApp.View.Controls;
using SQLApp.Model.Classes;

namespace SQLApp.View.Forms
{
    public partial class MainForm : Form
    {
        private string _filePath = "Settings.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<SqlConnectionStringBuilder> connectionBuilderList = FileManager.Load<List<SqlConnectionStringBuilder>>(_filePath);
                if (connectionBuilderList != null)
                {
                    ConnectionListControl.ConnectionBuilderList = connectionBuilderList;
                }
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FileManager.Save(ConnectionListControl.ConnectionBuilderList, _filePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }

        private void ConnectionListControl_ConnectionChanged(object sender, EventArgs e)
        {
            EditorValueOfTableControl.UpdateConnection();
            EditorRightsControl.UpdateConnection();
        }
    }
}
