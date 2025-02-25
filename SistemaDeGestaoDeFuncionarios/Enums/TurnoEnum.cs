using System.Text.Json.Serialization;

namespace SistemaDeGestaoDeFuncionarios.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manha, 
        Tarde,
        Noite
    }
}
