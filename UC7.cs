using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay19
{
    public class UC7
    {
        public string Regex_Pattern = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z]).*$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Pattern);
        }
    }
}