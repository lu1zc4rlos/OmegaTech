namespace client_desktop.Home_Tecnico
{
    partial class ResponderTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponderTicket));
            lblDashboardPrincipal = new System.Windows.Forms.Label();
            flowLayoutPanelDescricao = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelCard = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            txtResposta = new System.Windows.Forms.TextBox();
            btnConfirmarChamado = new System.Windows.Forms.Button();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new System.Windows.Forms.Panel();
            lbl_titulo = new System.Windows.Forms.Label();
            lbl_omega = new System.Windows.Forms.Label();
            pic_home = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblDashboardPrincipal
            // 
            lblDashboardPrincipal.AutoSize = true;
            lblDashboardPrincipal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDashboardPrincipal.ForeColor = System.Drawing.Color.White;
            lblDashboardPrincipal.Location = new System.Drawing.Point(40, 119);
            lblDashboardPrincipal.Name = "lblDashboardPrincipal";
            lblDashboardPrincipal.Size = new System.Drawing.Size(411, 54);
            lblDashboardPrincipal.TabIndex = 5;
            lblDashboardPrincipal.Text = "Descrição do cliente:";
            // 
            // flowLayoutPanelDescricao
            // 
            flowLayoutPanelDescricao.AutoScroll = true;
            flowLayoutPanelDescricao.BackColor = System.Drawing.Color.White;
            flowLayoutPanelDescricao.ForeColor = System.Drawing.Color.Black;
            flowLayoutPanelDescricao.Location = new System.Drawing.Point(39, 178);
            flowLayoutPanelDescricao.Name = "flowLayoutPanelDescricao";
            flowLayoutPanelDescricao.Size = new System.Drawing.Size(807, 288);
            flowLayoutPanelDescricao.TabIndex = 6;
            flowLayoutPanelDescricao.Paint += flowLayoutPanelDescricao_Paint;
            // 
            // flowLayoutPanelCard
            // 
            flowLayoutPanelCard.BackColor = System.Drawing.Color.White;
            flowLayoutPanelCard.ForeColor = System.Drawing.Color.Black;
            flowLayoutPanelCard.Location = new System.Drawing.Point(858, 178);
            flowLayoutPanelCard.Name = "flowLayoutPanelCard";
            flowLayoutPanelCard.Size = new System.Drawing.Size(296, 228);
            flowLayoutPanelCard.TabIndex = 7;
            flowLayoutPanelCard.Paint += flowLayoutPanelCard_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(40, 469);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(410, 54);
            label1.TabIndex = 8;
            label1.Text = "Resposta do técnico:";
            // 
            // txtResposta
            // 
            txtResposta.Location = new System.Drawing.Point(39, 526);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new System.Drawing.Size(807, 288);
            txtResposta.TabIndex = 9;
            txtResposta.TextChanged += txtResposta_TextChanged;
            // 
            // btnConfirmarChamado
            // 
            btnConfirmarChamado.BackColor = System.Drawing.Color.FromArgb(0, 179, 136);
            btnConfirmarChamado.FlatAppearance.BorderSize = 0;
            btnConfirmarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmarChamado.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnConfirmarChamado.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnConfirmarChamado.Image = (System.Drawing.Image)resources.GetObject("btnConfirmarChamado.Image");
            btnConfirmarChamado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnConfirmarChamado.Location = new System.Drawing.Point(904, 603);
            btnConfirmarChamado.Name = "btnConfirmarChamado";
            btnConfirmarChamado.Size = new System.Drawing.Size(173, 121);
            btnConfirmarChamado.TabIndex = 10;
            btnConfirmarChamado.Text = "Confirmar chamado ";
            btnConfirmarChamado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnConfirmarChamado.UseVisualStyleBackColor = false;
            btnConfirmarChamado.Click += btnConfirmarChamado_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new System.Drawing.Point(1028, 0);
            nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new System.Drawing.Size(139, 31);
            nightControlBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            panel1.Controls.Add(pic_home);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbl_omega);
            panel1.Controls.Add(lbl_titulo);
            panel1.Controls.Add(nightControlBox1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1167, 99);
            panel1.TabIndex = 12;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            lbl_titulo.ForeColor = System.Drawing.Color.White;
            lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_titulo.Location = new System.Drawing.Point(403, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(279, 37);
            lbl_titulo.TabIndex = 23;
            lbl_titulo.Text = "RESPONDER CLIENTE";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            lbl_omega.ForeColor = System.Drawing.Color.White;
            lbl_omega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_omega.Location = new System.Drawing.Point(482, 46);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(119, 28);
            lbl_omega.TabIndex = 24;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // pic_home
            // 
            pic_home.Image = (System.Drawing.Image)resources.GetObject("pic_home.Image");
            pic_home.Location = new System.Drawing.Point(18, 25);
            pic_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pic_home.Name = "pic_home";
            pic_home.Size = new System.Drawing.Size(56, 49);
            pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic_home.TabIndex = 28;
            pic_home.TabStop = false;
            pic_home.Click += pic_home_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(80, 24);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // ResponderTicket
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            ClientSize = new System.Drawing.Size(1166, 820);
            Controls.Add(panel1);
            Controls.Add(btnConfirmarChamado);
            Controls.Add(txtResposta);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelCard);
            Controls.Add(flowLayoutPanelDescricao);
            Controls.Add(lblDashboardPrincipal);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ResponderTicket";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ResponderTicket";
            Load += ResponderTicket_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDashboardPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDescricao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnConfirmarChamado;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}