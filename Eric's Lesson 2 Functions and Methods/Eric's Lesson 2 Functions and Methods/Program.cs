using System;

namespace Eric_s_Lesson_2_Functions_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "Hello";
            PrintThreeTimes(x);

            x = "Hi";
            PrintThreeTimes(x);

        }

        private static void PrintThreeTimes(string x)
        {
            Console.WriteLine(x);
            Console.WriteLine(x);
            Console.WriteLine(x);
        }
    }
}
