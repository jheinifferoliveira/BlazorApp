using System.ComponentModel.DataAnnotations;

namespace BlazorApp.ViewModels
{
    public class EditarTarefaViewModel
    {

        public Guid? Id { get; set; }
        [MinLength(8, ErrorMessage = "Por favor, informe o nome com pelo menos {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe o nome com no máximo {1}caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome da tarefa.")]
        public string? Nome { get; set; }
        [MinLength(8, ErrorMessage = "Por favor, informe a descrição com pelo menos {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe a descrição com no máximo { 1}caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição da tarefa.")]
        public string? Descricao { get; set; }
        [Required(ErrorMessage = "Por favor, informe a data e hora da tarefa.")]
        public string? DataHora { get; set; }
        [Required(ErrorMessage = "Por favor, informe a prioridade da tarefa.")]
        public string? Prioridade { get; set; }
    }
}

