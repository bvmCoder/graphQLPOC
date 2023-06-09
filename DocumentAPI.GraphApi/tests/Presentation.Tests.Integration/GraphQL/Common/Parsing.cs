namespace DocumentAPI.GraphApi.Presentation.Tests.Integration.GraphQL.Common;

using System.Text.Json.Serialization;

public partial class Parsing
{
    [JsonPropertyName("startOffset")]
    public long StartOffset { get; set; }

    [JsonPropertyName("duration")]
    public long Duration { get; set; }
}
