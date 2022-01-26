using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay19
{
    public class UC4
    {
        public string Regex_Pattern = "^[/+]{1}[9]{1}[1]{1}[7-9]{1}[0-9]{9}$";

        public bool validatePhoneNumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, Regex_Pattern);
        }
    }
}