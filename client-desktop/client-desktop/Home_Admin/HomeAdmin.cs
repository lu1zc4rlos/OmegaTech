using client_desktop.Home;
using CredentialManagement;
using repository;

namespace client_desktop.Home_Admin {
    public partial class HomeAdmin : Form {
        private ApiClient _apiClient;
        public static string TokenGlobal { get; set; }
        public HomeAdmin() {
            InitializeComponent();
        }
        public void HomeAdmin_Load(object sender, EventArgs e) {
            string alvo = "OmegaTech-Desktop";
            var credencial = new Credential { Target = alvo };

            if (!credencial.Load()) {
                MessageBox.Show("Sessão expirada. Por favor, faça o login novamente.", "Sessão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (Login login = new Login()) {
                    System.Windows.Forms.DialogResult resultado = login.ShowDialog();

                    if (resultado != System.Windows.Forms.DialogResult.OK) {
                        this.Close();
                        return;
                    }
                }
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
                if (sideBar.Width >= 240) {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        public void btnAdicionarTecnico_Click(object sender, EventArgs e) {

            foreach (Form formFilho in this.MdiChildren) {
                formFilho.Close();
            }
            AdicionarTecnico adicionarTecnico = new AdicionarTecnico();

            adicionarTecnico.FormBorderStyle = FormBorderStyle.None;
            adicionarTecnico.TopLevel = false;
            adicionarTecnico.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(adicionarTecnico);
            adicionarTecnico.Show();
        }
        public void btnTecnicosCadastrados_Click(object sender, EventArgs e) {

            foreach (Form formFilho in this.MdiChildren) {
                formFilho.Close();
            }
            TecnicosCadastrados tecnicosCadastrados = new TecnicosCadastrados(pnlConteudo);

            tecnicosCadastrados.FormBorderStyle = FormBorderStyle.None;
            tecnicosCadastrados.TopLevel = false; 
            tecnicosCadastrados.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear(); 
            pnlConteudo.Controls.Add(tecnicosCadastrados);
            tecnicosCadastrados.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e) {
            sidebarTransition.Start();
        }
        private void lblTitulo_Click(object sender, EventArgs e) { }

    }
}
