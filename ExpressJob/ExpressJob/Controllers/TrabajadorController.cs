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
using Microsoft.AspNetCore.Http;

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
               /*string folder = "trabajador/fotoPerfil/";*/
                /*trabajador.FotoPerfil = await UploadImage(folder, trabajador.FotoPerfil)*/
            }

            var trabajadordAdd = await _trabajadorRepository.AddTrabajador(trabajador);
            return Ok(trabajadordAdd);
        }


        private async Task<string> UploadImage(string folferPath, IFormFile file)
        {
            folferPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folferPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folferPath;

        }
    }
}
