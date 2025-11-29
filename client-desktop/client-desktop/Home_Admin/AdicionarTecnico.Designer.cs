namespace client_desktop.Home_Admin {
    partial class AdicionarTecnico {
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            txtSenha = new TextBox();
            cbMostrarSenha = new CheckBox();
            lblNome = new Label();
            lblConfirmarSenha = new Label();
            lblSenha = new Label();
            txtConfirmarSenha = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblDataNascimento = new Label();
            atpDataNascimento = new DateTimePicker();
            txtEmail = new TextBox();
            btnConfirmar = new Button();
            lblSenhaDiferente = new Label();
            pn_title.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 110);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1008, 99);
            pn_title.TabIndex = 4;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(388, 31);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(232, 37);
            lbl_titulo.TabIndex = 2;
            lbl_titulo.Text = "Adicionar Técnico";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(60, 62, 110);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(1008, 668);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 42, 90);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(204, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 461);
            panel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(40, 42, 110);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 1, 3);
            tableLayoutPanel2.Controls.Add(lblNome, 0, 0);
            tableLayoutPanel2.Controls.Add(lblConfirmarSenha, 0, 4);
            tableLayoutPanel2.Controls.Add(lblSenha, 0, 3);
            tableLayoutPanel2.Controls.Add(lblEmail, 0, 2);
            tableLayoutPanel2.Controls.Add(txtNome, 1, 0);
            tableLayoutPanel2.Controls.Add(lblDataNascimento, 0, 1);
            tableLayoutPanel2.Controls.Add(atpDataNascimento, 1, 1);
            tableLayoutPanel2.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel2.Controls.Add(btnConfirmar, 1, 6);
            tableLayoutPanel2.Controls.Add(txtConfirmarSenha, 1, 4);
            tableLayoutPanel2.Controls.Add(lblSenhaDiferente, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.Size = new Size(598, 461);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSenha);
            panel3.Controls.Add(cbMostrarSenha);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(176, 195);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 65);
            panel3.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(3, 19);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(192, 20);
            txtSenha.TabIndex = 3;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Dock = DockStyle.Right;
            cbMostrarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMostrarSenha.ForeColor = Color.White;
            cbMostrarSenha.Location = new Point(201, 0);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new Size(142, 59);
            cbMostrarSenha.TabIndex = 4;
            cbMostrarSenha.Text = "&Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(112, 21);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 23);
            lblNome.TabIndex = 19;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Anchor = AnchorStyles.Right;
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.BackColor = Color.Transparent;
            lblConfirmarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmarSenha.ForeColor = Color.White;
            lblConfirmarSenha.Location = new Point(27, 281);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(146, 23);
            lblConfirmarSenha.TabIndex = 19;
            lblConfirmarSenha.Text = "Confirmar senha: ";
            lblConfirmarSenha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Dock = DockStyle.Right;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(112, 195);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(61, 65);
            lblSenha.TabIndex = 19;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Anchor = AnchorStyles.Left;
            txtConfirmarSenha.BorderStyle = BorderStyle.None;
            txtConfirmarSenha.Location = new Point(179, 282);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(192, 20);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(118, 151);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Left;
            txtNome.BackColor = SystemColors.Window;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(179, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(416, 20);
            txtNome.TabIndex = 19;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Anchor = AnchorStyles.Right;
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataNascimento.ForeColor = Color.White;
            lblDataNascimento.Location = new Point(3, 86);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(170, 23);
            lblDataNascimento.TabIndex = 19;
            lblDataNascimento.Text = "Data de Nascimento:";
            lblDataNascimento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // atpDataNascimento
            // 
            atpDataNascimento.Anchor = AnchorStyles.Left;
            atpDataNascimento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atpDataNascimento.Location = new Point(179, 83);
            atpDataNascimento.Name = "atpDataNascimento";
            atpDataNascimento.RightToLeft = RightToLeft.No;
            atpDataNascimento.Size = new Size(132, 29);
            atpDataNascimento.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(179, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(416, 20);
            txtEmail.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.None;
            btnConfirmar.BackColor = Color.FromArgb(60, 62, 110);
            btnConfirmar.FlatAppearance.BorderColor = Color.White;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(334, 410);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(106, 30);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblSenhaDiferente
            // 
            lblSenhaDiferente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSenhaDiferente.AutoSize = true;
            lblSenhaDiferente.BackColor = Color.Red;
            lblSenhaDiferente.ForeColor = SystemColors.ButtonHighlight;
            lblSenhaDiferente.Location = new Point(468, 325);
            lblSenhaDiferente.Name = "lblSenhaDiferente";
            lblSenhaDiferente.Size = new Size(127, 20);
            lblSenhaDiferente.TabIndex = 20;
            lblSenhaDiferente.Text = "Senhas Diferentes";
            // 
            // AdicionarTecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 767);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pn_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdicionarTecnico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdicionarTecnico";
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            Load += AdicionarTecnico_Load;
        }

        #endregion

        private Panel pn_title;
        private Label lbl_titulo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TextBox txtSenha;
        private CheckBox cbMostrarSenha;
        private Label lblNome;
        private Label lblConfirmarSenha;
        private Label lblSenha;
        private TextBox txtConfirmarSenha;
        private Label lblEmail;
        private TextBox txtNome;
        private Label lblDataNascimento;
        private DateTimePicker atpDataNascimento;
        private TextBox txtEmail;
        private Button btnConfirmar;
        private Label lblSenhaDiferente;
    }
}