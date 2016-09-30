using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DierenAsiel;

namespace DierenAsiel
{
    public class Reservation
    {
        public Dog dog { get; private set; }
        public Cat cat { get; private set; }


        public Reservation()
        {

        }
        public void newCat(string name, Gender gender, string badHabits)
        {
            this.cat = new Cat(name, gender, badHabits);
        }

        public void newDog(string name, Gender gender, DateTime lastWalk)
        {
            this.dog = new Dog(name, gender, lastWalk);
        }

    }

    
}
