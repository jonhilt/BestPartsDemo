namespace BestPartsDemo.Models;

public class Contact
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Company { get; set; }
    public required string Role { get; set; }
}