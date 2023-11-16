using Microsoft.AspNetCore.Mvc;
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
    }
}
