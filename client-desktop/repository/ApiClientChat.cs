using model;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace repository {
    public class ApiClientChat {
        private readonly HttpClient _httpClient;

        public ApiClientChat(string token = null) {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ApiConfig.BaseUrl); 
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            if (!string.IsNullOrEmpty(token)) {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
        }
        public async Task<T> PostAsync<T>(string endpoint, object body) {
            var json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(endpoint, content);
            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) {
                throw new Exception($"Erro na API: {response.StatusCode} - {responseBody}");
            }

            return JsonConvert.DeserializeObject<T>(responseBody);
        }
    }
}
