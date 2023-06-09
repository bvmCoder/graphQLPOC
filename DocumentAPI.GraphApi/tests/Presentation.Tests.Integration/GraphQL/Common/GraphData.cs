namespace DocumentAPI.GraphApi.Presentation.Tests.Integration.GraphQL.Common;

using System.Collections.Generic;
using System.Text.Json.Serialization;

public partial class GraphData
{
    [JsonPropertyName("data")]
    public Data Data { get; set; }

    [JsonPropertyName("extensions")]
    public Extensions Extensions { get; set; }

    [JsonPropertyName("errors")]
    public List<ErrorMessage> Errors { get; set; }
}
