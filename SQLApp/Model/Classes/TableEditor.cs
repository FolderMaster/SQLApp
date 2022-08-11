using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace SQLApp.Model.Classes
{
    public class TableEditor
    {
        public struct Column
        {
            public string Name;

            public SqlDbType Type;

            public bool IsNull;

            public bool IsPrimaryKey;

            public string Value;
        }
    }
}
