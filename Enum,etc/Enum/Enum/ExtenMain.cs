using System;

namespace Enum
{
    class ExtenMain
    {
        static void Main()//Extended class
        {
            Console.WriteLine("__________STATIC MEMBER__________");
            Console.WriteLine("Enter the Width of LCD");//Static member Example where Height is Standard for all LCD models
            int a = Convert.ToInt32(Console.ReadLine());
            Practice p1 = new Practice(a);
            p1.CrossSection(a); //Parameterised Constructor


            Console.WriteLine("Enter the Width of LCD");
            int b = Convert.ToInt32(Console.ReadLine());
            p1.CrossSection(b);
            Console.ReadLine();

            Console.WriteLine("__________OVERLOADING__________");
            Console.WriteLine("Enter your name: ");
            string c = Console.ReadLine();
            Practice p = new Practice(c);   //Overloaded Constructor
            Console.ReadLine();

            Console.WriteLine("__________ENUM EXAMPLE__________");
            Console.WriteLine("Jhon is standing in middle of road And he is having 4 roads in four Directions");//Example of enum
            Console.WriteLine("which will Confirm road direction by enum");
            Console.ReadLine();


            Console.WriteLine("Direction for Delhi is " + (int)Direction.West + " Road");
            Console.WriteLine("Direction for Hydrabad is " + (int)Direction.South + " Road");
            Console.WriteLine("Direction for Noida is " + (int)Direction.North + " Road");
            Console.WriteLine("Direction for Mumbai is " + (int)Direction.East + " Road");
            Console.ReadLine();

            Console.WriteLine("__________CALL BY VALUE__________");
            Practice p5 = new Practice();
            p5.Extension();
            Practice p6 = new Practice();   //Example of call by value

            Console.WriteLine("__________CALL BY REFERANCE__________");
            int d = 10;
            Console.WriteLine("Before calling value "+d);
            Practice.Referance(ref d);
            Console.WriteLine("After calling value " + d);    //As it is call by REF so value of d variable changed 
            Console.ReadLine();

            //Practice j = new Practice();      //copy Constructor
            //j.width = 45;

            Console.ReadLine();
        }
    }
    
}
