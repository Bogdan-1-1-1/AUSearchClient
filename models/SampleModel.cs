using System;
using System.Text.Json.Serialization;

namespace sound_project_app
{
    public class SampleModel
    {

        [JsonPropertyName("gamename")]
        public string Gamename { get; set; }

        [JsonPropertyName("filename")]
        public string Name { get; set; }

        [JsonPropertyName("sample")]
        public int[] Sample { get; set; }

    }
}
