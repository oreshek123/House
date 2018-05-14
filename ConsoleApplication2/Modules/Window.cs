using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interface;

namespace ConsoleApplication2.Modules
{
    public class Window:IPart
    {
        public string Name { get; set; }
        public DateTime? StartWork { get; set; } = null;
        public DateTime? EndWork { get; set; } = null;
        public int Priority { get; set; }
        public string Color { get; set; }
        public string Manufacture { get; set; }
        //public bool IsStart { get; set; } = false;
    }
}
