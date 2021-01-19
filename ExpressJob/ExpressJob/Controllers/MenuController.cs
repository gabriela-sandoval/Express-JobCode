using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressJob.Controllers
{
    public class MenuController : Controller
    {
        public ViewResult Menu()
        {
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
