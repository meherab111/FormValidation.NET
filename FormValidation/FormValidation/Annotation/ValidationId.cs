using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FormValidation.Annotation
{
    public class ValidationId : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) { return false; }
            string inputId = value.ToString();

            string idPattern = @"^\d{2}-\d{5}-[1-3]$";

            if (Regex.IsMatch(inputId, idPattern))
            {
                return true;
            }


            return false;

        }
    }
}