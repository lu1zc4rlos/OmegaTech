using System;
using System.Drawing;
using System.Windows.Forms;

namespace client_desktop {
    public partial class TrocarSenha : Form {
        /*
        private RecuperarSenhaEmail _referencia;
        private RecuperarSenhaBLL _recuperarSenhaBLL = new RecuperarSenhaBLL();
        LoginBLL loginBLL = new LoginBLL();

        public TrocarSenha(RecuperarSenhaEmail tela) {
            InitializeComponent();
            _referencia = tela;
        }
        public TrocarSenha() {
            InitializeComponent();
        }   
        */
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            /*
            char passwordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenhaNova.PasswordChar = passwordChar;
            txtSenhaNovamente.PasswordChar = passwordChar;
            */
        }
        private void button1_Click(object sender, EventArgs e) {
            /*

            string email = _referencia.EmailUsuarioPublico;

            string novaSenha = txtSenhaNovamente.Text;
            if (txtSenhaNova.Text != txtSenhaNovamente.Text) {
                lblErroSenha.Visible = true;
            }
            if (txtSenhaNova.Text == txtSenhaNovamente.Text) {
                lblErroSenha.Visible = false;
                if (_recuperarSenhaBLL.ValidarSenha(novaSenha)) {
                    MessageBox.Show("Senha inválida! A senha deve ter:\n- Pelo menos 8 caracteres" +
                    "\n- Uma letra maiúscula\n- Um número\n- Um caractere especial.");
                    return;
                }
                _recuperarSenhaBLL.AlterarSenha(email, novaSenha);
                MessageBox.Show("Senha Alterada com sucesso!");

                if (string.IsNullOrWhiteSpace(txtSenhaNova.Text) || string.IsNullOrWhiteSpace(txtSenhaNovamente.Text)) {
                    lblErroSenha.Text = "Preencha todos os campos.";
                    lblErroSenha.ForeColor = Color.Red;
                    lblErroSenha.Visible = true;
                    return;
                }
                if (txtSenhaNova.Text != txtSenhaNovamente.Text) {
                    lblErroSenha.Text = "As senhas não coincidem.";
                    lblErroSenha.ForeColor = Color.Red;
                    lblErroSenha.Visible = true;
                    return;
                }
                try {
                    _recuperarSenhaBLL.AlterarSenha(email, novaSenha);

                    MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmailBLL.EnviarEmailBLL(
                         "Olá, " + _recuperarSenhaBLL.RetornoNome(email) + "\r\n\r\n" +
                         "Informamos que sua senha foi alterada com sucesso.\r\n\r\n" +
                         "Se você realizou essa alteração, pode desconsiderar esta mensagem.\r\n\r\n" +
                         "Caso não tenha solicitado essa mudança, recomendamos que entre em contato imediatamente com nossa equipe de suporte para garantir a segurança da sua conta.\r\n\r\n" +
                         "Atenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
                         email,
                         "Alteração de senha realizada com sucesso",
                         btnConfirmar
                    );
                    this.Close();
                    Usuario usuario = loginBLL.ObterUsuarioPorEmail(email);
                    Home.Home exemplo = new Home.Home(usuario);
                    exemplo.ShowDialog();
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro ao alterar a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          */
        }
        private void TrocarSenha_Load(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void textBox3_TextChanged(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e) {}
        private void label5_Click(object sender, EventArgs e) {}
        private void label2_Click(object sender, EventArgs e) {}
    }
}
