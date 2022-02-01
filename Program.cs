using System;
using System.Text.RegularExpressions;

namespace Day_24_UserRegistration
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Reg using Lambda Expressions!");
            Console.WriteLine("Enter First Name :");
            string name = Console.ReadLine(); 
            PatternCheck patternCheck = new PatternCheck();
            if (patternCheck.FirstName(name))
                Console.WriteLine(" First Name Is Valid");
            else
                Console.WriteLine("First Name Is Invalid");
        }
    }
}
