using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El nombre debe de tener  de 3 a 50 carácteres")]       
        public string Nombre { get; set; }

        [StringLength(256, ErrorMessage ="La descripción no debe de exceder los 256 carácteres")]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public bool IsActivo { get; set; }
    }
}
