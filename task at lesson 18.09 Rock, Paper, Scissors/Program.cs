using System;

namespace task_at_lesson_18._09_Rock__Paper__Scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ROCK, PAPER, SCISSORS


            Random random = new Random();
            string CPUChoise;
            int cpuwin = 0;
            int youwin = 0;
        begin:
            Console.WriteLine("Please Enter Your Choise (Rock, Paper, Scissors): ");
            string my_choise = Console.ReadLine();
            int choise = random.Next(1, 4);
            if (my_choise == "Rock" || my_choise == "Paper" || my_choise == "Scissors")
            {
                switch (choise)
                {
                    case 1:
                        CPUChoise = "Rock";
                        if (my_choise == "Paper")
                        {
                            Console.WriteLine("You Win");
                        }
                        else if (my_choise == "Scissors")
                        {
                            Console.WriteLine("CPU WIN");
                        }
                        else
                        {
                            Console.WriteLine("Equals");
                        }
                        cpuwin++;
                        youwin++;
                        if (cpuwin == 3)
                        {
                            Console.WriteLine("GAME OVER");
                            Console.WriteLine();
                            Console.WriteLine("{cpuwin}");
                            Console.WriteLine("{youwin}");
                        }
                        else if (youwin == 3)
                        {
                            Console.WriteLine("GAME OVER");
                            Console.ReadKey();
                            Console.WriteLine("{cpuwin}");
                            Console.WriteLine("{youwin}");
                        }
                        Console.WriteLine("Would you like to carry on(yes or no): ");
                        string yesNO = Console.ReadLine();
                        if (yesNO.ToLower() == "yes")
                        {
                            goto begin;
                        }
                        else
                        {
                            Console.WriteLine(" Please select X to EXIT");
                            Console.ReadKey();
                        }
                        break;


                    case 2:
                        CPUChoise = "Paper";
                        if (my_choise == "Rock")
                        {
                            Console.WriteLine("CPU Win");
                        }
                        else if (my_choise == "Scissors")
                        {
                            Console.WriteLine("You WIN");
                        }
                        else
                        {
                            Console.WriteLine("Equals");
                        }
                        Console.WriteLine("Would you like to carry on(yes or no): ");
                        string b = Console.ReadLine();
                        if (b == "yes")
                        {
                            goto begin;
                        }
                        else
                        {
                            Console.WriteLine(" Please select X to EXIT");
                            Console.ReadKey();
                        }
                        break;


                    case 3:
                        CPUChoise = "Scissors";
                        if (my_choise == "Rock")
                        {
                            Console.WriteLine("You Win");
                        }
                        else if (my_choise == "Paper")
                        {
                            Console.WriteLine("CPU WIN");
                        }
                        else
                        {
                            Console.WriteLine("Equals");
                        }
                        Console.WriteLine("Would you like to carry on(yes or no): ");
                        string c = Console.ReadLine();
                        if (c == "yes")
                        {
                            goto begin;
                        }
                        else
                        {
                            Console.WriteLine(" Please select X to EXIT");
                            Console.ReadKey();
                        }
                        break;
                }

            }
            else
            {
                Console.WriteLine("Please write your choise correctly");
                Console.WriteLine(" Please select X to EXIT");
                Console.ReadKey();
            }
            #endregion
        }
    }
}
