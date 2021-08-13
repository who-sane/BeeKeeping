using System;
using Beez.classLib;
using System.Collections.Generic;

namespace Bees
{
    class Program
    {     
            public static List<Bee> Bees= new List<Bee>();
              static void Main(string[] args)
        {   
            // 4 bees (John, Paul, George, Ringo) -> Sizes (3.2, 2.7, 1.1,  2.0)
            Hive Hive1 = new Hive(4);
            Hive1.Bees.Add(new Bee("John",3.2f));
            Hive1.Bees.Add(new Bee("Paul",2.7f));
            Hive1.Bees.Add(new Bee("George",1.1f));
            Hive1.Bees.Add(new Bee("Ringo",2.0f));

            // 3 bees (Kurt, Dave, Krist) -> Sizes (2.3, 7.4, 1.5)
            Hive Hive2 = new Hive(4);
            Hive2.Bees.Add(new Bee("kurt", 2.3f));
            Hive2.Bees.Add(new Bee("Dave", 7.4f));
            Hive2.Bees.Add(new Bee("Krist",1.5f));


            Console.WriteLine($"Hive 1 produces {Hive1.collecthoney(7)} portions of honey per week, while the Second hive produces {Hive2.collecthoney(7)} units per day");
            if(Hive1.maxAmount==Hive1.Bees.Count){
                Console.WriteLine($"Hive 1 is full! (limit {Hive1.maxAmount})");
            }
            else
            {
                Console.WriteLine($"Hive 1 is home to {Hive1.Bees.Count} bees, it's currently at it's capacity, it can house no more" );
            }
            if(Hive2.maxAmount==Hive2.Bees.Count){
            Console.WriteLine($"Hive 2 is full! (limit {Hive2.maxAmount})");
            }
            else
            {
            Console.WriteLine($"Hive 1 is home to {Hive2.Bees.Count} bees, at capacity it can house 1 more" );
            }
        }
    }
}