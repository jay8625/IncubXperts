using System;


namespace IFELSE
{
   
    public class StudentInfo
    {
        public int[] x = new int[11];
        int average1;
        int average2;
        int average3;
        int average4;
        int average5;
        int average6;
        int average7;
        int average8;
        int average9;
        int average10;
        public void Std1()
        {
            string name = "yash";
            int maths = 78;
            int science = 56;
            int english = 89;
            int average = (maths + science + english)/ 3;
            x[1]=average1 = average;
            if (average>=80)
            {
                Console.WriteLine(name+" is Pass");
            }
            else { Console.WriteLine(name+" is Fail"); }
        }

        public void Std2()
        {
            string name = "priyanka";
            int maths = 15;
            int science = 36;
            int english = 49;
            int average = (maths + science + english) / 3;
            x[2]=average2 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }

        public void Std3()
        {
            string name = "Jay";
            int maths = 88;
            int science = 76;
            int english = 69;
            int average = (maths + science + english) / 3;
            x[3] = average3 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }

        public void Std4()
        {
            string name = "Aniket";
            int maths = 28;
            int science = 36;
            int english = 23;
            int average = (maths + science + english) / 3;
            x[4] = average4 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }

        public void Std5()
        {
            string name = "Ajay";
            int maths = 48;
            int science = 26;
            int english = 35;
            int average = (maths + science + english) / 3;
            x[5] = average5 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }

        public void Std6()
        {
            string name = "Tanuj";
            int maths = 45;
            int science = 96;
            int english = 21;
            int average = (maths + science + english) / 3;
            x[6] = average6 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }

        public void Std7()
        {
            string name = "Tina";
            int maths = 65;
            int science = 46;
            int english = 91;
            int average = (maths + science + english) / 3;
            x[7] = average7 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }

        public void Std8()
        {
            string name = "Mihir";
            int maths = 64;
            int science = 36;
            int english = 61;
            int average = (maths + science + english) / 3;
            x[8] = average8 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }
        public void Std9()
        {
            string name = "Priya";
            int maths = 12;
            int science = 36;
            int english = 31;
            int average = (maths + science + english) / 3;
            x[9] = average9 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }

        public void Std10()
        {
            string name = "Rohan";
            int maths = 55;
            int science = 36;
            int english = 22;
            int average = (maths + science + english) / 3;
            x[10] = average10 = average;
            if (average >= 80)
            {
                Console.WriteLine(name + " is Pass");
            }
            else { Console.WriteLine(name + " is Fail"); }
        }


        public void Assending()
        {
            Array.Sort(x);
            foreach (int ivalue in x )
            {
              
                if (ivalue==average1)
                {
                    Console.WriteLine("Yash got :"+ivalue+"%");

                }
                if (ivalue == average2)
                {
                    Console.WriteLine("Priya got :" + ivalue + "%");

                }
                if (ivalue == average3)
                {
                    Console.WriteLine("Jay got :" + ivalue + "%");

                }
                if (ivalue == average4)
                {
                    Console.WriteLine("Aniket got :" + ivalue + "%");

                }
                if (ivalue == average5)
                {
                    Console.WriteLine("Ajay got :" + ivalue + "%");

                }
                if (ivalue == average6)
                {
                    Console.WriteLine("Tanuj got :" + ivalue + "%");

                }
                if (ivalue == average7)
                {
                    Console.WriteLine("Tina got :" + ivalue + "%");

                }
                if (ivalue == average8)
                {
                    Console.WriteLine("Mihir got :" + ivalue + "%");

                }
                if (ivalue == average9)
                {
                    Console.WriteLine("Priya got :" + ivalue + "%");

                }
                if (ivalue == average10)
                {
                    Console.WriteLine("Rohan got :" + ivalue + "%");

                }
               

            }
          
        }


    }

    public class Switch
    {
        public void SwitchCase()
        {
            Console.WriteLine("Enter the Rank To Get Information:");
            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("First is Yash");
                    break;
                case 2:
                    Console.WriteLine("Second is Priya");
                    break;
                case 3:
                    Console.WriteLine("Third is Jay");
                    break;
                case 4:
                    Console.WriteLine("Fourth is Aniket");
                    break;
                case 5:
                    Console.WriteLine("Fifth is Ajay");
                    break;
                case 6:
                    Console.WriteLine("Sixth is Tanuj");
                    break;
                case 7:
                    Console.WriteLine("Seventh is Tina");
                    break;
                case 8:
                    Console.WriteLine("Eighth is Mihir");
                    break;
                case 9:
                    Console.WriteLine("Ninth is Priya");
                    break;
                case 10:
                    Console.WriteLine("Tenth is Rohan");
                    break;

            }
        }
    }



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
            Switch rank = new Switch();
            rank.SwitchCase();
            Console.ReadLine();
        }
    }
}