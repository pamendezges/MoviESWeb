using System.ComponentModel.DataAnnotations;

namespace MoviESWeb.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "El email de usuario es obligatorio.")]
        public string EmailUser { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        public string NameUser { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)]
        public string PasswordUser { get; set; }
    }
}
