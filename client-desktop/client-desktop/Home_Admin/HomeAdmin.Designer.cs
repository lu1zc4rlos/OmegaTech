namespace client_desktop.Home_Admin {
    partial class HomeAdmin {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            sideBar = new FlowLayoutPanel();
            panel3 = new Panel();
            btnAdicionarTecnico = new Button();
            panel2 = new Panel();
            btnTecnicosCadastrados = new Button();
            pnlConteudo = new Panel();
            lblTitulo = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideBar.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 42, 90);
            panel4.Controls.Add(lblTitulo);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 89);
            panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 21);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(40, 42, 90);
            sideBar.Controls.Add(panel3);
            sideBar.Controls.Add(panel2);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 89);
            sideBar.Margin = new Padding(3, 4, 3, 4);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(246, 403);
            sideBar.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdicionarTecnico);
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 47);
            panel3.TabIndex = 3;
            // 
            // btnAdicionarTecnico
            // 
            btnAdicionarTecnico.BackColor = Color.FromArgb(60, 62, 110);
            btnAdicionarTecnico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarTecnico.ForeColor = SystemColors.Control;
            btnAdicionarTecnico.Location = new Point(-9, -20);
            btnAdicionarTecnico.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarTecnico.Name = "btnAdicionarTecnico";
            btnAdicionarTecnico.Size = new Size(265, 79);
            btnAdicionarTecnico.TabIndex = 2;
            btnAdicionarTecnico.Text = "&Adicionar Técnico";
            btnAdicionarTecnico.UseVisualStyleBackColor = false;
            btnAdicionarTecnico.Click += btnAdicionarTecnico_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTecnicosCadastrados);
            panel2.Location = new Point(3, 59);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 47);
            panel2.TabIndex = 3;
            // 
            // btnTecnicosCadastrados
            // 
            btnTecnicosCadastrados.BackColor = Color.FromArgb(60, 62, 110);
            btnTecnicosCadastrados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTecnicosCadastrados.ForeColor = SystemColors.Control;
            btnTecnicosCadastrados.Location = new Point(-12, -20);
            btnTecnicosCadastrados.Margin = new Padding(3, 4, 3, 4);
            btnTecnicosCadastrados.Name = "btnTecnicosCadastrados";
            btnTecnicosCadastrados.Size = new Size(265, 79);
            btnTecnicosCadastrados.TabIndex = 2;
            btnTecnicosCadastrados.Text = "&Técnicos Cadastrados";
            btnTecnicosCadastrados.UseVisualStyleBackColor = false;
            btnTecnicosCadastrados.Click += btnTecnicosCadastrados_Click;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(246, 89);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(554, 403);
            pnlConteudo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Snow;
            lblTitulo.Location = new Point(241, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(319, 56);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Home Administrador";
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(pnlConteudo);
            Controls.Add(sideBar);
            Controls.Add(panel4);
            IsMdiContainer = true;
            Name = "HomeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DestalhesTecnico";
            WindowState = FormWindowState.Maximized;
            Load += HomeAdmin_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sideBar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel4;
        private PictureBox pictureBox1;
        private FlowLayoutPanel sideBar;
        private Panel panel3;
        private Button btnAdicionarTecnico;
        private Panel panel2;
        private Button btnTecnicosCadastrados;
        private Panel pnlConteudo;
        private Label lblTitulo;
    }
}