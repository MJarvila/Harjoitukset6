using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har6Teht4
{
    class Elektroniikka : Viihde
    {
        public string Device { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }

        public Elektroniikka()
        {

        }

        public override string ToString()
        {
            Console.WriteLine("Device info: ");
            Console.WriteLine("------------");
            return base.ToString() + "Device: " + Device + "\n" + "Model: " + Model + "\n" + "Manufacturer: " + Manufacturer + "\n";
        }
    }
}
