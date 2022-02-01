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

            //Uc3

            Console.WriteLine("Enter Email ID :");
            String MailId = Console.ReadLine();
            if (patternCheck.Email(MailId))
                Console.WriteLine("Email ID Is Valid");
            else
                Console.WriteLine("Email ID Is Invalid");

            //Uc4

            Console.WriteLine("Enter Mobile No :");
            String MNum = Console.ReadLine(); 
            if (patternCheck.MobileNum(MNum))
                Console.WriteLine("Mobile Number Is Valid");
            else
                Console.WriteLine("Mobile Number Is Invalid");

            //Uc5

            Console.WriteLine("Enter Password :");
            String pass1 = Console.ReadLine();
            if (patternCheck.PasswordRule1(pass1))
                Console.WriteLine("Password Is Valid");
            else
                Console.WriteLine("Password Is Invalid");

            //Uc6

            Console.WriteLine("Enter Password :");
            String pass2 = Console.ReadLine();
            if (patternCheck.PasswordRule2(pass2))
                Console.WriteLine("Password Is Valid");
            else
                Console.WriteLine("Password Is Invalid");



        }
    }
}
