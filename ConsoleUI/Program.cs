using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            //people = people.OrderByDescending(x => x.LastName).ThenByDescending(x=>x.YearsExperience).ToList();
            //people = people.Where(person => person.YearsExperience > 9 && person.Birthday.Month == 3 ).ToList();


            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearsExperience }");
            //}

            int yearsTotal = 0;

            //people.Sum(person => person.YearsExperience);
            yearsTotal = people.Where(person => person.Birthday.Month == 3).Sum(person => person.YearsExperience);

            Console.WriteLine($"The total years of experience is {yearsTotal} ");

            Console.ReadLine();
        }
    }
}
