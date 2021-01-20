using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExpressJob.Domain;
using ExpressJob.Services.Repository;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;


namespace ExpressJob.Controllers
{
    public class TrabajadorController : Controller
    {
        private readonly TrabajadorRepository _trabajadorRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;
        private readonly UserManager<ExpressJobUser> UserManager;



        public TrabajadorController(TrabajadorRepository trabajorRepository, IWebHostEnvironment webHostEnvironment, UserManager<ExpressJobUser> userManager)
        {
            _trabajadorRepository = trabajorRepository;
            _webHostEnvironment = webHostEnvironment;
            UserManager = userManager;
        }
        
        
        
        [HttpPost]
        public async Task<IActionResult> AddTrabajador(Trabajador trabajador)
        {
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
