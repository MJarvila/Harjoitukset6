using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, 
/// äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0). 
/// Laadi luokka kannettavan radion toteutukseksi. 
/// Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla. 
/// Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa. 
/// </summary>
namespace Har6Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio Testi = new Radio();
            Console.WriteLine("Decide if the radio is on or off by typing true or false: ");
            Testi.OnOff = bool.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the volume from a range between 0 and 9: ");
            Testi.Volume = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the desired frequency from a range between 2000.0 - 26000.0 (Use a comma): ");
            Testi.Freq = double.Parse(Console.ReadLine());
            Testi.LookAtRadio();
        }
    }
}
