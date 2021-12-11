using System;
using System.IO;
using System.Threading;


namespace Thread_And_Files
{
    class Program
    {
        public static void Palindrome()     //Palindrome no from 100 to 10000
        {
            for (int i = 100; i < 10000; i++)
            {
                int num = i;
                int rem, sum = 0, temp;
                temp = num;
                while (num > 0)
                {
                    rem = num % 10;
                    sum = (sum * 10) + rem;
                    num /= 10;
                }
                if (sum == temp)
                {
                    var output = "palindrome: " + temp;
                    Console.WriteLine(output);
                }
            }
        }

        public static void Even()   //Even no methods from 1 to 1000
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even: " + i);
                }
            }
        }
        static void Main(string[] args)
        {

            FileStream logger;
            StreamWriter write;
            TextWriter WriteOut = Console.Out;
            try
            {
                logger = new FileStream("./Log.txt", FileMode.OpenOrCreate, FileAccess.Write);
                write = new StreamWriter(logger);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Log.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(write);

            Console.WriteLine("Enter the Threading Type:-");
            Console.WriteLine();
            Console.WriteLine("1.Without Threading");
            Console.WriteLine("2.Single Threading");
            Console.WriteLine("3.Multi Threading");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)                                          //Switchcase for Thread Condition
            {
                case 1:
                    {
                        Console.WriteLine("########## Normal Type:- ###########");      //Without threading
                        Palindrome();
                        Even();
                        Console.ReadLine();


                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("########## Single Thread:- ##########");
                        Thread Thread_1 = new Thread(Palindrome);                            //Single Threading 
                        Thread_1.Start();
                        Thread.Sleep(3000);     //Thread sleep timming ()
                        Even();
                        Console.ReadLine();
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("########## Multi Thread:- ##########");      //Thread Declared for Both Even & Plaindrome 
                        Thread Thread_1 = new Thread(Palindrome);
                        Thread Thread_2 = new Thread(Even);
                        Thread_1.Start();
                        Thread_2.Start();
                        Thread.Sleep(3000);             //Thread sleep 
                        Thread.Sleep(3000);
                        Console.ReadLine();
                    }
                    break;


                default:

                    Console.WriteLine("Looking forward to the Weekend.");
                    break;

            }


            Console.SetOut(WriteOut);
            write.Close();
            logger.Close();
            Console.ReadLine();

        }


    }
}
