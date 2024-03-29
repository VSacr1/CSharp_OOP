﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an object of Car() Class by using Type Interface called Car1
            var Car1 = new Car();
            //Using dot notation to call members on Car1
            Car1.Colour = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            //Output to the console window
            Console.WriteLine($"This car is painted {Car1.Colour}, was built in {Car1.Year}, and has {Car1.Mileage} mile on it.");
        }
    }

    //Declaring the Car() Class
    //This class has 3 properties; Colour, Year and Mileage
    public class Car
    {
        //Defining properties
        public string Colour { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }

}
