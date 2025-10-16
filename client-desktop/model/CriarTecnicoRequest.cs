using System.Text.Json.Serialization;

namespace model {
    public class CriarTecnicoRequest {
        [JsonPropertyName("nome")]
        private string Nome;

        [JsonPropertyName("email")]
        private string Email;

        [JsonPropertyName("senhaInicial")]
        private string SenhaInicial;

        [JsonPropertyName("especialidade")]
        private string Especialidade;
    }
}
