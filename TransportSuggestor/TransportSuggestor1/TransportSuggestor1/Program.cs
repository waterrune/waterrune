using System;

namespace TransportSuggestor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = GetDistanceFromUser();
            SuggestTransport(distance);
        }


        private static void SuggestTransport(int distance)
        {
            if (distance >= 100)
            {
                Console.WriteLine("Bus");
            }
            else
            {
                Console.WriteLine("Walk");
            }
        }

        private static int GetDistanceFromUser()
        {
            Console.WriteLine("What is the distance between your start and end in metres. Type numbers only");
            string distance = Console.ReadLine();
            int distanceInt = Convert.ToInt32(distance);
            return distanceInt;
        }
    }
}
