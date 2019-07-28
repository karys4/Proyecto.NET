using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Practica08Noticias.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string Nombre { get; set; }

        [PersonalData]
        public int Edad { get; set; }

    }
}
