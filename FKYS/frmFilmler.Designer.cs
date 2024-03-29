namespace FKYS
{
    partial class frmFilmler
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
            this.txt_filmAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filmPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_filmEkle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_filmAra
            // 
            this.txt_filmAra.Location = new System.Drawing.Point(24, 35);
            this.txt_filmAra.Name = "txt_filmAra";
            this.txt_filmAra.PlaceholderText = "Aranacak Metin Girin";
            this.txt_filmAra.Size = new System.Drawing.Size(217, 23);
            this.txt_filmAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(257, 35);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(90, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aranacak Metin";
            // 
            // filmPanel
            // 
            this.filmPanel.AutoScroll = true;
            this.filmPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.filmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmPanel.Location = new System.Drawing.Point(0, 0);
            this.filmPanel.Name = "filmPanel";
            this.filmPanel.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.filmPanel.Size = new System.Drawing.Size(964, 450);
            this.filmPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_filmAra);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 77);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_filmEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(852, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 77);
            this.panel2.TabIndex = 6;
            // 
            // btn_filmEkle
            // 
            this.btn_filmEkle.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_filmEkle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_filmEkle.FlatAppearance.BorderSize = 0;
            this.btn_filmEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filmEkle.Image = global::FKYS.Properties.Resources.add;
            this.btn_filmEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filmEkle.Location = new System.Drawing.Point(0, 18);
            this.btn_filmEkle.Name = "btn_filmEkle";
            this.btn_filmEkle.Size = new System.Drawing.Size(100, 56);
            this.btn_filmEkle.TabIndex = 5;
            this.btn_filmEkle.Text = "Film Ekle";
            this.btn_filmEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filmEkle.UseVisualStyleBackColor = false;
            this.btn_filmEkle.Click += new System.EventHandler(this.btn_filmEkle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.filmPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 450);
            this.panel3.TabIndex = 7;
            // 
            // frmFilmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmFilmler";
            this.Text = "frmFilmler";
            this.Load += new System.EventHandler(this.frmFilmler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txt_filmAra;
        private Button btnAra;
        private Label label1;
        private Model.ucFilm ucFilm3;
        private Model.ucFilm ucFilm2;
        private Model.ucFilm ucFilm1;
        private FlowLayoutPanel filmPanel;
        private Panel panel1;
        private Button btn_filmEkle;
        private Panel panel2;
        private Panel panel3;
    }
}