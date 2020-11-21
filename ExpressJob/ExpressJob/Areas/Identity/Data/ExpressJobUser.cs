using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ExpressJob.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ExpressJobUser class
    public class ExpressJobUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Apellidos { get; set; }
    }
}
