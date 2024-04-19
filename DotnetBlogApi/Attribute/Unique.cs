using DotnetBlogApi.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DotnetBlogApi.Attribute
{
    public class Unique : ValidationAttribute
    {
        private readonly string _IdPropertyName;
        public Unique(string IdPropertyName)
        {
            _IdPropertyName = IdPropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string name = value.ToString();
            var property = validationContext.ObjectType.GetProperty(_IdPropertyName);
            if (property != null)
            {
                var idValue = property.GetValue(validationContext.ObjectInstance, null);
                var _context = (DataContext)validationContext.GetService(typeof(DataContext));
                var entity = _context.Users.SingleOrDefault(e => e.Username == value.ToString() && e.Id != int.Parse(string.Format("{0}", idValue)));

                if (entity != null)
                {
                    return new ValidationResult(GetErrorMessage(value.ToString()));
                }
            }

            return ValidationResult.Success;
        }
        public string GetErrorMessage(string name)
        {
            return $"Name {name} is already in use.";
        }
    }
}
