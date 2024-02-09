using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;

namespace FormValidation.Annotation
{
    public class ValidationEmail : ValidationAttribute
    {
         
        public override bool IsValid(object value)
        {
            if (value == null) { return false; }
            string inputEmail = value.ToString();

        string emailPattern = @"^\d{2}-\d{5}-[1-3]@student\.aiub\.edu$";

            if (Regex.IsMatch(inputEmail, emailPattern))
            {
                return true;
            }


            return false;

        }
    }
}