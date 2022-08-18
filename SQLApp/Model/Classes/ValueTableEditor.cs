using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp.Model.Classes
{
    public class ValueTableEditor: Editor<Row>
    {
        public string TableName { get; set; }

        public override string Command 
        {
            get
            {
                Validator.IsNotNullOrEmpty(TableName);
                string result = "";

                foreach (Row row in _removedList)
                {
                    List<string> conditions = new List<string>();
                    foreach(KeyValuePair<string, string> pair in row.Data)
                    {
                        conditions.Add(string.Join(" ", pair.Key, CommandManager.Equal, pair.Value));
                    }
                    result += string.Join(" ", CommandManager.Delete, CommandManager.From, TableName,
                        CommandManager.Where, string.Join(" " + CommandManager.And + " ", conditions))
                        + ";";
                }

                for(int n = 0; n < _formerList.Count; ++n)
                {
                    Row formerRow = _formerList[n];
                    Row modifiedRow = _modifiedList[n];

                    List<string> sets = new List<string>();
                    foreach(KeyValuePair<string, string> pair in modifiedRow.Data)
                    {
                        if (pair.Value != formerRow.Data[pair.Key])
                        {
                            sets.Add(string.Join(" ", pair.Key, CommandManager.Equal, pair.Value));
                        }
                    }

                    List<string> conditions = new List<string>();
                    foreach (KeyValuePair<string, string> pair in formerRow.Data)
                    {
                        conditions.Add(string.Join(" ", pair.Key, CommandManager.Equal, pair.Value));
                    }

                    result += string.Join(" ", CommandManager.Update, TableName,
                        CommandManager.Set, string.Join(",", sets), CommandManager.Where,
                        string.Join(" " + CommandManager.And + " ", conditions)) + ";";
                }

                foreach(Row row in _addedList)
                {
                    result += string.Join(" ", CommandManager.InsertInto, TableName,
                        string.Join(",", row.Data.Keys), CommandManager.Values,
                        string.Join(",", row.Data.Values)) + ";";
                }

                return result;
            }
        }

        public ValueTableEditor()
        {
        }

        protected override bool Compare(Row a, Row b)
        {
            return a == b;
        }
    }
}
