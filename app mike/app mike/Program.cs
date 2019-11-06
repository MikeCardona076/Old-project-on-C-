using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_mike
{
    class Program
    {
        static void Main(string[] args)
        {

            float numero1 = 0;
            float numero2 = 0;
            float suma = 0;
            float resta = 0;
            float division = 0;
            float multiplicacion = 0;

            Console.WriteLine("Escribe el primer numero");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el primer numero");
            numero2 = float.Parse(Console.ReadLine());
            suma = numero1 + numero2;
            Console.WriteLine(suma);

            resta = numero1 - numero2;
            Console.WriteLine(resta);
            division = numero1 / numero2;
            Console.WriteLine(division);

            multiplicacion = numero1 * numero2;
            Console.WriteLine(multiplicacion);

            Console.Read();
        }
    }
}
