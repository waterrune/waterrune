using System;

namespace Eric_s_Lesson_2_Functions_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintThreeTimes("Hello");

            
            PrintThreeTimes("Hi");

        }

        private static void PrintThreeTimes(string x)
        {
            Console.WriteLine(x);
            Console.WriteLine(x);
            Console.WriteLine(x);
        }
    }
}
