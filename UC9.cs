﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay19
{
    class UC9
    {
        public string Regex_Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool validateEmail(string emailsample)
        {
            return Regex.IsMatch(emailsample, Regex_Pattern);
        }
    }
}