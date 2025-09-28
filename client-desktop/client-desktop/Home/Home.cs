using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_desktop.Home
{
    //alteração para fazer commit
    public partial class Home : Form
    {
        //private Usuario _usuario;
        /*
        public Usuario _usuario { get; set; }   
        */
        public Home(/*Usuario usuario*/)
        {
            InitializeComponent();
            /*
            _usuario = usuario;
            */
        }

        //métodos

        //sidebar
        bool sideBarExpand = true;
        private void SideBarTransition_Tick(object sender, EventArgs e)
        {
            /*
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 70)
                {
                    sideBarExpand = false;
                    SideBarTransition.Stop();
                }
            }

            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 207)
                {
                    sideBarExpand = true;
                    SideBarTransition.Stop();
                }
            }
            */
        }
        private void btn_sidebar_Click(object sender, EventArgs e)
        {
            /*
                SideBarTransition.Start();
            */
        }
        //botões 
        private Button currentButton;
        private void btn_atual(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    Btn_normal();
                    Color color = Color.DimGray;
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.WhiteSmoke;
                    currentButton.Font =  new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }
        private void Btn_normal()
        {
            /*
            foreach(Control previousBtn in sideBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Black;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            */
        }

        //requisições de outros forms.

        formChamados Chamados;
        formOmegaHelp OmegaHelp;
        private void btn_chamados_Click(object sender, EventArgs e)
        {
            /*
            btn_atual(sender);
            if (Chamados == null)
            {
                this.Hide();
                Chamados = new formChamados(_usuario);
                Chamados.FormClosed += chamados_FormClosed;
                Chamados.FormClosed += (s, args) => Application.Exit();
                Chamados.ShowDialog();
                this.Close();
            }
            else
            {
                Chamados.Activate();
            }
            */
        }
        private void chamados_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            Chamados = null;
            */
        }

        private void btn_chatbot_Click(object sender, EventArgs e)
        {
            /*
            btn_atual(sender);
            if(OmegaHelp == null)
            {
                this.Hide();
                OmegaHelp = new formOmegaHelp(_usuario);
                OmegaHelp.FormClosed += OmegaHelp_FormClosed;
                OmegaHelp.FormClosed += (s, args) => Application.Exit();
                OmegaHelp.ShowDialog();
                this.Close();              
            }
            else
            {
                OmegaHelp.Activate();
            }
            */
        }
        private void OmegaHelp_FormClosed(Object sender, FormClosedEventArgs e)
        {
            /*
            OmegaHelp = null;
            */
        }
        private void Home_Load(object sender, EventArgs e) {}
    }
}
