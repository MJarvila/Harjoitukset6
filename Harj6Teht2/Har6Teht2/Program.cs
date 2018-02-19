using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Toteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja. 
///  Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri. 
///  Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä. Polkupyörän osalta pitää pystyä erottelemaan se,
///  että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi. 
///  Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä löytyy.
/// Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot.
/// Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta.Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan.
/// Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.
/// </summary>
namespace Har6Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat Tuhkimo = new Boat();
            Tuhkimo.Name = "Tuhkimo";
            Tuhkimo.Model = "Best Boat";
            Tuhkimo.Year = 2017;
            Tuhkimo.Color = "White-Brown";
            Tuhkimo.BoatType = "Motorboat";
            Tuhkimo.BoatSeats = 4;
            Console.WriteLine(Tuhkimo.ToString());

            Bicycle Fillari = new Bicycle();
            Fillari.Name = "Munamankeli";
            Fillari.Model = "Tandemi";
            Fillari.Year = 1950;
            Fillari.Color = "Rust";
            Fillari.Transmission = true;
            Fillari.TransName = "Vaihteisto 0.5";
            Console.WriteLine(Fillari.ToString());

            Vehicle Auto = new Vehicle();
            Auto.Name = "Teuvo";
            Auto.Model = "Ristuksen Vanha Lada";
            Auto.Year = 1940;
            Auto.Color = "No idea. It's 80% rust.";

            Console.WriteLine(Auto.ToString());
        }
    }
}
