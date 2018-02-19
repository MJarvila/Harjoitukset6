using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). 
/// Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: 
/// työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary). 
/// Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss), 
/// heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus). 
/// </summary>
namespace Har6Teht1
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public double Bonus { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Car: " + Car + ". Bonus:  " + Bonus + ". \n";
        }
    }
}
