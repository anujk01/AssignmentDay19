using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay19
{
    public class UC2
    {
        public string Regex_Pattern = "^[A-Za-z]{3,}$";

        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, Regex_Pattern);
        }
    }
}