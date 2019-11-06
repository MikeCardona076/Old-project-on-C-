using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapido
{
    class Program
    {
        static void Main(string[] args)
        {
            float area = 0;
            Console.WriteLine("Para obtener el area de un triangulo Ingresa Los datos siguientes");
            Console.WriteLine("....................................");
            Console.WriteLine("Ingresa la Base");
            float bases = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la Base");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("....................................");
            area = bases * altura / 2;
            Console.WriteLine("El area es "+area);
            Console.ReadKey();
        }
    }
}
