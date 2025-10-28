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

        /* Referência Circular (Lembrete): A classe Usuario tem uma referência para TecnicoProfile
         * e a TecnicoProfile tem uma referência de volta para Usuario. Não se esqueça de tratar na API
         * com as anotações @JsonManagedReference e @JsonBackReference para evitar um loop infinito durante a serialização. */
    }
}
