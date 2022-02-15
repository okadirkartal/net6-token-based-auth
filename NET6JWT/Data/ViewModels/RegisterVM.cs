using System.ComponentModel.DataAnnotations;

namespace NET6JWT.Data.ViewModels;
public class RegisterVM
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required]
    public string EmailAddress { get; set; }
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Role { get; set; }
}