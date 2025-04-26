using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;

namespace PRN_BE.Utilities
{
    public class TogetherAIService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public TogetherAIService(IConfiguration config)
        {
            _httpClient = new HttpClient();
            _apiKey = config["TogetherAI:ApiKey"]; 
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public async Task<string> AskTogetherAsync(string userMessage)
        {
            var requestBody = new
            {
                model = "mistralai/Mistral-7B-Instruct-v0.1", 
                messages = new[]
                {
                new { role = "system", content = "Bạn là một trợ lý AI cho dịch vụ đặt phòng khách sạn." },
                new { role = "user", content = userMessage }
            },
                temperature = 0.7,
                max_tokens = 512
            };

            var content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://api.together.xyz/v1/chat/completions", content);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync();
            var json = await JsonDocument.ParseAsync(stream);

            return json.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();
        }
    }

}
