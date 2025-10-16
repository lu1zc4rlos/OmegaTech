using System.Text.Json.Serialization;

namespace model {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status {
        PENDENTE,
        EM_ANDAMENTO,
        CONCLUIDO
    }
}
