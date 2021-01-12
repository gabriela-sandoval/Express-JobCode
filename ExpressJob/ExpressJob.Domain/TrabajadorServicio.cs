using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressJob.Domain
{
    public class TrabajadorServicio
    {
        public int TrabajadorId { get; set; }

        public int ServicioId { get; set; }

        public virtual Trabajador Trabajador { get; set; }

        public virtual Servicio Servicio { get; set; }


    }
}
