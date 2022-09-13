
using PointOfSale.Windows.Helpers.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Windows.Helpers
{
    public class ValidationHelper : IValidationHelpers
    {
        /// <summary>
        /// Validate the given model and return the errors if any in the list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<ValidationResult> Validate<T>(T model)
        {
            var context = new ValidationContext(model, null, null);
            var validationErrors = new List<ValidationResult>();
            Validator.TryValidateObject(model, context, validationErrors, true);
            return validationErrors;
        }

        public string ValidateReturnMessage<T>(T model)
        {
            return GetValidationMessage(Validate(model));
        }

        /// <summary>
        /// Get the validation message as string 
        /// </summary>
        /// <param name="validationErrors"></param>
        /// <returns></returns>
        public string GetValidationMessage(List<ValidationResult> validationErrors)
        {
            if (validationErrors?.Count() == 0)
            {
                return string.Empty;
            }

            StringBuilder sbValidationMessage = new StringBuilder();
            foreach (ValidationResult validationResult in validationErrors)
            {
                sbValidationMessage.AppendLine(validationResult.ErrorMessage);
            }

            return sbValidationMessage.ToString();
        }
    }
}
