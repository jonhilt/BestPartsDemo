using Microsoft.AspNetCore.Components.Routing;

namespace BestPartsDemo.Components.Layout;

/// <summary>
/// A NavLink that matches on /contacts in the URI
/// </summary>
public class ContactsNavLink : NavLink
{
    protected override bool ShouldMatch(string uriAbsolute)
    {
        return uriAbsolute.Contains("/contacts");
    }
}