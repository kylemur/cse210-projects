using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new("Mike Scott", "Advanced Writing\n");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new("John Bytheway", "Algebra 2", "7.3", "8-19\n");
        string summary = mathAssignment1.GetSummary();
        string homeworkList = mathAssignment1.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);
    
        WritingAssignment writingAssignment1 = new("Mary Waters", "European History", "Causes of WWII");
        Console.WriteLine(writingAssignment1.GetSummary() + "\n" + writingAssignment1.GetWritingInformation());
    }
}