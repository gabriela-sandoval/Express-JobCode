using ExpressJob.Domain;
using ExpressJob.Services.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressJob.Controllers
{
    public class MenuController : Controller
    {
        private readonly TrabajadorRepository _trabajadorRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;

        public MenuController(TrabajadorRepository trabajorRepository, IWebHostEnvironment webHostEnvironment)
        {
            _trabajadorRepository = trabajorRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public ViewResult Menu()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OfrecerServicios(Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                var trabajadordAdd = await _trabajadorRepository.AddTrabajador(trabajador);
                if (trabajadordAdd > 0)
                {
                    return RedirectToAction(nameof(ServiciosTrabajador), new { isSuccess = true, idTrabajador = trabajador.IdTrabajador });
                }
            }
            return View();
        }

        public IActionResult OfrecerServicios()
        {
            return View();
        }

        public IActionResult ServiciosTrabajador()
        {
            return View();
        }

        public IActionResult NuevoServicioTrabajador()
        {
            return View();
        }

        public IActionResult Servicios()
        {
            return View();
        }

        public IActionResult ListaServiciosPorCategoria()
        {
            return View();
        }

        public IActionResult DetallesServicio()
        {
            return View();
        }
        
    }
}
