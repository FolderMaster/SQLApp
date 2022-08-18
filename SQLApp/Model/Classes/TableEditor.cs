using System.Collections.Generic;
using System.Linq;

namespace SQLApp.Model.Classes
{
    public class TableEditor: Editor<Column>
    {
        public string TableName { get; set; }

        public override string Command
        {
            get
            {
                Validator.IsNotNullOrEmpty(TableName);
                string result = "";

                foreach(Column column in _removedList)
                {
                    result += string.Join(" ", CommandManager.AlterTable, TableName,
                        CommandManager.DropColumn, column.Name) + ";";
                }

                for(int n = 0; n < _modifiedList.Count; ++n)
                {
                    result += string.Join(" ", CommandManager.AlterTable, TableName) + ";";
                }

                result += string.Join(" ", CommandManager.AlterTable, TableName);
                List<string> columnStrings = new List<string>();
                foreach (Column column in _addedList)
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
                result += string.Join(",", columnStrings);

                return result;
            }
        }

        public TableEditor()
        {
        }

        protected override bool Compare(Column a, Column b)
        {
            return a == b;
        }
    }
}
