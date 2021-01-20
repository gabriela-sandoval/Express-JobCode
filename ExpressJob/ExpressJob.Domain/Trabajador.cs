using ExpressJob.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using  Microsoft.AspNetCore.Http;

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

        /*public string FotoPerfil { get; set; }*/

        public List<TrabajadorServicio> TrabajadorServicios { get; set; }

        public virtual ExpressJobUser ExpressJobUser { get; set; }
        
        public IFormFile FotoPerfil { get; set; }
        
        }
}
