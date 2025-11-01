namespace client_desktop.Login_Cadastro_Senhas {
    partial class TrocarSenha {
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
            pictureBox2 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new Label();
            lblSenhaNovamente = new Label();
            lblSenhaNova = new Label();
            panel1 = new Panel();
            txtSenhaNova = new TextBox();
            btnConfirmar = new Button();
            txtSenhaNovamente = new TextBox();
            cbMostrarSenha = new CheckBox();
            panel2 = new Panel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(800, 112);
            pn_title.TabIndex = 20;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(285, 19);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(222, 37);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "ALTERAR SENHA";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(40, 19);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
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
            nightControlBox1.Location = new Point(661, 0);
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
            lbl_omega.Location = new Point(331, 56);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(119, 28);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // lblSenhaNovamente
            // 
            lblSenhaNovamente.AutoSize = true;
            lblSenhaNovamente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSenhaNovamente.ForeColor = Color.White;
            lblSenhaNovamente.Location = new Point(3, 130);
            lblSenhaNovamente.Name = "lblSenhaNovamente";
            lblSenhaNovamente.Size = new Size(215, 23);
            lblSenhaNovamente.TabIndex = 24;
            lblSenhaNovamente.Text = "Digite novamente a senha:";
            // 
            // lblSenhaNova
            // 
            lblSenhaNova.AutoSize = true;
            lblSenhaNova.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSenhaNova.ForeColor = Color.White;
            lblSenhaNova.Location = new Point(112, 247);
            lblSenhaNova.Name = "lblSenhaNova";
            lblSenhaNova.Size = new Size(166, 23);
            lblSenhaNova.TabIndex = 23;
            lblSenhaNova.Text = "Digite a senha nova:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSenhaNovamente);
            panel1.Controls.Add(txtSenhaNova);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtSenhaNovamente);
            panel1.Controls.Add(cbMostrarSenha);
            panel1.Location = new Point(88, 162);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 348);
            panel1.TabIndex = 25;
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.BorderStyle = BorderStyle.None;
            txtSenhaNova.Location = new Point(196, 88);
            txtSenhaNova.Margin = new Padding(3, 4, 3, 4);
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.PasswordChar = '*';
            txtSenhaNova.Size = new Size(271, 20);
            txtSenhaNova.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(40, 42, 90);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(254, 244);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(89, 37);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_ClickAsync;
            // 
            // txtSenhaNovamente
            // 
            txtSenhaNovamente.BorderStyle = BorderStyle.None;
            txtSenhaNovamente.Location = new Point(221, 133);
            txtSenhaNovamente.Margin = new Padding(3, 4, 3, 4);
            txtSenhaNovamente.Name = "txtSenhaNovamente";
            txtSenhaNovamente.PasswordChar = '*';
            txtSenhaNovamente.Size = new Size(233, 20);
            txtSenhaNovamente.TabIndex = 2;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cbMostrarSenha.ForeColor = Color.White;
            cbMostrarSenha.Location = new Point(460, 130);
            cbMostrarSenha.Margin = new Padding(3, 4, 3, 4);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new Size(142, 27);
            cbMostrarSenha.TabIndex = 1;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 42, 90);
            panel2.Location = new Point(73, 146);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 384);
            panel2.TabIndex = 26;
            // 
            // TrocarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(800, 569);
            Controls.Add(lblSenhaNova);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pn_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrocarSenha";
            Text = "Form1";
            Load += Form1_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_title;
        private Label lbl_titulo;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label lbl_omega;
        private Label lblSenhaNovamente;
        private Label lblSenhaNova;
        private Panel panel1;
        private TextBox txtSenhaNova;
        private Button btnConfirmar;
        private TextBox txtSenhaNovamente;
        private CheckBox cbMostrarSenha;
        private Panel panel2;
    }
}