using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog_and_cat = new car();
            var bowling = new car();
            Console.WriteLine("How many cars: {0}", Vehicle.howManyCars);
            Console.ReadLine();   
        }
    }

    class Vehicle
    {

        public static int howManyCars=0;
        public String color = "Blue";
    }

    class car : Vehicle
    {
          public String Color = "Red";
          public car()
        {
            Vehicle.howManyCars++;
            Console.WriteLine("my color is " + color);
            Console.ReadLine();

       }
    }
}
