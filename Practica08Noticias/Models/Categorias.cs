using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica08Noticias.Models
{
    public class Categorias
    {
        public int CategoriasID { get; set; }

        [Required]
        public string Nombre { get; set; }

        //Una categoria puede tener varias noticias (Es una colección o lista de elementos en este caso varias noticias)
        public virtual ICollection<Noticias> Noticias { get; set; }
    }
}
