using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Debe de contener de 3 a 50 letras")]
        public string Nombre { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        public int CategoriaiId { get; set; }
    }
}