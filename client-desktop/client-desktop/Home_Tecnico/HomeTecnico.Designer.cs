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
        private void InitializeComponent() {
            btnTicketsTotais = new Button();
            btnTicketsFechados = new Button();
            btnEmAtendimento = new Button();
            btnTicketsAbertos = new Button();
            lblDashboardPrincipal = new Label();
            lblUltimosTickets = new Label();
            pn_title = new Panel();
            pictureBox2 = new PictureBox();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnTicketsTotais
            // 
            btnTicketsTotais.BackColor = Color.FromArgb(28, 58, 120);
            btnTicketsTotais.FlatAppearance.BorderSize = 0;
            btnTicketsTotais.FlatStyle = FlatStyle.Flat;
            btnTicketsTotais.Font = new Font("Segoe UI", 10F);
            btnTicketsTotais.ForeColor = SystemColors.ControlLight;
            btnTicketsTotais.Image = Properties.Resources.botao_de_avanco_rapido;
            btnTicketsTotais.ImageAlign = ContentAlignment.TopCenter;
            btnTicketsTotais.Location = new Point(118, 211);
            btnTicketsTotais.Name = "btnTicketsTotais";
            btnTicketsTotais.Size = new Size(165, 121);
            btnTicketsTotais.TabIndex = 0;
            btnTicketsTotais.Text = "Tickets totais";
            btnTicketsTotais.TextAlign = ContentAlignment.BottomCenter;
            btnTicketsTotais.UseVisualStyleBackColor = false;
            btnTicketsTotais.Click += btnTicketsTotais_Click;
            // 
            // btnTicketsFechados
            // 
            btnTicketsFechados.BackColor = Color.FromArgb(0, 179, 136);
            btnTicketsFechados.FlatAppearance.BorderSize = 0;
            btnTicketsFechados.FlatStyle = FlatStyle.Flat;
            btnTicketsFechados.Font = new Font("Segoe UI", 10F);
            btnTicketsFechados.ForeColor = SystemColors.ControlLight;
            btnTicketsFechados.Image = Properties.Resources.verificar;
            btnTicketsFechados.ImageAlign = ContentAlignment.TopCenter;
            btnTicketsFechados.Location = new Point(810, 211);
            btnTicketsFechados.Name = "btnTicketsFechados";
            btnTicketsFechados.Size = new Size(165, 121);
            btnTicketsFechados.TabIndex = 1;
            btnTicketsFechados.Text = "Tickets concluídos";
            btnTicketsFechados.TextAlign = ContentAlignment.BottomCenter;
            btnTicketsFechados.UseVisualStyleBackColor = false;
            btnTicketsFechados.Click += btnTicketsFechados_Click;
            // 
            // btnEmAtendimento
            // 
            btnEmAtendimento.BackColor = Color.FromArgb(51, 160, 204);
            btnEmAtendimento.FlatAppearance.BorderSize = 0;
            btnEmAtendimento.FlatStyle = FlatStyle.Flat;
            btnEmAtendimento.Font = new Font("Segoe UI", 10F);
            btnEmAtendimento.ForeColor = SystemColors.ControlLight;
            btnEmAtendimento.Image = Properties.Resources.fone_de_ouvido;
            btnEmAtendimento.ImageAlign = ContentAlignment.TopCenter;
            btnEmAtendimento.Location = new Point(581, 211);
            btnEmAtendimento.Name = "btnEmAtendimento";
            btnEmAtendimento.Size = new Size(165, 121);
            btnEmAtendimento.TabIndex = 2;
            btnEmAtendimento.Text = "Em andamento";
            btnEmAtendimento.TextAlign = ContentAlignment.BottomCenter;
            btnEmAtendimento.UseVisualStyleBackColor = false;
            btnEmAtendimento.Click += btnEmAtendimento_Click;
            // 
            // btnTicketsAbertos
            // 
            btnTicketsAbertos.BackColor = Color.FromArgb(255, 0, 102);
            btnTicketsAbertos.FlatAppearance.BorderSize = 0;
            btnTicketsAbertos.FlatStyle = FlatStyle.Flat;
            btnTicketsAbertos.Font = new Font("Segoe UI", 10F);
            btnTicketsAbertos.ForeColor = SystemColors.ControlLight;
            btnTicketsAbertos.Image = Properties.Resources.olho;
            btnTicketsAbertos.ImageAlign = ContentAlignment.TopCenter;
            btnTicketsAbertos.Location = new Point(354, 211);
            btnTicketsAbertos.Name = "btnTicketsAbertos";
            btnTicketsAbertos.Size = new Size(165, 121);
            btnTicketsAbertos.TabIndex = 3;
            btnTicketsAbertos.Text = "Tickets pendentes";
            btnTicketsAbertos.TextAlign = ContentAlignment.BottomCenter;
            btnTicketsAbertos.UseVisualStyleBackColor = false;
            btnTicketsAbertos.Click += btnTicketsAbertos_Click;
            // 
            // lblDashboardPrincipal
            // 
            lblDashboardPrincipal.AutoSize = true;
            lblDashboardPrincipal.BackColor = Color.FromArgb(60, 62, 110);
            lblDashboardPrincipal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardPrincipal.ForeColor = Color.White;
            lblDashboardPrincipal.Location = new Point(327, 9);
            lblDashboardPrincipal.Name = "lblDashboardPrincipal";
            lblDashboardPrincipal.Size = new Size(404, 54);
            lblDashboardPrincipal.TabIndex = 4;
            lblDashboardPrincipal.Text = "Dashboard principal";
            lblDashboardPrincipal.Click += lblDashboardPrincipal_Click;
            // 
            // lblUltimosTickets
            // 
            lblUltimosTickets.AutoSize = true;
            lblUltimosTickets.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUltimosTickets.ForeColor = Color.White;
            lblUltimosTickets.Location = new Point(100, 406);
            lblUltimosTickets.Name = "lblUltimosTickets";
            lblUltimosTickets.Size = new Size(210, 37);
            lblUltimosTickets.TabIndex = 5;
            lblUltimosTickets.Text = "Últimos tickets";
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox2);
            pn_title.Controls.Add(lblDashboardPrincipal);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1068, 99);
            pn_title.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(12, 13);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // nightControlBox2
            // 
            nightControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox2.BackColor = Color.Transparent;
            nightControlBox2.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox2.CloseHoverForeColor = Color.White;
            nightControlBox2.Cursor = Cursors.Hand;
            nightControlBox2.DefaultLocation = true;
            nightControlBox2.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox2.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox2.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox2.EnableMaximizeButton = true;
            nightControlBox2.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox2.EnableMinimizeButton = true;
            nightControlBox2.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox2.Location = new Point(929, 0);
            nightControlBox2.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MaximizeHoverForeColor = Color.White;
            nightControlBox2.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MinimizeHoverForeColor = Color.White;
            nightControlBox2.Name = "nightControlBox2";
            nightControlBox2.Size = new Size(139, 31);
            nightControlBox2.TabIndex = 24;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(468, 63);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(119, 28);
            lbl_omega.TabIndex = 20;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(42, 459);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(997, 446);
            flowLayoutPanel.TabIndex = 24;
            // 
            // HomeTecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(1068, 917);
            Controls.Add(flowLayoutPanel);
            Controls.Add(pn_title);
            Controls.Add(lblUltimosTickets);
            Controls.Add(btnTicketsAbertos);
            Controls.Add(btnEmAtendimento);
            Controls.Add(btnTicketsFechados);
            Controls.Add(btnTicketsTotais);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeTecnico";
            StartPosition = FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.Label lbl_omega;
        private FlowLayoutPanel flowLayoutPanel;
    }
}