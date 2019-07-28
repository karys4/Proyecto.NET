using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica08Noticias.Models;
using Microsoft.EntityFrameworkCore;
using Practica08Noticias.Data;

namespace Practica08Noticias.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //consulta las ultimas 10 noticias e incluye la categoria por cada notica
            var noticias = (from n in _context.Noticias.Include("Categoria")
                            orderby n.FechaPublicacion descending
                            select n).Take(10);

            //pasar la lista de noticias a la vista
            return View(noticias.ToList());
        }

        public IActionResult Noticia(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticia = _context.Noticias
            .FirstOrDefault(m => m.NoticiasID == id); //Verificar NoticiaID
            if (noticia == null)
            {
                return NotFound();
            }

            return View(noticia);
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
