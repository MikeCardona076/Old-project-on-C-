using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    class Program
    {
        static void Main(string[] args)
        {
            int   nip=1234 , cuenta=0, recarga=0, nuevo=0, Nip=0, telefono=0, rec=0, opcion=0;
          double dinero = 0, saldo1 = 1000, mike= 0;
         string com="";
            string l= "Incorrecto";
            double monto=0;
          long claveinterbancaria=0;
           // int recarga= [ 1, 2, 3];

          //La variable Mike es la opcion que elije el usuario
        	do
            {
         
           
                  try 
	              {	      
                     Console.WriteLine("CAJERO MIKE");  
                     Console.WriteLine("Ingresa el nip");   
		             Nip= int.Parse(Console.ReadLine());
                   
	              }
                    catch
              {  }
                Console.WriteLine(" Nip Incorrecto. No se permiten letras y sólo deben ser 4 números. NO SEAS PENDEJO ");
               
                
              
            } while (Nip!=nip);
          
                do
                {        
                     Console.Clear();
                 Console.WriteLine("CAJERO MIKE");  

                 Console.WriteLine("Bienvenido Loco\n" + 
                                              "\n 1.Consulta de saldo" +
                                              "\n 2.Retiro"+
                                              "\n 3.Deposito" +
                                              "\n 4.Transferencia de Saldo"+
                                              "\n 5. Compra de tiempo aire" +
                                              "\n 6.Consulta de Nip" +
                                              "\n 7.Cambiar Nip"+
                                              "\n 8.Salir"
                                              );
                                                  
                                         Console.WriteLine("Escoge una opcion");
                                        try{mike= Convert.ToByte(Console.ReadLine());
                       }
                                           catch{Console.WriteLine("Escoge una opcion valida");}
                                       /*Aqui empieza una serie de elecciones del usuario*/
                                        switch(mike)
                                        {
                                          case 1:
                                          Console.Clear();
                                           // Consulta de saldo
                                              Console.WriteLine("Tu saldo es " + saldo1+"$");
                                          break;


                                          case 2:
                                          Console.Clear();
                                           // Retiro de saldo
                                                Console.WriteLine("Tienes " + saldo1+"$"+"\n Cuanto deseas retirar");
                                             try{
                                               dinero= int.Parse(Console.ReadLine());
	                                          if(dinero>=saldo1)
                                              {
                                               Console.WriteLine("No puedes retirar dinero que no tienes");
                                               
                                               } 
                                              else
                                                {
                                                 saldo1 = saldo1-dinero;
                                              Console.WriteLine("Tu saldo es "+saldo1+"$");
                                                    }
                                              }
                                              catch (Exception error)
                                                { Console.WriteLine("No se pueden poner letras");}
                                             
                                          break;
                                         // Deposito
                                          case 3:
                                           Console.Clear();
		                                       Console.WriteLine("Tienes " + saldo1+"$"+"\n Cuanto deseas Depositar");
                                               try{ dinero= int.Parse(Console.ReadLine());
                                                if(dinero>=5000)
                                                {
                                                Console.WriteLine("No se permiten depositos de 5000 mil pesos o mayores" );                             
                                                }
                                                else
                                                {
		                                              saldo1= saldo1+dinero;
                                                      Console.WriteLine("Tu saldo es "+saldo1+"$");
                                                }}
                                                catch{Console.WriteLine("No puedes poner letras guey");}
                                              
                                          break;
                                          case 4:
                                          Console.Clear();
                                             // Transferencia de saldo
                                             do
                                              {  
                                                 try{ 
                                                    Console.WriteLine("Ingresa la clave interbancaria");
                                                     //Utilice la variable LONG para resolver este problema
                                                  claveinterbancaria= long.Parse(Console.ReadLine());
                                                   if(claveinterbancaria.ToString().Length != 12)
                                                    Console.WriteLine("Debe tener solo 12 numeros"); 
                                                 
                                                    }                                                                           
                                                 catch{Console.WriteLine("No debe de contener letras");}
                                                      
                                             }
                                               
                                            while(claveinterbancaria.ToString().Length != 12);
                                               Console.Clear();
                                              do            
                                              {
                                               
                                                try{ Console.WriteLine("Ingrese el Monto a transferir");
                                                    monto= Double.Parse( Console.ReadLine());}
                                                catch{ Console.WriteLine("No se permiten letras prro");}
                                                
                                               }  
                                              // No sé porque razón esta línea de código funciona!
                                               while(monto <=0);
                                  
                                             
                                     
                                                Console.WriteLine("Desea transferir el monto "+monto+" a la cuenta "+ claveinterbancaria);
                                                 Console.WriteLine("1 SI");
                                                 Console.WriteLine("2 NO");
                                                   opcion= int.Parse(Console.ReadLine());
                                                   
                                                  switch(opcion)
                                                  {   
                                                   case 1:
                                                         if(monto>saldo1)
                                                  {Console.WriteLine("Saldo insuficiente");}
                                                         else
                                                     { saldo1= saldo1-monto;
                                                      Console.WriteLine("SE HA HECHO LA TRANSFERENCIA. Tu saldo es "+saldo1+"$");}
                                                       
                                                    break;
                                                    case 2:
                                                     
                                                   break;
                                


                                                  }                                            
                                          break;
                                          case 5:
                                          Console.Clear();
                                            // Compra de saldo
                                          
                                             do
	                                           { 
                                                    try{
                                                            Console.WriteLine("Ingrese el celular");
                                                            telefono= int.Parse(Console.ReadLine());
                                                          //Esto te permite solo ingresar 10 numeros 
                                                            if(telefono.ToString().Length != 10)
                                                                Console.WriteLine("Telefono Debe contener solo 10 digitos");
                                                        }
                                                    catch{Console.WriteLine("NO ES VALIDO");}
                            
                                               }
                                              while (telefono.ToString().Length != 10);
                                         do{Console.WriteLine("Escoge la recarga: 1. 100$   2. 200$    3. 500$");
                                          try{ rec= int.Parse(Console.ReadLine());}
                                        catch{Console.WriteLine("No puedes poner letras");}

                                                    switch(rec)
                                           {
                                                case 1: saldo1= saldo1-100;
                                                   Console.WriteLine("RECARGA HECHA SALDO "+ saldo1+"$");
                                           break;
                                                case 2: saldo1= saldo1-200;
                                              Console.WriteLine("RECARGA HECHA SALDO "+ saldo1+"$");
                                                   break;
                                              case 3: saldo1=saldo1-500;
                                                       Console.WriteLine("RECARGA HECHA SALDO "+ saldo1+"$");
                                            break;
                                           }
	                                      

                                            }
                                         while(rec==0);

                                     
                                          break;
                                          case 6:
                                            Console.Clear();
                                          // Consulta de Nip
                                               Console.WriteLine("Tu Nip es "+ nip);
                                           break;
                                           case 7:
                                            Console.Clear();
                                          // Cambio de Nip
                                                Console.WriteLine("Vas a cambiar tu nip. Ingresa el nuevo Nip");
                                              nip = int.Parse(Console.ReadLine());
                                               
                                     
                                                    do{
                                                      try{Console.WriteLine("Ingresa el nip guardado");
                                                      Nip = int.Parse(Console.ReadLine());}
                                                     catch{}
                                                   }
                                                   while(nip!=Nip);
                                                      
                                                 
                        
                                                  
                                                  Console.WriteLine("NIP CORRECTO ENTER PARA IRSE DE AQUI");
                                                   
	                                               
                                           
                          
                                                       Console.ReadKey();
                                          break;
                                          case 8:
                                         // Salir del programa 
                                          Environment.Exit(0);
                                          break;
                                         Console.ReadKey();      
                                        
                                        }
                Console.ReadKey();
              Console.Clear();
                
                }while(mike!=8);
                
	
         
       
        
    
            
        }
        
    }
}

                   

             

           

