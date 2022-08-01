using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hladanie_značiek
{
    public class Car
    {
        public readonly int LicencePlate;

        public string Ovner { get; set; }

        public bool Theft { get; set; }


        public Car(int licenceplate, string ovner)
        {
            LicencePlate = licenceplate;
            Ovner = ovner;
            Theft = false;

        }

        public void ReportTheft()
        {
            Theft = true;
        }

        public void ReportFindCar()
        {
            Theft = false;
        }

        public override string ToString()
        {
            return LicencePlate + ' ' + Ovner + ' ' + Theft;
        }
    }
}

