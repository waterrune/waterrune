using System;

namespace Quiz_Easy_Version_3
{
    class Program
    {
        static void Main(string[] args)


        {
            //start of loop 1 for question 1
            int i = 0;

            for (; ; )
            {
                if (i < 4)

                {
                    Console.WriteLine("Welcome User. We are going to test you 3 questions. Answer correctly to proceed to next question." + '\n' + "Press 'a', 'b', or 'c'. " + '\n');
                    Console.WriteLine("Question 1: Which is red?" + '\n' + "a) Apple" + '\n' + "b) Banana" + '\n' + "c) Cranberry");

                    var ans = Console.ReadLine();
                    i++;


                    if (ans == "a")
                    {
                        Console.WriteLine("Correct!");
                        //start of loop 2 for question 2
                        int i2 = 0;
                        for (; ; )
                        {
                            if (i2 < 4)
                                Console.WriteLine("Question 2: Which is blue?" + '\n' + "a) Water" + '\n' + "b) Horseshoe Crab Blood" + '\n' + "c) Oats");
                            var ans2 = Console.ReadLine();
                            i2++;
                            if (ans2 == "b")

                            {
                                Console.WriteLine("Correct!");
                                //start of loop 3 for question 3
                                int i3 = 0;
                                for (; ; )
                                {
                                    if (i3 < 4)
                                        Console.WriteLine("Question 3: Which is purple?" + '\n' + "a) Mr Bean" + '\n' + "b) You" + '\n' + "c) Ditto");
                                    var ans3 = Console.ReadLine();
                                    i3++;
                                    if (ans3 == "c")

                                    {
                                        Console.WriteLine("Correct! Congratulations! You've made it to the end! Score: 3/3");
                                        Environment.Exit(0);
                                    }
                                    else if (ans3 == "a")
                                    {

                                        Console.WriteLine("Wrong!");
                                        if (i3 == 4)
                                            break;
                                    }

                                    else if (ans3 == "b")
                                    {
                                        Console.WriteLine("Wrong!");
                                        if (i3 == 4)
                                            break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You have entered an invalid key! Please enter again");
                                        if (i3 == 4)
                                            break;
                                    }
                                }
                                Console.WriteLine("You lose!");
                                Environment.Exit(0);
                            }
                            else if (ans2 == "a")
                            {
                                Console.WriteLine("Wrong!");
                                if (i2 == 4)
                                    break;

                            }
                            else if (ans2 == "c")
                            {
                                Console.WriteLine("Wrong!");
                                if (i2 == 4)
                                    break;
                            }
                            else
                            {
                                Console.WriteLine("You have entered an invalid key! Please enter again");
                                if (i2 == 4)
                                    break;
                            }
                        }
                        Console.WriteLine("You lose!");
                        Environment.Exit(0);

                    }


                    else if (ans == "b")
                    {
                        Console.WriteLine("Wrong!");
                        if (i == 4)
                            break;

                    }



                    else if (ans == "c")
                    {

                        Console.WriteLine("Wrong!");
                        if (i == 4)
                            break;

                    }

                    else
                    {
                        Console.WriteLine("You have entered an invalid key! Please enter again");
                        if (i == 4)
                            break;

                    }
                }

            }
            Console.WriteLine("You lose!");
            Environment.Exit(0);






        }
    }
}
