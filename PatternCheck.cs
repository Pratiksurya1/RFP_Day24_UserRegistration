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

    }
}