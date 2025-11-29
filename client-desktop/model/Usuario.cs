using System.Text.Json.Serialization;

namespace model {
    public class Usuario {

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("dataNascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("senha")]
        public string Senha { get; set; }

        [JsonPropertyName("perfil")]
        public Perfil Perfil { get; set; } 

        [JsonPropertyName("tecnicoProfile")]
        public TecnicoProfile TecnicoProfile { get; set; }
    }
}
