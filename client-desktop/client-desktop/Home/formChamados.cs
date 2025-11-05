using System;
using System.Drawing;
using System.Windows.Forms;
using client_desktop.Home;

namespace client_desktop.Home
{
    public partial class formChamados : Form
    {
        /*
        private Usuario _usuario;
        private TicketClienteDAL _tickeClientetDAL = new TicketClienteDAL();
        */
        public formChamados(/*Usuario usuario*/)
        {
            InitializeComponent();
            /*
            _usuario = usuario;
            */
        }
        private void formChamados_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
            /*
            CarregarTicketsDoCliente();
            */
        }
        /*
        int IdUsuarioLogado = Login.Sessao.UsuarioLogado.Id;
        */
        private void CarregarTicketsDoCliente()
        {
            /*
            flowLayoutPanelCards.Controls.Clear();


            var listaTickets = _tickeClientetDAL.ObterTicketsDoBancoPorUsuario(IdUsuarioLogado);


            foreach (var ticket in listaTickets)
            {
                var card = CriarTicketCard(ticket.ID, ticket.Titulo, ticket.Cliente, ticket.Prioridade, ticket.Tempo, ticket.Status);
                flowLayoutPanelCards.Controls.Add(card);
            }
            */
        }
        private Panel CriarTicketCard(string id, string titulo, string cliente, string prioridade, string tempo, string status)
        {
            Panel card = new Panel();
            card.Width = 850;
            card.Height = 80;
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
            table.Controls.Add(NovaLabel("Há", true), 4, 0);
            table.Controls.Add(NovaLabel("Status", true), 5, 0);

            table.Controls.Add(NovaLabel(id), 0, 1);
            table.Controls.Add(NovaLabel(titulo, false, Color.DeepPink), 1, 1);
            table.Controls.Add(NovaLabel(cliente), 2, 1);
            table.Controls.Add(NovaLabel(prioridade), 3, 1);
            table.Controls.Add(NovaLabel(tempo), 4, 1);
            table.Controls.Add(NovaLabel(status), 5, 1);

            // Adicionar botão dinâmico
            Button btnAcao = new Button();
            btnAcao.AutoSize = true;

            // Verifica o status do chamado
            if (status == "Concluído")
            {
                btnAcao.Text = "Ver Resposta";
                btnAcao.BackColor = Color.Green;
                btnAcao.ForeColor = Color.White;
                btnAcao.Click += (s, e) =>
                {
                    int idNumerico = int.Parse(id.Replace("#HDN", ""));

                    this.Hide();
                    // Abre a tela de resposta do técnico
                    /*
                    using (formRespostaTecnico respostaTecnico = new formRespostaTecnico(idNumerico,_usuario))
                    {
                        respostaTecnico.ShowDialog();
                        this.Close();
                    }
                    */
                };
            }
            else
            {
                btnAcao.Text = "Excluir";
                btnAcao.BackColor = Color.Red;
                btnAcao.ForeColor = Color.White;
                btnAcao.Click += (s, e) =>
                {
                    int idNumerico = int.Parse(id.Replace("#HDN", ""));
                    DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir este chamado?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacao == DialogResult.Yes)
                    {
                        /*
                        _tickeClientetDAL.ExcluirTicket(idNumerico);
                        MessageBox.Show("Chamado excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTicketsDoCliente();
                        */
                    }
                };
            }

            // Aqui você adiciona o botão ao seu Card ou ao Layout
            card.Controls.Add(btnAcao);

            card.Controls.Add(table);
            return card;
        }

        private Label NovaLabel(string texto, bool negrito = false, Color? cor = null)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", negrito ? 9F : 8.5F, negrito ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = cor ?? Color.Black,
                AutoSize = true,
                Anchor = AnchorStyles.Left,
                Margin = new Padding(3, 0, 3, 0)
            };
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            /*
            flowLayoutPanelCards.Controls.Clear();

            var listaTickets = _tickeClientetDAL.ObterTicketsDoBancoPorUsuario(_usuario.Id);

            foreach (var ticket in listaTickets)
            {
                var card = CriarTicketCard(ticket.ID, ticket.Titulo, ticket.Cliente, ticket.Prioridade, ticket.Tempo, ticket.Status);
                flowLayoutPanelCards.Controls.Add(card);
            }
            */
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            flowLayoutPanelCards.Controls.Clear();
            var listaTickets = _tickeClientetDAL.ObterTicketsDoBancoPorUsuario(_usuario.Id, "Em andamento");

            foreach (var ticket in listaTickets)
            {
                var card = CriarTicketCard(ticket.ID, ticket.Titulo, ticket.Cliente, ticket.Prioridade, ticket.Tempo, ticket.Status);
                flowLayoutPanelCards.Controls.Add(card);
            }
            */
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*
            flowLayoutPanelCards.Controls.Clear();
            var listaTickets = _tickeClientetDAL.ObterTicketsDoBancoPorUsuario(_usuario.Id, "Concluído");

            foreach (var ticket in listaTickets)
            {
                var card = CriarTicketCard(ticket.ID, ticket.Titulo, ticket.Cliente, ticket.Prioridade, ticket.Tempo, ticket.Status);
                flowLayoutPanelCards.Controls.Add(card);
            }
            */
        }
        private void btnChamadosAbertos_Click(object sender, EventArgs e)
        {
            /*
            flowLayoutPanelCards.Controls.Clear();
            var listaTickets = _tickeClientetDAL.ObterTicketsDoBancoPorUsuario(_usuario.Id, "Aberto");

            foreach (var ticket in listaTickets)
            {
                var card = CriarTicketCard(ticket.ID, ticket.Titulo, ticket.Cliente, ticket.Prioridade, ticket.Tempo, ticket.Status);
                flowLayoutPanelCards.Controls.Add(card);
            }
            */
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            using (formAbrirChamado _formAbrirChamado = new formAbrirChamado(_usuario))
            {
                _formAbrirChamado.ShowDialog();
            }
            this.Hide();
            */
        }
        private void dgv_chamados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void pic_home_Click(object sender, EventArgs e) 
        {
            /*
            this.Hide();
            home = new Home(_usuario);
            home.FormClosed += (s, args) => Application.Exit();
            home.ShowDialog();
            this.Close();
            */
        }

        private void flowLayoutPanelCards_Paint(object sender, PaintEventArgs e){}
        private void pn_title_Paint(object sender, PaintEventArgs e){}
    }
}
