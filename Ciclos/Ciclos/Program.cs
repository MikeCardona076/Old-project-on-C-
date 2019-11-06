using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tres tipos de ciclos
            //While
            //DoWhile
            //For

            float suma = 0;
            float promedio = 0;
            float calificacion=0;
       
            for (int contador = 0; contador < 5; contador++)
            {

                do
                {
                Console.WriteLine("Ingresa tu calificacion " + (contador + 1));

                    calificacion = float.Parse(Console.ReadLine());
                    suma = suma + calificacion;
                }
                while (calificacion < 5);
                


            }
            Console.WriteLine("Tu nota final es ");
            promedio = suma / 5;
            Console.WriteLine(promedio);


            Console.ReadLine();
        }
    }
}
