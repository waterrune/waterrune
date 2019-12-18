using System;

namespace Quiz_Easy_Version_3
{
    class Program
    {
        static void Main(string[] args)

        {
            Boolean forever = true;
            while (forever)
            {

                Console.WriteLine("Welcome User. We are going to test you 3 questions. Answer correctly to proceed to next question." + '\n' + "Press 'a', 'b', or 'c'. " + '\n');
                Console.WriteLine("Question 1: Which is red?" + '\n' + "a) Apple" + '\n' + "b) Banana" + '\n' + "c) Cranberry");

                var ans = Console.ReadLine();



                if (ans == "a")
                {
                    Console.WriteLine("Correct!");
                    break;
                }

                else if (ans == "b")
                {
                    Console.WriteLine("Wrong!");

                }
                else if (ans == "c")
                {
                    Console.WriteLine("Wrong!");

                }
                else
                {
                    Console.WriteLine("You have entered an invalid key! Please enter again");

                }




            }
            bool forever2 = true;
            while (forever2)

            {

                Console.WriteLine("Question 2: Which is blue?" + '\n' + "a) Water" + '\n' + "b) Horseshoe Crab Blood" + '\n' + "c) Oats");
                var ans2 = Console.ReadLine();

                if (ans2 == "b")


                {
                    Console.WriteLine("Correct!");

                    break;
                }
                else if (ans2 == "a")
                {
                    Console.WriteLine("Wrong!");

                }
                else if (ans2 == "c")
                {
                    Console.WriteLine("Wrong!");

                }
                else
                {
                    Console.WriteLine("You have entered an invalid key! Please enter again");

                }


            }
            Boolean forever3 = true;

            while (forever3)
            {


                Console.WriteLine("Question 3: Which is purple?" + '\n' + "a) Mr Bean" + '\n' + "b) You" + '\n' + "c) Ditto");
                var ans3 = Console.ReadLine();
                if (ans3 == "c")



                {
                    Console.WriteLine("Correct! Congratulations! You've made it to the end! Score: 3/3");
                    break;

                }
                else if (ans3 == "a")
                {
                    Console.WriteLine("Wrong!");

                }
                else if (ans3 == "b")
                {
                    Console.WriteLine("Wrong!");

                }
                else
                {
                    Console.WriteLine("You have entered an invalid key! Please enter again");

                }

            }
        }
    }
}
