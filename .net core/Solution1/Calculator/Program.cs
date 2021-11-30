using System;
using Calfunctions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            Console.WriteLine("Enter the First number:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            secondNum = Convert.ToInt32(Console.ReadLine());


            Function obj = new Function();
 
            Console.WriteLine("Your Addition is:"+ obj.Sum(firstNum,secondNum));

            Console.WriteLine("Your Substraction is:" + obj.Substraction(firstNum, secondNum));

            Console.WriteLine("Your Multiplication is:" + obj.Multiplication(firstNum, secondNum));

            Console.WriteLine("Your Division is:" + obj.Division(firstNum, secondNum));


            Console.ReadLine();
            
            

            
        }
    }
}
