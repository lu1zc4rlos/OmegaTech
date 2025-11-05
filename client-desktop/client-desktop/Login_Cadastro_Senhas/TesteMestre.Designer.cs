namespace client_desktop.Login_Cadastro_Senhas
{
    partial class TesteMestre
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
            crownMenuStrip1 = new ReaLTaiizor.Controls.CrownMenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            crownMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // crownMenuStrip1
            // 
            crownMenuStrip1.BackColor = Color.FromArgb(60, 63, 65);
            crownMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownMenuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            crownMenuStrip1.Location = new Point(0, 0);
            crownMenuStrip1.Name = "crownMenuStrip1";
            crownMenuStrip1.Padding = new Padding(3, 2, 0, 2);
            crownMenuStrip1.Size = new Size(800, 24);
            crownMenuStrip1.TabIndex = 3;
            crownMenuStrip1.Text = "crownMenuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            loginToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click_1;
            // 
            // TesteMestre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(crownMenuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = crownMenuStrip1;
            Name = "TesteMestre";
            Text = "TesteMestre";
            WindowState = FormWindowState.Maximized;
            Load += TesteMestre_Load;
            crownMenuStrip1.ResumeLayout(false);
            crownMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownMenuStrip crownMenuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
    }
}