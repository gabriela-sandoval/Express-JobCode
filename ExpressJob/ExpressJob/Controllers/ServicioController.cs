using ExpressJob.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressJob.Domain;

namespace ExpressJob.Controllers
{
    public class ServicioController : Controller
    {
        private readonly ServicioRepository _servicioRepository = null;
        
        public ServicioController(ServicioRepository servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddServicio(TrabajadorServicio trabajadorServicio)
        {
            var servicioAdd = await _servicioRepository.AddServico(trabajadorServicio);
            return Ok(trabajadorServicio);
        }
        
    }
}
