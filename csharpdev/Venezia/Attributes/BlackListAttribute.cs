using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Venezia.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BlackListAttribute : ValidationAttribute
    {
        private string _values;
        public BlackListAttribute(string values)
        {
            _values = values;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (_values.ToLower() == value?.ToString().ToLower())
            {
                return new ValidationResult(this.ErrorMessageString);
            }
            return ValidationResult.Success;
        }
    }
}
