namespace FKYS
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btn_Istatistikler = new System.Windows.Forms.Button();
            this.btnFilmler = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Controls.Add(this.btn_Istatistikler);
            this.panel1.Controls.Add(this.btnFilmler);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 556);
            this.panel1.TabIndex = 0;
            // 
            // btnProfil
            // 
            this.btnProfil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Image = global::FKYS.Properties.Resources.user_s;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(29, 316);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(136, 40);
            this.btnProfil.TabIndex = 2;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btn_Istatistikler
            // 
            this.btn_Istatistikler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Istatistikler.FlatAppearance.BorderSize = 0;
            this.btn_Istatistikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Istatistikler.Image = global::FKYS.Properties.Resources.graph;
            this.btn_Istatistikler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Istatistikler.Location = new System.Drawing.Point(29, 260);
            this.btn_Istatistikler.Name = "btn_Istatistikler";
            this.btn_Istatistikler.Size = new System.Drawing.Size(136, 40);
            this.btn_Istatistikler.TabIndex = 1;
            this.btn_Istatistikler.Text = "İstatistikler";
            this.btn_Istatistikler.UseVisualStyleBackColor = true;
            this.btn_Istatistikler.Click += new System.EventHandler(this.btn_Istatistikler_Click);
            // 
            // btnFilmler
            // 
            this.btnFilmler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFilmler.FlatAppearance.BorderSize = 0;
            this.btnFilmler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmler.Image = global::FKYS.Properties.Resources.cinema;
            this.btnFilmler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmler.Location = new System.Drawing.Point(29, 214);
            this.btnFilmler.Name = "btnFilmler";
            this.btnFilmler.Size = new System.Drawing.Size(136, 40);
            this.btnFilmler.TabIndex = 0;
            this.btnFilmler.Text = "Filmler";
            this.btnFilmler.UseVisualStyleBackColor = true;
            this.btnFilmler.Click += new System.EventHandler(this.btnFilmler_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslik.Location = new System.Drawing.Point(12, 101);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(147, 80);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Film Kütüphanesi Yönetim Sistemi";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FKYS.Properties.Resources.movie;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 42);
            this.panel2.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(17, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 15);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "label2";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnExit.BackgroundImage = global::FKYS.Properties.Resources.close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(794, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(165, 42);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(830, 514);
            this.ControlPanel.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 556);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnExit;
        private Panel ControlPanel;
        private Button btnFilmler;
        private Label lblBaslik;
        private PictureBox pictureBox1;
        private Button btn_Istatistikler;
        private Label lblUser;
        private Button btnProfil;
    }
}