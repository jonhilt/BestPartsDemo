namespace BestPartsDemo.Components.Pages.Contacts;

public record ContactSortState(SortField Field, bool IsDescending);

public enum SortField
{
    Name,
    Company,
    JobTitle
}