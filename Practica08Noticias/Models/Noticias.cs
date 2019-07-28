using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica08Noticias.Models
{
    public class Noticias
    {
        //Se Agrega constructos para iniciar feha de publicación
        public Noticias() {
            FechaPublicacion = DateTime.Now;
}

        public int NoticiasID { get; set; }

        [Required(ErrorMessage = "El campo Titulo es Requerido")]
        [StringLength(100, ErrorMessage = "La longitud máxima es de 100")]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Contenido { get; set; }

        
        public DateTime FechaPublicacion { get; set; }

        //Foreign Key , sirve para hacer referencia a la tabla Categorias
        public int CategoriasID { get; set; }
        public virtual Categorias Categoria { get; set; }

    }
}
