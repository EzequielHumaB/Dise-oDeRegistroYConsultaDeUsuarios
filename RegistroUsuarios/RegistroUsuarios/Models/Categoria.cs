using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroUsuarios.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]  //Hace que llenar el campo sea obligatorio
        [StringLength(50,MinimumLength =2, ErrorMessage ="El nombre debe tener de minimo 2 y maximo 50 caracteres")]
        //El maximo de caracteres es de 50, y el minimo es 2
        public string Nombre { get; set; }

        [StringLength(200, ErrorMessage ="La descripcion no puede exceder los 200 caracteres")]
        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public Categoria()
        {
            Id = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            FechaCreacion = DateTime.Now;
        }
    }
}
