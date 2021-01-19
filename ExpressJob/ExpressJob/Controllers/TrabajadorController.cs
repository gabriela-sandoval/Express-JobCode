using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpressJob.Data;
using ExpressJob.Domain;
using ExpressJob.Services.Repository;
using ExpressJob.Services.IRepository;

namespace ExpressJob.Controllers
{
    public class TrabajadorController : Controller
    {
        private readonly ITrabajorRepository _trabajadorRepository = null;
        public TrabajadorController(ITrabajorRepository trabajorRepository)
        {
            _trabajadorRepository = trabajorRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddTrabajador(Trabajador trabajador)
        {
            var AddTrabajador = await _trabajadorRepository.AddTrabajador(trabajador);
            return Ok(AddTrabajador);
        }
    }
}
