using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_24_UserRegistration
{
    public class UserEntry:PatternCheck
    {
        String massage;

        public UserEntry(String massage)
        {
            this.massage = massage;
        }

        public void Validate()
        {
            if (massage.Contains("happy"))
            {
                Console.WriteLine("Enter First Name :");
                string name = Console.ReadLine();
                if (FirstName(name))
                     Console.WriteLine("First Name Is Valid");
                 else
                     Console.WriteLine("First Name Is Invalid");

                Console.WriteLine("Enter Last Name :");
                String lastName = Console.ReadLine();
                if (LastName(lastName))
                    Console.WriteLine("Last Name Is Valid");
                else
                    Console.WriteLine("Last Name Is Invalid");

                Console.WriteLine("Enter Email ID :");
                String MailId = Console.ReadLine();
                if (Email(MailId))
                    Console.WriteLine("Mail is valid");
                else
                    Console.WriteLine("Mail is Invalid");

                Console.WriteLine("Enter Mobile No :");
                String MNum = Console.ReadLine();
                if(MobileNum(MNum))
                    Console.WriteLine("Mobail No is Valid");
                else
                    Console.WriteLine("Mobail No is Invalid ");

                Console.WriteLine("Enter Password :");
                String pass = Console.ReadLine();
                if (PasswordRule4(pass))
                    Console.WriteLine("Password is Valid");
                else
                    Console.WriteLine("Password is Invalid");
            }
            else if(this.massage.Contains("sad"))
                Console.WriteLine("Test Cases is Sad Entry Is fails");
        }
    }
}
