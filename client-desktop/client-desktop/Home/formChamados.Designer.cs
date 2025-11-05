namespace client_desktop.Home {
    partial class formChamados
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
            pn_title = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pic_home = new PictureBox();
            lbl_titulo = new Label();
            pictureBox2 = new PictureBox();
            lbl_omega = new Label();
            panel1 = new Panel();
            btnChamadosAbertos = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnMeusChamados = new Button();
            flowLayoutPanelCards = new FlowLayoutPanel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(nightControlBox1);
            pn_title.Controls.Add(pic_home);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(875, 74);
            pn_title.TabIndex = 21;
            pn_title.Paint += pn_title_Paint;
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
            nightControlBox1.TabIndex = 24;
            // 
            // pic_home
            // 
            pic_home.Location = new Point(10, 16);
            pic_home.Name = "pic_home";
            pic_home.Size = new Size(36, 37);
            pic_home.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_home.TabIndex = 0;
            pic_home.TabStop = false;
            pic_home.Click += pic_home_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(390, 18);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(138, 30);
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "CHAMADOS";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(67, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(116, 25);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(96, 21);
            lbl_omega.TabIndex = 20;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 62, 110);
            panel1.Controls.Add(btnChamadosAbertos);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMeusChamados);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 552);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 48);
            panel1.TabIndex = 25;
            // 
            // btnChamadosAbertos
            // 
            btnChamadosAbertos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChamadosAbertos.BackColor = Color.FromArgb(40, 42, 90);
            btnChamadosAbertos.FlatAppearance.BorderColor = Color.White;
            btnChamadosAbertos.FlatAppearance.BorderSize = 0;
            btnChamadosAbertos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 47, 95);
            btnChamadosAbertos.FlatStyle = FlatStyle.Flat;
            btnChamadosAbertos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamadosAbertos.ForeColor = Color.White;
            btnChamadosAbertos.Location = new Point(276, 6);
            btnChamadosAbertos.Name = "btnChamadosAbertos";
            btnChamadosAbertos.Size = new Size(136, 30);
            btnChamadosAbertos.TabIndex = 11;
            btnChamadosAbertos.Text = "Abertos";
            btnChamadosAbertos.UseVisualStyleBackColor = false;
            btnChamadosAbertos.Click += btnChamadosAbertos_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(40, 42, 90);
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 47, 95);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(559, 6);
            button3.Name = "button3";
            button3.Size = new Size(136, 30);
            button3.TabIndex = 10;
            button3.Text = "Concluidos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(40, 42, 90);
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 47, 95);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(417, 6);
            button2.Name = "button2";
            button2.Size = new Size(136, 30);
            button2.TabIndex = 9;
            button2.Text = "Em andamento";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(40, 42, 90);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 47, 95);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(701, 6);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 8;
            button1.Text = "Adicionar Chamado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMeusChamados
            // 
            btnMeusChamados.Anchor = AnchorStyles.Left;
            btnMeusChamados.BackColor = Color.FromArgb(40, 42, 90);
            btnMeusChamados.FlatAppearance.BorderColor = Color.White;
            btnMeusChamados.FlatAppearance.BorderSize = 0;
            btnMeusChamados.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 47, 95);
            btnMeusChamados.FlatStyle = FlatStyle.Flat;
            btnMeusChamados.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMeusChamados.ForeColor = Color.White;
            btnMeusChamados.Location = new Point(134, 6);
            btnMeusChamados.Name = "btnMeusChamados";
            btnMeusChamados.Size = new Size(136, 30);
            btnMeusChamados.TabIndex = 7;
            btnMeusChamados.Text = "Meus chamados";
            btnMeusChamados.UseVisualStyleBackColor = false;
            btnMeusChamados.Click += btnCarregar_Click;
            // 
            // flowLayoutPanelCards
            // 
            flowLayoutPanelCards.AutoScroll = true;
            flowLayoutPanelCards.BackColor = Color.FromArgb(100, 102, 140);
            flowLayoutPanelCards.Dock = DockStyle.Fill;
            flowLayoutPanelCards.Location = new Point(0, 74);
            flowLayoutPanelCards.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            flowLayoutPanelCards.Size = new Size(875, 478);
            flowLayoutPanelCards.TabIndex = 26;
            flowLayoutPanelCards.Paint += flowLayoutPanelCards_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(40, 42, 90);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(12, 21);
            button4.Name = "button4";
            button4.Size = new Size(56, 49);
            button4.TabIndex = 30;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // formChamados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(875, 600);
            Controls.Add(flowLayoutPanelCards);
            Controls.Add(pn_title);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formChamados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formChamados";
            Load += formChamados_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMeusChamados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnChamadosAbertos;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}