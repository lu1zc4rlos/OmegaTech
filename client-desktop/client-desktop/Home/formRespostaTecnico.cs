using model;
using service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace client_desktop.Home
{
    public partial class formRespostaTecnico : Form
    {
        private int _ticketId;
        private string _token;
        private TicketResponseDTO _ticketDetalhe;
        public formRespostaTecnico(int ticketId, string token)
        {
            InitializeComponent();
            _ticketId = ticketId;
            _token = token;
        }
        private async void formRespostaTecnico_LoadAsync(object sender, EventArgs e)
        {
            this.ControlBox = false;

            try {
                var ticketService = new AuthTicketService(_token);
                _ticketDetalhe = await ticketService.BuscarTicketPorIdAsync(_ticketId);

                CarregarDetalhesTicket(_ticketDetalhe);
            }
            catch (HttpRequestException ex) {
                MessageBox.Show("Falha ao carregar detalhes do ticket: " + ex.Message, "Erro de API");
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro");
                this.Close();
            }
        }
        private void CarregarDetalhesTicket(TicketResponseDTO ticket)
        {
            
            try
            {
                if (ticket != null)
                {
                    Panel descricaoCard = new Panel();
                    descricaoCard.Size = new Size(670, 1000);
                    descricaoCard.BorderStyle = BorderStyle.FixedSingle;
                    descricaoCard.Margin = new Padding(10);
                    descricaoCard.Padding = new Padding(10);

                    Panel respostaCard = new Panel();
                    respostaCard.Size = new Size(670, 1000);
                    respostaCard.BorderStyle = BorderStyle.FixedSingle;
                    respostaCard.Margin = new Padding(10);
                    respostaCard.Padding = new Padding(10);

                    Label lblDescricao = new Label();
                    lblDescricao.Text = ticket.Descricao;
                    lblDescricao.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    lblDescricao.ForeColor = Color.FromArgb(70, 70, 70);
                    lblDescricao.AutoSize = false;
                    lblDescricao.Dock = DockStyle.Fill;
                    lblDescricao.TextAlign = ContentAlignment.TopLeft;
                    lblDescricao.MaximumSize = new Size(660, 0);

                    Label lblResposta = new Label();
                    lblResposta.Text = ticket.Resposta;
                    lblResposta.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    lblResposta.ForeColor = Color.FromArgb(70, 70, 70);
                    lblResposta.AutoSize = false;
                    lblResposta.Dock = DockStyle.Fill;
                    lblResposta.TextAlign = ContentAlignment.TopLeft;
                    lblResposta.MaximumSize = new Size(660, 0);


                    descricaoCard.Controls.Add(lblDescricao);
                    respostaCard.Controls.Add(lblResposta);

                    flowLayoutPanelDescricao.Controls.Add(descricaoCard);

                    flowLayoutPanelResposta.Controls.Add(respostaCard);
                }
                else
                {
                    MessageBox.Show("Chamado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes do chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void pic_home_Click(object sender, EventArgs e) {}
        private void flowLayoutPanelResposta_Paint(object sender, PaintEventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void panelDescricao_Paint(object sender, PaintEventArgs e) {}
    }
}
