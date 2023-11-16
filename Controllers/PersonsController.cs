using Microsoft.AspNetCore.Mvc;
using MoviESWeb.Models.DB;
using MoviESWeb.Models;

namespace MoviESWeb.Controllers
{
    public class PersonsController : Controller
    {
        private readonly MoviesContext _dbContext;

        public PersonsController(MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var users = _dbContext.Users.ToList();
            var admins = _dbContext.Admins.ToList();

            var viewModel = new MoviesViewModel
            {
                Users = users,
                Admins = admins
            };

            return View(viewModel);
        }

    }
}
