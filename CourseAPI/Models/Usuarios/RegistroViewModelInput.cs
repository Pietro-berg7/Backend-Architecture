﻿using System.ComponentModel.DataAnnotations;

namespace CourseAPI.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatório!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória!")]
        public string Senha { get; set; }
    }
}
