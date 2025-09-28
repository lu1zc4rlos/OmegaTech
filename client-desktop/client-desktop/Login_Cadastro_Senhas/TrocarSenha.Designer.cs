namespace client_desktop {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocarSenha));
            lblErroSenha = new System.Windows.Forms.Label();
            txtSenhaNovamente = new System.Windows.Forms.TextBox();
            lblSenhaNovamente = new System.Windows.Forms.Label();
            txtSenhaNova = new System.Windows.Forms.TextBox();
            lblSenhaNova = new System.Windows.Forms.Label();
            cbMostrarSenha = new System.Windows.Forms.CheckBox();
            btnConfirmar = new System.Windows.Forms.Button();
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
            // lblErroSenha
            // 
            lblErroSenha.AutoSize = true;
            lblErroSenha.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            lblErroSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            lblErroSenha.ForeColor = System.Drawing.Color.White;
            lblErroSenha.Location = new System.Drawing.Point(226, 195);
            lblErroSenha.Name = "lblErroSenha";
            lblErroSenha.Size = new System.Drawing.Size(150, 23);
            lblErroSenha.TabIndex = 16;
            lblErroSenha.Text = "Senhas diferentes ";
            lblErroSenha.Click += label5_Click;
            // 
            // txtSenhaNovamente
            // 
            txtSenhaNovamente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSenhaNovamente.Location = new System.Drawing.Point(226, 133);
            txtSenhaNovamente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSenhaNovamente.Name = "txtSenhaNovamente";
            txtSenhaNovamente.PasswordChar = '*';
            txtSenhaNovamente.Size = new System.Drawing.Size(233, 20);
            txtSenhaNovamente.TabIndex = 2;
            txtSenhaNovamente.TextChanged += textBox3_TextChanged;
            // 
            // lblSenhaNovamente
            // 
            lblSenhaNovamente.AutoSize = true;
            lblSenhaNovamente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            lblSenhaNovamente.ForeColor = System.Drawing.Color.White;
            lblSenhaNovamente.Location = new System.Drawing.Point(95, 313);
            lblSenhaNovamente.Name = "lblSenhaNovamente";
            lblSenhaNovamente.Size = new System.Drawing.Size(215, 23);
            lblSenhaNovamente.TabIndex = 14;
            lblSenhaNovamente.Text = "Digite novamente a senha:";
            lblSenhaNovamente.Click += label3_Click;
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSenhaNova.Location = new System.Drawing.Point(196, 88);
            txtSenhaNova.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.PasswordChar = '*';
            txtSenhaNova.Size = new System.Drawing.Size(271, 20);
            txtSenhaNova.TabIndex = 0;
            txtSenhaNova.TextChanged += textBox2_TextChanged;
            // 
            // lblSenhaNova
            // 
            lblSenhaNova.AutoSize = true;
            lblSenhaNova.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            lblSenhaNova.ForeColor = System.Drawing.Color.White;
            lblSenhaNova.Location = new System.Drawing.Point(101, 268);
            lblSenhaNova.Name = "lblSenhaNova";
            lblSenhaNova.Size = new System.Drawing.Size(166, 23);
            lblSenhaNova.TabIndex = 12;
            lblSenhaNova.Text = "Digite a senha nova:";
            lblSenhaNova.Click += label2_Click;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            cbMostrarSenha.ForeColor = System.Drawing.Color.White;
            cbMostrarSenha.Location = new System.Drawing.Point(460, 130);
            cbMostrarSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new System.Drawing.Size(142, 27);
            cbMostrarSenha.TabIndex = 1;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnConfirmar.ForeColor = System.Drawing.Color.White;
            btnConfirmar.Location = new System.Drawing.Point(254, 244);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(89, 37);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
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
            pn_title.Size = new System.Drawing.Size(789, 112);
            pn_title.TabIndex = 19;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            lbl_titulo.ForeColor = System.Drawing.Color.White;
            lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_titulo.Location = new System.Drawing.Point(285, 19);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(222, 37);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "ALTERAR SENHA";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(40, 19);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(73, 65);
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
            nightControlBox1.Location = new System.Drawing.Point(630, 0);
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
            lbl_omega.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            lbl_omega.ForeColor = System.Drawing.Color.White;
            lbl_omega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_omega.Location = new System.Drawing.Point(331, 56);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(119, 28);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSenhaNova);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtSenhaNovamente);
            panel1.Controls.Add(lblErroSenha);
            panel1.Controls.Add(cbMostrarSenha);
            panel1.Location = new System.Drawing.Point(77, 183);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(599, 348);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            panel2.Location = new System.Drawing.Point(62, 167);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(631, 384);
            panel2.TabIndex = 22;
            // 
            // TrocarSenha
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            ClientSize = new System.Drawing.Size(789, 667);
            Controls.Add(pn_title);
            Controls.Add(lblSenhaNovamente);
            Controls.Add(lblSenhaNova);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "TrocarSenha";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TrocarSenha";
            Load += TrocarSenha_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErroSenha;
        private System.Windows.Forms.TextBox txtSenhaNovamente;
        private System.Windows.Forms.Label lblSenhaNovamente;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label lblSenhaNova;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}