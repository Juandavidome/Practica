using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA
{
    internal class Empleado
    {
        private string FirstName;
        private string LastName;
        private double Document;
        private double Salary;
        private double WorkedDays;
        private double TotalDevengado;
        private double AuxTransport;
        private double Salud;
        private double Pension;

        public Empleado()
        {

        }

        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double Document1 { get => Document; set => Document = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double WorkedDays1 { get => WorkedDays; set => WorkedDays = value; }
        public double AuxTransport1 { get => AuxTransport; set => AuxTransport = value; }
        public double Salud1 { get => Salud; set => Salud = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
        public double TotalDevengado1 { get => TotalDevengado; set => TotalDevengado = value; }
    }
}
