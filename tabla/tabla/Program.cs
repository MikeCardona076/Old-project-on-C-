using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int mike1=0,mike2=0,mikee = 0;
           

            Console.WriteLine("Cual tabla de multiplicar quieres prro");
            mike1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hasta cual tabla de multiplicar quieres prro");
            mike2 = int.Parse(Console.ReadLine());

            for (int contador =1; contador <=mike2; contador++)
           {
                Console.WriteLine(mike1 + "x" + contador + "=" +(mike1* contador));
                
            }
            Console.WriteLine("Ahi esta tu pinche tabla");
         
            Console.ReadKey();

        }
    }
}
 