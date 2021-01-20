using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ExpressJob.Domain.Enum;
using Microsoft.AspNetCore.Identity;

namespace ExpressJob.Domain
{
    // Add profile data for application users by adding properties to the ExpressJobUser class
    public class ExpressJobUser : IdentityUser
    {

        public ExpressJobUser()
        {
           

        }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Apellidos { get; set; }

        public virtual Trabajador Trabajadors { get; set; }

      

    }
}
