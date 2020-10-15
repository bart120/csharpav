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
        private object[] _values;
        public BlackListAttribute(params object[] values)
        {
            _values = values;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            foreach (var item in _values)
            {
                if(value is IComparable && !(value is string))
                {
                    var result = ((IComparable)value).CompareTo(item);
                    if(result == 0)
                        return new ValidationResult(this.ErrorMessageString);
                }
                 
                if (item.ToString().ToLower() == value?.ToString().ToLower())
                {
                    return new ValidationResult(this.ErrorMessageString);
                }
            }
            
            return ValidationResult.Success;
        }
    }
}
