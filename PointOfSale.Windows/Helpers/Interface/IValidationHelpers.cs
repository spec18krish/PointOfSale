using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Windows.Helpers.Interface
{
    public interface IValidationHelpers
    {
        List<ValidationResult> Validate<T>(T model);
        string ValidateReturnMessage<T>(T model);
        string GetValidationMessage(List<ValidationResult> validationErrors);
    }
}
