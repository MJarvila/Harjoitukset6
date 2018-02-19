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
/// 
namespace Har6Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Matti Meimieskolainen";
            emp1.Profession = "Turhantoimittaja";
            emp1.Salary = 3000;
            Console.WriteLine(emp1.ToString());

            Employee emp2 = new Employee();
            emp2.Name = "Meido Moidolainen";
            emp2.Profession = "Sisäkkö";
            emp2.Salary = 2000;
            Console.WriteLine(emp2.ToString());

            Boss bos1 = new Boss();
            bos1.Name = "Iso Päällikkö";
            bos1.Profession = "Big Boss";
            bos1.Salary = 5000;
            bos1.Car = "Ferrari";
            bos1.Bonus = 500;
            Console.WriteLine(bos1.ToString());

            Boss bos2 = new Boss();
            bos2.Name = "Sakke Nikkeli";
            bos2.Profession = "SysAdminBossMan";
            bos2.Salary = 3000;
            bos2.Car = "Datsun";
            bos2.Bonus = 200;
            Console.WriteLine(bos2.ToString());
        }
    }
}
