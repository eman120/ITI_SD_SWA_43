using Microsoft.AspNetCore.Mvc.Filters;
using CarsApi.Models;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace CarsApi.Validations
{
    public class ValidateCarTypeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Car? car = context.ActionArguments["Car"] as Car;
            var regex = new Regex("^(Electric|Gas|Diesel|Hybrid)$",
                RegexOptions.IgnoreCase,
                TimeSpan.FromSeconds(2));
            if (car is null || !regex.IsMatch(car.Type))
            {
                context.ModelState.AddModelError("Type", "Type is not correct");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
