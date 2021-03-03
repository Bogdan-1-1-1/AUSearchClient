using System;
using System.Threading.Tasks;   
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace sound_project_app {
    class SourceGetter {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<SampleModel>> getFireSamples() {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

             var streamTask = client.GetStreamAsync("http://localhost:5000/api/game/get/fire");
             var samples = await JsonSerializer.DeserializeAsync<List<SampleModel>>(await streamTask);

            return samples;
        }

        public static async Task<List<SampleModel>> getExplosionSamples() {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

             var streamTask = client.GetStreamAsync("http://localhost:5000/api/game/get/explosion");
             var samples = await JsonSerializer.DeserializeAsync<List<SampleModel>>(await streamTask);

            return samples;
        }

        public static async Task<List<SampleModel>> getStepSamples() {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

             var streamTask = client.GetStreamAsync("http://localhost:5000/api/game/get/step");
             var samples = await JsonSerializer.DeserializeAsync<List<SampleModel>>(await streamTask);

            return samples;
        }
   
        public static async Task<List<NeuroValueModel>> getValues() {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

             var streamTask = client.GetStreamAsync("http://localhost:5000/api/game/get/values");
             var values = await JsonSerializer.DeserializeAsync<List<NeuroValueModel>>(await streamTask);

            return values;
        }
   

        public static async Task<List<SampleModel>> getFireSamples(String gameTitle) {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

             var streamTask = client.GetStreamAsync("http://localhost:5000/api/game/get/fire/" + gameTitle);
             var samples = await JsonSerializer.DeserializeAsync<List<SampleModel>>(await streamTask);

            return samples;
        }

        public static async Task<List<SampleModel>> getExplosionSamples(String gameTitle) {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

             var streamTask = client.GetStreamAsync("http://localhost:5000/api/game/get/explosion/" + gameTitle);
             var samples = await JsonSerializer.DeserializeAsync<List<SampleModel>>(await streamTask);

            return samples;
        }

        public static async Task<List<SampleModel>> getStepSamples(String gameTitle) {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

             var streamTask = client.GetStreamAsync("http://localhost:5000/api/game/get/step/" + gameTitle);
             var samples = await JsonSerializer.DeserializeAsync<List<SampleModel>>(await streamTask);

            return samples;
        }
   
        public static async Task<List<NeuroValueModel>> getValues(String gameTitle) {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

             var streamTask = client.GetStreamAsync("http://localhost:5000/api/game/get/values/" + gameTitle);
             var values = await JsonSerializer.DeserializeAsync<List<NeuroValueModel>>(await streamTask);

            return values;
        }
    }

}