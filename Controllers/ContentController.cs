using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviESWeb.Models;
using MoviESWeb.Models.DB;

namespace MoviESWeb.Controllers
{
    public class ContentController : Controller
    {
        private readonly MoviesContext _dbContext;

        public ContentController(MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var films = _dbContext.Films.ToList();
            var documentaries = _dbContext.Documentaries.ToList();

            var viewModel = new MoviesViewModel
            {
                Films = films,
                Documentaries = documentaries
            };

            return View(viewModel);
        }

        public IActionResult FilmDetails(int id)
        {
            var film = _dbContext.Films.FirstOrDefault(f => f.IdFilm == id);

            if (film == null)
            {
                return NotFound(); // Puedes personalizar la respuesta si la película no se encuentra
            }

            return View(film);
        }

        public IActionResult DocumentaryDetails(int id)
        {
            var documentary = _dbContext.Documentaries.FirstOrDefault(d => d.IdDocumentary == id);

            if (documentary == null)
            {
                return NotFound(); // Puedes personalizar la respuesta si el documental no se encuentra
            }

            return View(documentary);
        }

        public async Task<IActionResult> DeleteFilm(int? id)
        {
            if (id == null || _dbContext.Films == null)
            {
                return NotFound();
            }

            var film = await _dbContext.Films.FirstOrDefaultAsync(m => m.IdFilm == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        [HttpPost, ActionName("DeleteFilm")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFilmConfirmed(int id)
        {
            if (_dbContext.Films == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Films'  is null.");
            }
            var film = await _dbContext.Films.FindAsync(id);
            if (film != null)
            {
                _dbContext.Films.Remove(film);
            }

            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Persons");
        }

        public async Task<IActionResult> DeleteDocumentary(int? id)
        {
            if (id == null || _dbContext.Documentaries == null)
            {
                return NotFound();
            }

            var documentary = await _dbContext.Documentaries.FirstOrDefaultAsync(m => m.IdDocumentary == id);
            if (documentary == null)
            {
                return NotFound();
            }

            return View(documentary);
        }

        [HttpPost, ActionName("DeleteDocumentary")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDocumentaryConfirmed(int id)
        {
            if (_dbContext.Documentaries == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Documentaries'  is null.");
            }
            var documentary = await _dbContext.Documentaries.FindAsync(id);
            if (documentary != null)
            {
                _dbContext.Documentaries.Remove(documentary);
            }

            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Persons");
        }

    }
}
