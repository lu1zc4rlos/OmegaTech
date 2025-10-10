using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace client_desktop {
    public partial class Login : Form {

        public Login() {

            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
        }
        private void btnNaoCadastrado_Click(object sender, EventArgs e) {

            this.Hide();
            using (Cadastro cadastro = new Cadastro()) {
                cadastro.ShowDialog();
            }
            this.Show();
            LimparCampos();

        }
        private void Login_Load(object sender, EventArgs e) {

        }
        //classe para guardar os dados do usuario
        public static class Sessao {
            /*
            public static Usuario UsuarioLogado { get; set; }
            */
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {
            /*
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();


            LoginBLL loginBLL = new LoginBLL();
            UsuarioDAL usuarioDAL = new UsuarioDAL();

            try
            {
                Usuario usuario = loginBLL.ObterUsuarioPorEmaileSenha(email, senha);

                if (usuario != null)
                {
                    //teste do método para pegar o usuario
                    Sessao.UsuarioLogado = usuarioDAL.BuscarPorEmail(email);
                    this.Hide();
                    using (Home.Home home = new Home.Home(usuario))
                    {
                        home.ShowDialog();
                    }
                    this.Hide();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha inválidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        private void cbMostarSenha_CheckedChanged(object sender, EventArgs e) {
            /*
            txtSenha.PasswordChar = cbMostarSenha.Checked ? '\0' : '*';
            */
        }
        private void btnRecuperrarSenha_Click(object sender, EventArgs e) {
            /*
            this.Hide();
            using (RecuperarSenha recuperarSenha = new RecuperarSenha())
            {
                recuperarSenha.ShowDialog();
            }
            this.Show();
            LimparCampos();
            */
        }
        private void LimparCampos() {
            /*
            txtEmail.Clear();
            txtSenha.Clear();
            cbMostarSenha.Checked = false;
            */
        }
        private void txtSenha_TextChanged(object sender, EventArgs e) { }
        private void lblEmail_Click(object sender, EventArgs e) { }
        private void lblSenha_Click(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}