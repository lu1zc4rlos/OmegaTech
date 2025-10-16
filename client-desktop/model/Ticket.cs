using System.Text.Json.Serialization;

namespace model {
    public class Ticket {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("dataCriacao")]
        public DateTime DataCriacao { get; set; }

        [JsonPropertyName("prioridade")]
        public Prioridade Prioridade { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("resposta")]
        public string Resposta { get; set; }

        [JsonPropertyName("cliente")]
        public Usuario Cliente { get; set; }

        [JsonPropertyName("tecnicoAtribuido")]
        public Usuario TecnicoAtribuido { get; set; }
    }
}
