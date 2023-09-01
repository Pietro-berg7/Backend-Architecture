using System.ComponentModel.DataAnnotations;

namespace CourseAPI.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatório!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório!")]
        public string Senha { get; set; }
    }
}
