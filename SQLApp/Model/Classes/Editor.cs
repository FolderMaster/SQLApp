using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp.Model.Classes
{
    public class Editor<T>
    {
        protected List<T> _removedList = new List<T>();

        protected List<T> _addedList = new List<T>();

        protected List<T> _modifiedList = new List<T>();

        protected List<T> _formerList = new List<T>();

        public virtual string Command
        {
            get;
        }

        public Editor()
        {
        }

        protected virtual bool Compare(T a, T b)
        {
            return Comparer<T>.Default.Compare(a, b) == 0;
        }

        public virtual void Remove(T item)
        {
            int indexAddedColumn = _addedList.FindIndex(a => Compare(a, item));
            int indexModifiedColumn = _modifiedList.FindIndex(a => Compare(a, item));
            if (indexAddedColumn != -1)
            {
                _addedList.RemoveAt(indexAddedColumn);
            }
            else if (indexModifiedColumn != -1)
            {
                _formerList.RemoveAt(indexModifiedColumn);
                _modifiedList.RemoveAt(indexModifiedColumn);
            }
            else
            {
                _removedList.Add(item);
            }
        }

        public virtual void Add(T item)
        {
            _addedList.Add(item);
        }

        public virtual void Edit(T formerItem, T modifiedItem)
        {
            if(Compare(formerItem, modifiedItem))
            {
                int indexAddedColumn = _addedList.FindIndex(a => Compare(a, formerItem));
                int indexModifiedColumn = _modifiedList.FindIndex(a => Compare(a, formerItem));
                if (indexAddedColumn != -1)
                {
                    _addedList[indexAddedColumn] = modifiedItem;

                }
                else if (indexModifiedColumn != -1)
                {
                    _modifiedList[indexModifiedColumn] = modifiedItem;
                }
                else
                {
                    _formerList.Add(formerItem);
                    _modifiedList.Add(modifiedItem);
                }
            }
        }
    }
}
