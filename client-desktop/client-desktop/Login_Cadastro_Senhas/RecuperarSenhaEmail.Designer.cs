namespace client_desktop.Login_Cadastro_Senhas {
    partial class RecuperarSenhaEmail {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pn_title = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_titulo = new Label();
            pictureBox2 = new PictureBox();
            lbl_omega = new Label();
            txtCodigo = new TextBox();
            btnConfirmar = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblCodigo = new Label();
            btnEnviarCodigo = new Button();
            panel1 = new Panel();
            btnTrocarSenha = new Button();
            panel2 = new Panel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(nightControlBox1);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(700, 84);
            pn_title.TabIndex = 20;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(561, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 4;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(199, 17);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(273, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "CÓDIGO DE VERIFICAÇÃO";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(22, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lbl_omega
            // 
            lbl_omega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_omega.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(93, 35);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(96, 21);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Location = new Point(280, 244);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(160, 16);
            txtCodigo.TabIndex = 25;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.None;
            btnConfirmar.BackColor = Color.FromArgb(40, 42, 90);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(314, 265);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(82, 27);
            btnConfirmar.TabIndex = 26;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click_1Async;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(280, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 16);
            txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(228, 175);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 17);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "E-mail:";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(228, 242);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(54, 17);
            lblCodigo.TabIndex = 23;
            lblCodigo.Text = "Código:";
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Anchor = AnchorStyles.None;
            btnEnviarCodigo.BackColor = Color.FromArgb(40, 42, 90);
            btnEnviarCodigo.FlatAppearance.BorderSize = 0;
            btnEnviarCodigo.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnEnviarCodigo.FlatStyle = FlatStyle.Flat;
            btnEnviarCodigo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEnviarCodigo.ForeColor = Color.White;
            btnEnviarCodigo.Location = new Point(308, 197);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(94, 27);
            btnEnviarCodigo.TabIndex = 24;
            btnEnviarCodigo.Text = "&Enviar código";
            btnEnviarCodigo.UseVisualStyleBackColor = false;
            btnEnviarCodigo.Click += btnEnviarCodigo_ClickAsync;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnTrocarSenha);
            panel1.Location = new Point(159, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 261);
            panel1.TabIndex = 28;
            // 
            // btnTrocarSenha
            // 
            btnTrocarSenha.Anchor = AnchorStyles.None;
            btnTrocarSenha.BackColor = Color.FromArgb(40, 42, 90);
            btnTrocarSenha.FlatAppearance.BorderSize = 0;
            btnTrocarSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnTrocarSenha.FlatStyle = FlatStyle.Flat;
            btnTrocarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnTrocarSenha.ForeColor = Color.White;
            btnTrocarSenha.Location = new Point(135, 208);
            btnTrocarSenha.Name = "btnTrocarSenha";
            btnTrocarSenha.Size = new Size(127, 31);
            btnTrocarSenha.TabIndex = 4;
            btnTrocarSenha.Text = "&Trocar Senha";
            btnTrocarSenha.UseVisualStyleBackColor = false;
            btnTrocarSenha.Click += btnTrocarSenha_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(40, 42, 90);
            panel2.Location = new Point(146, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 288);
            panel2.TabIndex = 29;
            // 
            // RecuperarSenhaEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(700, 471);
            Controls.Add(txtCodigo);
            Controls.Add(btnConfirmar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblCodigo);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pn_title);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RecuperarSenhaEmail";
            Text = "Form1";
            Load += Form1_Load;
            pn_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_title;
        private Label lbl_titulo;
        private PictureBox pictureBox2;
        private Label lbl_omega;
        private TextBox txtCodigo;
        private Button btnConfirmar;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblCodigo;
        private Button btnEnviarCodigo;
        private Panel panel1;
        private Button btnTrocarSenha;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}