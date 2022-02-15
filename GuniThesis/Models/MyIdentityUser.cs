using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GuniThesis.Models
{
    public class MyIdentityUser
                    :IdentityUser<Guid>
    {

        [Display(Name = "Display Name")]
        [Required]
        [MinLength(3)]
        [StringLength(60)]
        public string DisplayName { get; set; }

        [Display(Name = "Date of Birth")]
        [PersonalData]                                  // for GDPR Compliance.
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Is Admin User?")]
        [Required]
        public bool IsAdminUser { get; set; }

    }
}
