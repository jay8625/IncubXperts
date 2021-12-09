using System;
using System.Reflection;


namespace Delegates
{
    public delegate void Deligate();
    class Program
    {
        public static event Deligate Add;
        static void Main(string[] args)
        {
            Console.WriteLine("**********EVENT & DELEGATES**********");
            Console.WriteLine();
            Add += new Deligate(Event);     //EVENT & DELEGATE
            Add.Invoke();
            Console.WriteLine();

            Console.WriteLine("**********SINGLECAST DELEGATES**********");
            Console.WriteLine();
            Console.WriteLine("Enter the first value: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second value: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Multiply a1 = new Multiply(Utilities.Multiplication);   //Singlecast Delegate
            a1.Invoke(a, b);
            Console.ReadLine();

            Console.WriteLine("**********MULTICAST DELEGATES**********");
            Console.WriteLine();
            Multiply a2 = new Multiply(Utilities.Addition);     //MultiCast Delegate
            a2.Invoke(a, b);
            Utilities.Division(a, b);
            Utilities.Multiplication(a, b);
            Console.ReadLine();

            Console.WriteLine("**********ANONYNOMOUS DELEGATES**********");
            Console.WriteLine();
            Console.WriteLine("Enter your name: ");
            string c = Console.ReadLine();
            Greetings print = delegate (string name)    //Anonynomous Delegate
            {

                Console.WriteLine("hello " + name);

            };
            print.Invoke(c);
            Console.ReadLine();



            Console.WriteLine("**********REFLECTION OF STRING**********");
            Console.WriteLine();
            Type types = typeof(string);        //REFLECTION OF STRING 

            Console.WriteLine("class name: " + types.Name);
           
            MethodInfo[] methods = types.GetMethods();
            {
                foreach (var method in methods)
                {
                    Console.WriteLine("Methods: "+method.Name);
                }
            }
            Console.ReadLine();



        }
        static void Event()     //EVENT METHOD
        {
            Console.WriteLine("Event ran");
        }

    }
}
