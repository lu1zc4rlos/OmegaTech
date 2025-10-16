using System.Text.Json.Serialization;

namespace model {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Perfil {
        ADMIN,
        TECNICO,
        CLIENTE 
    }
}
