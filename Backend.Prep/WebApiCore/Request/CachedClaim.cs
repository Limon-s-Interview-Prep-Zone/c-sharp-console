using System.Text.Json.Serialization;

namespace WebApiCore.Request;

public class CachedClaim
{
    [JsonPropertyName("originalIssuer")] public string OriginalIssuer { get; set; }

    [JsonPropertyName("subject")] public string Subject { get; set; }

    [JsonPropertyName("Type")] public string Type { get; set; }

    [JsonPropertyName("value")] public string Value { get; set; }

    [JsonPropertyName("valueType")] public string ValueType { get; set; }
}