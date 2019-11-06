using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mostrar al usuario un listado de operaciones
// Suma
//Resta
//Division
//multiplicacion
//mayor
//menor
//El usuario elegira una opcion del menu y dependiendo  de la seleccion hara la operacion mostrando el siguiente resultado



namespace tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float suma = 0;
            float resta = 0;
            float division = 0;
            float multi = 0;
            float mayor = 0;
            float menor = 0;
            float numero1 = 0;
            float numero2 = 0;
            bool operacion = false;
            float mike = 0;

            Console.WriteLine("*******************************");
            Console.WriteLine(" 1 Suma");
            Console.WriteLine(" 2 Restar");
            Console.WriteLine(" 3 Division");
            Console.WriteLine(" 4 Multiplicacion");
            Console.WriteLine(" 5 Mayor");
            Console.WriteLine(" 6 Menor");
            Console.WriteLine("*******************************");
            Console.WriteLine("Ingresa un numero");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            numero2 = float.Parse(Console.ReadLine());

            if (numero1 < 0)
            {
                operacion = false;
                Console.WriteLine("No se puede");
                Console.ReadLine();
                return;
            }
            else
            {
                if (numero2 < 0)
                {
                    operacion = false;
                    Console.WriteLine("No se puede");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Ingresa la operacion");
            mike = float.Parse(Console.ReadLine());

            if(mike>6)
            {
                Console.WriteLine("Ingresaste un numero que no es valido, por favor, lee bien prro");
                Console.ReadLine();


            }
            


            Console.WriteLine("*******************************");
          if (mike==1)
            {
                Console.WriteLine("Operacion ingresada");
                Console.WriteLine("Suma");
                Console.WriteLine("Primer numero");
                Console.WriteLine(numero1);
                Console.WriteLine("Segundo numero");
                Console.WriteLine(numero2);
                Console.WriteLine("Resultado");
                mike = numero1 + numero2;
                Console.WriteLine(mike);
                Console.ReadLine();
            }
            else
            {
                if(mike==2)
                {
                    Console.WriteLine("Operacion ingresada");
                    Console.WriteLine("Resta");
                    Console.WriteLine("Primer numero");
                    Console.WriteLine(numero1);
                    Console.WriteLine("Segundo numero");
                    Console.WriteLine(numero2);
                    Console.WriteLine("Resultado");
                    mike = numero1 - numero2;
                    Console.WriteLine(mike);
                }
                Console.ReadLine();
            }
            if (mike == 3)
            {
                Console.WriteLine("Operacion ingresada");
                Console.WriteLine("Division");
                Console.WriteLine("Primer numero");
                Console.WriteLine(numero1);
                Console.WriteLine("Segundo numero");
                Console.WriteLine(numero2);
                Console.WriteLine("Resultado");
                mike = numero1 / numero2;
                Console.WriteLine(mike);
                Console.ReadLine();
            }
            else
            {
                if (mike == 4)
                {
                    Console.WriteLine("Operacion ingresada");
                    Console.WriteLine("Multiplicacion");
                    Console.WriteLine("Primer numero");
                    Console.WriteLine(numero1);
                    Console.WriteLine("Segundo numero");
                    Console.WriteLine(numero2);
                    Console.WriteLine("Resultado");
                    mike = numero1 * numero2;
                    Console.WriteLine(mike);
                    
                }
                Console.ReadLine();
            }
            if (numero1 < numero2)
            {
                Console.WriteLine("Operacion ingresada");
                Console.WriteLine("Menor");
                Console.WriteLine("Primer numero");
                Console.WriteLine(numero1);
                Console.WriteLine("Segundo numero");
                Console.WriteLine(numero2);
                Console.WriteLine("Resultado");
                Console.WriteLine("Este numero es menor " + numero1);
                Console.ReadLine();
            }
            else
            {
                if (numero2 < numero1)
                {
                    Console.WriteLine("Operacion ingresada");
                    Console.WriteLine("Menor");
                    Console.WriteLine("Primer numero");
                    Console.WriteLine(numero1);
                    Console.WriteLine("Segundo numero");
                    Console.WriteLine(numero2);
                    Console.WriteLine("Resultado");
                    Console.WriteLine("Este numero es menor " + numero2);
                }
                Console.ReadLine();
            }
            if (numero1 > numero2)
            {
                Console.WriteLine("Operacion ingresada");
                Console.WriteLine("Mayor");
                Console.WriteLine("Primer numero");
                Console.WriteLine(numero1);
                Console.WriteLine("Segundo numero");
                Console.WriteLine(numero2);
                Console.WriteLine("Resultado");
                Console.WriteLine("Este numero es mas grande " + numero1);
                Console.ReadLine();
            }
            else
            {
                if (numero2 > numero1)
                {
                    Console.WriteLine("Operacion ingresada");
                    Console.WriteLine("Mayor");
                    Console.WriteLine("Primer numero");
                    Console.WriteLine(numero1);
                    Console.WriteLine("Segundo numero");
                    Console.WriteLine(numero2);
                    Console.WriteLine("Resultado");
                    Console.WriteLine("Este numero es mas grande " + numero2);
                }
                Console.ReadLine();
            }
        }

    }
}
