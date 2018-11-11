using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sporfe_1._0.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Sporfe_1._0.Controllers
{
    public class IndexInsideController : Controller
    {
        private readonly SprofeContext _context;
        public IndexInsideController(SprofeContext context)
        {
            this._context = context;

        }
        public IActionResult IndexIs()
        {
            var lista = _context.Profesor.ToList();
            return View(lista);
        }

        public IActionResult Proinfo(int id)
        {   
            var prof  =  _context.Profesor.Where(p => p.IdProfesor == id).First();
            ViewBag.Profesor = new SelectList(_context.Profesor, "IdProfesor","Nombre");
        
            return View();
        }

        public IActionResult CerrarSesion(){

            return RedirectToAction("Index","Home");
        }
        
    }
}