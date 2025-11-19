namespace client_desktop.Home {
    partial class formAbrirChamado {
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
            lbl_titulo = new Label();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            button1 = new Button();
            lblMensagem = new Label();
            txtDescricao = new TextBox();
            pn_title.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(nightControlBox2);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(939, 99);
            pn_title.TabIndex = 23;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(375, 27);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(186, 37);
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "ABRIR TICKET";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
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
            nightControlBox2.Location = new Point(800, 0);
            nightControlBox2.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MaximizeHoverForeColor = Color.White;
            nightControlBox2.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MinimizeHoverForeColor = Color.White;
            nightControlBox2.Name = "nightControlBox2";
            nightControlBox2.Size = new Size(139, 31);
            nightControlBox2.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 42, 90);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 47, 95);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(706, 598);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 26;
            button1.Text = "Adicionar Chamado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_ClickAsync;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMensagem.ForeColor = Color.White;
            lblMensagem.Location = new Point(59, 116);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(298, 20);
            lblMensagem.TabIndex = 25;
            lblMensagem.Text = "por favor digite a descrição da ocorrencia:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(59, 154);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(807, 437);
            txtDescricao.TabIndex = 24;
            // 
            // formAbrirChamado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 62, 110);
            ClientSize = new Size(939, 660);
            Controls.Add(button1);
            Controls.Add(lblMensagem);
            Controls.Add(txtDescricao);
            Controls.Add(pn_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formAbrirChamado";
            Text = "Form1";
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_title;
        private Label lbl_titulo;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private Button button1;
        private Label lblMensagem;
        private TextBox txtDescricao;
    }
}