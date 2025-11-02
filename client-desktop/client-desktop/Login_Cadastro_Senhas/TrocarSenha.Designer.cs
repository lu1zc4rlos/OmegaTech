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
        private void InitializeComponent()
        {
            pn_title = new Panel();
            lbl_titulo = new Label();
            pictureBox2 = new PictureBox();
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
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(700, 84);
            pn_title.TabIndex = 20;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(249, 14);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(181, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "ALTERAR SENHA";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(35, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(105, 33);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(96, 21);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // lblSenhaNovamente
            // 
            lblSenhaNovamente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSenhaNovamente.AutoSize = true;
            lblSenhaNovamente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSenhaNovamente.ForeColor = Color.White;
            lblSenhaNovamente.Location = new Point(3, 98);
            lblSenhaNovamente.Name = "lblSenhaNovamente";
            lblSenhaNovamente.Size = new Size(170, 17);
            lblSenhaNovamente.TabIndex = 24;
            lblSenhaNovamente.Text = "Digite novamente a senha:";
            // 
            // lblSenhaNova
            // 
            lblSenhaNova.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSenhaNova.AutoSize = true;
            lblSenhaNova.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSenhaNova.ForeColor = Color.White;
            lblSenhaNova.Location = new Point(98, 185);
            lblSenhaNova.Name = "lblSenhaNova";
            lblSenhaNova.Size = new Size(131, 17);
            lblSenhaNova.TabIndex = 23;
            lblSenhaNova.Text = "Digite a senha nova:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblSenhaNovamente);
            panel1.Controls.Add(txtSenhaNova);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtSenhaNovamente);
            panel1.Controls.Add(cbMostrarSenha);
            panel1.Location = new Point(77, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 261);
            panel1.TabIndex = 25;
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenhaNova.BorderStyle = BorderStyle.None;
            txtSenhaNova.Location = new Point(172, 66);
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.PasswordChar = '*';
            txtSenhaNova.Size = new Size(237, 16);
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
            btnConfirmar.Location = new Point(222, 183);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(78, 28);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_ClickAsync;
            // 
            // txtSenhaNovamente
            // 
            txtSenhaNovamente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenhaNovamente.BorderStyle = BorderStyle.None;
            txtSenhaNovamente.Location = new Point(193, 100);
            txtSenhaNovamente.Name = "txtSenhaNovamente";
            txtSenhaNovamente.PasswordChar = '*';
            txtSenhaNovamente.Size = new Size(204, 16);
            txtSenhaNovamente.TabIndex = 2;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cbMostrarSenha.ForeColor = Color.White;
            cbMostrarSenha.Location = new Point(402, 98);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new Size(115, 21);
            cbMostrarSenha.TabIndex = 1;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(40, 42, 90);
            panel2.Location = new Point(64, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 288);
            panel2.TabIndex = 26;
            // 
            // TrocarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(700, 427);
            Controls.Add(lblSenhaNova);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pn_title);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TrocarSenha";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
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