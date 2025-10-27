using System.Net.Http.Headers;
using System.Net.Http.Json;
using model;

namespace repository {
    public class ApiClient {
        private readonly HttpClient _httpClient;

        public ApiClient(string token = null) {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ApiConfig.BaseUrl);

            if (!string.IsNullOrEmpty(token)) {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public async Task<T> GetAsync<T>(string endpoint) {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> PostAsync<T>(string endpoint, object body) {
            var response = await _httpClient.PostAsJsonAsync(endpoint, body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}
