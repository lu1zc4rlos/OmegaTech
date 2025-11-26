using client_desktop.Home_Tecnico;
using CredentialManagement;
using model;
using service;
using System.Globalization;

namespace client_desktop.Home {

    public partial class formChamados : Form {

        public formChamados() {
            InitializeComponent();
        }

        private void formChamados_Load(object sender, EventArgs e) {
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

            CarregarTicketsDoClienteAsync().ConfigureAwait(false);
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

        private async Task CarregarTicketsDoClienteAsync(string statusFiltro = null) {

            flowLayoutPanelCards.Controls.Clear();

            string alvo = "OmegaTech-Desktop";
            var credencial = new Credential { Target = alvo };

            if (!credencial.Load()) {
                MessageBox.Show("Sessão não encontrada. Feche a tela e tente novamente.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tokenParaEnvio = credencial.Password;
            List<TicketResponseDTO> listaTickets;

            try {
                var ticketService = new AuthTicketService(tokenParaEnvio);

                listaTickets = await ticketService.BuscarTicketsAsync(statusFiltro);

                if (listaTickets == null || listaTickets.Count == 0) {
                    if (!string.IsNullOrWhiteSpace(statusFiltro)) {
                        MessageBox.Show($"Nenhum chamado encontrado com o status '{statusFiltro}'.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                    flowLayoutPanelCards.Controls.Add(card);
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

        private async void btnCarregar_Click(object sender, EventArgs e) {
            await CarregarTicketsDoClienteAsync();
        }
        private async void button3_Click(object sender, EventArgs e) {
            await CarregarTicketsDoClienteAsync("CONCLUIDO");
        }
        private async void btnChamadosEmAndamento_Click_1(object sender, EventArgs e) {
            await CarregarTicketsDoClienteAsync("EM_ANDAMENTO");
        }
        private async void btnChamadosAbertos_Click(object sender, EventArgs e) {
            await CarregarTicketsDoClienteAsync("PENDENTE");
        }

        private Panel CriarTicketCard(string id, string titulo, string cliente, string prioridade, string tempo, string status) {
            Panel card = new Panel();
            card.Width = 1660;
            card.Height = 90;
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

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));

            table.Controls.Add(NovaLabel("ID", true), 0, 0);
            table.Controls.Add(NovaLabel("Nome chamado", true), 1, 0);
            table.Controls.Add(NovaLabel("Cliente", true), 2, 0);
            table.Controls.Add(NovaLabel("Prioridade", true), 3, 0);
            table.Controls.Add(NovaLabel("Criação", true), 4, 0);
            table.Controls.Add(NovaLabel("Status", true), 5, 0);

            table.Controls.Add(NovaLabel("#HDN" + id), 0, 1);
            table.Controls.Add(NovaLabel(titulo, false, Color.DeepPink), 1, 1);
            table.Controls.Add(NovaLabel(cliente), 2, 1);
            table.Controls.Add(NovaLabel(prioridade), 3, 1);
            table.Controls.Add(NovaLabel(tempo), 4, 1);
            table.Controls.Add(NovaLabel(status), 5, 1);

            Button btnAcao = new Button();
            btnAcao.AutoSize = true;

           
            if (status == "CONCLUIDO") {
                btnAcao.Text = "Ver Resposta";
                btnAcao.BackColor = Color.Green;
                btnAcao.ForeColor = Color.White;

                btnAcao.Click += async (s, e) => {
                    if (!btnAcao.Enabled) return;
                    int idNumerico = int.Parse(id.Replace("#HDN", ""));

                    string token = ObterTokenSalvo();
                    if (string.IsNullOrWhiteSpace(token)) return;

                    await RespostaTicketAsync(idNumerico, token);

                    await CarregarTicketsDoClienteAsync();

                };
            }
            if(status == "PENDENTE") {
                btnAcao.Text = "Excluir";
                btnAcao.BackColor = Color.Red;
                btnAcao.ForeColor = Color.White;
                btnAcao.Click += async (s, e) => {
                    System.Windows.Forms.DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir este chamado?",
                                                                "Confirmar exclusão",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);

                    if (confirmacao == System.Windows.Forms.DialogResult.Yes) {
                        try {
                            string token = ObterTokenSalvo();
                            int idNumerico = int.Parse(id.Replace("#HDN", ""));
                            if (string.IsNullOrEmpty(token)) return;

                            var ticketService = new AuthTicketService(token);

                            await ticketService.ExcluirTicketAsync(idNumerico);

                            MessageBox.Show("Chamado excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            await CarregarTicketsDoClienteAsync();

                        }
                        catch (HttpRequestException ex) {
                            MessageBox.Show($"Falha ao excluir. Detalhe: {ex.Message}", "Erro de API");
                        }
                        catch (Exception ex) {
                            MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro");
                        }
                    }
                };
            }
            if(status == "EM_ANDAMENTO") {
                btnAcao.Text = "Em Andamento";
                btnAcao.BackColor = Color.Blue;
                btnAcao.ForeColor = Color.White;
                btnAcao.Enabled = false;
            }

            card.Controls.Add(btnAcao);

            card.Controls.Add(table);
            return card;
        }
        private async Task RespostaTicketAsync(int ticketId, string token) {

            this.Hide();
            using (formRespostaTecnico respostaTecnico = new formRespostaTecnico(ticketId, token)) {
                respostaTecnico.ShowDialog();
            }
            this.Show();

            await CarregarTicketsDoClienteAsync();
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

        private void button1_Click(object sender, EventArgs e) {
            foreach (Form formFilho in this.MdiChildren) {
                formFilho.Close();
            }
            formAbrirChamado abrirChamado = new formAbrirChamado();

            abrirChamado.MdiParent = this.MdiParent;
            abrirChamado.Show();

        }
        private void dgv_chamados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void pic_home_Click(object sender, EventArgs e) { }
        private void flowLayoutPanelCards_Paint(object sender, PaintEventArgs e) { }
        private void pn_title_Paint(object sender, PaintEventArgs e) { }

        private void button4_Click(object sender, EventArgs e) {
            this.Hide();
            Home homeForm = new Home();
            homeForm.ShowDialog();
            this.Show();

        }
        private void flowLayoutPanelCards_Paint_1(object sender, PaintEventArgs e) { }
    }

}