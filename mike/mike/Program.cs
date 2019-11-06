using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mike
{
    class Program
    {
        static void Main(string[] args)
        {
            int mike = 0;
           
            for (int i = 0; i== mike; i++)
            {
                Console.WriteLine("Que escribo?");
                string mikes = Console.ReadLine();
                Console.WriteLine("Cuantas veces?");
                mike = int.Parse(Console.ReadLine());
            }
            
            Console.ReadKey();
        }
    }
}
