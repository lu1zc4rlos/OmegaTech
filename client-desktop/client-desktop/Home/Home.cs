using model;
using repository;
using CredentialManagement;


namespace client_desktop.Home {
    public partial class Home : Form
    {

        private ApiClient _apiClient;
        public static string TokenGlobal { get; private set; }

        public Home(string username)
        {
        public Home() {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {

            string alvo = "OmegaTech-Desktop";
            string tokenSalvo = null;
            string usuarioSalvo = null;
            var credencial = new Credential { Target = alvo };

            if (credencial.Load())
            {

                tokenSalvo = credencial.Password;
                usuarioSalvo = credencial.Username;
                TokenGlobal = tokenSalvo;

                _apiClient = new ApiClient(tokenSalvo);


            }
            else
            {
                MessageBox.Show("Sessão expirada. Por favor, faça o login novamente.");
                this.Hide();
                using (Login login = new Login()) {
                    login.ShowDialog();
                }
                this.Show();
            }
        }

        private void btn_chamados_Click(object sender, EventArgs e) {
            this.Hide();
            using (formChamados formChamados = new formChamados()) {
                formChamados.ShowDialog();
            }
            this.Show();
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 54)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 215)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
        private void btn_chatbot_Click(object sender, EventArgs e) {

            this.Hide();
            using (formOmegaHelp formOmegaHelp = new formOmegaHelp()) {
                formOmegaHelp.ShowDialog();
            }
            this.Show();
            
        }

        private void btnOmegaHelp_Click(object sender, EventArgs e)
        {
            foreach (Form formFilho in this.MdiChildren)
            {
                formFilho.Close();
            }
            formOmegaHelp omegahelp = new formOmegaHelp();

            omegahelp.MdiParent = this;
            omegahelp.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {


        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            foreach (Form formFilho in this.MdiChildren)
            {
                formFilho.Close();
            }

            formChamados chamados = new formChamados();
            chamados.MdiParent = this;
            chamados.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void btn_sidebar_Click(object sender, EventArgs e) {
            SideBarTransition.Start();
        }
    }
}
