using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää.
/// </summary>
namespace Har6Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Harjas harja1 = new Harjas();
            harja1.Color = "Pinkki";
            harja1.HandleColor = "Valkoinen";

            Console.WriteLine(harja1.ToString());
        }
    }
}
