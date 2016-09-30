using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    abstract class Animal
    {
        string name;
        Gender gender;

        public Animal(string name, Gender gender)
        {
            this.name = name;
            this.gender = gender;
        }
    }
}
