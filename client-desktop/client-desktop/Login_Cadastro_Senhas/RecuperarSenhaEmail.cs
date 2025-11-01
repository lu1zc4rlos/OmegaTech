using model;
using service;

namespace client_desktop.Login_Cadastro_Senhas {
    public partial class RecuperarSenhaEmail : Form {
        public RecuperarSenhaEmail() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            btnTrocarSenha.Visible = false;
        }
        private async void btnEnviarCodigo_ClickAsync(object sender, EventArgs e) {
            try {
                var authService = new AuthService();
                await authService.SolicitarCodigoAsync(txtEmail.Text);

                MessageBox.Show("Código de recuperação enviado com sucesso para o e-mail informado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao enviar o e-mail: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void btnConfirmar_Click_1Async(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(txtCodigo.Text)) {
                MessageBox.Show("Por favor, insira o código de verificação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                var authService = new AuthService();
                await authService.ValidarCodigoAsync(txtEmail.Text, txtCodigo.Text);

                MessageBox.Show("Código verificado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnTrocarSenha.Visible = true;

            }
            catch (Exception ex) {
                MessageBox.Show("Erro: Código inválido ou expirado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos() {
            txtEmail.Clear();
            txtCodigo.Clear();
        }

        private void btnTrocarSenha_Click(object sender, EventArgs e) {
            this.Hide();
            using (TrocarSenha trocarSenh = new TrocarSenha(txtEmail.Text, txtCodigo.Text)) {
                trocarSenh.ShowDialog();
            }
            this.Show();
            LimparCampos();
        }
    }
}
