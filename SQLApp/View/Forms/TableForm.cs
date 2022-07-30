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

namespace SQLApp.View.Forms
{
    public partial class TableForm : Form
    {
        public string TableName
        {
            get
            {
                return EditorTableControl.TableName;
            }
        }

        public string Command
        {
            get
            {
                return EditorTableControl.Command;
            }
        }

        public TableForm()
        {
            InitializeComponent();
        }

        public TableForm(string nameTable)
        {
            InitializeComponent();

            EditorTableControl.TableName = nameTable;
        }
    }
}