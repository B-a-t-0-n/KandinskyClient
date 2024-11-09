using KandinskyLibrary.Model;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace KandinskyLibrary
{
    public class KandinskyAPI
    {
        private readonly string _url = "https://api-key.fusionbrain.ai/";
        private readonly HttpClient _httpClient;

        public KandinskyAPI(string apiKey, string secretKey)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("X-Key", $"Key {apiKey}");
            _httpClient.DefaultRequestHeaders.Add("X-Secret", $"Secret {secretKey}");
        }

        public async Task<ModelDTO[]?> GetModelsAsync() => await _httpClient.GetFromJsonAsync<ModelDTO[]>(_url + "key/api/v1/models");

        public async Task<StyleDTO[]?> GetStylesAsync() => await _httpClient.GetFromJsonAsync<StyleDTO[]>("https://cdn.fusionbrain.ai/static/styles/key");

        public async Task<string> GenerateAsync(
            string prompt,
            string modelId,
            string style, 
            int numImages = 1,
            int width = 1024,
            int height = 1024,
            string negativePrompt = "")
        {
            try
            {
                var parameters = new
                {
                    type = "GENERATE",
                    style,
                    num_images = numImages,
                    width,
                    height,
                    negativePromptUnclip = negativePrompt,
                    generateParams = new
                    {
                        query = prompt
                    }
                };

                var jsonParameters = JsonConvert.SerializeObject(parameters);

                using var form = new MultipartFormDataContent
                {
                    { new StringContent(jsonParameters, Encoding.UTF8, "application/json"), "params" },
                    { new StringContent(modelId), "model_id" }
                };

                var response = await _httpClient.PostAsync(_url + "key/api/v1/text2image/run", form);
                response.EnsureSuccessStatusCode();

                var data = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                return data!.uuid.ToString();
            }
            catch(Exception ex)
            {
                throw new Exception($"возникла ошибка \"{ex.Message}\"");
            }
            
        }

        public async Task<string[]> CheckGenerationAsync(string requestId, int attempts = 1000, int delay = 1)
        {
            while (attempts > 0)
            {
                var response = await _httpClient.GetAsync(_url + "key/api/v1/text2image/status/" + requestId);
                response.EnsureSuccessStatusCode();

                var data = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                if (data!.status.ToString() == "DONE")
                {
                    return data.images.ToObject<string[]>();
                }

                attempts--;
                await Task.Delay(delay * 100);
            }
            return new string[1];
        }
    }
}
