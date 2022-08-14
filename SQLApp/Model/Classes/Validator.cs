using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp.Model.Classes
{
    public static class Validator
    {
        public static void IsNotNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }
        }

        public static void IsNotEqual<T>(T a, T b)
        {
            if (Comparer<T>.Default.Compare(a, b) == 0)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
