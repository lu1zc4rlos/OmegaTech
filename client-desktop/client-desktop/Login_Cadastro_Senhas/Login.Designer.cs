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
        private void InitializeComponent() {
            pn_title = new Panel();
            lbl_titulo = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            btnNaoCadastrado = new Button();
            cbMostarSenha = new CheckBox();
            lblEmail = new Label();
            lblSenha = new Label();
            btnConfirmar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            btnRecuperrarSenha = new Button();
            pn_title.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(nightControlBox1);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1000, 74);
            pn_title.TabIndex = 17;
            pn_title.Paint += pn_title_Paint;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(449, 22);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(97, 37);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "LOGIN";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
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
            nightControlBox1.Location = new Point(861, 0);
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
            lbl_omega.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(81, 22);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(136, 31);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.Transparent;
            tableLayoutPanel1.Location = new Point(0, 74);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1000, 726);
            tableLayoutPanel1.TabIndex = 20;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 42, 90);
            panel2.Controls.Add(btnNaoCadastrado);
            panel2.Controls.Add(cbMostarSenha);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblSenha);
            panel2.Controls.Add(btnConfirmar);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(btnRecuperrarSenha);
            panel2.Location = new Point(81, 115);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(837, 496);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // btnNaoCadastrado
            // 
            btnNaoCadastrado.BackColor = Color.FromArgb(60, 62, 110);
            btnNaoCadastrado.FlatAppearance.BorderSize = 0;
            btnNaoCadastrado.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnNaoCadastrado.FlatStyle = FlatStyle.Flat;
            btnNaoCadastrado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnNaoCadastrado.ForeColor = Color.White;
            btnNaoCadastrado.Location = new Point(645, 433);
            btnNaoCadastrado.Margin = new Padding(3, 4, 3, 4);
            btnNaoCadastrado.Name = "btnNaoCadastrado";
            btnNaoCadastrado.Size = new Size(171, 43);
            btnNaoCadastrado.TabIndex = 5;
            btnNaoCadastrado.Text = "Realizar Cadastro";
            btnNaoCadastrado.UseVisualStyleBackColor = false;
            btnNaoCadastrado.Click += btnNaoCadastrado_Click;
            // 
            // cbMostarSenha
            // 
            cbMostarSenha.AutoSize = true;
            cbMostarSenha.BackColor = Color.FromArgb(40, 42, 90);
            cbMostarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cbMostarSenha.ForeColor = Color.White;
            cbMostarSenha.Location = new Point(514, 190);
            cbMostarSenha.Margin = new Padding(3, 4, 3, 4);
            cbMostarSenha.Name = "cbMostarSenha";
            cbMostarSenha.Size = new Size(142, 27);
            cbMostarSenha.TabIndex = 2;
            cbMostarSenha.Text = "Mostrar senha";
            cbMostarSenha.UseVisualStyleBackColor = false;
            cbMostarSenha.CheckedChanged += cbMostarSenha_CheckedChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(40, 42, 90);
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(122, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.FromArgb(40, 42, 90);
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(123, 194);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(61, 23);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            lblSenha.Click += lblSenha_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(60, 62, 110);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(368, 354);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(97, 40);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(190, 193);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(306, 20);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(190, 135);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(496, 20);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnRecuperrarSenha
            // 
            btnRecuperrarSenha.BackColor = Color.FromArgb(60, 62, 110);
            btnRecuperrarSenha.FlatAppearance.BorderSize = 0;
            btnRecuperrarSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnRecuperrarSenha.FlatStyle = FlatStyle.Flat;
            btnRecuperrarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRecuperrarSenha.ForeColor = Color.White;
            btnRecuperrarSenha.Location = new Point(19, 433);
            btnRecuperrarSenha.Margin = new Padding(3, 4, 3, 4);
            btnRecuperrarSenha.Name = "btnRecuperrarSenha";
            btnRecuperrarSenha.Size = new Size(208, 43);
            btnRecuperrarSenha.TabIndex = 4;
            btnRecuperrarSenha.Text = "Recuperar senha";
            btnRecuperrarSenha.UseVisualStyleBackColor = false;
            btnRecuperrarSenha.Click += btnRecuperrarSenha_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(1000, 800);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pn_title);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FluxoCondicional";
            Load += Login_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label lbl_omega;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button btnNaoCadastrado;
        private CheckBox cbMostarSenha;
        private Label lblEmail;
        private Label lblSenha;
        private Button btnConfirmar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnRecuperrarSenha;
    }
}