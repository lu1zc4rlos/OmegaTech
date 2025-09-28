namespace client_desktop.Home {
    partial class formAbrirChamado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbrirChamado));
            comboBoxTipo = new System.Windows.Forms.ComboBox();
            txtDescricao = new System.Windows.Forms.TextBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            lblTipoOcorencia = new System.Windows.Forms.Label();
            lblPrioridade = new System.Windows.Forms.Label();
            lblMensagem = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            pn_title = new System.Windows.Forms.Panel();
            pic_home = new System.Windows.Forms.PictureBox();
            lbl_titulo = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new System.Windows.Forms.Label();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Internet Lenta", "Sem Conexão", "Impressora Off", "Problema Login", "Trocar Senha", "Vírus no PC", "Atualizar App", "Instalar Driver", "PC Travando", "Tela Azul", "Sem Áudio", "Sem Vídeo", "Erro Sistema", "Backup Falhou", "Email Não Envia" });
            comboBoxTipo.Location = new System.Drawing.Point(218, 138);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new System.Drawing.Size(151, 28);
            comboBoxTipo.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new System.Drawing.Point(71, 304);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new System.Drawing.Size(807, 288);
            txtDescricao.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Baixa", "Média", "Alta" });
            comboBox2.Location = new System.Drawing.Point(218, 198);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(151, 28);
            comboBox2.TabIndex = 2;
            // 
            // lblTipoOcorencia
            // 
            lblTipoOcorencia.AutoSize = true;
            lblTipoOcorencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTipoOcorencia.ForeColor = System.Drawing.Color.White;
            lblTipoOcorencia.Location = new System.Drawing.Point(74, 141);
            lblTipoOcorencia.Name = "lblTipoOcorencia";
            lblTipoOcorencia.Size = new System.Drawing.Size(141, 20);
            lblTipoOcorencia.TabIndex = 3;
            lblTipoOcorencia.Text = "Tipo da ocorrência:";
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblPrioridade.ForeColor = System.Drawing.Color.White;
            lblPrioridade.Location = new System.Drawing.Point(74, 198);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new System.Drawing.Size(143, 20);
            lblPrioridade.TabIndex = 4;
            lblPrioridade.Text = "Grau de prioridade:";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblMensagem.ForeColor = System.Drawing.Color.White;
            lblMensagem.Location = new System.Drawing.Point(71, 264);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new System.Drawing.Size(298, 20);
            lblMensagem.TabIndex = 5;
            lblMensagem.Text = "por favor digite a descrição da ocorrencia:";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(718, 599);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(160, 40);
            button1.TabIndex = 9;
            button1.Text = "Adicionar Chamado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pn_title
            // 
            pn_title.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(pic_home);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox2);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            pn_title.Location = new System.Drawing.Point(0, 0);
            pn_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new System.Drawing.Size(957, 99);
            pn_title.TabIndex = 22;
            pn_title.Paint += pn_title_Paint;
            // 
            // pic_home
            // 
            pic_home.Image = (System.Drawing.Image)resources.GetObject("pic_home.Image");
            pic_home.Location = new System.Drawing.Point(12, 25);
            pic_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pic_home.Name = "pic_home";
            pic_home.Size = new System.Drawing.Size(56, 49);
            pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic_home.TabIndex = 25;
            pic_home.TabStop = false;
            pic_home.Click += pic_home_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            lbl_titulo.ForeColor = System.Drawing.Color.White;
            lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_titulo.Location = new System.Drawing.Point(416, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(186, 37);
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "ABRIR TICKET";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(74, 25);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // nightControlBox2
            // 
            nightControlBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nightControlBox2.BackColor = System.Drawing.Color.Transparent;
            nightControlBox2.CloseHoverColor = System.Drawing.Color.FromArgb(199, 80, 80);
            nightControlBox2.CloseHoverForeColor = System.Drawing.Color.White;
            nightControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            nightControlBox2.DefaultLocation = true;
            nightControlBox2.DisableMaximizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox2.DisableMinimizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox2.EnableCloseColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox2.EnableMaximizeButton = true;
            nightControlBox2.EnableMaximizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox2.EnableMinimizeButton = true;
            nightControlBox2.EnableMinimizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox2.Location = new System.Drawing.Point(818, 0);
            nightControlBox2.MaximizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MaximizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox2.MinimizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MinimizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox2.Name = "nightControlBox2";
            nightControlBox2.Size = new System.Drawing.Size(139, 31);
            nightControlBox2.TabIndex = 24;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            lbl_omega.ForeColor = System.Drawing.Color.White;
            lbl_omega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_omega.Location = new System.Drawing.Point(451, 46);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(119, 28);
            lbl_omega.TabIndex = 20;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // formAbrirChamado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            ClientSize = new System.Drawing.Size(957, 707);
            Controls.Add(pn_title);
            Controls.Add(button1);
            Controls.Add(lblMensagem);
            Controls.Add(lblPrioridade);
            Controls.Add(lblTipoOcorencia);
            Controls.Add(comboBox2);
            Controls.Add(txtDescricao);
            Controls.Add(comboBoxTipo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "formAbrirChamado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "formAbrirChamado";
            Load += formAbrirChamado_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTipoOcorencia;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.PictureBox pic_home;
    }
}