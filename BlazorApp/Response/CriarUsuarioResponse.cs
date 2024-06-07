namespace BlazorApp.Responses
{
    public class CriarUsuarioResponse
    {
        public string? Message { get; set; }
        public CriarResponse? Response { get; set; }
    }

    public class CriarResponse
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime? DataHoraCadastro { get; set; }
    }
}
