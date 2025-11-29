namespace client_desktop.Home_Admin {
    partial class RespostaDoTecnico {
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
            pn_title = new Panel();
            label1 = new Label();
            flowLayoutPanelResposta = new FlowLayoutPanel();
            flowLayoutPanelDescricao = new FlowLayoutPanel();
            label4 = new Label();
            pn_title.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(label1);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1311, 99);
            pn_title.TabIndex = 24;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(497, 24);
            label1.Name = "label1";
            label1.Size = new Size(310, 37);
            label1.TabIndex = 27;
            label1.Text = "RESPOSTA DO TECNICO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanelResposta
            // 
            flowLayoutPanelResposta.AutoScroll = true;
            flowLayoutPanelResposta.BackColor = Color.White;
            flowLayoutPanelResposta.Location = new Point(12, 473);
            flowLayoutPanelResposta.Name = "flowLayoutPanelResposta";
            flowLayoutPanelResposta.Size = new Size(1287, 323);
            flowLayoutPanelResposta.TabIndex = 30;
            // 
            // flowLayoutPanelDescricao
            // 
            flowLayoutPanelDescricao.AutoScroll = true;
            flowLayoutPanelDescricao.BackColor = Color.White;
            flowLayoutPanelDescricao.Location = new Point(12, 118);
            flowLayoutPanelDescricao.Name = "flowLayoutPanelDescricao";
            flowLayoutPanelDescricao.Size = new Size(1287, 340);
            flowLayoutPanelDescricao.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(201, 407);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 28;
            // 
            // RespostaDoTecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(1311, 808);
            Controls.Add(flowLayoutPanelResposta);
            Controls.Add(flowLayoutPanelDescricao);
            Controls.Add(label4);
            Controls.Add(pn_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RespostaDoTecnico";
            Text = "RespostaDoTecnico";
            Load += RespostaDoTecnico_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_title;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelResposta;
        private FlowLayoutPanel flowLayoutPanelDescricao;
        private Label label4;
    }
}