using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if(customer.MembershipTypeId== MembershipType.Unknown ||customer.MembershipTypeId== MembershipType.Free)
                return ValidationResult.Success;
            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is required");
            var age = DateTime.Today.Year - customer.BirthDate.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customers should be at least 18 years old!");
        }
    }
}