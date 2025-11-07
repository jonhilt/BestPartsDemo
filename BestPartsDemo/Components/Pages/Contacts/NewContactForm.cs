using BestPartsDemo.Models;

namespace BestPartsDemo.Components.Pages.Contacts;

// [NoBot]
// [ValidatableType]
public class NewContactForm
{
    public Contact Contact { get; set; }
    public string? Honeypot { get; set; }
}