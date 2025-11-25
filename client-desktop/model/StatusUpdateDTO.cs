using System.Text.Json.Serialization;

namespace model {
    public class StatusUpdateDTO {
        [JsonPropertyName("novoStatus")]
        public string NovoStatus { get; set; }
    }
}
