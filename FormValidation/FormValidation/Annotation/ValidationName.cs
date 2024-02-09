using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;


namespace FormValidation.Annotation
{
    public class ValidationName : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) { return false; }

            string namePattern = @"^[a-zA-Z\s\-']+$";
            string inputName = value.ToString();

            if (Regex.IsMatch(inputName, namePattern))
            {
                return true;
            }


            return false;

        }



    }
}