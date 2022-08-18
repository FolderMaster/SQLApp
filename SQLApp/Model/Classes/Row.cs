using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SQLApp.Model.Classes
{
    public class Row
    {
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        public Row()
        {
        }
    }
}
