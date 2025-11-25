using model;
using repository;

namespace service {
    public class AuthTicketService {
        public AuthTicketService() { }

        private readonly ApiClientTicket _apiClientTicket;

        public AuthTicketService(string token) {
            _apiClientTicket = new ApiClientTicket(token);
        }

        public async Task CriarTicketAsync(string mensagem, string token) {

            var apiClientTicket = new ApiClientTicket(token);

            var request = new MensagemRequest {
                Mensagem = mensagem
            };

            await apiClientTicket.PostAsync("tickets/criar", request);
        }
        public async Task<List<TicketResponseDTO>> BuscarTicketsAsync(string status = null) {

            string endpoint = "tickets/meus";

            if (!string.IsNullOrWhiteSpace(status)) {
                endpoint += $"?status={status.ToLower()}";
            }

            return await _apiClientTicket.GetAsync<List<TicketResponseDTO>>(endpoint);
        }
        public async Task AtualizarStatusAsync(int ticketId, string novoStatus) {
            string endpoint = $"tickets/status/{ticketId}";

            var request = new StatusUpdateDTO {
                NovoStatus = novoStatus
            };

            await _apiClientTicket.PutAsync(endpoint, request);
        }
        public async Task<TicketResponseDTO> BuscarTicketPorIdAsync(int ticketId) {
            string endpoint = $"tickets/{ticketId}";
            return await _apiClientTicket.GetAsync<TicketResponseDTO>(endpoint);
        }
        public async Task ResponderTicketAsync(int ticketId, string resposta) {
            string endpoint = $"tickets/resposta/{ticketId}";

            var request = new RespostaTicketDTO {
                Resposta = resposta
            };

            await _apiClientTicket.PutAsync(endpoint, request);
        }

    }
}
