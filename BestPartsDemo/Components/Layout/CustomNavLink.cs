using Microsoft.AspNetCore.Components.Routing;

namespace BestPartsDemo.Components.Layout;

public class CustomNavLink : NavLink
{
    protected override bool ShouldMatch(string uriAbsolute)
    {
        return uriAbsolute.EndsWith("bob");
    }
}