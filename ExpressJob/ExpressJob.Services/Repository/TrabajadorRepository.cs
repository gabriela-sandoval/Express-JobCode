using ExpressJob.Data;
using ExpressJob.Domain;
using ExpressJob.Services.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<int> AddTrabajador(Trabajador trabajador)
        {
            var newTrabajador = new Trabajador()
            {
                Descripcion = trabajador.Descripcion,
                TelefonoFijo = trabajador.TelefonoFijo,
                TelefonoMovil = trabajador.TelefonoMovil,
                FotoPerfil = trabajador.FotoPerfil

            };

            await _context.Trabajadors.AddAsync(newTrabajador);
            await _context.SaveChangesAsync();

            return newTrabajador.IdTrabajador;
        }

        

        public async Task<List<Trabajador>> GetAllTrabajador()
        {
            return await _context.Trabajadors
                .Select(t => new Trabajador()
                {
                    Descripcion = t.Descripcion,
                    TelefonoFijo = t.TelefonoFijo, 
                    TelefonoMovil = t.TelefonoMovil,
                    FotoPerfil = t.FotoPerfil
                }).ToListAsync();
        }
    }
}
