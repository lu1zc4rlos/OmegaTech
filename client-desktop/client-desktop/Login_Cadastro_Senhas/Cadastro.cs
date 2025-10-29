using model;
using service;
using System.Globalization;
using System.Runtime.Serialization;

namespace client_desktop {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }
        private void InitializeComponent() {
            txtEmail = new TextBox();
            btnConfirmar = new Button();
            lblEmailCadastrado = new Label();
            cbMostrarSenha = new CheckBox();
            txtSenha = new TextBox();
            lblSenhaDiferente = new Label();
            btnVoltarLogin = new Button();
            txtConfirmarSenha = new TextBox();
            pn_title = new Panel();
            lbl_titulo = new Label();
            pictureBox2 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            lblNome = new Label();
            lblConfirmarSenha = new Label();
            lblSenha = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblDataNascimento = new Label();
            atpDataNascimento = new DateTimePicker();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(179, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 20);
            txtEmail.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(60, 62, 110);
            btnConfirmar.FlatAppearance.BorderColor = Color.White;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(79, 369);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 30);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
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
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Dock = DockStyle.Right;
            cbMostrarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMostrarSenha.ForeColor = Color.White;
            cbMostrarSenha.Location = new Point(201, 0);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new Size(142, 59);
            cbMostrarSenha.TabIndex = 4;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(3, 19);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(192, 20);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += textBox2_TextChanged;
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
            btnVoltarLogin.Anchor = AnchorStyles.Right;
            btnVoltarLogin.BackColor = Color.FromArgb(60, 62, 110);
            btnVoltarLogin.FlatAppearance.BorderSize = 0;
            btnVoltarLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnVoltarLogin.FlatStyle = FlatStyle.Flat;
            btnVoltarLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnVoltarLogin.ForeColor = Color.White;
            btnVoltarLogin.Location = new Point(306, 369);
            btnVoltarLogin.Name = "btnVoltarLogin";
            btnVoltarLogin.Size = new Size(210, 30);
            btnVoltarLogin.TabIndex = 7;
            btnVoltarLogin.Text = "Voltar para tela de login";
            btnVoltarLogin.UseVisualStyleBackColor = false;
            btnVoltarLogin.Click += button2_Click;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Anchor = AnchorStyles.Left;
            txtConfirmarSenha.BorderStyle = BorderStyle.None;
            txtConfirmarSenha.Location = new Point(179, 255);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(192, 20);
            txtConfirmarSenha.TabIndex = 5;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox1);
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
            lbl_titulo.Location = new Point(366, 14);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(156, 37);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "CADASTRO";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
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
            lbl_omega.Location = new Point(87, 23);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(119, 28);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            lbl_omega.Click += lbl_omega_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 42, 90);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(178, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 414);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 1, 3);
            tableLayoutPanel2.Controls.Add(lblNome, 0, 0);
            tableLayoutPanel2.Controls.Add(btnVoltarLogin, 1, 6);
            tableLayoutPanel2.Controls.Add(btnConfirmar, 0, 6);
            tableLayoutPanel2.Controls.Add(lblConfirmarSenha, 0, 4);
            tableLayoutPanel2.Controls.Add(lblSenha, 0, 3);
            tableLayoutPanel2.Controls.Add(txtConfirmarSenha, 1, 4);
            tableLayoutPanel2.Controls.Add(lblEmail, 0, 2);
            tableLayoutPanel2.Controls.Add(txtNome, 1, 0);
            tableLayoutPanel2.Controls.Add(lblDataNascimento, 0, 1);
            tableLayoutPanel2.Controls.Add(atpDataNascimento, 1, 1);
            tableLayoutPanel2.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.Size = new Size(519, 414);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSenha);
            panel3.Controls.Add(cbMostrarSenha);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(176, 177);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 59);
            panel3.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.FromArgb(40, 42, 90);
            lblNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(112, 18);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 23);
            lblNome.TabIndex = 19;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Anchor = AnchorStyles.Right;
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.BackColor = Color.FromArgb(40, 42, 90);
            lblConfirmarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmarSenha.ForeColor = Color.White;
            lblConfirmarSenha.Location = new Point(27, 254);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(146, 23);
            lblConfirmarSenha.TabIndex = 19;
            lblConfirmarSenha.Text = "Confirmar senha: ";
            lblConfirmarSenha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.FromArgb(40, 42, 90);
            lblSenha.Dock = DockStyle.Right;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(112, 177);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(61, 59);
            lblSenha.TabIndex = 19;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(40, 42, 90);
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(118, 136);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Left;
            txtNome.BackColor = SystemColors.Window;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(179, 19);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(320, 20);
            txtNome.TabIndex = 19;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Anchor = AnchorStyles.Right;
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.FromArgb(40, 42, 90);
            lblDataNascimento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataNascimento.ForeColor = Color.White;
            lblDataNascimento.Location = new Point(3, 77);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(170, 23);
            lblDataNascimento.TabIndex = 19;
            lblDataNascimento.Text = "Data de Nascimento:";
            lblDataNascimento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // atpDataNascimento
            // 
            atpDataNascimento.Anchor = AnchorStyles.Left;
            atpDataNascimento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atpDataNascimento.Location = new Point(179, 74);
            atpDataNascimento.Name = "atpDataNascimento";
            atpDataNascimento.RightToLeft = RightToLeft.No;
            atpDataNascimento.Size = new Size(132, 29);
            atpDataNascimento.TabIndex = 19;
            atpDataNascimento.ValueChanged += atpDataNascimento_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 62, 110);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 600);
            panel2.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(875, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Cadastro
            // 
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(875, 600);
            Controls.Add(pn_title);
            Controls.Add(lblSenhaDiferente);
            Controls.Add(lblEmailCadastrado);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Cadastro_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        private async void btnConfirmar_Click(object sender, EventArgs e) {

            try {
               
                lblSenhaDiferente.Visible = false;

                if (txtSenha.Text != txtConfirmarSenha.Text) {
                    lblSenhaDiferente.Text = "As senhas não coincidem.";
                    lblSenhaDiferente.ForeColor = Color.Red;
                    lblSenhaDiferente.Visible = true;
                    return;
                }
                ValidacaoService.validacaoService(
                   txtNome.Text,
                   txtSenha.Text,
                   txtEmail.Text,
                   atpDataNascimento.Value,
                   txtConfirmarSenha.Text
                );
                
                var usuario = new Usuario() {
                    Nome = txtNome.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Senha = txtSenha.Text.Trim(),
                    DataNascimento = atpDataNascimento.Value,
                    Perfil = Perfil.ROLE_CLIENTE,
                    TecnicoProfile = null
                };

                var authService = new AuthService();
                var response = await authService.CadastroAsync(usuario);

                if (response == null || string.IsNullOrEmpty(response.Token)) {
                    throw new Exception("Falha ao registrar. A API não retornou um token.");
                }

                MessageBox.Show("Usuário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                this.Hide();
                using (Home.Home homeForm = new Home.Home(response.Username)) {
                    homeForm.ShowDialog();
                }
                this.Show();
                LimparCampos();
            }
            catch (Exception ex){

                MessageBox.Show("Ocorreu um erro no cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void button2_Click(object sender, EventArgs e) {

            this.Close();
            this.Hide();
            using (Login login = new Login()) {
                login.ShowDialog();
            }
            this.Show();
            LimparCampos();

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
        private void LimparCampos() {

            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            cbMostrarSenha.Checked = false;
        }
        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void atpDataNascimento_ValueChanged(object sender, EventArgs e) { }
        private void lbl_omega_Click(object sender, EventArgs e) { }
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
