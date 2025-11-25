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
        private void InitializeComponent() {
            lblDashboardPrincipal = new Label();
            flowLayoutPanelDescricao = new FlowLayoutPanel();
            flowLayoutPanelCard = new FlowLayoutPanel();
            label1 = new Label();
            txtResposta = new TextBox();
            btnConfirmarChamado = new Button();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            lbl_omega = new Label();
            lbl_titulo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDashboardPrincipal
            // 
            lblDashboardPrincipal.AutoSize = true;
            lblDashboardPrincipal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardPrincipal.ForeColor = Color.White;
            lblDashboardPrincipal.Location = new Point(40, 119);
            lblDashboardPrincipal.Name = "lblDashboardPrincipal";
            lblDashboardPrincipal.Size = new Size(411, 54);
            lblDashboardPrincipal.TabIndex = 5;
            lblDashboardPrincipal.Text = "Descrição do cliente:";
            // 
            // flowLayoutPanelDescricao
            // 
            flowLayoutPanelDescricao.Location = new Point(0, 0);
            flowLayoutPanelDescricao.Name = "flowLayoutPanelDescricao";
            flowLayoutPanelDescricao.Size = new Size(200, 100);
            flowLayoutPanelDescricao.TabIndex = 15;
            // 
            // flowLayoutPanelCard
            // 
            flowLayoutPanelCard.Location = new Point(0, 0);
            flowLayoutPanelCard.Name = "flowLayoutPanelCard";
            flowLayoutPanelCard.Size = new Size(200, 100);
            flowLayoutPanelCard.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 469);
            label1.Name = "label1";
            label1.Size = new Size(410, 54);
            label1.TabIndex = 8;
            label1.Text = "Resposta do técnico:";
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(0, 0);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(100, 27);
            txtResposta.TabIndex = 13;
            // 
            // btnConfirmarChamado
            // 
            btnConfirmarChamado.BackColor = Color.FromArgb(0, 179, 136);
            btnConfirmarChamado.FlatAppearance.BorderSize = 0;
            btnConfirmarChamado.FlatStyle = FlatStyle.Flat;
            btnConfirmarChamado.Font = new Font("Segoe UI", 10F);
            btnConfirmarChamado.ForeColor = SystemColors.ControlLight;
            btnConfirmarChamado.Image = Properties.Resources.verificar;
            btnConfirmarChamado.ImageAlign = ContentAlignment.TopCenter;
            btnConfirmarChamado.Location = new Point(904, 603);
            btnConfirmarChamado.Name = "btnConfirmarChamado";
            btnConfirmarChamado.Size = new Size(173, 121);
            btnConfirmarChamado.TabIndex = 10;
            btnConfirmarChamado.Text = "Confirmar chamado ";
            btnConfirmarChamado.TextAlign = ContentAlignment.BottomCenter;
            btnConfirmarChamado.UseVisualStyleBackColor = false;
            btnConfirmarChamado.Click += btnConfirmarChamado_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1028, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 42, 90);
            panel1.Controls.Add(lbl_omega);
            panel1.Controls.Add(lbl_titulo);
            panel1.Controls.Add(nightControlBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 99);
            panel1.TabIndex = 12;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(482, 46);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(119, 28);
            lbl_omega.TabIndex = 24;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(403, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(279, 37);
            lbl_titulo.TabIndex = 23;
            lbl_titulo.Text = "RESPONDER CLIENTE";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(40, 178);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(739, 288);
            flowLayoutPanel1.TabIndex = 16;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 526);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(807, 288);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.ForeColor = Color.Black;
            flowLayoutPanel2.Location = new Point(785, 178);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(369, 228);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // ResponderTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(1166, 820);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(btnConfirmarChamado);
            Controls.Add(txtResposta);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelCard);
            Controls.Add(flowLayoutPanelDescricao);
            Controls.Add(lblDashboardPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResponderTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResponderTicket";
            Load += ResponderTicket_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}