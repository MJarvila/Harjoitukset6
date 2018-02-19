using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har6Teht4
{
    class Viihde
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Viihde()
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Year: " + Year + "\n";
        }
    }
}
