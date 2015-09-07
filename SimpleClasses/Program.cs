using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            myNewCar.Value= myNewCar.DetermineMarketValue(); //setting carvalue with the method

            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", 
                myNewCar.Make,
                myNewCar.Model, 
                myNewCar.Year,
                myNewCar.Color,
                myNewCar.Value);

            

            Console.ReadLine();

        }

        private static double determineMarketValueAsAMethodOutsideTheClass(Car car)
        {
            double carValue = 100.0;

            //Somedat white come to go online and look up the car´s value
            //and trieve its value into the carValue variable

            return carValue;

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double Value { get; set; }

        public double DetermineMarketValue()
        {
            double carValue = 0;

            carValue = (this.Year > 1990) ? 100000.0 : 5000;

            return carValue;
        }



    }
}
