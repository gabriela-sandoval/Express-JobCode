using ExpressJob.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressJob.Domain
{
   public  class Trabajador
    {
        public string Descripcion { get; set; }

        public string TelefonoFijo { get; set; }

        public Municipio Municipio { get; set; }

    }
}
