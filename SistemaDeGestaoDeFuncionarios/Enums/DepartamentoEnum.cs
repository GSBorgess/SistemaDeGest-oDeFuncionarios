﻿using System.Text.Json.Serialization;

namespace SistemaDeGestaoDeFuncionarios.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH, 
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
