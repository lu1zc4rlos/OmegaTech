using model;
using repository;

namespace service {
    public class ChatService {
        public ChatService() { }

        public async Task<ChatResponse> EnviarMensagemAsync(string mensagem, string token) {
           
            var apiClientChat = new ApiClientChat(token);

            var request = new MensagemRequest {
                Mensagem = mensagem
            };

            
            var response = await apiClientChat.PostAsync<ChatResponse>("chat/mensagem", request);

            return response;
        }
    }
}