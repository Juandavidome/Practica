using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA
{
    
    internal class Datos
    { 
        Empleado Myempleado = new Empleado();
        public void IngresarDatos()
        {
            Console.WriteLine("Ingrese el nombre del Usuario:");
            Myempleado.FirstName1 = (Console.ReadLine());
            Console.WriteLine("Ingrese el apellido del Usuario ");
            Myempleado.LastName1 = (Console.ReadLine());
            Console.WriteLine("Ingrese el documento del Usuario: ");
            Myempleado.Document1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Salario del Usuario: ");
            Myempleado.Salary1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los dias que trabajo el empleado");
            Myempleado.WorkedDays1 = double.Parse(Console.ReadLine());

            Myempleado.TotalDevengado1 = Myempleado.Salary1 / 31;
            Myempleado.TotalDevengado1 = Myempleado.TotalDevengado1 * Myempleado.WorkedDays1;
            Myempleado.AuxTransport1 = 117172 / 30;
            Myempleado.AuxTransport1 = Myempleado.AuxTransport1 * Myempleado.WorkedDays1;
            if (Myempleado.AuxTransport1 < 2000000)
            {
                Myempleado.AuxTransport1 = Myempleado.AuxTransport1 * Myempleado.WorkedDays1;

            }
            else
            {
                Myempleado.AuxTransport1 = Myempleado.AuxTransport1;

            }
            Myempleado.Salud1 = Myempleado.TotalDevengado1 * 0.4;
            Myempleado.Pension1 = Myempleado.TotalDevengado1 * 0.4;

        }
        public void ImprimirDatos()
        {
            Console.WriteLine($"El nombre del usuario es: {Myempleado.FirstName1}");
            Console.WriteLine($"El apellido del usuario es: {Myempleado.LastName1}");
            Console.WriteLine($"El documento del usuario es: {Myempleado.Document1}");
            Console.WriteLine($"El salario del usuario es: {Myempleado.Salary1}");
            Console.WriteLine($"Los dias que trabajo el usuario es: {Myempleado.WorkedDays1}");
            Console.WriteLine($"El salario del tiempo de trabajo es de: {Myempleado.TotalDevengado1}");
            Console.WriteLine($"El auxilio de Tranporte del empleado por los dias trabajados es de : {Myempleado.AuxTransport1}");
            Console.WriteLine($"El pago de salud es de: {Myempleado.Salud1}");
            Console.WriteLine($"El pago de pension es de: {Myempleado.Pension1}");
        }
    }
}
