using System.ComponentModel.DataAnnotations;
using Michaelsoft.BodyGuard.Common.Attributes;
using Michaelsoft.BodyGuard.Common.Models;
using Newtonsoft.Json;

namespace Michaelsoft.BodyGuard.Common.HttpModels.Authentication
{
    public class UserCreateRequest
    {

        [Required]
        [JsonRequired]
        [MinLength(5)]
        [MaxLength(320)]
        [EmailAddress]
        [Display(Name = "email_address")]
        public string EmailAddress { get; set; }

        [Required]
        [JsonRequired]
        [MinLength(6)]
        [MaxLength(64)]
        [ValidatePassword]
        [Display(Name = "password")]
        public string Password { get; set; }

        [Required]
        [JsonRequired]
        [MinLength(6)]
        [MaxLength(64)]
        [ValidatePassword]
        [Compare("Password")]
        [Display(Name = "password_confirm")]
        public string PasswordConfirm { get; set; }

        public User UserData { get; set; }
        
        public int TtlSeconds { get; set; } = 48 * 3600;

        public string ConfirmRegistrationUrl { get; set; } = "/Authentication/ConfirmRegistration?token={{token}}";

    }
}