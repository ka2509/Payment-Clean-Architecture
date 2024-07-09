using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCleanArchitecture.Application.Features.User.DTOs
{
    public class CreateUserDto
    {
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Student Identity must contain only digits.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Student Identity must contain exactly 6 digits.")]
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required, Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
