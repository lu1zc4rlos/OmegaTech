using CredentialManagement;
using repository;
using service;

namespace client_desktop.Home
{
    public partial class formOmegaHelp : Form {
        private ApiClient _apiClient;
        public static string TokenGlobal { get; private set; }

        public formOmegaHelp() {
            InitializeComponent();
         
        }
        private void formOmegaHelp_Load(object sender, EventArgs e) {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
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

        private void TxtEnviarMensagem_KeyDown(object sender, KeyEventArgs e) {
            throw new NotImplementedException();
        }

        private void AdicionarMensagem(string mensagem, bool ehUsuario) {
            
            Label lbl = new Label();
            lbl.Text = mensagem;
            lbl.Font = new Font("Segoe UI", 10);
            lbl.MaximumSize = new Size(flowLayoutPanelChat.Width - 100, 0);
            lbl.AutoSize = true;
            lbl.Padding = new Padding(10);
            lbl.BackColor = ehUsuario ? Color.FromArgb(60, 62, 110) : Color.Bisque;
            lbl.ForeColor = ehUsuario ? Color.White : Color.Black;
            lbl.Margin = new Padding(5);

            FlowLayoutPanel linha = new FlowLayoutPanel();
            linha.FlowDirection = FlowDirection.LeftToRight;
            linha.WrapContents = false;
            linha.Width = flowLayoutPanelChat.Width - 25;
            linha.AutoSize = true;
            linha.Padding = new Padding(5);

            if (ehUsuario) {
                linha.Controls.Add(new Label() { Width = linha.Width - lbl.PreferredWidth - 20 });
                linha.Controls.Add(lbl);
            }
            else {
                linha.Controls.Add(lbl);
            }

            flowLayoutPanelChat.Controls.Add(linha);
            flowLayoutPanelChat.ScrollControlIntoView(linha);
        }
        private async void btnEnviar_Click(object sender, EventArgs e) {

            string mensagemUsuario = txtEnviarMensagem.Text.Trim();
            AdicionarMensagem(mensagemUsuario, true); 

            try {
                var token = TokenGlobal;

                var chatService = new ChatService();
                var resposta = await chatService.EnviarMensagemAsync(mensagemUsuario, token);
                
                if (resposta.Tipo == "ERRO") {
                    AdicionarMensagem($"⚠️ Erro: {resposta.Resposta}", false);
                }
                else {
                    AdicionarMensagem($"🤖 Bot: {resposta.Resposta}", false);
                }

                if (resposta.Dados != null) {
                    string dadosFormatados = FormatarDados(resposta.Dados);
                    AdicionarMensagem($"📊 Dados: {dadosFormatados}", false);
                }
                
            }
            catch (Exception ex) {
                AdicionarMensagem($"Erro crítico ao enviar: {ex.Message}", false);
            }
            txtEnviarMensagem.Clear();

        }
        private void button4_Click(object sender, EventArgs e) {
            this.Hide();
            Home homeForm = new Home();
            homeForm.ShowDialog();
            this.Show();
        }
        private string FormatarDados(object dados) {
            if (dados == null) return string.Empty;

            try {
               
                var options = new System.Text.Json.JsonSerializerOptions {
                    WriteIndented = true
                };
                return System.Text.Json.JsonSerializer.Serialize(dados, options);
            }
            catch {
                return dados.ToString();
            }
        }
        private void pn_title_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanelChat_Paint(object sender, PaintEventArgs e) { }
    }
}
