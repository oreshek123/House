using ConsoleApplication2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Modules
{
    public class Ctroika
    {
        public void startCt()
        {
            Console.WriteLine("Стройка началась");
            House house = new House();
            house.CreateHousePlan();

            Team team = new Team();
            team.GenerateWorkers();

            while(house.Parts>0)
            {
                Console.WriteLine(". . .");
                team.WorkJ(ref house.PartsHouse,ref house.Parts);
            }

            Console.WriteLine("----------------------FULL PLAN OF WORK------------------------------");
            
            foreach (IPart part in house.PartsHouse)
            {
                Console.WriteLine($"Name : {part.Name} Start : {part.StartWork} End : {part.EndWork}");
            }
            Console.WriteLine("----------------------------------------------------------------------");


        }
    }
}
