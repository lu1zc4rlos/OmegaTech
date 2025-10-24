using System;
using System.Net.Http;
using System.Net.Http.Json; 
using System.Threading.Tasks;
using System.Collections.Generic;
using model;

namespace Infrastructure {
    public class ApiService {
        private static readonly HttpClient client = new HttpClient();
        private readonly string baseUrl = "http://localhost:8080/";

        static ApiService() {
            // Você pode configurar headers padrões aqui, se precisar.
            // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "seu_token");
        }

        // Exemplo: Buscar todos os tickets
        public async Task<List<Ticket>> PostLoginAsync() {
            try {
                string url = $"{baseUrl}/tickets";
                List<Ticket> tickets = await client.GetFromJsonAsync<List<Ticket>>(url);
                return tickets;
            }
            catch (HttpRequestException e) {
                // Lide com erros de rede, API fora do ar, etc.
                Console.WriteLine($"Erro na requisição: {e.Message}");
                return null;
            }
        }

        public async Task<Usuario> CreateUsuarioAsync(Usuario novoUsuario) {
            try {
                string url = $"{baseUrl}/usuarios"; // Supondo que este é seu endpoint de criação
                HttpResponseMessage response = await client.PostAsJsonAsync(url, novoUsuario);

                if (response.IsSuccessStatusCode) {
                    Usuario usuarioCriado = await response.Content.ReadFromJsonAsync<Usuario>();
                    return usuarioCriado;
                }
                return null; // Ou lance uma exceção
            }
            catch (HttpRequestException e) {
                Console.WriteLine($"Erro na requisição: {e.Message}");
                return null;
            }
        }

        // Adicione aqui outros métodos (GetUsuarioPorId, UpdateTicket, DeleteTicket, etc.)
    
    }
}
