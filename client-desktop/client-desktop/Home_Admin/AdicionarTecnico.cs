using model;
using service;
using System.Globalization;

namespace client_desktop.Home_Admin {
    public partial class AdicionarTecnico : Form {
        public AdicionarTecnico() {
            InitializeComponent();
        }
        public void AdicionarTecnico_Load(object sender, EventArgs e) {

            lblSenhaDiferente.Visible = false;
            CultureInfo culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            atpDataNascimento.Format = DateTimePickerFormat.Custom;
            atpDataNascimento.CustomFormat = "dd/MM/yyyy";
            atpDataNascimento.MaxDate = DateTime.Today;
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

            txtConfirmarSenha.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenha.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
        }
        private void LimparCampos() {

            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            cbMostrarSenha.Checked = false;
        }
        private async void btnConfirmar_Click(object sender, EventArgs e) {

            try {
                if (txtSenha.Text != txtConfirmarSenha.Text) {
                 lblSenhaDiferente.Text = "As senhas não coincidem.";
                 lblSenhaDiferente.ForeColor = Color.Red;
                 lblSenhaDiferente.Visible = true;
                 return;
                }
                ValidacaoService.validacaoService(
                 txtNome.Text,
                 txtSenha.Text,
                 txtEmail.Text,
                 atpDataNascimento.Value,
                 txtConfirmarSenha.Text
                );
                var novoTecnico = new Usuario() {
                 Nome = txtNome.Text.Trim(),
                 Email = txtEmail.Text.Trim(),
                 Senha = txtSenha.Text.Trim(),
                 DataNascimento = atpDataNascimento.Value,
                 Perfil = Perfil.ROLE_TECNICO,
                 TecnicoProfile = null
                };
                var authService = new AuthUsuarioService();
                await authService.CadastroTecnicoAsync(novoTecnico);

                LimparCampos();
                MessageBox.Show("Técnico cadastrado com sucesso!", "Sucesso"); 
            
            }
            catch (HttpRequestException httpEx) {
                MessageBox.Show($"Erro ao cadastrar: {httpEx.Message}", "Falha na Comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
