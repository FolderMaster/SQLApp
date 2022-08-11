using SQLApp.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp.View.Forms
{
    public partial class SortForm : Form
    {
        public Sorting Sorting
        {
            get
            {
                return SortingControl.Sorting;
            }
        }

        public SortForm(string tableName)
        {
            InitializeComponent();

            SortingControl.TableName = tableName;
        }
    }
}
