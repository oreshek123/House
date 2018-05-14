using ConsoleApplication2.Interface;
using ConsoleApplication2.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Ctroika ctroika = new Ctroika();
            ctroika.startCt();
            Paint();
            Console.ReadLine();
        }

        static void Paint()
        {
            Console.WriteLine("                  +++++++++                    ");
            Thread.Sleep(800);
            Console.WriteLine("              ++++++++++++++++++               ");
            Thread.Sleep(800);
            Console.WriteLine("         +++++++++++++++++++++++++++++         ");
            Thread.Sleep(800);
            Console.WriteLine("     ++++++++++++++++++++++++++++++++++++++    ");
            Thread.Sleep(800);
            Console.WriteLine("   +++++++++++++++++++++++++++++++++++++++++   ");
            Thread.Sleep(800);
            Console.WriteLine("  |-----------------------------------------|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |*************______________**__________**|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |*************|------------|**|        |**|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |*************|------------|**|        |**|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |*************|------------|**|        |**|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |*************|------------|**|        |**|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |*************|------------|**|________|**|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |*************|------------|**************|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |*************|____________|**************|  ");
            Thread.Sleep(800);
            Console.WriteLine("  |-----------------------------------------|  ");

        }
    }
}
