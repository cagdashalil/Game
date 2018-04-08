namespace oyun2
{
    partial class Form1
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
            this.rdDokuz = new System.Windows.Forms.RadioButton();
            this.rdSekiz = new System.Windows.Forms.RadioButton();
            this.rdYedi = new System.Windows.Forms.RadioButton();
            this.rdAlti = new System.Windows.Forms.RadioButton();
            this.rdBes = new System.Windows.Forms.RadioButton();
            this.gridAlan = new System.Windows.Forms.DataGridView();
            this.btnOyna = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rdDokuz
            // 
            this.rdDokuz.AutoSize = true;
            this.rdDokuz.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdDokuz.Location = new System.Drawing.Point(542, 59);
            this.rdDokuz.Name = "rdDokuz";
            this.rdDokuz.Size = new System.Drawing.Size(49, 21);
            this.rdDokuz.TabIndex = 7;
            this.rdDokuz.TabStop = true;
            this.rdDokuz.Text = "9*9";
            this.rdDokuz.UseVisualStyleBackColor = true;
            // 
            // rdSekiz
            // 
            this.rdSekiz.AutoSize = true;
            this.rdSekiz.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdSekiz.Location = new System.Drawing.Point(572, 36);
            this.rdSekiz.Name = "rdSekiz";
            this.rdSekiz.Size = new System.Drawing.Size(51, 21);
            this.rdSekiz.TabIndex = 8;
            this.rdSekiz.TabStop = true;
            this.rdSekiz.Text = "8*8";
            this.rdSekiz.UseVisualStyleBackColor = true;
            // 
            // rdYedi
            // 
            this.rdYedi.AutoSize = true;
            this.rdYedi.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdYedi.Location = new System.Drawing.Point(574, 12);
            this.rdYedi.Name = "rdYedi";
            this.rdYedi.Size = new System.Drawing.Size(49, 21);
            this.rdYedi.TabIndex = 9;
            this.rdYedi.TabStop = true;
            this.rdYedi.Text = "7*7";
            this.rdYedi.UseVisualStyleBackColor = true;
            // 
            // rdAlti
            // 
            this.rdAlti.AutoSize = true;
            this.rdAlti.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdAlti.Location = new System.Drawing.Point(508, 36);
            this.rdAlti.Name = "rdAlti";
            this.rdAlti.Size = new System.Drawing.Size(49, 21);
            this.rdAlti.TabIndex = 10;
            this.rdAlti.TabStop = true;
            this.rdAlti.Text = "6*6";
            this.rdAlti.UseVisualStyleBackColor = true;
            // 
            // rdBes
            // 
            this.rdBes.AutoSize = true;
            this.rdBes.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdBes.Location = new System.Drawing.Point(508, 12);
            this.rdBes.Name = "rdBes";
            this.rdBes.Size = new System.Drawing.Size(49, 21);
            this.rdBes.TabIndex = 11;
            this.rdBes.TabStop = true;
            this.rdBes.Text = "5*5";
            this.rdBes.UseVisualStyleBackColor = true;
            // 
            // gridAlan
            // 
            this.gridAlan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridAlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlan.ColumnHeadersVisible = false;
            this.gridAlan.Location = new System.Drawing.Point(12, 12);
            this.gridAlan.Name = "gridAlan";
            this.gridAlan.RowHeadersVisible = false;
            this.gridAlan.Size = new System.Drawing.Size(479, 395);
            this.gridAlan.TabIndex = 4;
            this.gridAlan.Click += new System.EventHandler(this.grdOyun_Click);
            // 
            // btnOyna
            // 
            this.btnOyna.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOyna.Location = new System.Drawing.Point(508, 86);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(119, 23);
            this.btnOyna.TabIndex = 12;
            this.btnOyna.Text = "OYUNA BAŞLA";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPuan.Location = new System.Drawing.Point(613, 136);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(0, 17);
            this.lblPuan.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::oyun2.Properties.Resources.gameOver;
            this.pictureBox1.Location = new System.Drawing.Point(40, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::oyun2.Properties.Resources.havaiFişek;
            this.pictureBox2.Location = new System.Drawing.Point(2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 474);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(499, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "HAMLE SAYISI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 456);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.rdDokuz);
            this.Controls.Add(this.rdSekiz);
            this.Controls.Add(this.rdYedi);
            this.Controls.Add(this.rdAlti);
            this.Controls.Add(this.rdBes);
            this.Controls.Add(this.gridAlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdDokuz;
        private System.Windows.Forms.RadioButton rdSekiz;
        private System.Windows.Forms.RadioButton rdYedi;
        private System.Windows.Forms.RadioButton rdAlti;
        private System.Windows.Forms.RadioButton rdBes;
        private System.Windows.Forms.DataGridView gridAlan;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

