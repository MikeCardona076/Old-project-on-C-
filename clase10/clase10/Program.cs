using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10
{
    class Program
    {
        static void Main(string[] args)
        {
            //condiciones anidadas

            int nip = 0;
            string Nip = Console.ReadLine();
            Console.WriteLine("Ingresa Nip");



            if (Nip.Length == 4 && int.TryParse(Console.ReadLine(), out int Nipp))
            {
                Console.WriteLine("El nip es " + Nip);
            }
            else
            {
                Console.WriteLine("No es correcto");
            }
            Console.ReadKey();

        }
    }
}
