using model;
using repository;

namespace service {
    public class AuthTicketService {
        public AuthTicketService() { }

        public async Task CriarTicketAsync(string mensagem, string token) {

            var apiClientTicket = new ApiClientTicket(token);

            var request = new MensagemRequest {
                Mensagem = mensagem
            };

            await apiClientTicket.PostAsync("tickets/criar", request);
        }
    }
}
