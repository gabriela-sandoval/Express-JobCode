
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ExpressJob.Domain
{
    public class Trabajador
    {
        public Trabajador()
        {
            this.TrabajadorServicios = new List<TrabajadorServicio>();
        }

        [Key]
        public int IdTrabajador { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Phone]
        [MaxLength (10)]
        [MinLength(10)]
        [Display(Name = "teléfono fijo")]
        public string TelefonoFijo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Phone]
        [MaxLength(10)]
        [MinLength(10)]
        [Display(Name = "teléfono móvil")]
        public string TelefonoMovil { get; set; }

       // [NotMapped]
        //public IFormFile FotoPerfil { get; set; }

        public List<TrabajadorServicio> TrabajadorServicios { get; set; }

        public int IdExpressJobUser { get; set; } 
        
        public virtual ExpressJobUser ExpressJobUser { get; set; }
        
    
        
        

    }
}
