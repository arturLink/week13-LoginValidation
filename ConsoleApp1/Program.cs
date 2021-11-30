using System;

namespace ConsoleAppudde
{
    class Program
    {
        static void Main(string[] args)
        {
            // login: admin
            // password: pass

            //declare variables
            //assign value
            string login = "admin";
            string passworrd = "pass";
            int tries = 0;
            string userName, userPassword;
            while (tries != 3)
            {
                Console.WriteLine("Enter your login: ");
                userName = Console.ReadLine();
                Console.WriteLine("Enter your password");
                userPassword = Console.ReadLine();

                if (login != userName || passworrd != userPassword)
                {
                    Console.WriteLine($"oopsie. Something went wrong{tries}");
                    tries++;
                }
                else
                {
                    Console.WriteLine("welcome");
                }
            }
        }
    }
}
