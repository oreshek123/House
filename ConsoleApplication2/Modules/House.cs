using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interface;


namespace ConsoleApplication2.Modules
{
    public class House
    {
        public List<Basement> Basements{get;set;}
        public List<Window> Windows { get; set; }
        public List<Door> Doors { get; set; }
        public List<Roof> Roofs { get; set; }
        public List<Wall> Walls { get; set; }

        public List<IPart> PartsHouse = new List<IPart>();
        public int Parts;
        public void CreateHousePlan()
        {
            Random random = new Random();
            
            for (int i = 0; i < random.Next(1,10); i++)
            {
                IPart w = new Basement();
                w.Name = "Basement";
                w.Priority = 0;
                PartsHouse.Add(w);
            }

            for (int i = 0; i < random.Next(1, 10); i++)
            {
                IPart w = new Window();
                w.Name = "Window";
                w.Priority = 3;
                PartsHouse.Add(w);
            }

            for (int i = 0; i < random.Next(1, 10); i++)
            {
                IPart w = new Door();
                w.Name = "Door";
                w.Priority = 2;
                PartsHouse.Add(w);
            }

            for (int i = 0; i < random.Next(1, 10); i++)
            {
                IPart w = new Wall();
                w.Name = "Wall";
                w.Priority = 1;
                PartsHouse.Add(w);
            }

            for (int i = 0; i < random.Next(1, 10); i++)
            {
                IPart w = new Roof();
                w.Name = "Roof";
                w.Priority = 4;
                PartsHouse.Add(w);
            }


            Parts = PartsHouse.Count;
        }

    }
}
