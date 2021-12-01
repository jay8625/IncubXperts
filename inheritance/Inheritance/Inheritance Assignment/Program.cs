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
            Console.WriteLine("Os :" + os);
        }
        public string OperatingSystem()
        {
            os = "ios";
            return os;
        }

}
    class Iphone : Phone
    {
        string modelSize = "20x8cm";
        public void PrintSize()
        {
            Console.WriteLine("Model Size is :"+ modelSize);
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
            ios.OperatingSystem();
            ios.prize = 120000;
            ios.PhoneInfo();
            ios.PrintSize();
        }
    }
}
