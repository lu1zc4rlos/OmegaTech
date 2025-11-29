namespace client_desktop.Home_Admin {
    public partial class RespostaDoTecnico : Form {

        private readonly string _descricao;
        private readonly string _respostaTecnico;
        public RespostaDoTecnico(string descricao, string resposta) {
            InitializeComponent();
            _descricao = descricao.Replace("#HDN", "").Trim();
            _respostaTecnico = resposta.Trim();
        }
        private void RespostaDoTecnico_Load(object sender, EventArgs e) {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

            ExibirConteudo();
        }
        private void ExibirConteudo() {
            PreencherFlowLayoutPanel(flowLayoutPanelDescricao, "Descrição do Chamado:", _descricao);

            PreencherFlowLayoutPanel(flowLayoutPanelResposta, "Resposta do Técnico:", _respostaTecnico);
        }
        private void PreencherFlowLayoutPanel(FlowLayoutPanel panel, string titulo, string conteudo) {
            panel.Controls.Clear();

            Label lblTitulo = new Label {
                Text = titulo,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 5) 
            };
            panel.Controls.Add(lblTitulo);

            Label lblConteudo = new Label {
                Text = conteudo,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                MaximumSize = new Size(panel.Width - panel.Padding.Horizontal, 0)
            };
            panel.Controls.Add(lblConteudo);
        }
    }
}
