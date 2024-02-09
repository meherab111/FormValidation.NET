using FormValidation.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage = "*Please Provide Name")]
        [ValidationName(ErrorMessage = "*Alphabets, hyphen and space Allowed")]
        public string Name { get; set; }
        

        [Required(ErrorMessage = "*Please Provide Username")]
        [ValidationUname(ErrorMessage = "*Max 10 char, numbers and special char Allowed")]
        public string Uname { get; set; }
        
        
        [Required(ErrorMessage = "*Please Provide ID")]
        [ValidationId(ErrorMessage = "*Wrong format, eg. (12-*****-1)")]
       
        public string Id { get; set; }
        

        [Required(ErrorMessage = "*Please Provide Email")]
        [ValidationEmail(ErrorMessage = "*Wrong format, eg. (12-*****-1@student.aiub.edu)")]
        [CompareIDWithEmail(ErrorMessage = "ID and email format portion do not match")]
        public string Email { get; set; }

 



    }
}