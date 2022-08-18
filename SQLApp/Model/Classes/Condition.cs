using System;
using System.Collections.Generic;

namespace SQLApp.Model.Classes
{
    public class Condition
    {
        private List<bool> _areNot = new List<bool>();

        private List<string> _columns = new List<string>();

        private List<Operation> _operations = new List<Operation>();

        private List<string> _values = new List<string>();

        private List<Conjunction> _conjunctions = new List<Conjunction>();

        public string Command
        {
            get
            {
                string result = "";
                for(int n = 0; n < _columns.Count; ++n)
                {
                    if (_areNot[n])
                    {
                        result += CommandManager.Not + " ";
                    }
                    result += _columns[n] + " " + OperationToString(_operations[n]) + " "
                        + _values[n];
                    if (n < _conjunctions.Count)
                    {
                        result += " " + _conjunctions[n] + " ";
                    }
                }
                if(result.Length > 0)
                {
                    result = CommandManager.Where + " " + result;
                }
                return result;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return _areNot.Count == 0;
            }
        }

        public Condition()
        {
        }

        public void Start(bool isNot, string column, Operation operation, string value)
        {
            if(!IsEmpty)
            {
                throw new MethodAccessException();
            }
            else
            {
                _areNot.Add(isNot);
                _columns.Add(column);
                _operations.Add(operation);
                _values.Add(value);
            }
        }

        public void Add(Conjunction conjunction, bool isNot, string column, Operation operation,
            string value)
        {
            if (IsEmpty)
            {
                throw new EntryPointNotFoundException();
            }
            else
            {
                _conjunctions.Add(conjunction);
                _areNot.Add(isNot);
                _columns.Add(column);
                _operations.Add(operation);
                _values.Add(value);
            }
        }

        public void Clear()
        {
            _areNot.Clear();
            _columns.Clear();
            _operations.Clear();
            _values.Clear();
            _conjunctions.Clear();
        }

        public static string OperationToString(Operation operation)
        {
            string result = "";
            switch (operation)
            {
                case Operation.Equal:
                    result +=  CommandManager.Equal;
                    break;
                case Operation.NotEqual:
                    result += CommandManager.NotEqual;
                    break;
                case Operation.More:
                    result += CommandManager.More;
                    break;
                case Operation.MoreOrEqual:
                    result += CommandManager.MoreOrEqual;
                    break;
                case Operation.Less:
                    result += CommandManager.Less;
                    break;
                case Operation.LessOrEqual:
                    result += CommandManager.LessOrEqual;
                    break;
                case Operation.Like:
                    result += CommandManager.Like;
                    break;
            }
            return result;
        }

        public enum Operation
        {
            Equal,
            NotEqual,
            More,
            MoreOrEqual,
            Less,
            LessOrEqual,
            Like
        }

        public enum Conjunction
        {
            AND,
            OR
        }
    }
}
