using System;
using System.Text.Json.Serialization;

namespace sound_project_app
{
    public class NeuroValueModel
    {

        [JsonPropertyName("gamename")]
        public string Gamename {get; set; }

        [JsonPropertyName("values")]
        public double[] Values { get; set; }

    }
}
