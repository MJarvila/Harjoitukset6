using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har6Teht5
{
    class Maaliämpäri
    {
        public string Color { get; set; }

        public Maaliämpäri()
        {

        }

        public override string ToString()
        {
            return "Maali on: " + Color + "\n";
        }
    }
}
