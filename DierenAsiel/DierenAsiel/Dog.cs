using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    public class Dog : Animal
    {
        public string name { get; set; }
        public Gender gender { get; set; }
        public DateTime lastwalk { get; set; }

        public Dog(string name, Gender gender, DateTime lastWalk) : base(name, gender)
        {
            this.name = name;
            this.gender = gender;
            this.lastwalk = lastwalk;
        }


        public bool reserve(string ReservedBy)
        {
            return true;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
