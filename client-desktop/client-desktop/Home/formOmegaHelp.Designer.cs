namespace client_desktop.Home
{
    partial class formOmegaHelp
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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pn_title = new Panel();
            button4 = new Button();
            lbl_titulo = new Label();
            pictureBox2 = new PictureBox();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new Label();
            txtEnviarMensagem = new TextBox();
            btnEnviar = new Button();
            flowLayoutPanelChat = new FlowLayoutPanel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            nightControlBox1.Location = new Point(752, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 20;
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(button4);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox2);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(0, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(875, 74);
            pn_title.TabIndex = 3;
            pn_title.Paint += pn_title_Paint;
            // 
            // button4
            // 
            pic_home.Location = new Point(10, 16);
            pic_home.Name = "pic_home";
            pic_home.Size = new Size(38, 37);
            pic_home.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_home.TabIndex = 0;
            pic_home.TabStop = false;
            pic_home.Click += pic_home_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.ImeMode = ImeMode.NoControl;
            lbl_titulo.Location = new Point(378, 22);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(132, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "OmegaHelp";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(68, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            nightControlBox2.Location = new Point(736, 0);
            nightControlBox2.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MaximizeHoverForeColor = Color.White;
            nightControlBox2.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MinimizeHoverForeColor = Color.White;
            nightControlBox2.Name = "nightControlBox2";
            nightControlBox2.Size = new Size(139, 31);
            nightControlBox2.TabIndex = 1;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_omega.ForeColor = Color.White;
            lbl_omega.ImeMode = ImeMode.NoControl;
            lbl_omega.Location = new Point(126, 22);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new Size(96, 21);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // txtEnviarMensagem
            // 
            txtEnviarMensagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEnviarMensagem.BackColor = Color.FromArgb(60, 62, 110);
            txtEnviarMensagem.BorderStyle = BorderStyle.None;
            txtEnviarMensagem.ForeColor = Color.White;
            txtEnviarMensagem.Location = new Point(10, 571);
            txtEnviarMensagem.Margin = new Padding(3, 2, 3, 2);
            txtEnviarMensagem.Multiline = true;
            txtEnviarMensagem.Name = "txtEnviarMensagem";
            txtEnviarMensagem.Size = new Size(761, 22);
            txtEnviarMensagem.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnviar.BackColor = Color.WhiteSmoke;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Location = new Point(776, 570);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(82, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelChat
            // 
            flowLayoutPanelChat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.BackColor = Color.FromArgb(100, 102, 140);
            flowLayoutPanelChat.Location = new Point(10, 80);
            flowLayoutPanelChat.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            flowLayoutPanelChat.Size = new Size(848, 486);
            flowLayoutPanelChat.TabIndex = 6;
            flowLayoutPanelChat.Paint += flowLayoutPanelChat_Paint;
            // 
            // formOmegaHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 102, 140);
            ClientSize = new Size(875, 600);
            Controls.Add(flowLayoutPanelChat);
            Controls.Add(btnEnviar);
            Controls.Add(txtEnviarMensagem);
            Controls.Add(pn_title);
            Controls.Add(nightControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formOmegaHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OmegaHelp";
            WindowState = FormWindowState.Maximized;
            Load += formOmegaHelp_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.TextBox txtEnviarMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChat;
        private Button button4;
    }
}