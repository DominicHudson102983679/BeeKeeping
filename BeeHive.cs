using System;
using System.Collections.Generic;
using System.Text;

namespace BeeKeeping
{
    public class BeeHive
    {
        /* putting bees into a list so they can be called later on sequentially in CollectHoney() and NumBees() */
        public List<Bee> BeeList;
        public int maxBees = 5;

        /* creating beehive */
        public BeeHive()
        {
            BeeList = new List<Bee>();
        }

        /* used to place bees in beehives */
        public void PlaceBees(Bee Bee)
        {
            BeeList.Add(Bee);
        }
        
        public void CollectHoney(int days)
        {
            foreach (Bee i in BeeList)
            {
                float totalHoney = days * i.size * 0.2f;
                Console.WriteLine(i.name + " has collected " + totalHoney + " honey in " + days + " days");
                Console.WriteLine();
            }
        }

        public void NumBees()
        {
            /* didnt need to put maxBees in here but i wasnt sure where I was supposed to actually use it */
            Console.WriteLine("This beehive has " + (BeeList.Count) + " bees but can hold up to " + maxBees + " bees");
        }

    }
}