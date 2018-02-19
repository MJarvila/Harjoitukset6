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
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int BoatSeats { get; set; }

        public Boat()
        {

        }

        public override string ToString()
        {
            Console.WriteLine("Boat Info: ");
            return base.ToString() +"Boat Type: " + BoatType + "\n" + "Seats: " + BoatSeats + "\n";
        }
    }
}
