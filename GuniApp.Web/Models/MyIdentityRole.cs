using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace GuniApp.Web.Models
{
    public class MyIdentityRole
      : IdentityRole<Guid>
    {

        [StringLength(100)]
        public string Description { get; set; }

    }
}
