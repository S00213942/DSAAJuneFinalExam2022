using System;
using Tracker.WebAPIClient;

namespace Q3_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivityAPIClient.Track(StudentID: "your student Id goes here", 
                StudentName: "Your Name goes here",
                activityName: "DSAA Final Exam 2022", Task: "Question 3a");
            Console.WriteLine("Hello World!");
        }
    }
}
