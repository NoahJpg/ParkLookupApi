using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.Models
{
  public class Parks
  {
    public int ParksId { get; set; }

    [Required]
    [StringLength(20)]
    public string ParkName { get; set; }

    [Required]
    [StateOrNational(ErrorMessage = "Type must be 'State' or 'National'")]
      public string Type { get; set; }
  }

  //custom validation for Type to be 'State' or 'National' only
  public class StateOrNationalAttribute : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      var type = value as string;
      if (type == null || (type.ToLower() != "state" && type.ToLower() != "national"))
      {
        return new ValidationResult($"{validationContext.DisplayName} must be 'State' or 'National'");
      }
      return ValidationResult.Success;
    }
  }
}