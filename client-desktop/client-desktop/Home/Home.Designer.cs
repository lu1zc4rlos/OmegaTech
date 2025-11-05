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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            sideBar = new FlowLayoutPanel();
            btn_chamados = new Button();
            btn_chatbot = new Button();
            pn_title = new Panel();
            pictureBox1 = new PictureBox();
            lbl_titulo = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new Label();
            btn_sidebar = new PictureBox();
            SideBarTransition = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sideBar.SuspendLayout();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_sidebar).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sideBar.BackColor = Color.FromArgb(60, 62, 110);
            sideBar.Controls.Add(btn_chamados);
            sideBar.Controls.Add(btn_chatbot);
            sideBar.FlowDirection = FlowDirection.TopDown;
            sideBar.Location = new Point(1, 102);
            sideBar.Margin = new Padding(3, 4, 3, 4);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(263, 695);
            sideBar.TabIndex = 2;
            // 
            // btn_chamados
            // 
            btn_chamados.BackColor = Color.FromArgb(60, 62, 110);
            btn_chamados.FlatAppearance.BorderSize = 0;
            btn_chamados.FlatStyle = FlatStyle.Flat;
            btn_chamados.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_chamados.ForeColor = Color.White;
            btn_chamados.ImageAlign = ContentAlignment.MiddleLeft;
            btn_chamados.ImeMode = ImeMode.NoControl;
            btn_chamados.Location = new Point(3, 4);
            btn_chamados.Margin = new Padding(3, 4, 3, 4);
            btn_chamados.Name = "btn_chamados";
            btn_chamados.Padding = new Padding(25, 0, 0, 0);
            btn_chamados.Size = new Size(274, 95);
            btn_chamados.TabIndex = 1;
            btn_chamados.Text = "             Chamados";
            btn_chamados.TextAlign = ContentAlignment.MiddleLeft;
            btn_chamados.UseVisualStyleBackColor = false;
            btn_chamados.Click += btn_chamados_Click;
            // 
            // btn_chatbot
            // 
            btn_chatbot.Anchor = AnchorStyles.Top;
            btn_chatbot.BackColor = Color.FromArgb(60, 62, 110);
            btn_chatbot.FlatAppearance.BorderSize = 0;
            btn_chatbot.FlatStyle = FlatStyle.Flat;
            btn_chatbot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_chatbot.ForeColor = Color.White;
            btn_chatbot.ImageAlign = ContentAlignment.MiddleLeft;
            btn_chatbot.ImeMode = ImeMode.NoControl;
            btn_chatbot.Location = new Point(3, 107);
            btn_chatbot.Margin = new Padding(3, 4, 3, 4);
            btn_chatbot.Name = "btn_chatbot";
            btn_chatbot.Padding = new Padding(25, 0, 0, 0);
            btn_chatbot.Size = new Size(274, 95);
            btn_chatbot.TabIndex = 2;
            btn_chatbot.Text = "             OmegaHelp";
            btn_chatbot.TextAlign = ContentAlignment.MiddleLeft;
            btn_chatbot.UseVisualStyleBackColor = false;
            btn_chatbot.Click += btn_chatbot_Click;
            // 
            // pn_title
            // 
            pn_title.Anchor = AnchorStyles.Top;
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(pictureBox1);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(nightControlBox1);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Controls.Add(btn_sidebar);
            pn_title.Location = new Point(1, 1);
            pn_title.Margin = new Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1000, 99);
            pn_title.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(70, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.None;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(542, 28);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(96, 37);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "HOME";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(861, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(144, 28);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(119, 28);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // btn_sidebar
            // 
            btn_sidebar.Image = (Image)resources.GetObject("btn_sidebar.Image");
            btn_sidebar.ImeMode = ImeMode.NoControl;
            btn_sidebar.Location = new Point(10, 20);
            btn_sidebar.Margin = new Padding(3, 4, 3, 4);
            btn_sidebar.Name = "btn_sidebar";
            btn_sidebar.Size = new Size(38, 36);
            btn_sidebar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_sidebar.TabIndex = 0;
            btn_sidebar.TabStop = false;
            btn_sidebar.Click += btn_sidebar_Click;
            // 
            // SideBarTransition
            // 
            SideBarTransition.Interval = 20;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 102, 140);
            ClientSize = new Size(1000, 800);
            Controls.Add(pn_title);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            sideBar.ResumeLayout(false);
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_sidebar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBar;
        private Button btn_chamados;
        private Button btn_chatbot;
        private Panel pn_title;
        private PictureBox pictureBox1;
        private Label lbl_titulo;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label lbl_omega;
        private PictureBox btn_sidebar;
        private System.Windows.Forms.Timer SideBarTransition;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}