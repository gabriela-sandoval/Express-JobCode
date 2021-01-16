using ExpressJob.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExpressJob.Services.IRepository
{
   public  interface IServicioRepository
    {
        Task<List<Servicio>> GetAllServicio();
    }
}
