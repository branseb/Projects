using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hladanie_značiek
{
    public class DatabazaVozidiel
    {
        public List <Car> Cars { get; set; }

        public void AddCar (int licenceplate,string ovner)
        {
            var auto  = new Car(licenceplate, ovner);
            auto.ReportFindCar();
            Cars.Add(auto);
            

        }

        public void AddCar (int licenceplate,string ovner ,bool theft)
        {
            var auto = new Car(licenceplate, ovner);
            auto.Theft = theft;
        }

        public void ReportTheft(int licenceplate)
        {
            var car = Cars.Find(car => car.LicencePlate == licenceplate);
            if (car == null)
            { Console.WriteLine("No find this Car!"); }
            else
            {
                car.ReportTheft();
            } 
        }

        public Car GetCar (int searchcar)
        {
            var car = Cars.Find(car => car.LicencePlate == searchcar);
            if (car == null)
            {
                Console.WriteLine("No find this Car!");
            }

            return car;
        }

    }
}
