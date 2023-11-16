using System.ComponentModel.DataAnnotations;

namespace MoviESWeb.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        public string NameUser { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)]
        public string PasswordUser { get; set; }

    }
}
