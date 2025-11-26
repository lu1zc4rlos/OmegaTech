using System.Text.Json.Serialization;

namespace model {
    public class RespostaTicketDTO {
        [JsonPropertyName("resposta")]
        public string Resposta { get; set; }
    }
}
