using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interface;

namespace ConsoleApplication2.Modules
{
    public class TeamLeader:IWorker
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Category Category { get; set; } = Category.TeamLeader;
        public List<IPart> jobs { get; set; }

        public void PrintReport(List<IPart> parts)
        {
            foreach (IPart item in parts.OrderBy(o => o.Priority))
            {
                Console.WriteLine("Name : {0} Start: {1} End : {2}\n", item.Name, item.StartWork, item.EndWork);
            }

            Console.WriteLine($" Quantity of parts {parts.Count}");
        }
    }
}
