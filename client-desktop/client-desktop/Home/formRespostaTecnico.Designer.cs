namespace client_desktop.Home
{
    partial class formRespostaTecnico
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pn_title = new Panel();
            lbl_titulo = new Label();
            flowLayoutPanelDescricao = new FlowLayoutPanel();
            flowLayoutPanelResposta = new FlowLayoutPanel();
            pn_title.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(183, 476);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 1;
            label1.Text = "Resposta tecnico:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(183, 127);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Descrição:";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(194, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(209, 421);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1142, 99);
            pn_title.TabIndex = 23;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(406, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(310, 37);
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "RESPOSTA DO TECNICO";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanelDescricao
            // 
            flowLayoutPanelDescricao.AutoScroll = true;
            flowLayoutPanelDescricao.BackColor = Color.White;
            flowLayoutPanelDescricao.Location = new Point(183, 153);
            flowLayoutPanelDescricao.Name = "flowLayoutPanelDescricao";
            flowLayoutPanelDescricao.Size = new Size(807, 288);
            flowLayoutPanelDescricao.TabIndex = 24;
            // 
            // flowLayoutPanelResposta
            // 
            flowLayoutPanelResposta.AutoScroll = true;
            flowLayoutPanelResposta.BackColor = Color.White;
            flowLayoutPanelResposta.Location = new Point(183, 499);
            flowLayoutPanelResposta.Name = "flowLayoutPanelResposta";
            flowLayoutPanelResposta.Size = new Size(807, 288);
            flowLayoutPanelResposta.TabIndex = 25;
            flowLayoutPanelResposta.Paint += flowLayoutPanelResposta_Paint;
            // 
            // formRespostaTecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(1142, 821);
            Controls.Add(flowLayoutPanelResposta);
            Controls.Add(flowLayoutPanelDescricao);
            Controls.Add(pn_title);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRespostaTecnico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formRespostaTecnico";
            Load += formRespostaTecnico_LoadAsync;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDescricao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResposta;
    }
}