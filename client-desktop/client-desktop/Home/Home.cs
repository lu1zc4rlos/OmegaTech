using model;
using repository;
using CredentialManagement;


namespace client_desktop.Home {
    public partial class Home : Form {

        private ApiClient _apiClient;
        public static string TokenGlobal { get; private set; }

        public Home() {
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
                this.Hide();
                using (Login login = new Login()) {
                    login.ShowDialog();
                }
                this.Show();
            }
        }

        private void btn_chamados_Click(object sender, EventArgs e) {
            this.Hide();
            using (formChamados formChamados = new formChamados()) {
                formChamados.ShowDialog();
            }
            this.Show();
        }

        private void btn_chatbot_Click(object sender, EventArgs e) {

            this.Hide();
            using (formOmegaHelp formOmegaHelp = new formOmegaHelp()) {
                formOmegaHelp.ShowDialog();
            }
            this.Show();
            
        }

        private void btn_sidebar_Click(object sender, EventArgs e) {
            SideBarTransition.Start();
        }
    }
}
