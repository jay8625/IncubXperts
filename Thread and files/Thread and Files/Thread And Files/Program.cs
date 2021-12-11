using System;
using System.Threading;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Thread_And_Files
{
    class Program
    {

        

        public static void LogWriter(string message)
        {
            var logpath = ConfigurationManager.AppSettings["logpath"];

            using (StreamWriter write = new StreamWriter(logpath, true))
            {
                write.WriteLine((DateTime.Now) + message);
            }
        }
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
                if (sum==temp)
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
                if (i%2==0)
                {
                    Console.WriteLine("Even: "+i);
                }
            }
        }
        static void Main(string[] args)
        {
            LogWriter(" hello world");

            string path = @"D:\log.txt";
            List<string> lines = File.ReadAllLines(path).ToList();
            

            Console.WriteLine("Enter the Threading Type:-");
            Console.WriteLine();
            Console.WriteLine("1.Without Threading");
            Console.WriteLine("2.Single Threading");
            Console.WriteLine("3.Multi Threading");
            int input =Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            LogWriter("########## Normal Type:- ###########");
                            Console.WriteLine("########## Normal Type:- ###########");
                            Palindrome();
                            Even();
                            Console.ReadLine();


                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("########## Single Thread:- ##########");
                            Thread Thread_1 = new Thread(Palindrome);   //Thread Declared for Both Even & Plaindrome 
                            Thread_1.Start();
                            Thread.Sleep(3000);     //Thread sleep timming
                            Even();
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("########## Multi Thread:- ##########");
                            Thread Thread_1 = new Thread(Palindrome);
                            Thread Thread_2 = new Thread(Even);
                            Thread_1.Start();
                            Thread_2.Start();
                            Thread.Sleep(3000);
                            Thread.Sleep(3000);
                            Console.ReadLine();
                        }
                        break;


                    default:

                        Console.WriteLine("Looking forward to the Weekend.");
                        break;
                
                }
            }
        }
    }

