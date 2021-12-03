using System;


namespace IFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo std1 = new StudentInfo();
            std1.Std1();
            std1.Std2();
            std1.Std3();
            std1.Std4();
            std1.Std5();
            std1.Std6();
            std1.Std7();
            std1.Std8();
            std1.Std9();
            std1.Std10();
            Console.ReadLine();
            Console.WriteLine("**********As Per ranks:-**********");
            std1.Assending();
            Console.ReadLine();
            Methods rank = new Methods();
            rank.SwitchCase();
            Console.ReadLine();

        }
    }
}