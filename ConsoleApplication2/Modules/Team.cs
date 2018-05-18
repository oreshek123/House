using ConsoleApplication2.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Modules
{
    public class Team
    {
        public List<IWorker> Workers { get; set; } = new List<IWorker>();
        private Random random = new Random();
        public void GenerateWorkers()
        {
            for (int i = 0; i < random.Next(3,10); i++)
            {
                        Worker worker = new Worker()
                        {
                            Name = i.ToString()
                        };
                        Workers.Add(worker);
            }
            TeamLeader teamLeader = new TeamLeader()
            {
                Name = "BOSS"
            };
            Workers.Add(teamLeader);
        }
        public void WorkJ(ref List<IPart> parts,ref int part)
        {
            foreach (IPart item in parts.OrderBy(o=> o.Priority))
            {
                int wNum = random.Next(0, Workers.Count);

                if(Workers[wNum].GetType() == (typeof(Worker)))
                {
                    if (item.StartWork == null)
                    {
                        string day = random.Next(1, 32).ToString();
                        string month = random.Next(1, 13).ToString();
                        string year = random.Next(2017, 2019).ToString();
                        if (int.Parse(month) < 10)
                        {
                            month = $"0{month}";
                        }
                        string date = $"{day}-{month}-{year}";
                        DateTime enddate = DateTime.Parse(date).AddDays(random.Next(10,30));
                        DateTime validValue ;
                         
                        item.StartWork = DateTime.TryParse(date, out validValue)? validValue:
                            (DateTime?)null;
                        //item.StartWork = DateTime.Now;
                        item.EndWork = DateTime.TryParse(enddate.ToString(), out validValue) ? validValue :
                            (DateTime?)null;
                        //item.EndWork = DateTime.Now.AddDays(random.Next(1, 30));

                        Workers[wNum].jobs.Add(item);
                        part--;
                        break;
                    }
                }
                else
                {
                    Workers[wNum].PrintReport(parts);
                } 
            }
        }
    }
}
