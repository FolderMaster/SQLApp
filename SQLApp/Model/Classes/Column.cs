using System.Data;

namespace SQLApp.Model.Classes
{
    public class Column
    {
        private string _name = null;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.IsNotNullOrEmpty(value);
                _name = value;
            }
        }

        public SqlDbType Type { get; set; }

        public bool IsNull { get; set; }

        public bool IsPrimaryKey { get; set; }

        public string DefaultValue { get; set; }

        public Column()
        {
        }

        public Column(string name, SqlDbType type, bool isNull, bool isPrimaryKey, string defaultValue)
        {
            Name = name;
            Type = type;
            IsNull = isNull;
            IsPrimaryKey = isPrimaryKey;
            DefaultValue = defaultValue;
        }
    }
}
