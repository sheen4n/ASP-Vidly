using System.ComponentModel.DataAnnotations;

namespace VidlyASP.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}