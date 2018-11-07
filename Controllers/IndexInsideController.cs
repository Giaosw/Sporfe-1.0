using Microsoft.AspNetCore.Mvc;
using Sporfe_1._0.Models;

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
            return View();
        }
                public IActionResult Proinfo()
        {
            return View();
        }
    }
}