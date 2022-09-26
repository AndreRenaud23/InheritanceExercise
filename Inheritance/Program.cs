using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Lets start with a bird!");
            Console.WriteLine("----------------------------------------");
            Thread.Sleep(2000);

            Bird bird1 = new Bird();

            bird1.Species = "Bird";
            bird1.Age = 3;
            bird1.Size = "Large";
            bird1.NumOfLegs = 2;

            bird1.CanFly = "No";
            bird1.TypeOfFeathers = "Long and neat";
            bird1.TypeOfBird = "Peacock";
            bird1.Habitat = "Tropical forest";

            Console.WriteLine($"Type of species: {bird1.Species}");
            Console.WriteLine($"Age: {bird1.Age}");
            Console.WriteLine($"Size: {bird1.Size}");
            Console.WriteLine($"Number of legs: {bird1.NumOfLegs}");

            Console.WriteLine($"Ability to fly: {bird1.CanFly}");
            Console.WriteLine($"Type of feathers: {bird1.TypeOfFeathers}");
            Console.WriteLine($"Type of bird: {bird1.TypeOfBird}");
            Console.WriteLine($"Type of habitat: {bird1.Habitat}");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Now a reptile!");
            Console.WriteLine("----------------------------------------");
            Thread.Sleep(2000);

            Reptile reptile1 = new Reptile();

            reptile1.Species = "Reptile";
            reptile1.Age = 2;
            reptile1.Size = "Medium";
            reptile1.NumOfLegs = 4;

            reptile1.Speed = "Slow";
            reptile1.TextureOfScales = "Rocky";
            reptile1.HasTail = "Yes";
            reptile1.Color = "Brown";

            Console.WriteLine($"Type of species: {reptile1.Species}");
            Console.WriteLine($"Age: {reptile1.Age}");
            Console.WriteLine($"Size: {reptile1.Size}");
            Console.WriteLine($"Number of legs: {reptile1.NumOfLegs}");

            Console.WriteLine($"Ability to fly: {reptile1.Speed}");
            Console.WriteLine($"Type of feathers: {reptile1.TextureOfScales}");
            Console.WriteLine($"Type of bird: {reptile1.HasTail}");
            Console.WriteLine($"Type of habitat: {reptile1.Color}");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Yay! We are done now :)");
            Console.WriteLine("----------------------------------------");
            Thread.Sleep(1000);
        }
    }
}
