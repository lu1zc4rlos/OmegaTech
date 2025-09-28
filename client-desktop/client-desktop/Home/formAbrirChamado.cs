using System;
using System.Windows.Forms;
using client_desktop.Home;

namespace client_desktop.Home
{
    public partial class formAbrirChamado : Form
    {
        /*
        private Usuario _usuario;
        */
        public formAbrirChamado(/*Usuario usuario*/)
        {
            /*
            InitializeComponent();
            _usuario = usuario;
            */
        }

        private void formAbrirChamado_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            // Validações
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, insira uma descrição do problema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Coletar dados
            string prioridade = comboBox2.SelectedItem.ToString();
            string tipoChamado = comboBoxTipo.SelectedItem.ToString();
            string descricao = txtDescricao.Text.Trim();
            string status = "Aberto";
            DateTime dataCriacao = DateTime.Now;
            int usuarioId = _usuario.Id;

            try
            {
                TicketClienteDAL _ticketClienteDAL = new TicketClienteDAL();

                _ticketClienteDAL.CriarTicket(new Ticket
                {
                    Titulo = tipoChamado,
                    Prioridade = prioridade,
                    Status = status,
                    Descricao = descricao,
                    DataCriacao = dataCriacao,
                    UsuarioId = usuarioId

                });

                MessageBox.Show("Chamado enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                using (formChamados _formChamados = new formChamados(_usuario))
                {
                    _formChamados.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void pn_title_Paint(object sender, PaintEventArgs e){}

        private void pic_home_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            formChamados _formChamados = new formChamados(_usuario);
            _formChamados.FormClosed += (s, args) => Application.Exit();
            _formChamados.ShowDialog();
            this.Close();
            */
        }
    }
}
    

