using CredentialManagement;
using service;

namespace client_desktop {
    public partial class Login : Form {

        public Login() {

            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
        }
        private void btnNaoCadastrado_Click(object sender, EventArgs e) {


            Cadastro cadastro = new Cadastro();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
            this.Close();
            LimparCampos();

        }
        private void Login_Load(object sender, EventArgs e) 
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

        }
        private async void btnConfirmar_Click(object sender, EventArgs e) {
            
            try {

                var authService = new AuthService();
                string email = txtEmail.Text.Trim();
                string senha = txtSenha.Text.Trim();
                var response = await authService.LoginAsync(email, senha);

                string tokenRecebido = response.Token;
                string usuario = email; 
                string alvo = "OmegaTech-Desktop";

                try {
                    var credencial = new Credential {
                        Target = alvo,
                        Username = usuario,
                        Password = tokenRecebido,
                        Type = CredentialType.Generic,
                        PersistanceType = PersistanceType.LocalComputer
                    };
                    credencial.Save();
                }
                    catch (Exception ex) {
                        MessageBox.Show("Erro ao salvar a credencial: " + ex.Message);
                    }

                this.Hide();
                using (Home.Home homeForm = new Home.Home(response.Username)) {
                    homeForm.ShowDialog();
                }
                this.Show();
                LimparCampos();

            }
            catch (HttpRequestException ex) {             
                MessageBox.Show("Usuário ou senha inválidos. Tente novamente.",
                                "Erro de Login",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("Não foi possível conectar à API: " + ex.Message,
                                "Erro de Conexão",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
        private void cbMostarSenha_CheckedChanged(object sender, EventArgs e) {
            
            txtSenha.PasswordChar = cbMostarSenha.Checked ? '\0' : '*';
            
        }
        private void btnRecuperrarSenha_Click(object sender, EventArgs e) {


            RecuperarSenha recuperarSenha = new RecuperarSenha();
            recuperarSenha.MdiParent = this.MdiParent;
            recuperarSenha.Show();
            this.Close();
            LimparCampos();
        }
        private void LimparCampos() {
            
            txtEmail.Clear();
            txtSenha.Clear();
            cbMostarSenha.Checked = false;           
        }
        private void txtSenha_TextChanged(object sender, EventArgs e) { }
        private void lblEmail_Click(object sender, EventArgs e) { }
        private void lblSenha_Click(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void pn_title_Paint(object sender, PaintEventArgs e) { }
    }
}