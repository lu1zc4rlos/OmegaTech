using System.Text.Json.Serialization;

namespace model {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Perfil {
        ROLE_ADMIN,
        ROLE_TECNICO,
        ROLE_CLIENTE
    }
}
