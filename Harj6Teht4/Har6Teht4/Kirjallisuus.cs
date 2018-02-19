using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har6Teht4
{
    class Kirjallisuus : Viihde
    {
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Kirjallisuus()
        {

        }

        public override string ToString()
        {
            Console.WriteLine("Book:");
            Console.WriteLine("-----");
            return base.ToString() + "Author: " + Author + "\n" + "Number of pages: " + PageCount + "\n";
        }
    }
}
