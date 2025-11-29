using client_desktop.Home_Técnico;

namespace client_desktop.Login_Cadastro_Senhas
{
    public partial class TesteMestre : Form
    {
        public TesteMestre()
        {
            InitializeComponent();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e) {
            Login loginForm = sender as Login;

            if (loginForm != null && loginForm.DialogResult == System.Windows.Forms.DialogResult.OK) {

                string perfil = loginForm.PerfilUsuario;

                this.Hide();

                if (perfil == "ROLE_TECNICO") {
                    HomeTecnico formTecnico = new HomeTecnico();
                    formTecnico.Show();

                }
                else if (perfil == "ROLE_CLIENTE") {
                    Home.Home formCliente = new Home.Home();
                    formCliente.Show();

                }
                else if (perfil == "ROLE_ADMIN") {
                    Home_Admin.HomeAdmin formAdmin = new Home_Admin.HomeAdmin();
                    formAdmin.Show();

                }
                else {
                    MessageBox.Show("Perfil de usuário desconhecido ou não atribuído.", "Erro de Permissão");
                    this.Close();
                    return;
                }
            }
            
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void crownMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void recuperarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecuperarSenha recuperarSenha = new RecuperarSenha();
            recuperarSenha.MdiParent = this;
            recuperarSenha.Show();
        }

        private void TesteMestre_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.FormClosed += Login_FormClosed;
            login.Show();
        }



        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form formFilho in this.MdiChildren)
            {
                formFilho.Close();
            }

            Login login = new Login();
            login.MdiParent = this;
            login.FormClosed += Login_FormClosed;
            login.Show();
        }
    }
}
