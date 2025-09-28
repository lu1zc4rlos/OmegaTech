using System;
using System.Drawing;
using System.Windows.Forms;

namespace client_desktop.Home
{
    public partial class formOmegaHelp : Form {
        /*
        private Usuario _usuario;
        */
        public formOmegaHelp(/*Usuario usuario*/) {
            InitializeComponent();
            /*
            this.AcceptButton = btnEnviar;
            _usuario = usuario;
            */
        }

        private void TxtEnviarMensagem_KeyDown(object sender, KeyEventArgs e) {
            throw new NotImplementedException();
        }

        private void AdicionarMensagem(string mensagem, bool ehUsuario) {
            /*
            Label lbl = new Label();
            lbl.Text = mensagem;
            lbl.Font = new Font("Segoe UI", 10);
            lbl.MaximumSize = new Size(flowLayoutPanelChat.Width - 100, 0);
            lbl.AutoSize = true;
            lbl.Padding = new Padding(10);
            lbl.BackColor = ehUsuario ? Color.FromArgb(60, 62, 110) : Color.Bisque;
            lbl.ForeColor = ehUsuario ? Color.White : Color.Black;
            lbl.Margin = new Padding(5);

            FlowLayoutPanel linha = new FlowLayoutPanel();
            linha.FlowDirection = FlowDirection.LeftToRight;
            linha.WrapContents = false;
            linha.Width = flowLayoutPanelChat.Width - 25;
            linha.AutoSize = true;
            linha.Padding = new Padding(5);

            if (ehUsuario) {
                linha.Controls.Add(new Label() { Width = linha.Width - lbl.PreferredWidth - 20 });
                linha.Controls.Add(lbl);
            }
            else {
                linha.Controls.Add(lbl);
            }

            flowLayoutPanelChat.Controls.Add(linha);
            flowLayoutPanelChat.ScrollControlIntoView(linha);
        }
        private async void btnEnviar_Click(object sender, EventArgs e) {
            string mensagem = txtEnviarMensagem.Text.Trim();

            if (!string.IsNullOrEmpty(mensagem)) {
                AdicionarMensagem(mensagem, true);

                try {
                    string resposta = await ChatBLL.ProcessarMensagemAsync(mensagem);
                    AdicionarMensagem(resposta, false);
                }
                catch (Exception ex) {
                    AdicionarMensagem("Erro ao processar resposta: " + ex.Message, false);
                }

                txtEnviarMensagem.Clear();
            }
            */
        }
        private void formOmegaHelp_Load(object sender, EventArgs e) {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }
        /*
        Home home;
        private Usuario usuario;
        */
        private void pic_home_Click(object sender, EventArgs e) {
            /*
            this.Hide();
            home = new Home(usuario);
            home.FormClosed += (s, args) => Application.Exit();
            home.ShowDialog();
            this.Close();
            */
        }
        private void pn_title_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanelChat_Paint(object sender, PaintEventArgs e) {}
    }
}
