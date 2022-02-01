﻿using System;
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

        public bool MobileNum(String Mnum)
        {
            String MobileNumPattern = "^[9][1][7-9]{1}[0-9]{9}$";
            return Regex.IsMatch(Mnum, MobileNumPattern);
        }

        public bool PasswordRule1(String pass)
        {
            String PasswordRulePattern1 = "^[A-Za-z]{8,}$";
            return Regex.IsMatch(pass, PasswordRulePattern1);
        }

        public bool PasswordRule2(String pass)
        {
            String PasswordRulePattern2 = "^(?=.*?[A-Z])[A-Za-z0-9@$!%*#?&]{8,}$";
            return Regex.IsMatch(pass, PasswordRulePattern2);
        }

        public bool PasswordRule3(String pass)
        {
            String PasswordRulePattern3 = "^(?=.*?[A-Z])[A-Za-z0-9@$!%*#?&]{8,}$";
            return Regex.IsMatch(pass, PasswordRulePattern3);
        }

        public bool PasswordRule4(String pass)
        {
            String PasswordRulePattern4 = "^[A-Za-z0-9]*[@$!%*#?&]{1}[A-Za-z0-9]*$";
            return Regex.IsMatch(pass, PasswordRulePattern4);
        }

        public bool EmailSamples(String email)
        {
            String EmailSample= "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            return Regex.IsMatch(email,EmailSample);
        }
    }
}