namespace FKYS.Model
{
    partial class ucFilm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.pBox_FilmImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_FilmImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pBox_FilmImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFilmName);
            this.panel2.Controls.Add(this.lblPuan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 74);
            this.panel2.TabIndex = 3;
            // 
            // lblFilmName
            // 
            this.lblFilmName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilmName.Location = new System.Drawing.Point(59, 20);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(51, 21);
            this.lblFilmName.TabIndex = 1;
            this.lblFilmName.Text = "label1";
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuan
            // 
            this.lblPuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(65, 42);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(38, 15);
            this.lblPuan.TabIndex = 2;
            this.lblPuan.Text = "label1";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBox_FilmImage
            // 
            this.pBox_FilmImage.Image = global::FKYS.Properties.Resources.up;
            this.pBox_FilmImage.Location = new System.Drawing.Point(0, 0);
            this.pBox_FilmImage.Name = "pBox_FilmImage";
            this.pBox_FilmImage.Size = new System.Drawing.Size(179, 260);
            this.pBox_FilmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_FilmImage.TabIndex = 0;
            this.pBox_FilmImage.TabStop = false;
            this.pBox_FilmImage.Click += new System.EventHandler(this.pBox_FilmImage_Click);
            // 
            // ucFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Name = "ucFilm";
            this.Size = new System.Drawing.Size(179, 340);
            this.Click += new System.EventHandler(this.ucFilm_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_FilmImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblFilmName;
        private PictureBox pBox_FilmImage;
        private Label lblPuan;
        private Panel panel2;
    }
}
