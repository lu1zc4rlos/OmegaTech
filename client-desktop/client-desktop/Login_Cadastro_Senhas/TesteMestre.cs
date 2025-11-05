using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_desktop.Login_Cadastro_Senhas
{
    public partial class TesteMestre : Form
    {
        public TesteMestre()
        {
            InitializeComponent();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void crownMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void recuperarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecuperarSenha recuperarSenha = new RecuperarSenha();
            recuperarSenha.MdiParent = this;
            recuperarSenha.Show();
        }

        private void TesteMestre_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }



        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form formFilho in this.MdiChildren)
            {
                formFilho.Close();
            }

            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }
    }
}
