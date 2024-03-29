﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min1InStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.Stock == 0 || movie.Stock > 20 || movie.Stock.ToString() == null)
            {
                return new ValidationResult("The field Number in Stock must be between 1 and 20.");
            }

            return ValidationResult.Success;
        }
    }
}