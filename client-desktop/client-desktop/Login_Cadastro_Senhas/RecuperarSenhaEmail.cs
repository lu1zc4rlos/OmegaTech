using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace client_desktop {
    public partial class RecuperarSenhaEmail : Form {
        /*
        private readonly RecuperarSenhaBLL recuperarSenhaBLL = new RecuperarSenhaBLL();
        private string codigoGerado;
        private string emailUsuario;
        
        public string EmailUsuarioPublico {
            get { return emailUsuario; }
            set { emailUsuario = value; }
        }
        public string CodigoGerado() {
            RecuperarSenhaBLL _codigo = new RecuperarSenhaBLL();
            string codigo = _codigo.GerarCodigoSeguro();

            return codigo;
        }
        public RecuperarSenhaEmail() {
            InitializeComponent();
            btnTrocarSenha.Visible = false;
            btnAcessarPrograma.Visible = false;
        }
        */
        private void btnEnviarCodigo_Click(object sender, EventArgs e) {
            /*

            emailUsuario = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(emailUsuario)) {
                MessageBox.Show("Por favor, informe o seu e-mail.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            codigoGerado = recuperarSenhaBLL.GerarCodigoSeguro();

            try {
                EmailBLL.EnviarEmailBLL(
                   "Olá, " + recuperarSenhaBLL.RetornoNome(emailUsuario) + "\r\n\r\n" +
                   "Recebemos uma solicitação para redefinir sua senha de acesso ao sistema AtendeTech.\r\n\r\n" +
                   "Para confirmar essa solicitação, utilize o código abaixo dentro do aplicativo:\r\n\r\n" +
                   "CÓDIGO DE VERIFICAÇÃO: " + codigoGerado + "\r\n\r\n" +
                   "Se você não solicitou essa redefinição, por favor ignore esta mensagem ou entre em contato com nossa equipe de suporte.\r\n\r\n" +
                   "Atenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
                   emailUsuario,
                   "Código para redefinição de senha",
                   btnEnviarCodigo
                );
                MessageBox.Show("Código de recuperação enviado com sucesso para o e-mail informado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao enviar o e-mail: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        private void btnConfirmar_Click_1(object sender, EventArgs e) {
            /*
            if (string.IsNullOrEmpty(txtCodigo.Text)) {
                MessageBox.Show("Por favor, insira o código de verificação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (codigoGerado == txtCodigo.Text.Trim()) {
                MessageBox.Show("Código verificado com sucesso!\nEscolha o que deseja fazer.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTrocarSenha.Visible = true;
                btnAcessarPrograma.Visible = true;
            }
            else {
                MessageBox.Show("Código inválido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        private void btnTrocarSenha_Click(object sender, EventArgs e) {
            /*
            var telaTrocarSenha = new TrocarSenha(this);
            this.Hide();
            telaTrocarSenha.ShowDialog();
            this.Close();
            */
        }
        /*
        LoginBLL loginBLL = new LoginBLL();
        */
        private void btnAcessarPrograma_Click(object sender, EventArgs e) {
            /*
            this.Hide();
            Usuario usuario = loginBLL.ObterUsuarioPorEmail(EmailUsuarioPublico);
            Home.Home home = new Home.Home(usuario);
            home.ShowDialog();
            this.Close();
            */
        }
        private void RecuperarSenhaEmail_Load(object sender, EventArgs e) {}
        private void txtEmail_TextChanged(object sender, EventArgs e) {}
        private void button2_Click(object sender, EventArgs e) {}
        private void txtCodigo_TextChanged(object sender, EventArgs e) {}
        private void lblEmail_Click(object sender, EventArgs e) {}
        private void lblCodigo_Click(object sender, EventArgs e) {}
    }
}
