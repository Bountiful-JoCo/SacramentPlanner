﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Speaker
    {

        public int ID { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter Last name using only letters, apostrophe or hyphen")]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter First name using only letters, apostrophe or hyphen")]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }


        public ICollection<Assignment> Assignments { get; set; }

        
        
    }
}
