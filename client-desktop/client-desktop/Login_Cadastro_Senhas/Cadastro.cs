using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Forms;


namespace client_desktop {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            lblNome = new Label();
            txtNome = new TextBox();
            lblDataNascimento = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblConfirmarSenha = new Label();
            btnConfirmar = new Button();
            lblEmailCadastrado = new Label();
            atpDataNascimento = new DateTimePicker();
            cbMostrarSenha = new CheckBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblSenhaDiferente = new Label();
            btnVoltarLogin = new Button();
            txtConfirmarSenha = new TextBox();
            pn_title = new Panel();
            lbl_titulo = new Label();
            pictureBox2 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(265, 142);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(329, 144);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(300, 20);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataNascimento.ForeColor = Color.White;
            lblDataNascimento.Location = new Point(329, 183);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(170, 23);
            lblDataNascimento.TabIndex = 2;
            lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(125, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 20);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(265, 214);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmarSenha.ForeColor = Color.White;
            lblConfirmarSenha.Location = new Point(217, 290);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(146, 23);
            lblConfirmarSenha.TabIndex = 6;
            lblConfirmarSenha.Text = "Confirmar senha: ";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(40, 42, 90);
            btnConfirmar.FlatAppearance.BorderColor = Color.White;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(48, 268);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 30);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblEmailCadastrado
            // 
            lblEmailCadastrado.AutoSize = true;
            lblEmailCadastrado.BackColor = Color.Transparent;
            lblEmailCadastrado.ForeColor = Color.Red;
            lblEmailCadastrado.Location = new Point(427, 237);
            lblEmailCadastrado.Name = "lblEmailCadastrado";
            lblEmailCadastrado.Size = new Size(0, 20);
            lblEmailCadastrado.TabIndex = 10;
            lblEmailCadastrado.Click += label6_Click;
            // 
            // atpDataNascimento
            // 
            atpDataNascimento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atpDataNascimento.Location = new Point(507, 178);
            atpDataNascimento.Name = "atpDataNascimento";
            atpDataNascimento.RightToLeft = RightToLeft.No;
            atpDataNascimento.Size = new Size(132, 29);
            atpDataNascimento.TabIndex = 1;
            atpDataNascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMostrarSenha.ForeColor = Color.White;
            cbMostrarSenha.Location = new Point(303, 135);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new Size(142, 27);
            cbMostrarSenha.TabIndex = 4;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(128, 135);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(155, 20);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(265, 251);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(61, 23);
            lblSenha.TabIndex = 13;
            lblSenha.Text = "Senha:";
            // 
            // lblSenhaDiferente
            // 
            lblSenhaDiferente.AutoSize = true;
            lblSenhaDiferente.Location = new Point(411, 320);
            lblSenhaDiferente.Name = "lblSenhaDiferente";
            lblSenhaDiferente.Size = new Size(0, 20);
            lblSenhaDiferente.TabIndex = 15;
            // 
            // btnVoltarLogin
            // 
            btnVoltarLogin.BackColor = Color.FromArgb(40, 42, 90);
            btnVoltarLogin.FlatAppearance.BorderSize = 0;
            btnVoltarLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnVoltarLogin.FlatStyle = FlatStyle.Flat;
            btnVoltarLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnVoltarLogin.ForeColor = Color.White;
            btnVoltarLogin.Location = new Point(235, 268);
            btnVoltarLogin.Name = "btnVoltarLogin";
            btnVoltarLogin.Size = new Size(210, 30);
            btnVoltarLogin.TabIndex = 7;
            btnVoltarLogin.Text = "Voltar para tela de login";
            btnVoltarLogin.UseVisualStyleBackColor = false;
            btnVoltarLogin.Click += button2_Click;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BorderStyle = BorderStyle.None;
            txtConfirmarSenha.Location = new Point(158, 174);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(155, 20);
            txtConfirmarSenha.TabIndex = 5;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
           // pn_title.Controls.Add(nightControlBox1);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(875, 74);
            pn_title.TabIndex = 16;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.None;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(366, 21);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(156, 37);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "CADASTRO";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(31, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(736, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(87, 28);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(119, 28);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(btnVoltarLogin);
            panel1.Controls.Add(txtConfirmarSenha);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(cbMostrarSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(206, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 357);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 42, 90);
            panel2.Location = new Point(193, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 380);
            panel2.TabIndex = 18;
            // 
            // Cadastro
            // 
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(875, 600);
            Controls.Add(pn_title);
            Controls.Add(lblSenhaDiferente);
            Controls.Add(lblSenha);
            Controls.Add(atpDataNascimento);
            Controls.Add(lblEmailCadastrado);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblDataNascimento);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Cadastro_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
/*
        private UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private RecuperarSenhaBLL _requisitosSenhaBLL = new RecuperarSenhaBLL ();
        LoginBLL loginBLL = new LoginBLL();
*/
        private void btnConfirmar_Click(object sender, EventArgs e) {
/*
            DateTime Data = atpDataNascimento.Value.Date;

            Usuario novoUsuario = new Usuario() {
                Nome = txtNome.Text,
                Data_Nascimento = Data,
                Email = txtEmail.Text.Trim(),
                Senha = txtConfirmarSenha.Text,
            };

            lblEmailCadastrado.Visible = false;
            lblSenhaDiferente.Visible = false;

            if (string.IsNullOrWhiteSpace(novoUsuario.Nome) ||
                string.IsNullOrWhiteSpace(novoUsuario.Email) ||
                string.IsNullOrWhiteSpace(novoUsuario.Senha) ||
                string.IsNullOrWhiteSpace(txtConfirmarSenha.Text)) {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_requisitosSenhaBLL.ValidarSenha(txtConfirmarSenha.Text)) {
                MessageBox.Show("Senha inválida! A senha deve ter:\n- Pelo menos 8 caracteres" +
                "\n- Uma letra maiúscula\n- Um número\n- Um caractere especial.");
                return;
            }
            if (txtSenha.Text != txtConfirmarSenha.Text) {
                lblSenhaDiferente.Text = "As senhas não coincidem.";
                lblSenhaDiferente.ForeColor = Color.Red;
                lblSenhaDiferente.Visible = true;
                return;
            }
            try {

                if (_usuarioBLL.EmailJaCadastrado(novoUsuario)) {
                    lblEmailCadastrado.Text = "Email já cadastrado";
                    lblEmailCadastrado.ForeColor = Color.Red;
                    lblEmailCadastrado.Visible = true;
                    return;
                }

                _usuarioBLL.AdicionarUsuario(novoUsuario);

                if (!EmailBLL.EmailValido(novoUsuario.Email)) {
                    MessageBox.Show("E-mail inválido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                EmailBLL.EnviarEmailBLL("Olá, " + novoUsuario.Nome + "\r\n\r\n" +
                    "Seja bem-vindo ao AtendeTech, o seu novo assistente virtual de ajuda e suporte técnico.\r\n\r\n" +
                    "Estamos muito contentes em tê-lo como usuário da nossa plataforma. O AtendeTech foi desenvolvido para tornar seu atendimento mais rápido, eficiente e acessível, sempre que você precisar de suporte técnico.\r\n\r\n" +
                    "Com o AtendeTech, você pode:\r\n\r\nObter respostas para dúvidas técnicas com agilidade\r\n\r\nReceber instruções passo a passo para resolver problemas\r\n\r\nAcessar suporte a qualquer hora, de forma simples e intuitiva\r\n\r\n" +
                    "Contar com um serviço confiável e sempre disponível\r\n\r\nSe tiver qualquer dúvida ou sugestão, nossa equipe está à disposição para ajudá-lo.\r\n\r\nAtenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
                    novoUsuario.Email,
                    "Sua conta foi criada com sucesso - seja bem-vindo(a)!",
                    btnConfirmar
                );

                MessageBox.Show("Usuário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Usuario usuario = loginBLL.ObterUsuarioPorEmail(novoUsuario.Email);
                Projeto_teste.Home.Home home = new Projeto_teste.Home.Home(usuario);
                home.ShowDialog();
                this.Close();
            }
            catch(Exception ex){

                MessageBox.Show("Ocorreu um erro ao adicionar o usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
*/
        }

        private void button2_Click(object sender, EventArgs e) {
/*
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
*/
        }
        private void Cadastro_Load(object sender, EventArgs e) {
            CultureInfo culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            atpDataNascimento.Format = DateTimePickerFormat.Custom;
            atpDataNascimento.CustomFormat = "dd/MM/yyyy";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

            atpDataNascimento.MaxDate = DateTime.Today;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            txtConfirmarSenha.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenha.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
        }
        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void label6_Click(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void textBox4_TextChanged(object sender, EventArgs e) {}
    }

    [Serializable]
    internal class FormaException : Exception {
        public FormaException() {
        }
        public FormaException(string message) : base(message) {
        }
        public FormaException(string message, Exception innerException) : base(message, innerException) {
        }
        protected FormaException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
