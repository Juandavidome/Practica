using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA
{
    internal class Program
    {
        public static void Main(String[]args)
        {
            Datos MyDatos = new Datos();
            Console.WriteLine("Bienvenido al programa de Nomina");
            Console.WriteLine("1.Si desea agregar un empleado");
            Console.WriteLine("2.Si desea salir del programa");
            string opc = Console.ReadLine();
            int opc1 = 1;

            switch(opc)
            {
                

            
                case "1":
                    {
                        do
                        {


                            MyDatos.IngresarDatos();
                            MyDatos.ImprimirDatos();
                            Console.WriteLine("1.Si desea ingresar otro empleado.");
                            Console.WriteLine("2.Si desea salir del programa");
                            opc1 = int.Parse(Console.ReadLine());
                            Console.Clear();
                        } while (opc1 != 2);
                    break;
                }
            
                case "2":
                    {
                        Console.WriteLine("Saliendo del Programa");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ingreso no Valido");

                        break;
                    }
            }
        }
    }
}

