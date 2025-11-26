using client_desktop.Home_Tecnico;
using CredentialManagement;
using model;
using service;
using System.Drawing.Drawing2D;
using System.Globalization;


namespace client_desktop.Home_Técnico {
    public partial class HomeTecnico : Form {
        public FlowLayoutPanel flowLayoutPanelCards;

        public HomeTecnico() {
            InitializeComponent();
            ArredondarBotao(btnTicketsTotais, 20);
            ArredondarBotao(btnTicketsAbertos, 20);
            ArredondarBotao(btnEmAtendimento, 20);
            ArredondarBotao(btnTicketsFechados, 20);
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

        private void HomeTecnico_Load(object sender, EventArgs e) {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

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

            CarregarTicketsDoTecnicoAsync().ConfigureAwait(false);
        }

        private async Task CarregarTicketsDoTecnicoAsync(string statusFiltro = null) {

            flowLayoutPanel.Controls.Clear();

            string alvo = "OmegaTech-Desktop";
            var credencial = new Credential { Target = alvo };

            if (!credencial.Load()) {
                MessageBox.Show("Sessão não encontrada. Necessário re-autenticar.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tokenParaEnvio = credencial.Password;
            List<TicketResponseDTO> listaTickets;

            try {
                var ticketService = new AuthTicketService(tokenParaEnvio);

                string filtroApi = statusFiltro != null ? statusFiltro.ToUpperInvariant().Replace(' ', '_') : null;
                listaTickets = await ticketService.BuscarTicketsAsync(filtroApi);

                if (listaTickets == null || listaTickets.Count == 0) {
                    string msg = string.IsNullOrWhiteSpace(statusFiltro) ?
                                 "Nenhum chamado atribuído encontrado." :
                                 $"Nenhum chamado com status '{statusFiltro}' encontrado.";
                    MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var ticket in listaTickets) {
                    string dataFormatada = ticket.DataCriacao.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                    var card = CriarTicketCard(
                        ticket.Id.ToString(),
                        ticket.Titulo,
                        ticket.NomeCliente,
                        ticket.Prioridade,
                        dataFormatada,
                        ticket.Status
                    );
                    flowLayoutPanel.Controls.Add(card);
                }

            }
            catch (HttpRequestException ex) {
                MessageBox.Show($"Falha ao buscar tickets da API. Detalhe: {ex.Message}",
                                "Erro de API",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}",
                                "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AtualizarStatusTicketAsync(int ticketId, string novoStatus, string token) {
            try {
                var ticketService = new AuthTicketService(token);
                await ticketService.AtualizarStatusAsync(ticketId,novoStatus);

                MessageBox.Show($"Status do Ticket {ticketId} alterado para {novoStatus} na API.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarTicketsDoTecnicoAsync();
            }
            catch (HttpRequestException ex) {
                MessageBox.Show($"Falha ao atualizar status. Detalhe: {ex.Message}", "Erro de API");
            }
        }

        private async Task ResponderEAtualizarTicketAsync(int ticketId, string token, string cliente) {

            this.Hide();
            using (ResponderTicket responderTicket = new ResponderTicket(ticketId, token)) {
                System.Windows.Forms.DialogResult resultado = responderTicket.ShowDialog();

                if (resultado == System.Windows.Forms.DialogResult.OK) {
                    MessageBox.Show($"Ticket {ticketId} concluído com sucesso.", "Ação Finalizada");
                }
            }
            this.Show();

            await CarregarTicketsDoTecnicoAsync();
        }

        public Panel CriarTicketCard(string id, string titulo, string cliente, string prioridade, string tempo, string status) {
            Panel card = new Panel();
            card.Width = 1000;
            card.Height = 100;
            card.BackColor = Color.FromArgb(245, 245, 255);
            card.Padding = new Padding(10);
            card.Margin = new Padding(5);
            card.BorderStyle = BorderStyle.FixedSingle;

            TableLayoutPanel table = new TableLayoutPanel();
            table.Dock = DockStyle.Fill;
            table.ColumnCount = 7;
            table.RowCount = 2;
            table.Padding = new Padding(0);
            table.Margin = new Padding(0);

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));

            table.Controls.Add(NovaLabel("ID", true), 0, 0);
            table.Controls.Add(NovaLabel("Nome chamado", true), 1, 0);
            table.Controls.Add(NovaLabel("Cliente", true), 2, 0);
            table.Controls.Add(NovaLabel("Prioridade", true), 3, 0);
            table.Controls.Add(NovaLabel("Há", true), 4, 0);
            table.Controls.Add(NovaLabel("Status", true), 5, 0);
            table.Controls.Add(NovaLabel("Ação", true), 6, 0);

            table.Controls.Add(NovaLabel("#HDN" + id), 0, 1);
            table.Controls.Add(NovaLabel(titulo, false, Color.DeepPink), 1, 1);
            table.Controls.Add(NovaLabel(cliente), 2, 1);
            table.Controls.Add(NovaLabel(prioridade), 3, 1);
            table.Controls.Add(NovaLabel(tempo), 4, 1);
            table.Controls.Add(NovaLabel(status), 5, 1);

            Button btnAtualizar = new Button();
            btnAtualizar.AutoSize = true;
            btnAtualizar.BackColor = Color.FromArgb(0, 150, 136);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Enabled = true;

            string statusUpper = status.ToUpperInvariant().Replace(' ', '_');

            switch (statusUpper) {
                case "PENDENTE":
                    btnAtualizar.Text = "Iniciar";
                    btnAtualizar.BackColor = Color.DodgerBlue;
                    break;
                case "EM_ANDAMENTO":
                    btnAtualizar.Text = "Responder";
                    btnAtualizar.BackColor = Color.OrangeRed;
                    break;
                case "CONCLUIDO":
                    btnAtualizar.Text = "Concluído";
                    btnAtualizar.Enabled = false;
                    btnAtualizar.BackColor = Color.Green;
                    break;
                default:
                    btnAtualizar.Text = "Aguardando";
                    btnAtualizar.Enabled = false;
                    break;
            }

            btnAtualizar.Click += async (s, e) => {
                if (!btnAtualizar.Enabled) return;

                string token = ObterTokenSalvo();
                if (string.IsNullOrWhiteSpace(token)) return;

                int idNumerico = int.Parse(id);
                string proximoStatusApi = "";

                string currentStatus = status.ToUpperInvariant().Replace(' ', '_');

                if (currentStatus == "PENDENTE") {
                    proximoStatusApi = "EM_ANDAMENTO";
                    await AtualizarStatusTicketAsync(idNumerico, proximoStatusApi, token);
                }
                else if (currentStatus == "EM_ANDAMENTO") {
                    await ResponderEAtualizarTicketAsync(idNumerico, token, cliente);
                }

                await CarregarTicketsDoTecnicoAsync();
            };

            table.Controls.Add(btnAtualizar, 6, 1);
            card.Controls.Add(table);

            return card;
        }

        private string ObterTokenSalvo() {
            string alvo = "OmegaTech-Desktop";
            var credencial = new Credential { Target = alvo };
            if (credencial.Load()) {
                return credencial.Password;
            }
            MessageBox.Show("Sessão expirada. Faça login novamente.", "Erro de Token");
            this.Close();
            return null;
        }
        private Label NovaLabel(string texto, bool negrito = false, Color? cor = null) {
            return new Label {
                Text = texto,
                Font = new Font("Segoe UI", negrito ? 9F : 8.5F, negrito ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = cor ?? Color.Black,
                AutoSize = true,
                Anchor = AnchorStyles.Left,
                Margin = new Padding(3, 0, 3, 0)
            };
        }

        private async void btnTicketsTotais_Click(object sender, EventArgs e) {
            await CarregarTicketsDoTecnicoAsync();
        }
        private async void btnTicketsAbertos_Click(object sender, EventArgs e) {
            await CarregarTicketsDoTecnicoAsync("PENDENTE");
        }
        private async void btnEmAtendimento_Click(object sender, EventArgs e) {
            await CarregarTicketsDoTecnicoAsync("EM_ANDAMENTO");
        }
        private async void btnTicketsFechados_Click(object sender, EventArgs e) {
            await CarregarTicketsDoTecnicoAsync("CONCLUIDO");
        }

        private void lblDashboardPrincipal_Click(object sender, EventArgs e) { }

        private void flowLayoutPanelCards_Paint(object sender, PaintEventArgs e) { }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}