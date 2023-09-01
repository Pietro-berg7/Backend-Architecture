namespace CourseAPI.Models
{
    public class ValidaCampoViewModel
    {
        public IEnumerable<string> Erros { get; private set; }

        public ValidaCampoViewModel(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
