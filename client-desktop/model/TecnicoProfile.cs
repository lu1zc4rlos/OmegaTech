using System.Text.Json.Serialization;

namespace model {
    public class TecnicoProfile {
        [JsonPropertyName("id")]
        public long Id { get; set; } 

        [JsonPropertyName("matricula")]
        public string Matricula { get; set; } 

        [JsonPropertyName("especialidade")]
        public string Especialidade { get; set; } 

        [JsonPropertyName("dataCertificacao")]
        public DateTime DataCertificacao { get; set; } 

        [JsonPropertyName("usuario")]
        public Usuario Usuario { get; set; }
    }
}