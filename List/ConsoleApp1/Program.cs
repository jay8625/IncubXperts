using System;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        public class ColletctionDemo
        {
            public static void Main(string[] args)
            {
                int studentCount = 12;
                int DivisionCount = 3;
                int loopcount1 = 1;
                int loopcount2 = 1;
                var Trial=" ";


                List<Div> Division = new List<Div>();       //List for division

                for (int j = 1; j <= DivisionCount; j++)
                {
                    loopcount1 = j;
                    Div division = new Div()
                    {
                        DivisionCode = "Division" + j,
                    };
                    Division.Add(division);
                    var temp = " ";
                    Division.ForEach(cr => temp = (cr.DivisionCode));       //Stored division code in temp for sequencing before student loop
                    Console.WriteLine(temp);


                    List<StudentInfo> Student = new List<StudentInfo>();        //List for Student

                    for (int i = 1; i <= studentCount; i++)
                    {
                        loopcount2 = i;
                        StudentInfo students = new StudentInfo()
                        {
                            StudentId = 1000 + i,
                            StudentName = "Stud" + i,
                            StudentRollno = i
                        };
                        Student.Add(students);

                        Student.ForEach(s => Trial= (" Student name is: " + s.StudentName + " Student rollno is: " + s.StudentRollno + " Student ID: " + s.StudentId));     //Common print loop

                        if (loopcount1 == 1 && loopcount2 == 1 )        //If conditions for Printing Students info in Specific division
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 1 && loopcount2 == 2 )
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 1 && loopcount2 == 3)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 1 && loopcount2 == 4)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 2 && loopcount2 == 5)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 2 && loopcount2 == 6)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 2 && loopcount2 == 7)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 2 && loopcount2 == 8)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 3 && loopcount2 == 9)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 3 && loopcount2 == 10)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 3 && loopcount2 == 11)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 3 && loopcount2 == 12)
                        {
                            Console.WriteLine(Trial);
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Enter to Swaping of students:-");        //Starting of swaping students
                Console.ReadLine();

                List<Div> Course = new List<Div>();      //List for division

                for (int j = 1; j <= DivisionCount; j++)        
                {
                    loopcount1 = j;
                    Div division = new Div()
                    {
                        DivisionCode = "Division" + j,
                    };
                    Course.Add(division);
                    var temp = " ";
                    Course.ForEach(cr => temp = (cr.DivisionCode));
                    Console.WriteLine(temp);


                    List<StudentInfo> Student = new List<StudentInfo>();         //List for Students

                    for (int i = 1; i <= studentCount; i++)
                    {
                        loopcount2 = i;
                        StudentInfo students = new StudentInfo()
                        {
                            StudentId = 1000 + i,
                            StudentName = "Stud" + i,
                            StudentRollno = i
                        };
                        Student.Add(students);

                        Student.ForEach(s => Trial = (" Student name is: " + s.StudentName + " Student rollno is: " + s.StudentRollno + " Student ID: " + s.StudentId));     //Common print loop


                        if (loopcount1 == 1 && loopcount2 == 5)     //If conditions for Printing swapped Students info in Specific division
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 1 && loopcount2 == 7)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 1 && loopcount2 == 11)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 1 && loopcount2 == 12)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 2 && loopcount2 == 2)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 2 && loopcount2 == 6)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 2 && loopcount2 == 1)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 2 && loopcount2 == 8)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 3 && loopcount2 == 9)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 3 && loopcount2 == 10)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 3 && loopcount2 == 3)
                        {
                            Console.WriteLine(Trial);
                        }
                        if (loopcount1 == 3 && loopcount2 == 4)
                        {
                            Console.WriteLine(Trial);
                        }
                    }
                }
                Console.ReadLine();
            }
        }

    }
}
    