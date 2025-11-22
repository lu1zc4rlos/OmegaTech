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

    }
}
