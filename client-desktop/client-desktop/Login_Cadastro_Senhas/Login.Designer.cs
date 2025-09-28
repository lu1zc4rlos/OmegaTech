namespace client_desktop {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblTelaLogin = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtSenha = new System.Windows.Forms.TextBox();
            lblSenha = new System.Windows.Forms.Label();
            btnNaoCadastrado = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            cbMostarSenha = new System.Windows.Forms.CheckBox();
            btnRecuperrarSenha = new System.Windows.Forms.Button();
            pn_title = new System.Windows.Forms.Panel();
            lbl_titulo = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTelaLogin
            // 
            lblTelaLogin.AutoSize = true;
            lblTelaLogin.Location = new System.Drawing.Point(198, 68);
            lblTelaLogin.Name = "lblTelaLogin";
            lblTelaLogin.Size = new System.Drawing.Size(98, 20);
            lblTelaLogin.TabIndex = 0;
            lblTelaLogin.Text = "Tela de Login";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            lblEmail.ForeColor = System.Drawing.Color.White;
            lblEmail.Location = new System.Drawing.Point(302, 252);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(62, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            lblEmail.Click += lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtEmail.Location = new System.Drawing.Point(132, 106);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(286, 20);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSenha.Location = new System.Drawing.Point(358, 304);
            txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new System.Drawing.Size(154, 20);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            lblSenha.ForeColor = System.Drawing.Color.White;
            lblSenha.Location = new System.Drawing.Point(302, 304);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new System.Drawing.Size(61, 23);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            lblSenha.Click += lblSenha_Click;
            // 
            // btnNaoCadastrado
            // 
            btnNaoCadastrado.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            btnNaoCadastrado.FlatAppearance.BorderSize = 0;
            btnNaoCadastrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 67, 115);
            btnNaoCadastrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNaoCadastrado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnNaoCadastrado.ForeColor = System.Drawing.Color.White;
            btnNaoCadastrado.Location = new System.Drawing.Point(321, 312);
            btnNaoCadastrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNaoCadastrado.Name = "btnNaoCadastrado";
            btnNaoCadastrado.Size = new System.Drawing.Size(171, 43);
            btnNaoCadastrado.TabIndex = 5;
            btnNaoCadastrado.Text = "Realizar Cadastro";
            btnNaoCadastrado.UseVisualStyleBackColor = false;
            btnNaoCadastrado.Click += btnNaoCadastrado_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnConfirmar.ForeColor = System.Drawing.Color.White;
            btnConfirmar.Location = new System.Drawing.Point(449, 361);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(97, 40);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cbMostarSenha
            // 
            cbMostarSenha.AutoSize = true;
            cbMostarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            cbMostarSenha.ForeColor = System.Drawing.Color.White;
            cbMostarSenha.Location = new System.Drawing.Point(520, 303);
            cbMostarSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbMostarSenha.Name = "cbMostarSenha";
            cbMostarSenha.Size = new System.Drawing.Size(142, 27);
            cbMostarSenha.TabIndex = 2;
            cbMostarSenha.Text = "Mostrar senha";
            cbMostarSenha.UseVisualStyleBackColor = true;
            cbMostarSenha.CheckedChanged += cbMostarSenha_CheckedChanged;
            // 
            // btnRecuperrarSenha
            // 
            btnRecuperrarSenha.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            btnRecuperrarSenha.FlatAppearance.BorderSize = 0;
            btnRecuperrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 67, 115);
            btnRecuperrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRecuperrarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnRecuperrarSenha.ForeColor = System.Drawing.Color.White;
            btnRecuperrarSenha.Location = new System.Drawing.Point(28, 312);
            btnRecuperrarSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRecuperrarSenha.Name = "btnRecuperrarSenha";
            btnRecuperrarSenha.Size = new System.Drawing.Size(208, 43);
            btnRecuperrarSenha.TabIndex = 4;
            btnRecuperrarSenha.Text = "Recuperar senha";
            btnRecuperrarSenha.UseVisualStyleBackColor = false;
            btnRecuperrarSenha.Click += btnRecuperrarSenha_Click;
            // 
            // pn_title
            // 
            pn_title.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox1);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            pn_title.Location = new System.Drawing.Point(0, 0);
            pn_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new System.Drawing.Size(1000, 99);
            pn_title.TabIndex = 17;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            lbl_titulo.ForeColor = System.Drawing.Color.White;
            lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_titulo.Location = new System.Drawing.Point(449, 20);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(97, 37);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "LOGIN";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(38, 20);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(72, 65);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new System.Drawing.Point(861, 0);
            nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new System.Drawing.Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbl_omega.ForeColor = System.Drawing.Color.White;
            lbl_omega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_omega.Location = new System.Drawing.Point(430, 57);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(136, 31);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRecuperrarSenha);
            panel1.Controls.Add(btnNaoCadastrado);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new System.Drawing.Point(226, 149);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(554, 476);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            panel2.Location = new System.Drawing.Point(210, 135);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(586, 505);
            panel2.TabIndex = 19;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            ClientSize = new System.Drawing.Size(1000, 800);
            Controls.Add(pn_title);
            Controls.Add(cbMostarSenha);
            Controls.Add(btnConfirmar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblTelaLogin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FluxoCondicional";
            Load += Login_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelaLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnNaoCadastrado;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.CheckBox cbMostarSenha;
        private System.Windows.Forms.Button btnRecuperrarSenha;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}