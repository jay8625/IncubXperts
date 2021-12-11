using System;


namespace List
{
    class Div
    {
        public string DivisionCode { get; set; }    //Division model

    }

    class StudentInfo
    {
        public int StudentId { get; set; }      //Student model

        public string StudentName { get; set; }

        public int StudentRollno { get; set; }

        public static void Print(StudentInfo student)   //Student Print method
        {
            Console.WriteLine(student.StudentId);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.StudentRollno);
        }
    }
}

