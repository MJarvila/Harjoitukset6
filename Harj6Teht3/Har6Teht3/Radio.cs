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
    class Radio
    {
        public bool OnOff { get; set; }
        private int MinVolume = 0;
        private int MaxVolume = 9;
        public int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
 
                if (value >= MinVolume && value <= MaxVolume)
                {
                    volume = value;
                    //Console.WriteLine("JeeJee");
                }
                else
                    Console.WriteLine("Values only from 0 to 9!");
            }
        }
        private double MinFreq = 2000.0;
        private double MaxFreq = 26000.0;
        public double freq;
        public double Freq
        {
            get { return freq; }
            set
            {
                if (value >= MinFreq && value <= MaxFreq)
                {
                    freq = value;
                    //Console.WriteLine("Radio kuuluu ja homma toimii.");
                }
                else
                    Console.WriteLine("Not within the valid frequency range!");
            }
        }
        public void LookAtRadio()
        {
            Console.WriteLine("The radio is on: " + OnOff + "\n" + "Volume is: " + Volume + "\n" + "The frequency is: " + Freq);
        }
    }
}
