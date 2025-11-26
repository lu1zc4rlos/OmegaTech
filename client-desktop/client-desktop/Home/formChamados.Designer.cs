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
        private void InitializeComponent() {
            pn_title = new Panel();
            lbl_titulo = new Label();
            panel1 = new Panel();
            btnChamadosAbertos = new Button();
            btnChamadosConcluidos = new Button();
            btnChamadosEmAndamento = new Button();
            button1 = new Button();
            btnMeusChamados = new Button();
            flowLayoutPanelCards = new FlowLayoutPanel();
            pn_title.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(60, 62, 110);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1000, 99);
            pn_title.TabIndex = 21;
            pn_title.Paint += pn_title_Paint;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(446, 24);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(169, 37);
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "CHAMADOS";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 62, 110);
            panel1.Controls.Add(btnChamadosAbertos);
            panel1.Controls.Add(btnChamadosConcluidos);
            panel1.Controls.Add(btnChamadosEmAndamento);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMeusChamados);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 736);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 64);
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
            btnChamadosAbertos.Location = new Point(315, 8);
            btnChamadosAbertos.Margin = new Padding(3, 4, 3, 4);
            btnChamadosAbertos.Name = "btnChamadosAbertos";
            btnChamadosAbertos.Size = new Size(155, 40);
            btnChamadosAbertos.TabIndex = 11;
            btnChamadosAbertos.Text = "Pendentes ";
            btnChamadosAbertos.UseVisualStyleBackColor = false;
            btnChamadosAbertos.Click += btnChamadosAbertos_Click;
            // 
            // btnChamadosConcluidos
            // 
            btnChamadosConcluidos.Anchor = AnchorStyles.Left;
            btnChamadosConcluidos.BackColor = Color.FromArgb(40, 42, 90);
            btnChamadosConcluidos.FlatAppearance.BorderColor = Color.White;
            btnChamadosConcluidos.FlatAppearance.BorderSize = 0;
            btnChamadosConcluidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 47, 95);
            btnChamadosConcluidos.FlatStyle = FlatStyle.Flat;
            btnChamadosConcluidos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamadosConcluidos.ForeColor = Color.White;
            btnChamadosConcluidos.Location = new Point(639, 8);
            btnChamadosConcluidos.Margin = new Padding(3, 4, 3, 4);
            btnChamadosConcluidos.Name = "btnChamadosConcluidos";
            btnChamadosConcluidos.Size = new Size(155, 40);
            btnChamadosConcluidos.TabIndex = 10;
            btnChamadosConcluidos.Text = "Concluidos";
            btnChamadosConcluidos.UseVisualStyleBackColor = false;
            btnChamadosConcluidos.Click += button3_Click;
            // 
            // btnChamadosEmAndamento
            // 
            btnChamadosEmAndamento.BackColor = Color.FromArgb(40, 42, 90);
            btnChamadosEmAndamento.FlatAppearance.BorderColor = Color.White;
            btnChamadosEmAndamento.FlatAppearance.BorderSize = 0;
            btnChamadosEmAndamento.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 47, 95);
            btnChamadosEmAndamento.FlatStyle = FlatStyle.Flat;
            btnChamadosEmAndamento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamadosEmAndamento.ForeColor = Color.White;
            btnChamadosEmAndamento.Location = new Point(477, 8);
            btnChamadosEmAndamento.Margin = new Padding(3, 4, 3, 4);
            btnChamadosEmAndamento.Name = "btnChamadosEmAndamento";
            btnChamadosEmAndamento.Size = new Size(155, 40);
            btnChamadosEmAndamento.TabIndex = 9;
            btnChamadosEmAndamento.Text = "Em andamento";
            btnChamadosEmAndamento.UseVisualStyleBackColor = false;
            btnChamadosEmAndamento.Click += btnChamadosEmAndamento_Click_1;
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
            button1.Location = new Point(801, 8);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
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
            btnMeusChamados.Location = new Point(153, 8);
            btnMeusChamados.Margin = new Padding(3, 4, 3, 4);
            btnMeusChamados.Name = "btnMeusChamados";
            btnMeusChamados.Size = new Size(155, 40);
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
            flowLayoutPanelCards.Location = new Point(0, 99);
            flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            flowLayoutPanelCards.Size = new Size(1000, 637);
            flowLayoutPanelCards.TabIndex = 26;
            flowLayoutPanelCards.Paint += flowLayoutPanelCards_Paint_1;
            // 
            // formChamados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 800);
            Controls.Add(flowLayoutPanelCards);
            Controls.Add(pn_title);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formChamados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formChamados";
            Load += formChamados_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMeusChamados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Button btnChamadosEmAndamento;
        private System.Windows.Forms.Button btnChamadosConcluidos;
        private System.Windows.Forms.Button btnChamadosAbertos;
    }
}