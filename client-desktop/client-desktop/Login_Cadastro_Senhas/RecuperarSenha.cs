using client_desktop.Login_Cadastro_Senhas;
using model;
using service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace client_desktop {
    public partial class RecuperarSenha : Form {
        public RecuperarSenha() {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e) {
            
            this.Hide();
            using (RecuperarSenhaEmail recuperarsenhaemail = new RecuperarSenhaEmail()) 
            {
                recuperarsenhaemail.ShowDialog();
            }
            this.Show();
            LimparCampos();
            
        }
        private void LimparCampos() {

            txtEmail.Clear();
            txtSenhaAtual.Clear();
            txtSenhaNova.Clear();
            txtSenhaNovamente.Clear();
            cbMostrarSenha.Checked = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            
            txtSenhaAtual.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenhaNova.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenhaNovamente.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            
        }
        private async void button1_Click(object sender, EventArgs e) {
    
            try
            {            
                if (txtSenhaNova.Text != txtSenhaNovamente.Text) {
                    label5.Text = "As senhas não coincidem.";
                    label5.ForeColor = Color.Red;
                    label5.Visible = true;
                    return;
                }
                ValidacaoService.validacaoService(
                    txtEmail.Text,
                    txtSenhaAtual.Text,
                    txtSenhaNova.Text           
                );

                var authService = new AuthService();
                var request = new AlterarSenhaRequest {
                    Email = txtEmail.Text,
                    SenhaAtual = txtSenhaAtual.Text,
                    NovaSenha = txtSenhaNova.Text
                };

                await authService.AlterarSenhaAsync(request);

                MessageBox.Show("Senha alterada com sucesso!", "Você já pode fazer login.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                using (Login login = new Login()) {
                    login.ShowDialog();
                }
                this.Show();
                LimparCampos();             
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void txtSenhaNova_TextChanged(object sender, EventArgs e) {}
        private void RecuperarSenha_Load(object sender, EventArgs e) {}
        private void textBox3_TextChanged(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void label4_Click(object sender, EventArgs e) {}
        private void textBox4_TextChanged(object sender, EventArgs e) {}
    }
}
