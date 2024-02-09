using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FormValidation.Annotation
{
    public class ValidationUname : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) { return false; }

            string inputUname = value.ToString();

            string unamePattern = @"^[a-zA-Z0-9!@#$%^&*()\-_=+`~|\[\]{};:'"",<.>/?]{1,10}$";

            if (Regex.IsMatch(inputUname, unamePattern))
            {
                return true;
            }


            return false;

        }
    }
}