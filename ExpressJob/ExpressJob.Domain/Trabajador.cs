using ExpressJob.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExpressJob.Domain
{
   public  class Trabajador
    {
        [Key]
        public string id_trabajador { get; set; }
        public string Descripcion { get; set; }

        public string TelefonoFijo { get; set; }

        public string TelefonoMovil { get; set; }

        public Municipio Municipio { get; set; }

    }
}
