using System;
using System.Text.RegularExpressions;

namespace Day_24_UserRegistration
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Reg using Lambda Expressions!");
            
            PatternCheck patternCheck = new PatternCheck();

            //Uc1
            Console.WriteLine("Enter First Name :");
            string name = Console.ReadLine();
            if (patternCheck.FirstName(name))
                Console.WriteLine(" First Name Is Valid");
            else
                Console.WriteLine("First Name Is Invalid");

            //Uc2 

            Console.WriteLine("Enter Last Name Name :");
            String lastName= Console.ReadLine();
            if (patternCheck.LastName(lastName))
                Console.WriteLine("Last Name Is Valid");
            else
                Console.WriteLine("Last Name Is Invalid");
        }
    }
}
