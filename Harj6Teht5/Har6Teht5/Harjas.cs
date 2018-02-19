using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har6Teht5
{
    class Harjas : Maaliämpäri
    {
        public string HandleColor { get; set; }

        public Harjas()
        {

        }

        public override string ToString()
        {
            return base.ToString() + "Harja on: " + HandleColor;
        }
    }
}
