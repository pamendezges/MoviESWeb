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
    }
}
