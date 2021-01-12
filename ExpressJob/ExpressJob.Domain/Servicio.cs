using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExpressJob.Domain
{
    public class Servicio
    {
        public Servicio()
        {
            this.TrabajadorServicios = new List<TrabajadorServicio>();
        }

        [Key]
        public int IdServicio { get; set; }

        public string NombreServicio { get; set; }

        public List<TrabajadorServicio> TrabajadorServicios { get; set; }
       
    }
}
