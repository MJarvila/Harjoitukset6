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
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }
        public override string ToString()
        {
            Console.WriteLine(Profession+":");
            return "Name: " + Name + ". Profession: " + Profession + ". Salary: " + Salary + ". \n";
        }
    }

}
