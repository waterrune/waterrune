using System;

namespace TransportSuggestor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the distance between your start and end in metres. Type numbers only");

            string distance = Console.ReadLine();

            int distanceInt = Convert.ToInt32(distance);

            if (distanceInt >= 100)
            {
                Console.WriteLine("Bus");
            }
            else
            {
                Console.WriteLine("Walk");
            }
        }
    }
}
