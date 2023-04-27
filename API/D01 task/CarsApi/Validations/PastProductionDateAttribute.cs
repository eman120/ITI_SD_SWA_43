using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace CarsApi.Validations
{
    public class PastProductionDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value) => value is DateTime date && date < DateTime.Now;
    }
}
