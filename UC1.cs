using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay19
{
    class UC1
    {
        public string Name_Regex = "^[A-Za-z]{3,}$";

        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, Name_Regex);
        }
    }
}
