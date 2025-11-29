namespace client_desktop.Home_Admin {
    partial class TecnicosCadastrados {
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pn_title = new Panel();
            lbl_titulo = new Label();
            pn_title.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 118);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1052, 599);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 110);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1076, 99);
            pn_title.TabIndex = 5;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(422, 31);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(278, 37);
            lbl_titulo.TabIndex = 3;
            lbl_titulo.Text = "Técnicos Cadastrados";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // TecnicosCadastrados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(1076, 729);
            Controls.Add(pn_title);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TecnicosCadastrados";
            Text = "TecnicosCadastrados";
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ResumeLayout(false);
            Load += TecnicosCadastrados_Load;
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pn_title;
        private Label lbl_titulo;
    }
}