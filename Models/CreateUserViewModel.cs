using System.ComponentModel.DataAnnotations;

namespace TWValidacao.Models;

public class CreateUserViewModel
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(255)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    [Phone]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [Url]
    public string ProfilePicture { get; set; } = string.Empty;

    [Required]
    [StringLength(255, MinimumLength = 5)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [StringLength(255, MinimumLength = 5)]
    [Compare(nameof(Password))]
    public string PasswordConfirmation { get; set; } = string.Empty;
}