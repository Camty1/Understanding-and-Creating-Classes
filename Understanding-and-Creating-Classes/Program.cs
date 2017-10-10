using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_and_Creating_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Color);

            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            //double marketValueOfCar = determineMarketValue(myNewCar);

            Console.ReadLine();
        }

        private static double determineMarketValue(Car _car)
        {
            double carvalue = 100;

            return carvalue;
        }
    }

    class Car //I have done this with multiple different scripts in Js, but being able to have in on one script is very nice.
    {
        public string Make { get; set; } //Get and set for all of them so it gets an input and sets its value as that
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue() //This is how they do Console.WriteLine();
        {
            double carValue = 100;

            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0; //Basic comparison, but I could see the creation of classes being very useful.
            
            return carValue;
        }


    }
}
