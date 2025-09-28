namespace client_desktop.Home
{
    partial class Home
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pn_title = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_titulo = new System.Windows.Forms.Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new System.Windows.Forms.Label();
            btn_sidebar = new System.Windows.Forms.PictureBox();
            sideBar = new System.Windows.Forms.FlowLayoutPanel();
            btn_chamados = new System.Windows.Forms.Button();
            btn_chatbot = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SideBarTransition = new System.Windows.Forms.Timer(components);
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_sidebar).BeginInit();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            resources.ApplyResources(pn_title, "pn_title");
            pn_title.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(pictureBox1);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(nightControlBox1);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Controls.Add(btn_sidebar);
            pn_title.Name = "pn_title";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            resources.ApplyResources(lbl_titulo, "lbl_titulo");
            lbl_titulo.ForeColor = System.Drawing.Color.White;
            lbl_titulo.Name = "lbl_titulo";
            // 
            // nightControlBox1
            // 
            resources.ApplyResources(nightControlBox1, "nightControlBox1");
            nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.Name = "nightControlBox1";
            // 
            // lbl_omega
            // 
            resources.ApplyResources(lbl_omega, "lbl_omega");
            lbl_omega.ForeColor = System.Drawing.Color.White;
            lbl_omega.Name = "lbl_omega";
            // 
            // btn_sidebar
            // 
            resources.ApplyResources(btn_sidebar, "btn_sidebar");
            btn_sidebar.Name = "btn_sidebar";
            btn_sidebar.TabStop = false;
            btn_sidebar.Click += btn_sidebar_Click;
            // 
            // sideBar
            // 
            resources.ApplyResources(sideBar, "sideBar");
            sideBar.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            sideBar.Controls.Add(btn_chamados);
            sideBar.Controls.Add(btn_chatbot);
            sideBar.Name = "sideBar";
            // 
            // btn_chamados
            // 
            btn_chamados.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            btn_chamados.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_chamados, "btn_chamados");
            btn_chamados.ForeColor = System.Drawing.Color.White;
            btn_chamados.Name = "btn_chamados";
            btn_chamados.UseVisualStyleBackColor = false;
            btn_chamados.Click += btn_chamados_Click;
            // 
            // btn_chatbot
            // 
            btn_chatbot.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            btn_chatbot.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btn_chatbot, "btn_chatbot");
            btn_chatbot.ForeColor = System.Drawing.Color.White;
            btn_chatbot.Name = "btn_chatbot";
            btn_chatbot.UseVisualStyleBackColor = false;
            btn_chatbot.Click += btn_chatbot_Click;
            // 
            // SideBarTransition
            // 
            SideBarTransition.Interval = 20;
            SideBarTransition.Tick += SideBarTransition_Tick;
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(100, 102, 140);
            Controls.Add(pn_title);
            Controls.Add(sideBar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Home";
            Load += Home_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_sidebar).EndInit();
            sideBar.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.PictureBox btn_sidebar;
        private System.Windows.Forms.Label lbl_omega;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_chamados;
        private System.Windows.Forms.Button btn_chatbot;
        private System.Windows.Forms.Timer SideBarTransition;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}