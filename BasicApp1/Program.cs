using System;

namespace BasicApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github!");
            Student student = new Student();
            student.StudentId = 2;
            student.StudentName = "Hexagon";
            student.Question = "Will Nasa save Iron Man?";
            Console.WriteLine(student.Question);
            Console.ReadLine();
        }
    }
}
