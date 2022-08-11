using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SQLApp.Model.Classes;

namespace SQLApp.View.Forms
{
    public partial class ConditionForm : Form
    {
        public Condition Condition
        {
            get
            {
                return ConditionControl.Condition;
            }
        }

        public ConditionForm(string tableName)
        {
            InitializeComponent();

            ConditionControl.TableName = tableName;
        }
    }
}
