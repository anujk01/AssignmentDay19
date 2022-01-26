using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay19
{
    public class UC3
    {
        public string Regex_Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Pattern);
        }
    }
}
