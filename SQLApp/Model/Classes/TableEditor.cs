using System.Collections.Generic;
using System.Linq;

namespace SQLApp.Model.Classes
{
    public class TableEditor
    {
        private List<string> _removedColumns = new List<string>();

        private List<Column> _addedColumns = new List<Column>();

        private List<Column> _modifiedColumns = new List<Column>();

        private List<Column> _formerColumns = new List<Column>();

        public string TableName { get; set; }

        public string String
        {
            get
            {
                Validator.IsNotNullOrEmpty(TableName);
                string result = "";
                foreach(string columnName in _removedColumns)
                {
                    result += string.Join(" ", CommandManager.AlterTable, TableName,
                        CommandManager.DropColumn, columnName) + ";";
                }

                foreach(Column column in _addedColumns)
                {

                }
                return result;
            }
        }

        public TableEditor()
        {
        }

        public void Remove(string tableName)
        {
            _removedColumns.Add(tableName);

            _addedColumns.Remove(_addedColumns.First(a => a.Name == tableName));
            _modifiedColumns.Remove(_modifiedColumns.Find(a => a.Name == tableName));
            _formerColumns.Remove(_formerColumns.Find(a => a.Name == tableName));
        }

        public void Add(Column column)
        {
            _addedColumns.Add(column);

            _removedColumns.Remove(column.Name);
        }

        public void Edit(Column formerColumn, Column modifiedColumn)
        {
            int indexAddedColumn = _addedColumns.FindIndex(a => a.Name == formerColumn.Name);
            int indexModifiedColumn = _modifiedColumns.FindIndex(a => a.Name == formerColumn.Name);
            if (indexAddedColumn != -1)
            {
                _addedColumns[indexAddedColumn] = modifiedColumn;

            }
            else if(indexModifiedColumn != -1)
            {
                _modifiedColumns[indexModifiedColumn] = modifiedColumn;
            }
            else
            {
                _formerColumns.Add(formerColumn);
                _modifiedColumns.Add(modifiedColumn);
            }
        }
    }
}
