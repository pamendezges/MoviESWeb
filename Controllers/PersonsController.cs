using Microsoft.AspNetCore.Mvc;
using MoviESWeb.Models.DB;
using MoviESWeb.Models;
using Microsoft.EntityFrameworkCore;

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
            var films = _dbContext.Films.ToList();
            var documentaries = _dbContext.Documentaries.ToList();

            var viewModel = new MoviesViewModel
            {
                Users = users,
                Admins = admins,
                Films = films,
                Documentaries = documentaries
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _dbContext.Users == null)
            {
                return NotFound();
            }

            var user = await _dbContext.Users.FirstOrDefaultAsync(m => m.IdUser == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_dbContext.Users == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Users'  is null.");
            }
            var user = await _dbContext.Users.FindAsync(id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
            }

            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
