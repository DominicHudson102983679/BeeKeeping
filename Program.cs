using System;
using System.Collections.Generic;
using System.Text;

namespace BeeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
            /* creating first beehive, creating 4 bees, placing them and displaying them*/
            BeeHive BeeHive1 = new BeeHive();

            Bee Bee11 = new Bee("John", 3.2f);
            Bee Bee12 = new Bee("Paul", 2.7f);
            Bee Bee13 = new Bee("George", 1.1f);
            Bee Bee14 = new Bee("Ringo", 2.0f);

            BeeHive1.PlaceBees(Bee11);
            BeeHive1.PlaceBees(Bee12);
            BeeHive1.PlaceBees(Bee13);
            BeeHive1.PlaceBees(Bee14);

            Console.WriteLine("First beehive: ");
            BeeHive1.NumBees();
            Console.WriteLine(Bee11.name + ", " + Bee12.name + ", " + Bee13.name + " and " + Bee14.name);
            Console.WriteLine();

            /* creating second beehive, creating 3 bees, placing them and displaying them*/
            BeeHive BeeHive2 = new BeeHive();

            Bee Bee21 = new Bee("Kurt", 2.3f);
            Bee Bee22 = new Bee("Dave", 7.4f);
            Bee Bee23 = new Bee("Krist", 1.5f);

            BeeHive2.PlaceBees(Bee21);
            BeeHive2.PlaceBees(Bee22);
            BeeHive2.PlaceBees(Bee23);

            Console.WriteLine("Second beehive: ");
            BeeHive2.NumBees();
            Console.WriteLine(Bee21.name + ", " + Bee22.name + " and " + Bee23.name);
            Console.WriteLine();

            /* getting user input for CollectHoney() */
            Console.WriteLine("How many days do you want to collect honey for?");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            BeeHive1.CollectHoney(days);
            BeeHive2.CollectHoney(days);


        }
    }
} 
