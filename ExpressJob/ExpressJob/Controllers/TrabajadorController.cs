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
        public async Task<IActionResult> AddNewTrabajador(Trabajador trabajador)
        {
            int id = await _trabajadorRepository.AddTrabajador(trabajador);
            if ( id > 0)
            {
                return RedirectToAction(nameof(AddNewTrabajador), new { IsSuccesss = true, IdTrabajador = id });
            }
            return View();
        }
      

        public ViewResult AddNewTrabajador (bool isSuccess = false, int IdTrabajador = 0)
        {
            var trabajador = new Trabajador();

            ViewBag.isSuccess = isSuccess;
            ViewBag.IdTranajador = IdTrabajador;

            return View(trabajador);
        }
    }
}
