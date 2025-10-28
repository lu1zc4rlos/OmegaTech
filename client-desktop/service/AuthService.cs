using model;
using repository;
using CredentialManagement;

namespace service {
  public class AuthService {
        public async Task<LoginResponse> LoginAsync(string email, string senha) {
            var api = new ApiClient();
            var request = new LoginRequest { Email = email, Senha = senha };
            var response = await api.PostAsync<LoginResponse>("usuarios/login", request);

            
            if (response != null && !string.IsNullOrEmpty(response.Token)) 
            {
                string alvo = "OmegaTech-Desktop";
                var credencial = new Credential
                {
                    Target = alvo,
                    Username = email,
                    Password = response.Token, 
                    Type = CredentialType.Generic,
                    PersistanceType = PersistanceType.LocalComputer
                };
                
                credencial.Save();
            }

            return response;
        }
        public async Task<LoginResponse> CadastroAsync(Usuario request) {
            var api = new ApiClient();

            var response = await api.PostAsync<LoginResponse>("usuarios/cadastro", request);

            if (response != null && !string.IsNullOrEmpty(response.Token)) {
                string alvo = "OmegaTech-Desktop";
                var credencial = new Credential {
                    Target = alvo,
                    Username = request.Email,
                    Password = response.Token,
                    Type = CredentialType.Generic,
                    PersistanceType = PersistanceType.LocalComputer
                };

                credencial.Save();
            }

            return response;
        }
    }
}
