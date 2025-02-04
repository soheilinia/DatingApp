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
}