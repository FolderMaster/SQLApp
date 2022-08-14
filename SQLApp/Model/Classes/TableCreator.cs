using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp.Model.Classes
{
    public class TableCreator
    {
        private List<Column> _columns = new List<Column>();

        public string TableName { get; set; }

        public string String
        {
            get
            {
                Validator.IsNotNullOrEmpty(TableName);
                string result = CommandManager.CreateTable + " " + TableName + "(";
                List<string> columnStrings = new List<string>();
                foreach (Column column in _columns)
                {
                    string columnString = column.Name + " " + column.Type;
                    if (!column.IsNull)
                    {
                        columnString += " " + CommandManager.NotNull;
                    }
                    if (column.IsPrimaryKey)
                    {
                        columnString += " " + CommandManager.PrimaryKey;
                    }
                    if (!string.IsNullOrEmpty(column.DefaultValue))
                    {
                        columnString += " " + CommandManager.Default + " " + column.DefaultValue;
                    }
                    columnStrings.Add(columnString);
                }
                result += string.Join(",", columnStrings) + ");";
                return result;
            }
        }

        public TableCreator()
        {
        }
    }
}
