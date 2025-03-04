using System.ComponentModel.DataAnnotations;

namespace API.Controllers;

public class RegisterDto
{
    [Required]
    [StringLength(50, MinimumLength = 4)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [StringLength(50, MinimumLength = 4)]
    public string Password { get; set; } = string.Empty;

    [Required]
    public string? KnownAs { get; set; }

    [Required]
    public string? Gender { get; set; }

    [Required]
    public string? DateOfBirth { get; set; }

    [Required]
    public string? City { get; set; }
    
    [Required]
    public string? Country { get; set; }

    
}