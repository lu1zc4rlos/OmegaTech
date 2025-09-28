using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using client_desktop.Home_Técnico;

namespace client_desktop.Home_Tecnico
{
    public partial class ResponderTicket : Form
    {
        /*
        private Ticket _ticket;
        private Usuario _usuario;
        */
        public ResponderTicket()
        {
            InitializeComponent();
        }
        private void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();

            botao.Region = new Region(path);
        }
        /*
        public ResponderTicket(Ticket ticket, Usuario usuario)
        {        
            InitializeComponent();
         
            _ticket = ticket;
            _usuario = usuario;
        }
        */
        private void ResponderTicket_Load(object sender, EventArgs e)
        {
            /*
            CriarCard();
            ArredondarBotao(btnConfirmarChamado, 20);
            */
        }
        private void CriarCard()
        {
            /*
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


            Label lblCodigo = new Label { Text = $"Código: {_ticket.ID}", Font = boldFont, ForeColor = textColor, AutoSize = true };
            Label lblCliente = new Label { Text = $"Cliente: {_usuario.Nome}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblPrioridade = new Label { Text = $"Prioridade: {_ticket.Prioridade}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblAssunto = new Label { Text = $"Assunto: {_ticket.Titulo}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblAbertoHa = new Label { Text = $"Aberto há: {_ticket.Tempo}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblStatus = new Label { Text = $"Status: {_ticket.Status}", Font = normalFont, ForeColor = textColor, AutoSize = true };
            Label lblEmail = new Label { Text = $"Email: {_usuario.Email}", Font = normalFont, ForeColor = textColor, AutoSize = true };

            layout.Controls.Add(lblCodigo);
            layout.Controls.Add(lblCliente);
            layout.Controls.Add(lblPrioridade);
            layout.Controls.Add(lblAssunto);
            layout.Controls.Add(lblAbertoHa);
            layout.Controls.Add(lblStatus);
            layout.Controls.Add(lblEmail);

            card.Controls.Add(layout);

            flowLayoutPanelCard.Controls.Add(card);

            Panel descricaoCard = new Panel();
            descricaoCard.Size = new Size(660, 670);
            descricaoCard.BackColor = Color.White;
            descricaoCard.BorderStyle = BorderStyle.FixedSingle;
            descricaoCard.Margin = new Padding(10);
            descricaoCard.Padding = new Padding(10);

            Label lblDescricao = new Label();
            lblDescricao.Text = _ticket.Descricao;
            lblDescricao.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblDescricao.ForeColor = Color.FromArgb(70, 70, 70);
            lblDescricao.AutoSize = false;
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.TextAlign = ContentAlignment.TopLeft;
            lblDescricao.MaximumSize = new Size(600, 0);


            descricaoCard.Controls.Add(lblDescricao);

            flowLayoutPanelDescricao.Controls.Add(descricaoCard);
            */

        }
        private void btnConfirmarChamado_Click(object sender, EventArgs e)
        {
            /*
            if (string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                MessageBox.Show("Por favor, preencha a resposta antes de confirmar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                TicketDAL ticketDAL = new TicketDAL();

                ticketDAL.AdicionarResposta(int.Parse(_ticket.ID.Replace("#HDN", "")), txtResposta.Text.Trim());

                MessageBox.Show("Resposta enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar resposta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void flowLayoutPanelDescricao_Paint(object sender, PaintEventArgs e) { }
        private void txtResposta_TextChanged(object sender, EventArgs e) { }
        private void flowLayoutPanelCard_Paint(object sender, PaintEventArgs e) { }

        private void pic_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeTecnico _homeTecnico = new HomeTecnico();
            _homeTecnico.FormClosed += (s, args) => Application.Exit();
            _homeTecnico.ShowDialog();
            this.Close();
        }
    }
}

