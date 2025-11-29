using CredentialManagement;
using model;
using repository;
using System.Buffers.Text;

namespace service {
  public class AuthUsuarioService {

        private readonly ApiClient _apiClient;
        public AuthUsuarioService() {
            _apiClient = new ApiClient();
        }

        public AuthUsuarioService(string token) {
            _apiClient = new ApiClient(token);
        }
        public async Task<LoginResponse> LoginAsync(string email, string senha) {
            var request = new LoginRequest { Email = email, Senha = senha };
            var response = await _apiClient.PostAsync<LoginResponse>("usuarios/login", request);

            
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

            var response = await _apiClient.PostAsync<LoginResponse>("usuarios/cadastro", request);

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
        public async Task AlterarSenhaAsync(AlterarSenhaRequest request) {

            await _apiClient.PutAsync("usuarios/alterar_senha", request);
        }
        public async Task SolicitarCodigoAsync(string email) {
            var request = new SolicitarCodigoRequest { Email = email };

            await _apiClient.PostAsync("usuarios/solicitar_codigo", request);
        }
        public async Task ValidarCodigoAsync(string email, string codigo) {
            var request = new ValidarCodigoRequest { Email = email, Codigo = codigo };

             await _apiClient.PostAsync("usuarios/validar_codigo", request);
        }
        public async Task ResetarSenhaAsync(ResetarSenhaComCodigo request) {

            await _apiClient.PutAsync("usuarios/resetar_senha", request);
        }
        public async Task CadastroTecnicoAsync(Usuario request) {

            await _apiClient.PostAsync("admin/cadastro", request);

        }
        public async Task<List<TecnicoResponseDTO>> BuscarTodosTecnicosAsync() {

                List<TecnicoResponseDTO> listaTecnicos =
                    await _apiClient.GetAsync<List<TecnicoResponseDTO>>("admin/tecnicos");

                return listaTecnicos;
           
        }
        public async Task<TecnicoResponseDTO> BuscarDetalhesTecnicoAsync(int tecnicoId) {

                string endpoint = $"admin/{tecnicoId}";
                return await _apiClient.GetAsync<TecnicoResponseDTO>(endpoint);
            
        }
    }
}
