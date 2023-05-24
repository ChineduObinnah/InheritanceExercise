using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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

            var swan = new Birds();


            swan.BirdOfPrey = false;
            swan.diet = "bugs";
            swan.IsNoctornal = false;
            swan.tail = false;
            swan.name = "Swan";
            Console.WriteLine($" This is a {swan.name}\n it is {swan.BirdOfPrey} that it is a predator\n It is {swan.IsNoctornal} that it is noctornal\n and it is {swan.tail} that" +
                $"it has a tail\n it has a diet of {swan.diet}");
            var Lizzard = new Reptiles();

            Lizzard.CanSwim = false;
            Lizzard.HasVenom = true;
            Lizzard.NumofTeett = 50;
            Lizzard.Location = "Australia";
            Lizzard.name = "Komodo Dragon";
            Lizzard.CanSwim = false;

            Console.WriteLine($" This is a {Lizzard.name}\n it is {Lizzard.HasVenom} that is has venom\n It has {Lizzard.NumofTeett} rows of teeth\n it lives in {Lizzard.Location}\n" +
                $" It is {Lizzard.CanSwim} that it can swim");

        }

        /*Create an object of your Reptile class
         *  give values to your members using the object of your Reptile class
         *  
         * Creatively display the class member values 
         */



    }

}

