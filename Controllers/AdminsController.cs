using Microsoft.AspNetCore.Mvc;
using MoviESWeb.Models.DB;

namespace MoviESWeb.Controllers
{
    public class AdminsController : Controller
    {
        private readonly MoviesContext _dbContext;

        public AdminsController(MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var users = _dbContext.Users.ToList();
            return View(users);
        }

        

    }
}
