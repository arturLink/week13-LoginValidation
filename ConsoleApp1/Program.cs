using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // login: admin
            // password: pass1234

            //declare variables
            //assign value
            string login = "admin";
            string passworrd = "pass";

            string userName, userPassword;
            Console.WriteLine("Enter your login: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password");
            userPassword = Console.ReadLine();

            if (login == userName && passworrd == userPassword)
            {
                Console.WriteLine("Welcome bud");
            }
            else
            {
                Console.WriteLine("Goodbye bud");
            }
        }
    }
}
