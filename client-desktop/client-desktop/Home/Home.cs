using client_desktop.Home_Admin;
using CredentialManagement;
using model;
using repository;


namespace client_desktop.Home {
    public partial class Home : Form {

        private ApiClient _apiClient;
        public static string TokenGlobal { get; set; }

        public Home() {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e) {

            string alvo = "OmegaTech-Desktop";
            var credencial = new Credential { Target = alvo };

            if (credencial.Load()) {

                string tokenSalvo = credencial.Password;
                string usuarioSalvo = credencial.Username;
                TokenGlobal = tokenSalvo;

                _apiClient = new ApiClient(tokenSalvo);


            }
            else {
                MessageBox.Show("Sessão expirada. Redirecionando para o Login.", "Erro de Sessão");
                this.Close();
            }
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e) {
            if (sidebarExpand) {
                sideBar.Width -= 10;
                if (sideBar.Width <= 0) {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else {
                sideBar.Width += 10;
                if (sideBar.Width >= 215) {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
        private void btnOmegaHelp_Click(object sender, EventArgs e) {
            foreach (Form formFilho in this.MdiChildren) {
                formFilho.Close();
            }
            formOmegaHelp omegahelp = new formOmegaHelp();
            omegahelp.FormBorderStyle = FormBorderStyle.None;
            omegahelp.TopLevel = false;
            omegahelp.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(omegahelp);
            omegahelp.Show();

        }
        private void btnChamados_Click(object sender, EventArgs e) {
            foreach (Form formFilho in this.MdiChildren) {
                formFilho.Close();
            }

            formChamados chamados = new formChamados(pnlConteudo);
            chamados.FormBorderStyle = FormBorderStyle.None;
            chamados.TopLevel = false;
            chamados.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(chamados);
            chamados.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            sidebarTransition.Start();
        }
        private void panel3_Paint(object sender, PaintEventArgs e) {

        }
    }
}
