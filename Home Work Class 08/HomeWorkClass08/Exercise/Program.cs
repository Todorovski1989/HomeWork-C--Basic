using Domain.Models;
using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contractor contractor01 = new Contractor
            {
                FirstName = "Bob",
                LastName = "Bobert",
                WorkHours = 55,
                PayPerHour = 20
            };

            Contractor contractor02 = new Contractor
            {
                FirstName = "Rick",
                LastName = "Rickeret",
                WorkHours = 100,
                PayPerHour = 20
            };

            Manager manager01 = new Manager
            {
                FirstName = "Mona",
                LastName = "Monalisa"
            };

            Manager manager02 = new Manager
            {
                FirstName = "Igor",
                LastName = "Igorsky"
            };

            SalesPerson salesPerson = new SalesPerson
            {
                FirstName = "Lea",
                LastName = "Leova"
            };

            object[] company = new object[5] {contractor01, contractor02, manager01, manager02, salesPerson};

            CEO ceo = new CEO("Ron", "Ronsky", 1000, 25, new string[] { "Bob Bobert", "Rick Rickert", "Mona Monalisa", "Igor Igorsky", "Lea Leova"});

            ceo.AddSharesPrice(250);
            ceo.PrintInfo();
            ceo.GetSalary();
            ceo.PrintEmployees();
        }
    }
}
