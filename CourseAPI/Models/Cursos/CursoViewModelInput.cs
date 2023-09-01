using System.ComponentModel.DataAnnotations;

namespace CourseAPI.Models.Cursos
{
    public class CursoViewModelInput
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
