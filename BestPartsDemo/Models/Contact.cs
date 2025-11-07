using System.ComponentModel.DataAnnotations;

namespace BestPartsDemo.Models;

public class Contact
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Company { get; set; }
    public string Role { get; set; }
}