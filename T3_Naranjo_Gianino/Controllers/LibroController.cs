using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using T3_Naranjo_Gianino.Datos;
using T3_Naranjo_Gianino.Models;

namespace T3_Naranjo_Gianino.Controllers
{
    [Authorize]
    public class LibroController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LibroController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.Libro;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libro.Add(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(libro);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var libro = _db.Libro.Find(id);

            if (libro == null)
                return NotFound();

            return View(libro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libro.Update(libro);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(libro);
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var libro = _db.Libro.Find(id);

            if (libro == null)
                return NotFound();

            return View(libro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Libro libro)
        {
            _db.Libro.Remove(libro);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}