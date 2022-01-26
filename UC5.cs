using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay19
{
    public class UC5
    {
        public string Regex_Pattern = @"[A-Z,a-z,0-9]{8,}$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Pattern);
        }
    }
}