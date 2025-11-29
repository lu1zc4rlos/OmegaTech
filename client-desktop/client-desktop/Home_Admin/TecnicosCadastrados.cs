using CredentialManagement;
using model;
using service;

namespace client_desktop.Home_Admin {
    public partial class TecnicosCadastrados : Form {

        private readonly Panel _painelPrincipal;
        public TecnicosCadastrados(Panel painelPrincipal) {
            InitializeComponent();
            _painelPrincipal = painelPrincipal;
        }
        public async void TecnicosCadastrados_Load(object sender, EventArgs e) {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

            await CarregarListaTecnicosAsync();
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

        private async Task CarregarListaTecnicosAsync() {

            flowLayoutPanel1.Controls.Clear(); 

            string tokenParaEnvio = ObterTokenSalvo();
            if (string.IsNullOrEmpty(tokenParaEnvio)) return;

            List<TecnicoResponseDTO> listaTecnicos;

            try {
                var tecnicoService = new AuthUsuarioService(tokenParaEnvio);

                listaTecnicos = await tecnicoService.BuscarTodosTecnicosAsync();

                if (listaTecnicos == null || listaTecnicos.Count == 0) {
                    MessageBox.Show("Nenhum técnico cadastrado encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var tecnico in listaTecnicos) {
                    string dataCadastroFormatada = tecnico.DataCriacao.ToString("dd/MM/yyyy");

                    var card = CriarTecnicoCard(
                        tecnico.Id.ToString(),
                        tecnico.Nome,
                        tecnico.Matricula,
                        dataCadastroFormatada,
                        tecnico.Email
                    );
                    flowLayoutPanel1.Controls.Add(card);
                }

            }
            catch (HttpRequestException ex) {
                MessageBox.Show($"Falha ao buscar técnicos da API. Detalhe: {ex.Message}", "Erro de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            table.Padding = new Padding(0);
            table.Margin = new Padding(0);

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

            Button btnDetalhe = new Button();
            btnDetalhe.Text = "Detalhes";
            btnDetalhe.BackColor = Color.DarkOrange;
            btnDetalhe.ForeColor = Color.White;
            btnDetalhe.AutoSize = true;

            btnDetalhe.Click += async (s, e) => {

                string token = ObterTokenSalvo();
                if (string.IsNullOrWhiteSpace(token)) return;

                int idNumerico = int.Parse(id);

                await AbrirDetalhesTecnicoAsync(idNumerico, token);

                await CarregarListaTecnicosAsync();
            };

            card.Controls.Add(btnDetalhe); 
            card.Controls.Add(table);

            return card;
        }

        private async Task AbrirDetalhesTecnicoAsync(int tecnicoId, string token) {

            this.Hide();
            DetalhesTecnico detalheTecnico = new DetalhesTecnico(tecnicoId, token, _painelPrincipal);

            detalheTecnico.FormBorderStyle = FormBorderStyle.None;
            detalheTecnico.TopLevel = false;
            detalheTecnico.Dock = DockStyle.Fill;

            _painelPrincipal.Controls.Clear();
            _painelPrincipal.Controls.Add(detalheTecnico);
            detalheTecnico.Show();
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
    }
}

