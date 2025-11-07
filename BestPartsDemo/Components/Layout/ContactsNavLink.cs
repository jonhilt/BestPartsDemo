using Microsoft.AspNetCore.Components.Routing;

namespace BestPartsDemo.Components.Layout;

public class ContactsNavLink : NavLink
{
    protected override bool ShouldMatch(string uriAbsolute)
    {
        Console.WriteLine(uriAbsolute);
        return uriAbsolute.Contains("/contacts");
    }
}