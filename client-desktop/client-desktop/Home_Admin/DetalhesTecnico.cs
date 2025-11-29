using client_desktop.Home;
using CredentialManagement;
using model;
using Newtonsoft.Json.Linq;
using service;
using System.Globalization;

namespace client_desktop.Home_Admin {
    public partial class DetalhesTecnico : Form {

        private readonly int _tecnicoId;
        private readonly string _token;
        private readonly Panel _painelPrincipal;


        public DetalhesTecnico(int tecnicoId, string token, Panel painelPrincipal) {
            InitializeComponent();
            _tecnicoId = tecnicoId;
            _token = token;
            _painelPrincipal = painelPrincipal;

        }

        public async void DetalhesTecnico_Load(object sender, EventArgs e) {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
            await CarregarDetalhesTecnicosAsync(); 
        }

        private async Task CarregarDetalhesTecnicosAsync() { 

            flowLayoutPanel1.Controls.Clear(); 

            if (string.IsNullOrEmpty(_token)) {
                MessageBox.Show("Token de autenticação ausente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            TecnicoResponseDTO detalhesTecnico;

            try {
                var tecnicoService = new AuthUsuarioService(_token);

                detalhesTecnico = await tecnicoService.BuscarDetalhesTecnicoAsync(_tecnicoId);

                if (detalhesTecnico == null) {
                    MessageBox.Show("Detalhes do técnico não encontrados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var tecnico = detalhesTecnico;

                string dataCadastroFormatada = tecnico.DataCriacao.ToString("dd/MM/yyyy");

                var card = CriarTecnicoCard(
                    tecnico.Id.ToString(),
                    tecnico.Nome,
                    tecnico.Matricula,
                    dataCadastroFormatada,
                    tecnico.Email
                );

                flowLayoutPanel1.Controls.Add(card);
                await CarregarTicketsRespondidosDoTecnicoAsync();
            }
            catch (HttpRequestException ex) {
                MessageBox.Show($"Falha ao buscar detalhes do técnico. Detalhe: {ex.Message}", "Erro de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CriarTecnicoCard(string id, string nome, string matricula, string dataCriacao, string email) {

            Panel card = new Panel();
            card.Width = 1000;
            card.Height = 90;
            card.BackColor = Color.FromArgb(245, 245, 255);
            card.Padding = new Padding(10);
            card.Margin = new Padding(5);
            card.BorderStyle = BorderStyle.FixedSingle;

            TableLayoutPanel table = new TableLayoutPanel();
            table.Dock = DockStyle.Fill;
            table.ColumnCount = 6;
            table.RowCount = 2;

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));

            table.Controls.Add(NovaLabel("ID", true), 0, 0);
            table.Controls.Add(NovaLabel("Nome", true), 1, 0);
            table.Controls.Add(NovaLabel("Matrícula", true), 2, 0);
            table.Controls.Add(NovaLabel("E-mail", true), 3, 0);
            table.Controls.Add(NovaLabel("Desde", true), 4, 0);

            table.Controls.Add(NovaLabel("#HDN" + id), 0, 1);
            table.Controls.Add(NovaLabel(nome, false, Color.Navy), 1, 1);
            table.Controls.Add(NovaLabel(matricula), 2, 1);
            table.Controls.Add(NovaLabel(email), 3, 1);
            table.Controls.Add(NovaLabel(dataCriacao), 4, 1);

            card.Controls.Add(table);
            return card;
        }
        private Panel CriarTicketCard(string id, string titulo, string cliente, string prioridade, string tempo, string status, string descricao, string resposta) {
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

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4));
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

                    this.Hide();
                    RespostaDoTecnico respostaDoTecnico = new RespostaDoTecnico(descricao, resposta);

                    respostaDoTecnico.FormBorderStyle = FormBorderStyle.None;
                    respostaDoTecnico.TopLevel = false;
                    respostaDoTecnico.Dock = DockStyle.Fill;

                    _painelPrincipal.Controls.Clear();
                    _painelPrincipal.Controls.Add(respostaDoTecnico);
                    respostaDoTecnico.Show();

                };
            }

            card.Controls.Add(btnAcao);

            card.Controls.Add(table);
            return card;
        }
        private async Task CarregarTicketsRespondidosDoTecnicoAsync() {

            flowLayoutPanel2.Controls.Clear();

            if (string.IsNullOrEmpty(_token)) {
                MessageBox.Show("Token de autenticação ausente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<TicketResponseDTO> listaTickets;

            try {
                var ticketService = new AuthTicketService(_token); 

                listaTickets = await ticketService.BuscarTicketsRespondidosPorTecnicoAsync(_tecnicoId);

                if (listaTickets == null || listaTickets.Count == 0) {
                    MessageBox.Show($"Nenhum chamado CONCLUÍDO encontrado para o Técnico ID {_tecnicoId}.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        ticket.Status,
                        ticket.Descricao,
                        ticket.Resposta
                    );
                    flowLayoutPanel2.Controls.Add(card);
                }

            }
            catch (HttpRequestException ex) {
                MessageBox.Show($"Falha ao buscar tickets do técnico. Detalhe: {ex.Message}",
                                "Erro de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show($"Esse técnico não respondeu a nenhum ticket",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Label NovaLabel(string texto, bool negrito = false, Color? cor = null) {
            return new Label {
                Text = texto,
                Font = new Font("Segoe UI", negrito ? 9F : 8.5F, negrito ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = cor ?? Color.Black,
                AutoSize = true,
                Anchor = AnchorStyles.Left | AnchorStyles.Top, 
                Margin = new Padding(3, 0, 3, 0)
            };
        }
    }
}