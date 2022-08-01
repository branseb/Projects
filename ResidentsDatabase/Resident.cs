using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidentsDatabase
{
    public class Resident 
    {
        public readonly string Name;

        public readonly DateOnly Birthdate;

        public readonly string ID;

        public Resident (string name , DateOnly birthdate , string id)
        {
            Name = name;
            Birthdate = birthdate;
            ID = id;
        }
        public override string ToString()
        {
            return Name + "-" + Birthdate + "-" + ID;
        }
    }
}
