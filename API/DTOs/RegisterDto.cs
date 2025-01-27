using System.ComponentModel.DataAnnotations;

namespace API.Controllers;

public class RegisterDto
{
    [Required]
    [StringLength(50, MinimumLength = 4)]
    public required string Username { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 4)]
    public required string Password { get; set; }
}