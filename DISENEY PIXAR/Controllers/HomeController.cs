using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DISENEY_PIXAR.Models;
using Microsoft.EntityFrameworkCore;
using DISENEY_PIXAR.Models.ViewModel;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace DISENEY_PIXAR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Peli()
        {
            pixarContext context = new pixarContext();
            var pelicu = context.Pelicula.OrderBy(x => x.Nombre);
            if (pelicu == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(pelicu);
            }
        }
        [Route("{Id}")]
        public IActionResult Personajes(string id)
        {
            pixarContext context = new pixarContext();
            var nombre = id.Replace("-", " ").ToUpper();
            var peliculas = context.Pelicula.Include(x => x.Apariciones).FirstOrDefault(x => x.Nombre.ToUpper() == nombre);
            var aparicion = context.Apariciones.Include(x => x.IdPersonajeNavigation).Include(x => x.IdPeliculaNavigation)
            .Where(x => (x.IdPelicula == peliculas.Id)).Select(x => x);
            if (peliculas == null)
            {
                return RedirectToAction("Peliculas");
            }
            else
            {
                PersonajesViewModel pvm = new PersonajesViewModel();
                pvm.Nombre = peliculas.Nombre;
                pvm.Id = peliculas.Id;
                pvm.NombreOriginal = peliculas.NombreOriginal;
                pvm.FechaEstreno = peliculas.FechaEstreno;
                pvm.Descripcion = peliculas.Descripción;
                pvm.Apariciones = aparicion;
                return View(pvm);
            }
        }
        
        public IActionResult Cortometrajes()
        {
            pixarContext context = new pixarContext();
            CortometrajeViewModel cvm = new CortometrajeViewModel();
            cvm.Categorias = context.Categoria.Include(x => x.Cortometraje);
            return View(cvm);
        }
       
        [Route("{id}/Cortometraje")]
        public IActionResult Cortometraje(string id)
        {
            var nom = id.Replace("-", " ").ToLower();
            pixarContext context = new pixarContext();
            var cortom = context.Cortometraje.FirstOrDefault(x => x.Nombre == nom);
            if (cortom==null)
            {
                return RedirectToAction("Cortometrajes");

            }
            else
            {
                return View(cortom);
            }
           
        }
       
    }
}
