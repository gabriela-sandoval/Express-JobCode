using ExpressJob.Data;
using ExpressJob.Domain;
using ExpressJob.Services.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpressJob.Services.Repository
{
    public class TrabajadorRepository : ITrabajorRepository
    {
        private readonly ExpressJobContext _context = null;

        public TrabajadorRepository(ExpressJobContext context)
        {
            _context = context;
        }

        public Task<int> AddTrabajador(Trabajador trabajador)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Trabajador>> GetAllTrabajador()
        {
            throw new System.NotImplementedException();
        }
    }
}
