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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChamados));
            pn_title = new System.Windows.Forms.Panel();
            pic_home = new System.Windows.Forms.PictureBox();
            lbl_titulo = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnChamadosAbertos = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnMeusChamados = new System.Windows.Forms.Button();
            flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            pn_title.Size = new System.Drawing.Size(1000, 99);
            pn_title.TabIndex = 21;
            pn_title.Paint += pn_title_Paint;
            // 
            // pic_home
            // 
            pic_home.Image = (System.Drawing.Image)resources.GetObject("pic_home.Image");
            pic_home.Location = new System.Drawing.Point(11, 21);
            pic_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pic_home.Name = "pic_home";
            pic_home.Size = new System.Drawing.Size(41, 49);
            pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic_home.TabIndex = 0;
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
            lbl_titulo.Location = new System.Drawing.Point(446, 24);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(169, 37);
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "CHAMADOS";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(77, 21);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
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
            nightControlBox2.Location = new System.Drawing.Point(861, 0);
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
            lbl_omega.Location = new System.Drawing.Point(133, 33);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(119, 28);
            lbl_omega.TabIndex = 20;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            panel1.Controls.Add(btnChamadosAbertos);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMeusChamados);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 736);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1000, 64);
            panel1.TabIndex = 25;
            // 
            // btnChamadosAbertos
            // 
            btnChamadosAbertos.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            btnChamadosAbertos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnChamadosAbertos.FlatAppearance.BorderSize = 0;
            btnChamadosAbertos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            btnChamadosAbertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChamadosAbertos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnChamadosAbertos.ForeColor = System.Drawing.Color.White;
            btnChamadosAbertos.Location = new System.Drawing.Point(315, 8);
            btnChamadosAbertos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnChamadosAbertos.Name = "btnChamadosAbertos";
            btnChamadosAbertos.Size = new System.Drawing.Size(156, 40);
            btnChamadosAbertos.TabIndex = 11;
            btnChamadosAbertos.Text = "Abertos";
            btnChamadosAbertos.UseVisualStyleBackColor = false;
            btnChamadosAbertos.Click += btnChamadosAbertos_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(639, 8);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(156, 40);
            button3.TabIndex = 10;
            button3.Text = "Concluidos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(477, 8);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(156, 40);
            button2.TabIndex = 9;
            button2.Text = "Em andamento";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.Location = new System.Drawing.Point(801, 8);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(160, 40);
            button1.TabIndex = 8;
            button1.Text = "Adicionar Chamado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMeusChamados
            // 
            btnMeusChamados.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            btnMeusChamados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnMeusChamados.FlatAppearance.BorderSize = 0;
            btnMeusChamados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            btnMeusChamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMeusChamados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMeusChamados.ForeColor = System.Drawing.Color.White;
            btnMeusChamados.Location = new System.Drawing.Point(153, 8);
            btnMeusChamados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMeusChamados.Name = "btnMeusChamados";
            btnMeusChamados.Size = new System.Drawing.Size(156, 40);
            btnMeusChamados.TabIndex = 7;
            btnMeusChamados.Text = "Meus chamados";
            btnMeusChamados.UseVisualStyleBackColor = false;
            btnMeusChamados.Click += btnCarregar_Click;
            // 
            // flowLayoutPanelCards
            // 
            flowLayoutPanelCards.AutoScroll = true;
            flowLayoutPanelCards.BackColor = System.Drawing.Color.FromArgb(100, 102, 140);
            flowLayoutPanelCards.Location = new System.Drawing.Point(0, 98);
            flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            flowLayoutPanelCards.Size = new System.Drawing.Size(1000, 639);
            flowLayoutPanelCards.TabIndex = 26;
            flowLayoutPanelCards.Paint += flowLayoutPanelCards_Paint;
            // 
            // formChamados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1000, 800);
            Controls.Add(flowLayoutPanelCards);
            Controls.Add(pn_title);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "formChamados";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "formChamados";
            Load += formChamados_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMeusChamados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnChamadosAbertos;
    }
}