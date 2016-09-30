using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    class Reservor
    {
        string name { get; set; }
        DateTime reservedAt { get; set; }

        public Reservor(string name, DateTime reservedAt)
        {
            this.name = name;
            this.reservedAt = reservedAt;
        }

    }
}
