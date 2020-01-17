using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VidlyASP.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Phone")]
        public string Phone { get; set; }
    }
}