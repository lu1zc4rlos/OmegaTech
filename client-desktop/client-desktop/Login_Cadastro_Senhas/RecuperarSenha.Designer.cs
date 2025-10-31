﻿namespace client_desktop {
    partial class RecuperarSenha {
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
            lblSenhaAtual = new Label();
            txtSenhaAtual = new TextBox();
            txtSenhaNova = new TextBox();
            lblSenhaNova = new Label();
            txtSenhaNovamente = new TextBox();
            lblSenhaNovamente = new Label();
            btnConfirmar = new Button();
            btnOutraForma = new Button();
            cbMostrarSenha = new CheckBox();
            txtEmail = new TextBox();
            lblEamail = new Label();
            label5 = new Label();
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
            // lblSenhaAtual
            // 
            lblSenhaAtual.AutoSize = true;
            lblSenhaAtual.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSenhaAtual.ForeColor = Color.White;
            lblSenhaAtual.Location = new Point(237, 239);
            lblSenhaAtual.Name = "lblSenhaAtual";
            lblSenhaAtual.Size = new Size(166, 23);
            lblSenhaAtual.TabIndex = 0;
            lblSenhaAtual.Text = "Digite a senha atual:";
            lblSenhaAtual.Click += label1_Click;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.BorderStyle = BorderStyle.None;
            txtSenhaAtual.Location = new Point(205, 106);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.PasswordChar = '*';
            txtSenhaAtual.Size = new Size(272, 22);
            txtSenhaAtual.TabIndex = 1;
            txtSenhaAtual.TextChanged += textBox1_TextChanged;
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.BorderStyle = BorderStyle.None;
            txtSenhaNova.Location = new Point(205, 142);
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.PasswordChar = '*';
            txtSenhaNova.Size = new Size(272, 22);
            txtSenhaNova.TabIndex = 2;
            txtSenhaNova.TextChanged += txtSenhaNova_TextChanged;
            // 
            // lblSenhaNova
            // 
            lblSenhaNova.AutoSize = true;
            lblSenhaNova.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSenhaNova.ForeColor = Color.White;
            lblSenhaNova.Location = new Point(237, 276);
            lblSenhaNova.Name = "lblSenhaNova";
            lblSenhaNova.Size = new Size(166, 23);
            lblSenhaNova.TabIndex = 2;
            lblSenhaNova.Text = "Digite a senha nova:";
            // 
            // txtSenhaNovamente
            // 
            txtSenhaNovamente.BorderStyle = BorderStyle.None;
            txtSenhaNovamente.Location = new Point(244, 185);
            txtSenhaNovamente.Name = "txtSenhaNovamente";
            txtSenhaNovamente.PasswordChar = '*';
            txtSenhaNovamente.Size = new Size(233, 22);
            txtSenhaNovamente.TabIndex = 3;
            txtSenhaNovamente.TextChanged += textBox3_TextChanged;
            // 
            // lblSenhaNovamente
            // 
            lblSenhaNovamente.AutoSize = true;
            lblSenhaNovamente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhaNovamente.ForeColor = Color.White;
            lblSenhaNovamente.Location = new Point(237, 314);
            lblSenhaNovamente.Name = "lblSenhaNovamente";
            lblSenhaNovamente.Size = new Size(215, 23);
            lblSenhaNovamente.TabIndex = 4;
            lblSenhaNovamente.Text = "Digite novamente a senha:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(40, 42, 90);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(41, 276);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(110, 33);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
            // 
            // btnOutraForma
            // 
            btnOutraForma.BackColor = Color.FromArgb(40, 42, 90);
            btnOutraForma.FlatAppearance.BorderSize = 0;
            btnOutraForma.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnOutraForma.FlatStyle = FlatStyle.Flat;
            btnOutraForma.ForeColor = Color.White;
            btnOutraForma.Location = new Point(475, 410);
            btnOutraForma.Name = "btnOutraForma";
            btnOutraForma.Size = new Size(196, 33);
            btnOutraForma.TabIndex = 6;
            btnOutraForma.Text = "Tentar de outra forma";
            btnOutraForma.UseVisualStyleBackColor = false;
            btnOutraForma.Click += button2_Click;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cbMostrarSenha.ForeColor = Color.White;
            cbMostrarSenha.Location = new Point(317, 233);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new Size(149, 27);
            cbMostrarSenha.TabIndex = 4;
            cbMostrarSenha.Text = "Mostrar senhas";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(228, 62);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 22);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // lblEamail
            // 
            lblEamail.AutoSize = true;
            lblEamail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEamail.ForeColor = Color.White;
            lblEamail.Location = new Point(237, 196);
            lblEamail.Name = "lblEamail";
            lblEamail.Size = new Size(198, 23);
            lblEamail.TabIndex = 9;
            lblEamail.Text = "Digite e-mail do usuário:";
            lblEamail.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 318);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 11;
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
            pn_title.Size = new Size(899, 84);
            pn_title.TabIndex = 18;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(355, 27);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(216, 37);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "TROCAR SENHA";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(35, 14);
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
            nightControlBox1.Location = new Point(760, 0);
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
            lbl_omega.Location = new Point(114, 27);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(119, 28);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtSenhaNovamente);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(cbMostrarSenha);
            panel1.Controls.Add(txtSenhaNova);
            panel1.Controls.Add(txtSenhaAtual);
            panel1.Location = new Point(205, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 357);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 42, 90);
            panel2.Location = new Point(194, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 386);
            panel2.TabIndex = 20;
            // 
            // RecuperarSenha
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(899, 600);
            Controls.Add(pn_title);
            Controls.Add(label5);
            Controls.Add(lblEamail);
            Controls.Add(btnOutraForma);
            Controls.Add(lblSenhaNovamente);
            Controls.Add(lblSenhaNova);
            Controls.Add(lblSenhaAtual);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecuperarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecuperarSenha";
            Load += RecuperarSenha_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label lblSenhaNova;
        private System.Windows.Forms.TextBox txtSenhaNovamente;
        private System.Windows.Forms.Label lblSenhaNovamente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnOutraForma;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEamail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}