using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita: 
/// kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia, tabletteja, läppäreitä, ... jne. 
/// Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) esiintyy ja käytä apuna perintää, 
/// jos tavaroille löytyy yhteisiä ominaisuuksia. 
/// Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. 
/// Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita. 
/// </summary>
namespace Har6Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirjallisuus kirja1 = new Kirjallisuus();

            kirja1.Name = "Elric, Stealer of Souls";
            kirja1.Year = 1961;
            kirja1.Author = "Michael Moorcock";
            kirja1.PageCount = 458;
            Console.WriteLine(kirja1.ToString());

            Elektroniikka laite1 = new Elektroniikka();
            laite1.Name = "KolomeDeeäsÄxäl";
            laite1.Year = 2012;
            laite1.Device = "Nintendo 3DS";
            laite1.Model = "XL";
            laite1.Manufacturer = "Nintendo";

            Console.WriteLine(laite1.ToString());
        }
    }
}
