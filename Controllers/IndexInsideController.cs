using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sporfe_1._0.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            var lista = _context.Profesor.Include(p => p.calificacion).Where(p => p.IdProfesor == id).ToList();
            
            return View(lista);

        }
        public IActionResult votar(){
            return RedirectToAction("IndexIs");
        }

        public IActionResult CerrarSesion(){

            return RedirectToAction("Index","Home");
        }

        public IActionResult RegistroVoto(){
            return View();
        }
        public IActionResult RegistroVotos(Calificacion c){
            if (ModelState.IsValid)
            {
                _context.Add(c);
                _context.SaveChanges();

                return RedirectToAction("ConfirmacionVoto");
            }
            ViewBag.Profesor = new SelectList(_context.Profesor, "IdProfesor","Codigo");
            return View();
        }

        public IActionResult ConfirmacionVoto(){
            return View();
        }
        
    }
}