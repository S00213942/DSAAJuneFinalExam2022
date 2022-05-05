using System;
using Tracker.WebAPIClient;

namespace Q3_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivityAPIClient.Track(StudentID: "S00213942",
                StudentName: "Emmet Carroll",
                activityName: "DSAA Final Exam 2022", Task: "Question 3a");

            int[] arr_i =  { 10, 5, 20, 3, 6, 15, 26 };
            Array.Sort(arr_i);
            for (int i = 0; i < arr_i.Length; i++)
            {
                Console.WriteLine("Int Array: {1}",i, arr_i[i]);
            }

            float[] arr_f = { 10.3f, 5f, 20f, 3f, 6f, 15f, 26f };
            foreach (float item in arr_f)
            {
                Console.WriteLine("Float Array: {0}", item);
            }
        }
        public static void InsertAll()
        {

        }
    }

   
}
