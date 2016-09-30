using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    public class Cat : Animal
    {
        public string name { get; set; }
        public Gender gender { get; set; }
        public string badHabits { get; set; }

        public Cat(string name, Gender gender, string badHabits) : base(name, gender)
        {
            this.name = name;
            this.gender = gender;
            this.badHabits = badHabits;
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
