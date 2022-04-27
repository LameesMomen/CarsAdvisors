using CarsAdvisors.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CarsAdvisors.Models
{
    public class UniqueAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Cars Context = new Cars();
            Maker Maker = Context.Makers.FirstOrDefault(c => c.MakerName == value.ToString());
            Maker Mak = validationContext.ObjectInstance as Maker;

            if (Maker == null || Maker.ID == Mak.ID)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Name Already Exist");
        }
    }
}
