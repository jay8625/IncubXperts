using System;


namespace Inheritance_Assignment
{
    public class Phone
    {
        public string model;
        public int prize;
        public string processor;
        public string ram;
        private string os;



        public void PhoneInfo()
        {
            Console.WriteLine("model :" + model);
            Console.WriteLine("Prize :" + prize);
            Console.WriteLine("Processor :" + processor);
            Console.WriteLine("Ram :" + ram);

        }
        public string OperatingSystem()
        {
            os = "os: ios";
            return os;
        }

}
    public class Iphone : Phone
    {
        public string modelSize = "20x8cm";
        public void PrintSize()
        {
            Console.WriteLine("Model Size is :"+ modelSize);
        }
    }

    class Android : Phone
    {
        private string oS="Android";
        public void PrintOs()
        {
            Console.WriteLine("Operating system is :" + oS);
        }
        
        
    }

    class Window :Phone
    {
        private string oS="Windows";
        public void PrintOs()
        {
            Console.WriteLine("Operating System is :" + oS);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            //Iphone i = new Phone();    (can't happen because class Iphone is not having fully access to class phone)
            //Phone i = new Phone();     (both can be done)
            //Phone i = new Iphone();
            Iphone ios = new Iphone
            {
                model = "13 Pro max",
                processor = "A13",
                ram = "6gb"
            };
            Console.WriteLine("This Description is for Iphone:-");
            ios.prize = 120000; 
            ios.PhoneInfo();
            ios.OperatingSystem();
            ios.PrintSize();
            Console.ReadLine();

            Android and = new Android
            {
                model = "One Plus",
                processor = "Sd888",
                ram = "12gb"
            }; 
            Console.WriteLine("This Description is for Android:-");
            and.prize = 120000;
            and.PrintOs();
            and.PhoneInfo();
            Console.ReadLine();

            Window Win = new Window
            {
                model = "Nokia",
                processor = "Mediatech",
                ram = "4gb"
            }; 
            Console.WriteLine("This Description is for Windows:-");
            Win.PrintOs();
            Win.prize = 120000;
            Win.PhoneInfo();
            Console.ReadLine();
        }
    }
}
