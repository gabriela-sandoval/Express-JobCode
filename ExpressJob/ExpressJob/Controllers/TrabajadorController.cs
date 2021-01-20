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
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace ExpressJob.Controllers
{
    public class TrabajadorController : Controller
    {
        private readonly TrabajadorRepository _trabajadorRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;

        public TrabajadorController(TrabajadorRepository trabajorRepository, IWebHostEnvironment webHostEnvironment)
        {
            _trabajadorRepository = trabajorRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> AddTrabajador(Trabajador trabajador)
        {
            if (trabajador.FotoPerfil != null)
            {
                string folder = "trabajador/fotoPerfil/";
                folder += trabajador.FotoPerfil.FileName+Guid.NewGuid().ToString();
                string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                await trabajador.FotoPerfil.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            }

            var trabajadordAdd = await _trabajadorRepository.AddTrabajador(trabajador);
            return Ok(trabajadordAdd);
        }
    }
}
