using System;
using Tracker.WebAPIClient;

namespace Q3_MonoGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {

            using (var game = new Game1())
                game.Run();
            ActivityAPIClient.Track(StudentID: "your student Id goes here",
                StudentName: "Your Name goes here",
                activityName: "DSAA Final Exam 2022",
                Task: "Question 3b");
        }
    }
}
