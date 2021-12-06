using System;


namespace Enum
{
 class Program
 {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Width of LCD");//Static member Example where Height is Standard for all LCD models
            int a = Convert.ToInt32(Console.ReadLine());
            Practice p1 = new Practice(a);
            p1.CrossSection(a);


            Console.WriteLine("Enter the Width of LCD");
            int b = Convert.ToInt32(Console.ReadLine());
            p1.CrossSection(b);
            Console.ReadLine();


            Console.WriteLine("Direction for Delhi is " + (int)Direction.West + " Road");//Example of enum
            Console.WriteLine("Direction for Hydrabad is " + (int)Direction.South + " Road");
            Console.WriteLine("Direction for Noida is " + (int)Direction.North + " Road");
            Console.WriteLine("Direction for Mumbai is " + (int)Direction.East + " Road");


            Console.ReadLine();

            //all the methods have been called in ExtendMain class as I have made it a Extension class
  
        }
    }
}
