using System.Collections.Generic;

namespace SQLApp.Model.Classes
{
    public class Sorting
    {
        private List<string> _columns = new List<string>();

        private List<Mode> _modes = new List<Mode>();

        public bool IsEmpty
        {
            get
            {
                return _columns.Count == 0;
            }
        }

        public string String
        {
            get
            {
                string result = "";
                List<string> strings = new List<string>();
                for (int n = 0; n < _columns.Count; ++n)
                {
                    strings.Add(_columns[n] + " " + _modes[n]);
                }
                result = string.Join(", ", strings);
                if(result.Length > 0)
                {
                    result = CommandManager.OrderBy + " " + result;
                }
                return result;
            }
        }

        public Sorting()
        {
        }
        
        public void Add(string column, Mode mode)
        {
            _columns.Add(column);
            _modes.Add(mode);
        }

        public void Clear()
        {
            _columns.Clear();
            _modes.Clear();
        }

        public enum Mode
        {
            ASC,
            DESC
        }
    }
}
