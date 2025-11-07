using System.ComponentModel.DataAnnotations;

namespace BestPartsDemo.Components.Pages.Contacts;

public class NoBotAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext _)
    {
        var botWarningSigns = 0;
        if (value is not NewContactForm registration)
            return new ValidationResult("Invalid registration data.");
        // Honeypot field: bots often fill hidden fields
        if (!string.IsNullOrEmpty(registration.Honeypot))
        {
            botWarningSigns += 1;
        }

        // other checks here...
        return botWarningSigns >= 1
            ? new ValidationResult("Bot-like behavior detected!")
            : ValidationResult.Success;
    }
}