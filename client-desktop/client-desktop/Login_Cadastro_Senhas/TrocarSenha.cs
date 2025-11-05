using model;
using service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace client_desktop.Login_Cadastro_Senhas {
    public partial class TrocarSenha : Form {

        public string _emailParaValidar;
        public string _codigoParaValidar;

        public TrocarSenha(string email, string codigoParaValidar) {
            InitializeComponent();
            _emailParaValidar = email;
            _codigoParaValidar = codigoParaValidar;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            txtSenhaNova.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenhaNovamente.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
        }
        private void LimparCampos() {
            txtSenhaNova.Clear();
            txtSenhaNovamente.Clear();
        }

        private async void btnConfirmar_ClickAsync(object sender, EventArgs e) {

            try {
                ValidacaoService.validacaoService(
                        txtSenhaNova.Text,
                        txtSenhaNova.Text
                );

                var authService = new AuthService();
                var request = new ResetarSenhaComCodigo(
                    _emailParaValidar,
                    _codigoParaValidar,
                    txtSenhaNova.Text
                );

                await authService.ResetarSenhaAsync(request);

                MessageBox.Show("Senha alterada com sucesso!", "Você já pode fazer login.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                using (Login login = new Login()) {
                    login.ShowDialog();
                }
                this.Show();
                LimparCampos();

            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao alterar a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void button1_ClickAsync(object sender, EventArgs e) { }
    }
}
          
        
    

