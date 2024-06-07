namespace BlazorApp.Responses
{
    public class AutenticarUsuarioResponse
    {
        public string? Message { get; set; }
        public AutenticarResponse? Response { get; set; }
    }

    public class AutenticarResponse
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime? DataHoraAcesso { get; set; }
        public string? AccessToken { get; set; }
        public DateTime? DataHoraExpiracao { get; set; }
    }
}
