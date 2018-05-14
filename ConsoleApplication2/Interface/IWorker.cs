using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Interface
{
    public enum Category
    {
        Worker, TeamLeader
    }
    public interface IWorker
    {
        string Name { get; set; }
        double Salary { get; set; }
        Category Category { get; set; }
        List<IPart> jobs { get; set; }
        void PrintReport(List<IPart> parts);
    }
}
