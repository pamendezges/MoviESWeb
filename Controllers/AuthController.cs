using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MoviESWeb.Models;
using MoviESWeb.Models.DB;

namespace MoviESWeb.Controllers
{
    public class AuthController : Controller
    {
        private readonly MoviesContext _dbContext;

        public AuthController(MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _dbContext.Users.FirstOrDefault(u => u.NameUser == model.NameUser && u.PasswordUser == model.PasswordUser);

                if (user != null)
                { 
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrectos");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_dbContext.Users.Any(u => u.NameUser == model.NameUser))
                {
                    ModelState.AddModelError("NameUser", "El nombre de usuario ya está en uso.");
                    return View(model);
                }

                if (_dbContext.Users.Any(u => u.EmailUser == model.EmailUser))
                {
                    ModelState.AddModelError("EmailUser", "El email ya está registrado.");
                    return View(model);
                }

                var newUser = new User
                {
                    NameUser = model.NameUser,
                    EmailUser = model.EmailUser,
                    PasswordUser = model.PasswordUser
                };

                _dbContext.Users.Add(newUser);
                _dbContext.SaveChanges();

                return RedirectToAction("Login");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginAdmin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _dbContext.Admins.FirstOrDefault(u => u.NameAdmin == model.NameUser && u.PasswordAdmin == model.PasswordUser);

                if (user != null)
                {
                    return RedirectToAction("Index", "Persons");
                }

                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrectos");
            }

            return View(model);
        }

    }



}
