using System.ComponentModel.DataAnnotations;

namespace CustomValidations.Utility
{
    public class MaxFileResolutionsAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileResolutionsAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                if (file.Length > (100000* _maxFileSize))
                {
                    return new ValidationResult($"Maximum allowed File size is {_maxFileSize} MB.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
