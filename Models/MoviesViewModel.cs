using MoviESWeb.Models.DB;

namespace MoviESWeb.Models
{
    // MoviesViewModel.cs
    public class MoviesViewModel
    {
        public List<Film> Films { get; set; }
        public List<Documentary> Documentaries { get; set; }
        public List<User> Users { get; set; }
        public List<Admin> Admins { get; set; }
    }

}
