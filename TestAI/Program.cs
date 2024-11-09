using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

public class Text2ImageAPI
{
    private readonly string _url;
    private readonly HttpClient _httpClient;

    public Text2ImageAPI(string url, string apiKey, string secretKey)
    {
        _url = url;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("X-Key", $"Key {apiKey}");
        _httpClient.DefaultRequestHeaders.Add("X-Secret", $"Secret {secretKey}");
    }

    public async Task<string> GetModelAsync()
    {
        var response = await _httpClient.GetAsync(_url + "key/api/v1/models");
        response.EnsureSuccessStatusCode();

        var data = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
        return data[0].id.ToString();
    }

    public async Task<string> GenerateAsync(string prompt, string modelId)
    {
        var parameters = new
        {
            type = "GENERATE",
            generateParams = new
            {
                query = prompt
            }
        };

        var jsonParameters = JsonConvert.SerializeObject(parameters);

        using var form = new MultipartFormDataContent();
        form.Add(new StringContent(jsonParameters, Encoding.UTF8, "application/json"), "params");
        form.Add(new StringContent(modelId), "model_id");

        var response = await _httpClient.PostAsync(_url + "key/api/v1/text2image/run", form);
        response.EnsureSuccessStatusCode();

        var data = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
        return data.uuid.ToString();
    }

    public async Task<string[]> CheckGenerationAsync(string requestId, int attempts = 10, int delay = 10)
    {
        while (attempts > 0)
        {
            var response = await _httpClient.GetAsync(_url + "key/api/v1/text2image/status/" + requestId);
            response.EnsureSuccessStatusCode();

            var data = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
            if (data.status.ToString() == "DONE")
            {
                return data.images.ToObject<string[]>();
            }

            attempts--;
            await Task.Delay(delay * 1000); // задержка в миллисекундах
        }
        return null;
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        string apiUrl = "https://api-key.fusionbrain.ai/";
        string apiKey = "1244FBBD0FD896833F90BCF4E01AF122";
        string secretKey = "9DA6E9D3F6EDF6D8324E9C840D20BD38";

        var api = new Text2ImageAPI(apiUrl, apiKey, secretKey);
        string modelId = await api.GetModelAsync();

        Console.WriteLine("Model ID: " + modelId);

        string uuid = await api.GenerateAsync("море", modelId);
        Console.WriteLine("Request UUID: " + uuid);

        string[] images = await api.CheckGenerationAsync(uuid);
        if (images != null && images.Length > 0)
        {
            Console.WriteLine("Generated Images:");
            foreach (var img in images)
            {
                Console.WriteLine(img);
            }
        }
        else
        {
            Console.WriteLine("No images generated or generation failed.");
        }
    }
}