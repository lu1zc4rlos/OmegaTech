using System.Drawing.Drawing2D;
using model;
using service;

namespace client_desktop.Home_Tecnico {
    public partial class ResponderTicket : Form {

        private int _ticketId;
        private string _token;
        private TicketResponseDTO _ticketDetalhe;
        public ResponderTicket(int ticketId, string token) {
            InitializeComponent();
            _ticketId = ticketId;
            _token = token;
            ArredondarBotao(btnConfirmarChamado, 20);
        }
        private void ArredondarBotao(Button botao, int raio) {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();

            botao.Region = new Region(path);
        }

        private async void ResponderTicket_Load(object sender, EventArgs e) {
            this.ControlBox = false;

            try {
                var ticketService = new AuthTicketService(_token);
                _ticketDetalhe = await ticketService.BuscarTicketPorIdAsync(_ticketId);

                PreencherUIComDetalhes(_ticketDetalhe);
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

        private async void btnConfirmarChamado_Click(object sender, EventArgs e) {
            string respostaTecnico = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(respostaTecnico)) {
                MessageBox.Show("Por favor, preencha a resposta antes de confirmar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                var ticketService = new AuthTicketService(_token);

                await ticketService.ResponderTicketAsync(_ticketId, respostaTecnico); 

                MessageBox.Show("Chamado concluído e resposta registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (HttpRequestException ex) {
                MessageBox.Show($"Erro ao concluir chamado: {ex.Message}", "Erro de API");
            }
            catch (Exception ex) {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro");
            }
        }

        private void PreencherUIComDetalhes(TicketResponseDTO ticket) {

            Panel card = new Panel();
            card.Size = new Size(400, 600);
            card.BackColor = Color.FromArgb(245, 247, 250);
            card.BorderStyle = BorderStyle.None;
            card.Margin = new Padding(10);
            card.Padding = new Padding(15);

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(card.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(card.Width - 20, card.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, card.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();
            card.Region = new Region(path);

            FlowLayoutPanel layout = new FlowLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.FlowDirection = FlowDirection.TopDown;
            layout.WrapContents = false;
            layout.AutoScroll = false;

            Font boldFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Font normalFont = new Font("Segoe UI", 10, FontStyle.Regular);
            Color textColor = Color.FromArgb(50, 50, 50);

            Label lblCodigo = new Label { Text = $"Id: {"#HDN" + ticket.Id}", Font = boldFont, ForeColor = textColor, AutoSize = true };
            Label lblCliente = new Label { Text = $"Cliente: {ticket.NomeCliente}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblPrioridade = new Label { Text = $"Prioridade: {ticket.Prioridade}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblAssunto = new Label { Text = $"Assunto: {ticket.Titulo}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblAbertoHa = new Label { Text = $"Aberto há: {ticket.DataCriacao}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblStatus = new Label { Text = $"Status: {ticket.Status}", Font = normalFont, ForeColor = textColor, AutoSize = true };

            layout.Controls.Add(lblCodigo);
            layout.Controls.Add(lblCliente);
            layout.Controls.Add(lblPrioridade);
            layout.Controls.Add(lblAssunto);
            layout.Controls.Add(lblAbertoHa);
            layout.Controls.Add(lblStatus);

            card.Controls.Add(layout);

            flowLayoutPanel2.Controls.Add(card);

            Panel descricaoCard = new Panel();
            descricaoCard.Size = new Size(660, 670);
            descricaoCard.BackColor = Color.White;
            descricaoCard.BorderStyle = BorderStyle.FixedSingle;
            descricaoCard.Margin = new Padding(10);
            descricaoCard.Padding = new Padding(10);

            Label lblDescricao = new Label();
            lblDescricao.Text = ticket.Descricao;
            lblDescricao.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblDescricao.ForeColor = Color.FromArgb(70, 70, 70);
            lblDescricao.AutoSize = false;
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.TextAlign = ContentAlignment.TopLeft;
            lblDescricao.MaximumSize = new Size(600, 0);


            descricaoCard.Controls.Add(lblDescricao);

            flowLayoutPanel1.Controls.Add(descricaoCard);

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}