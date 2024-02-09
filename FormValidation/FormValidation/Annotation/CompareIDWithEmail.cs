using FormValidation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.Annotation
{
    public class CompareIDWithEmail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (UserInfo)validationContext.ObjectInstance;

                                                            // Extract the prefix of the email
            string emailPrefix = user.Email?.Split('@')[0]; 

                                                            // Compare the entire ID with the email prefix
            if (user.Id != emailPrefix)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}