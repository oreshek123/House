using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interface;

namespace ConsoleApplication2.Modules
{
    public class Worker:IWorker
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Category Category { get; set; } = Category.Worker;
        public List<IPart> jobs { get; set; } = new List<IPart>();
        public void PrintReport(List<IPart> parts){}
    }
}
