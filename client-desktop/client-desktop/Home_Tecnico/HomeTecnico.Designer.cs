namespace client_desktop.Home_Técnico
{
    partial class HomeTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTecnico));
            btnTicketsTotais = new System.Windows.Forms.Button();
            btnTicketsFechados = new System.Windows.Forms.Button();
            btnEmAtendimento = new System.Windows.Forms.Button();
            btnTicketsAbertos = new System.Windows.Forms.Button();
            lblDashboardPrincipal = new System.Windows.Forms.Label();
            lblUltimosTickets = new System.Windows.Forms.Label();
            flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            pn_title = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new System.Windows.Forms.Label();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnTicketsTotais
            // 
            btnTicketsTotais.BackColor = System.Drawing.Color.FromArgb(28, 58, 120);
            btnTicketsTotais.FlatAppearance.BorderSize = 0;
            btnTicketsTotais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTicketsTotais.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnTicketsTotais.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnTicketsTotais.Image = (System.Drawing.Image)resources.GetObject("btnTicketsTotais.Image");
            btnTicketsTotais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnTicketsTotais.Location = new System.Drawing.Point(118, 211);
            btnTicketsTotais.Name = "btnTicketsTotais";
            btnTicketsTotais.Size = new System.Drawing.Size(150, 121);
            btnTicketsTotais.TabIndex = 0;
            btnTicketsTotais.Text = "Tickets totais";
            btnTicketsTotais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTicketsTotais.UseVisualStyleBackColor = false;
            btnTicketsTotais.Click += btnTicketsTotais_Click;
            // 
            // btnTicketsFechados
            // 
            btnTicketsFechados.BackColor = System.Drawing.Color.FromArgb(0, 179, 136);
            btnTicketsFechados.FlatAppearance.BorderSize = 0;
            btnTicketsFechados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTicketsFechados.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnTicketsFechados.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnTicketsFechados.Image = (System.Drawing.Image)resources.GetObject("btnTicketsFechados.Image");
            btnTicketsFechados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnTicketsFechados.Location = new System.Drawing.Point(810, 211);
            btnTicketsFechados.Name = "btnTicketsFechados";
            btnTicketsFechados.Size = new System.Drawing.Size(150, 121);
            btnTicketsFechados.TabIndex = 1;
            btnTicketsFechados.Text = "Tickets fechados";
            btnTicketsFechados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTicketsFechados.UseVisualStyleBackColor = false;
            btnTicketsFechados.Click += btnTicketsFechados_Click;
            // 
            // btnEmAtendimento
            // 
            btnEmAtendimento.BackColor = System.Drawing.Color.FromArgb(51, 160, 204);
            btnEmAtendimento.FlatAppearance.BorderSize = 0;
            btnEmAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEmAtendimento.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnEmAtendimento.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnEmAtendimento.Image = (System.Drawing.Image)resources.GetObject("btnEmAtendimento.Image");
            btnEmAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEmAtendimento.Location = new System.Drawing.Point(581, 211);
            btnEmAtendimento.Name = "btnEmAtendimento";
            btnEmAtendimento.Size = new System.Drawing.Size(150, 121);
            btnEmAtendimento.TabIndex = 2;
            btnEmAtendimento.Text = "Em atendimento";
            btnEmAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEmAtendimento.UseVisualStyleBackColor = false;
            btnEmAtendimento.Click += btnEmAtendimento_Click;
            // 
            // btnTicketsAbertos
            // 
            btnTicketsAbertos.BackColor = System.Drawing.Color.FromArgb(255, 0, 102);
            btnTicketsAbertos.FlatAppearance.BorderSize = 0;
            btnTicketsAbertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTicketsAbertos.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnTicketsAbertos.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnTicketsAbertos.Image = (System.Drawing.Image)resources.GetObject("btnTicketsAbertos.Image");
            btnTicketsAbertos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnTicketsAbertos.Location = new System.Drawing.Point(354, 211);
            btnTicketsAbertos.Name = "btnTicketsAbertos";
            btnTicketsAbertos.Size = new System.Drawing.Size(150, 121);
            btnTicketsAbertos.TabIndex = 3;
            btnTicketsAbertos.Text = "Tickets abertos";
            btnTicketsAbertos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTicketsAbertos.UseVisualStyleBackColor = false;
            btnTicketsAbertos.Click += btnTicketsAbertos_Click;
            // 
            // lblDashboardPrincipal
            // 
            lblDashboardPrincipal.AutoSize = true;
            lblDashboardPrincipal.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            lblDashboardPrincipal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDashboardPrincipal.ForeColor = System.Drawing.Color.White;
            lblDashboardPrincipal.Location = new System.Drawing.Point(327, 9);
            lblDashboardPrincipal.Name = "lblDashboardPrincipal";
            lblDashboardPrincipal.Size = new System.Drawing.Size(404, 54);
            lblDashboardPrincipal.TabIndex = 4;
            lblDashboardPrincipal.Text = "Dashboard principal";
            lblDashboardPrincipal.Click += lblDashboardPrincipal_Click;
            // 
            // lblUltimosTickets
            // 
            lblUltimosTickets.AutoSize = true;
            lblUltimosTickets.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblUltimosTickets.ForeColor = System.Drawing.Color.White;
            lblUltimosTickets.Location = new System.Drawing.Point(100, 406);
            lblUltimosTickets.Name = "lblUltimosTickets";
            lblUltimosTickets.Size = new System.Drawing.Size(210, 37);
            lblUltimosTickets.TabIndex = 5;
            lblUltimosTickets.Text = "Últimos tickets";
            // 
            // flowLayoutPanelCards
            // 
            flowLayoutPanelCards.AutoScroll = true;
            flowLayoutPanelCards.Location = new System.Drawing.Point(100, 468);
            flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            flowLayoutPanelCards.Size = new System.Drawing.Size(893, 375);
            flowLayoutPanelCards.TabIndex = 6;
            flowLayoutPanelCards.Paint += flowLayoutPanelCards_Paint;
            // 
            // pn_title
            // 
            pn_title.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox2);
            pn_title.Controls.Add(lblDashboardPrincipal);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            pn_title.Location = new System.Drawing.Point(0, 0);
            pn_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new System.Drawing.Size(1068, 99);
            pn_title.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(12, 13);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(64, 58);
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
            nightControlBox2.Location = new System.Drawing.Point(929, 0);
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
            lbl_omega.Location = new System.Drawing.Point(468, 63);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(119, 28);
            lbl_omega.TabIndex = 20;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // HomeTecnico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            ClientSize = new System.Drawing.Size(1068, 917);
            Controls.Add(pn_title);
            Controls.Add(flowLayoutPanelCards);
            Controls.Add(lblUltimosTickets);
            Controls.Add(btnTicketsAbertos);
            Controls.Add(btnEmAtendimento);
            Controls.Add(btnTicketsFechados);
            Controls.Add(btnTicketsTotais);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "HomeTecnico";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HomeTecnico";
            Load += HomeTecnico_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnTicketsTotais;
        private System.Windows.Forms.Button btnTicketsFechados;
        private System.Windows.Forms.Button btnEmAtendimento;
        private System.Windows.Forms.Button btnTicketsAbertos;
        private System.Windows.Forms.Label lblDashboardPrincipal;
        private System.Windows.Forms.Label lblUltimosTickets;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.Label lbl_omega;
    }
}