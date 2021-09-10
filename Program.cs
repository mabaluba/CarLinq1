using System;
using System.Collections.Generic;
using System.Linq;

namespace CarLinq1
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            var listCars = new List<Car>
            {
                new ("Fiat", "Bravo", 2005, "red"),
                new ("Mersedes", "E", 2010, "black"),
                new ("Skoda", "Fabia", 2009, "yellow"),
                new ("Mersedes","A", 2009, "grey")

            };

            var listCustomers = new List<Customer>
            {
                new ("Petrov", "Mersedes", "0509864578"),
                new ("Ivanov", "Fiat", "0509876545"),
                new ("Vasiliev", "Skoda", "0504789863")

            };

            var markaAndColor = 
                from cars in listCars
                select new {Marka = cars.marka, Color = cars.color};

            foreach (var item in markaAndColor)
            {
                Console.WriteLine(item.Marka+" "+item.Color);
            }

            Console.WriteLine();

            var custumerCar = 
                from custumers in listCustomers
                join cars in listCars on custumers.model equals cars.marka
                select new
                {
                    Name = custumers.name,
                    Tel = custumers.tel,
                    Model = custumers.model,
                    Brand = cars.marka,
                    Color = cars.color,
                    Year = cars.year
                };
            foreach (var item in custumerCar)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Name, item.Tel, item.Model, item.Brand, item.Color, item.Year);
            }
        }
    }
}
