using model;
using repository;
using CredentialManagement;


namespace client_desktop.Home {
    public partial class Home : Form {

        private ApiClient _apiClient;
        public static string TokenGlobal { get; private set; }

        public Home(string username) {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e) {

            string alvo = "OmegaTech-Desktop";
            string tokenSalvo = null;
            string usuarioSalvo = null;
            var credencial = new Credential { Target = alvo };

            if (credencial.Load()) {

                tokenSalvo = credencial.Password;
                usuarioSalvo = credencial.Username;
                TokenGlobal = tokenSalvo;

                _apiClient = new ApiClient(tokenSalvo);

                
            }
            else {
                MessageBox.Show("Sessão expirada. Por favor, faça o login novamente.");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }



    }
}
