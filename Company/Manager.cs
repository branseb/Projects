using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Manager : Employee
    {
        public Manager(int id, string name, DateOnly startdate, int rate , bool phone ,bool notebook , bool car) : base(id, name, startdate, rate)
        {
            Phone = phone;
            Notebook = notebook;
            Car = car;
        }

        public bool Phone { get; private set; }
        public bool Notebook { get; private set; }

        public bool Car { get; private set; }

        public void SetPhone (bool phone)
        {
            Phone = phone;
        }
        public void SetNotebook (bool notebook)
        {
            Notebook = notebook;
        }

        public void SetCar (bool car)
        {
            Car = car;
        }

        public override string GetInfo()
        {
            var info = new StringBuilder();
            info.AppendLine(base.GetInfo());
            info.AppendLine("Phone: " +( Phone ? "Yes" : "No"));
            info.AppendLine("Notebook: " + (Notebook ? "Yes" : "No"));
            info.AppendLine("Car: " + (Car ? "Yes" : "No"));
            return info.ToString();
        }

        
    }
}
