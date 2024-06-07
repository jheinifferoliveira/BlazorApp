using System.ComponentModel.DataAnnotations;

namespace BlazorApp.ViewModels
{
    /// <summary>
    /// Modelo de dados para a página de autenticação de usuário
    /// </summary>
    public class AutenticarUsuarioViewModel
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email de acesso.")]
        public string? Email { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])(?=.*[^\da-zA-Z]).{8,}$", 
            ErrorMessage = "Por favor, informe a senha com letras maiúsculas, minúsculas, números, símbolos e pelo menos 8 caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a senha de acesso.")]
        public string? Senha { get; set; }
    }
}