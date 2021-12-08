using System;


namespace String
{
    class Utilities
    {
        int num1 = 10;
        int num2 = 0;

        public void Divide()    //Divide by zero exception
        {
            try
            {
                int result = num1 / num2;
                Console.WriteLine("Sum is: " + result);

            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }

        }
        public void StringConvert()    //Format exception
        {
            try
            {
                string name = "JAY";
                int num = Convert.ToInt32(name);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
        }
        public void ArryExecption()     //Index outof range
        {
            try
            {
                int[] arr = { 1 };
                arr[1] = 100;
                Console.WriteLine(arr[1]);
            }
            catch (IndexOutOfRangeException ex3)
            {
                Console.WriteLine(ex3.Message);
            }

        }

        public void MultiCatch()    //Multi catch block
        {
            int c=0;
            try
            {
                Console.WriteLine("Please enter two Integers:-");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
            }
            catch (DivideByZeroException ex4)
            {
                Console.WriteLine("second number should not zero");
            }
            catch (FormatException ex5)
            {
                Console.WriteLine("Please enter integer numbers");
            }
            finally
            {
                Console.WriteLine("Division = " + c);       //Final block
            }
        }
    }
       
}
