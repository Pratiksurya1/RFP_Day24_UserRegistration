using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_24_UserRegistration
{
    internal class PatternCheck
    {
        public static string REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool FirstName(string name)
        {
            return Regex.IsMatch(name, REGEX);
        }

        public bool LastName(string name)
        {
            string LastNamePattern = "^[A-Z]{1}[A-Za-z]{2,}$";
            return Regex.IsMatch(name, LastNamePattern);
        }

        public bool Email(String email)
        {
            String EmailPattern = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            return Regex.IsMatch(email, EmailPattern);
        }
    }
}