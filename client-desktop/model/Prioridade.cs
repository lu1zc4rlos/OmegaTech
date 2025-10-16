using System.Text.Json.Serialization;

namespace model {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Prioridade {
        BAIXA,
        MEDIA,
        ALTA,
        URGENTE
    }
}
