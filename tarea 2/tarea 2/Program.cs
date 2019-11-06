using System;

namespace Prueva_numero_1
{
    class Program
    {
        static void Main(string[] args)
        {

            float num1 = 0;
            float num2 = 0;
            float suma = 0;
            float resta = 0;
            float multiplicacion = 0;
            float division = 0;
            bool haceroperaciones = true;


            Console.WriteLine("ingrese un numero");
            num1 = float.Parse(Console.ReadLine());

            if (num1 < 0)
            {

                haceroperaciones = false;
                Console.WriteLine("No se puede");
                Console.ReadLine();

            }

            else
            {


                Console.WriteLine("ingrese otro numero");
                num2 = float.Parse(Console.ReadLine());


                if (num2 < 0)
                {

                    haceroperaciones = false;
                    Console.WriteLine("No se puede bro");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("La suma los dos numeros es");

                    suma = num1 + num2;

                    Console.WriteLine(suma);
                    Console.ReadLine();


                    Console.WriteLine("La resta los dos numeros es");

                    resta = num1 - num2;

                    Console.WriteLine(resta);
                    Console.ReadLine();


                    Console.WriteLine("La multiplicacion los dos numeros es");

                    multiplicacion = num1 * num2;

                    Console.WriteLine(multiplicacion);
                    Console.ReadLine();


                    Console.WriteLine("La division los dos numeros es");


                    division = num1 / num2;

                    Console.WriteLine(division);
                    Console.ReadLine();

                }




            }
        }
    }
}