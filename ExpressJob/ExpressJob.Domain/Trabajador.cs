using ExpressJob.Domain.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExpressJob.Domain
{
    public class Trabajador
    {
        public Trabajador()
        {
            this.TrabajadorServicios = new List<TrabajadorServicio>();
        }

        [Key]
        public int IdTrabajador { get; set; }
       
        public string Direccion { get; set; }

        public string TelefonoFijo { get; set; }

        public string TelefonoMovil { get; set; }

        [NotMapped]
        public IFormFile FotoPerfil { get; set; }

        public List<TrabajadorServicio> TrabajadorServicios { get; set; }

        public virtual ICollection<ExpressJobUser> ExpressJobUser { get; set; }

    }
}
