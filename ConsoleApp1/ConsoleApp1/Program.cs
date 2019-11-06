using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        
            class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("La Matriz a resolver");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("| X11 X12 X13 | T1 ");
                Console.WriteLine("| X21 X22 X23 | T2 ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor de X11");
                double x11 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + " X12 X13 | T1 ");
                Console.WriteLine("| X21 X22 X23 | T2 ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor de X12");
                double x12 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + " X13 | T1 ");
                Console.WriteLine("| X21 X22 X23 | T2 ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor de X13");
                double x13 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | T1 ");
                Console.WriteLine("| X21 X22 X23 | T2 ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor T1");
                double t1 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("| X21 X22 X23 | T2 ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor X21");
                double x21 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + " X22 X23 | T2 ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor X22");
                double x22 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + " X23 | T2 ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor X23");
                double x23 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | T2 ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor T2");
                double t2 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("| X31 X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor X31");
                double x31 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + " X32 X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor X32");
                double x32 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + " X33 | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor X33");
                double x33 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | T3 ");
                Console.WriteLine(" ---           ---");
                Console.WriteLine("Ingresa el valor T3");
                double t3 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | " + t3 + " ");
                Console.WriteLine(" ---           ---");

                Console.Clear();
                Console.WriteLine("Tu matriz esta lista 🙂");
                Console.WriteLine(x11 + "x + " + +x12 + "y + " + x13 + "z = " + t1);
                Console.WriteLine(x21 + "x + " + +x22 + "y + " + x23 + "z = " + t2);
                Console.WriteLine(x31 + "x + " + +x32 + "y + " + x33 + "z = " + t3);
                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | " + t3 + " ");
                Console.WriteLine(" ---           ---");
                double divi = x11;
                //aqui transformamos el valor de x11 en 1
                if (x11 > 0)
                {
                    x11 = (x11 / divi);
                    x12 = (x12 / divi);
                    x13 = (x13 / divi);
                    t1 = (t1 / divi);
                }
                if (x11 < 0)
                {
                    x11 = (x11 / divi);
                    x12 = (x12 / divi);
                    x13 = (x13 / divi);
                    t1 = (t1 / divi);
                }
                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | " + t3 + " ");
                Console.WriteLine(" ---           ---");
                double multi = x21;
                //aqui transformacion el valor x21 en 0
                if (x21 != 0)
                {
                    if (x21 < 0)
                    {
                        x21 = (multi * x11) - x21;
                        x22 = (multi * x12) - x22;
                        x23 = (multi * x13) - x23;
                        t2 = (multi * t1) - t2;
                    }
                    if (x21 > 0)
                    {
                        x21 = (-multi * x11) + x21;
                        x22 = (-multi * x12) + x22;
                        x23 = (-multi * x13) + x23;
                        t2 = (-multi * t1) + t2;
                    }
                }

                multi = x31;
                //aqui transformamos x31 en 0
                if (x31 != 0)
                {
                    if (x31 < 0)
                    {
                        x31 = (multi * x11) - x31;
                        x32 = (multi * x12) - x32;
                        x33 = (multi * x13) - x33;
                        t3 = (multi * t1) - t3;
                    }
                    if (x31 > 0)
                    {
                        x31 = (-multi * x11) + x31;
                        x32 = (-multi * x12) + x32;
                        x33 = (-multi * x13) + x33;
                        t3 = (-multi * t1) + t3;
                    }
                }

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | " + t3 + " ");
                Console.WriteLine(" ---           ---");
                double divis = x22;
                //aqui transformamos x22 en 1
                if (x22 > 1)
                {
                    x21 = (x21 / divis);
                    x22 = (x22 / divis);
                    x23 = (x23 / divis);
                    t2 = (t2 / divis);
                }
                if (x22 < 1)
                {
                    x21 = (x21 / divis);
                    x22 = (x22 / divis);
                    x23 = (x23 / divis);
                    t2 = (t2 / divis);
                }

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | " + t3 + " ");
                Console.WriteLine(" ---           ---");
                multi = x32;
                //aqui trasnformamos x32 en 0
                if (x32 != 0)
                {
                    if (x32 < 0)
                    {
                        x31 = (multi * x21) - x31;
                        x32 = (multi * x22) - x32;
                        x33 = (multi * x23) - x33;
                        t3 = (multi * t2) - t3;
                    }
                    if (x32 > 0)
                    {
                        x31 = (-multi * x21) + x31;
                        x32 = (-multi * x22) + x32;
                        x33 = (-multi * x23) + x33;
                        t3 = (-multi * t2) + t3;
                    }
                }

                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | " + t3 + " ");
                Console.WriteLine(" ---           ---");
                divis = x33;
                //aqui dice que si los valores x33 y el t3 son 0 son homogenea
                if (t3 == 0 && x33 == 0)
                {

                }
                else
                {
                    //aqui transformamos el valor x33 en 1
                    if (x33 > 1)
                    {
                        x31 = (x31 / divis);
                        x32 = (x32 / divis);
                        x33 = (x33 / divis);
                        t3 = (t3 / divis);
                    }
                    if (x33 < 1)
                    {
                        x31 = (x31 / divis);
                        x32 = (x32 / divis);
                        x33 = (x33 / divis);
                        t3 = (t3 / divis);
                    }
                }
                Console.WriteLine(" ---           ---");
                Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | " + t3 + " ");
                Console.WriteLine(" ---           ---");

                Console.WriteLine(x11 + "x " + "+ " + x12 + "y " + "+ " + x13 + "z " + "= " + t1);
                Console.WriteLine(x22 + "y " + "+ " + x23 + "z " + "= " + t2);
                Console.WriteLine(x33 + "z " + "= " + t3);

                Console.WriteLine(" ---           ---");
                double z = t3;
                Console.WriteLine("Z = " + z);
                double y = t2 - (x23 * z);
                Console.WriteLine("Y = " + y);
                double x = t1 - ((x12 * y) + (x13 * z));
                Console.WriteLine("X = " + x);
                Console.WriteLine(" ---           ---");

                Console.ReadLine();
            }
            }
    }

