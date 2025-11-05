namespace client_desktop.Home {
    partial class Home {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            sideBar = new FlowLayoutPanel();
            panel1 = new Panel();
            btnHome = new Button();
            panel2 = new Panel();
            btnOmegaHelp = new Button();
            panel3 = new Panel();
            btnChamados = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideBar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(lblTitulo);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(700, 67);
            panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Snow;
            lblTitulo.Location = new Point(310, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "OmegaTech";
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(40, 42, 90);
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel3);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 67);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(215, 302);
            sideBar.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 35);
            panel1.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(60, 62, 110);
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Location = new Point(-11, -13);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(232, 59);
            btnHome.TabIndex = 2;
            btnHome.Text = "&Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnOmegaHelp);
            panel2.Location = new Point(3, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 35);
            panel2.TabIndex = 3;
            // 
            // btnOmegaHelp
            // 
            btnOmegaHelp.BackColor = Color.FromArgb(60, 62, 110);
            btnOmegaHelp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOmegaHelp.ForeColor = SystemColors.Control;
            btnOmegaHelp.Location = new Point(-11, -13);
            btnOmegaHelp.Name = "btnOmegaHelp";
            btnOmegaHelp.Size = new Size(232, 59);
            btnOmegaHelp.TabIndex = 2;
            btnOmegaHelp.Text = "&OmegaHelp";
            btnOmegaHelp.UseVisualStyleBackColor = false;
            btnOmegaHelp.Click += btnOmegaHelp_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnChamados);
            panel3.Location = new Point(3, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 35);
            panel3.TabIndex = 3;
            // 
            // btnChamados
            // 
            btnChamados.BackColor = Color.FromArgb(60, 62, 110);
            btnChamados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamados.ForeColor = SystemColors.Control;
            btnChamados.Location = new Point(-11, -13);
            btnChamados.Name = "btnChamados";
            btnChamados.Size = new Size(232, 59);
            btnChamados.TabIndex = 2;
            btnChamados.Text = "&Chamados";
            btnChamados.UseVisualStyleBackColor = false;
            btnChamados.Click += btnChamados_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 369);
            Controls.Add(sideBar);
            Controls.Add(panel4);
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel4;
        private Label lblTitulo;
        private FlowLayoutPanel sideBar;
        private Panel panel1;
        private Button btnHome;
        private Panel panel2;
        private Button btnOmegaHelp;
        private Panel panel3;
        private Button btnChamados;
        private PictureBox pictureBox1;
    }
}