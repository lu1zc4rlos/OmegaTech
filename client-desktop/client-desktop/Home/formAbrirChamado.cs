using CredentialManagement;
using service;

namespace client_desktop.Home {
    public partial class formAbrirChamado : Form {
        public static string TokenGlobal { get; set; }
        public formAbrirChamado() {
            InitializeComponent();
        }
        private void formAbrirChamado_Load(object sender, EventArgs e) {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

            string alvo = "OmegaTech-Desktop";
            var credencial = new Credential { Target = alvo };

            if (!credencial.Load()) { 
                MessageBox.Show("Sessão expirada. Por favor, faça o login novamente.", "Sessão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (Login login = new Login()) {
                    System.Windows.Forms.DialogResult resultado = login.ShowDialog();

                    if (resultado != System.Windows.Forms.DialogResult.OK) {
                        this.Close();
                        return;
                    }
                }
            }
        }

        private async void button1_ClickAsync(object sender, EventArgs e) {
            
            string mensagemDoTicket = txtDescricao.Text;
            if (string.IsNullOrWhiteSpace(mensagemDoTicket)) {
                MessageBox.Show("Por favor, descreva seu problema.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string alvo = "OmegaTech-Desktop";
            var credencial = new Credential { Target = alvo };

            if (!credencial.Load()) {
                MessageBox.Show("Sessão não encontrada. Feche a tela e tente novamente.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tokenParaEnvio = credencial.Password;
            try {
                button1.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                var _authTicketService = new AuthTicketService();
                await _authTicketService.CriarTicketAsync(mensagemDoTicket, tokenParaEnvio);

                this.Close();

                MessageBox.Show("Chamado enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show($"Falha ao criar o chamado: {ex.Message}",
                                 "Erro de API",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            finally {
                button1.Enabled = true;
                this.Cursor = Cursors.Default;
            }

        }

        private void pn_title_Paint(object sender, PaintEventArgs e) { }
    }
}


