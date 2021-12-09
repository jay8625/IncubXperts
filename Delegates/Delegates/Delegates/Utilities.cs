using System;


namespace Delegates
{
    public delegate void Multiply(int a, int b);
    public delegate void Greetings(string name);
  

    class Utilities
    {

        public static void Multiplication(int a,int b)
        {
            int Multiply = a * b;
            Console.WriteLine("Multiplication is : "+ Multiply); 
        }

        public static void Addition(int a,int b)
        {
            int addition=a+b;
            Console.WriteLine("Addition is : "+ addition);
        }

        public static void Division(int a,int b)
        {
            int division = a / b;
            Console.WriteLine("Division is : "+division);
        }
    }                                             
}
