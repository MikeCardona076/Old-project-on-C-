using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ejerccicio. Pedir al usuario nombre, telefono, direccion, edad, profesion, sexo, nacionalidad.
// validar Si es menor de edad
// Ingresarb sexo, solo acepte F o M y desplegar femenino o masculino 
// desplegar toda la informacion ql final
// si no ingresa nacionalidad mexicana desplegar extreanjero'
//Poner todos los datos al final 

namespace tercera_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            float numero = 0;
            string dir = "";
            float edad = 0;
            string pro = "";
            string sexo = "";
            string nat = "";
            string mex = "Mexicano";

            Console.WriteLine("Ingresa tu nombre");
            nombre = (Console.ReadLine());

            Console.WriteLine("Ingresa tu numero");
            numero = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu direccion");
            dir = (Console.ReadLine());

            Console.WriteLine("Ingresa tu edad");
            edad = float.Parse(Console.ReadLine());
            if (edad < 17)
            {
                Console.WriteLine("Eres menor de edad prro");
                Console.ReadLine();

            }


            Console.WriteLine("Ingresa tu profesion");
            pro = (Console.ReadLine());

            Console.WriteLine("Ingresa tu sexo");
            sexo = (Console.ReadLine());
            if (sexo == "m")
            {
                sexo = "Eres  Macho";

            }
            else if(sexo == "f")
            {
                
                
                    sexo = "Eres  Mujer";

                


            }

            Console.WriteLine("Ingresa tu nacionalidad");
            nat = (Console.ReadLine());
            if (nat == "mexicano")
            {
                sexo = "Eres  Macho y eres mexicano";

            }
            else 
            {


                nat = "Eres  extranjero";




            }


            Console.WriteLine(nombre);
            Console.WriteLine(numero);
            Console.WriteLine(dir);
            Console.WriteLine(edad);
            Console.WriteLine(pro);
            Console.WriteLine(sexo);
            Console.WriteLine(nat);

            Console.ReadLine();

        }
        //nombre.ToString());
    }
}
