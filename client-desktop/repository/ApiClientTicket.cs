using model;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace repository {
    public class ApiClientTicket {
        private readonly HttpClient _httpClient;

        public ApiClientTicket(string token = null) {
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
        public async Task PostAsync(string endpoint, object body) {
            var response = await _httpClient.PostAsJsonAsync(endpoint, body);

            response.EnsureSuccessStatusCode();
        }
        public async Task<T> GetAsync<T>(string endpoint) {
            var response = await _httpClient.GetAsync(endpoint);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<T>();
        }
        public async Task PutAsync(string endpoint, object body) {
            var response = await _httpClient.PutAsJsonAsync(endpoint, body);
            response.EnsureSuccessStatusCode();
        }
    }
}
