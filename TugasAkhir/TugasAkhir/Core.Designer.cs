namespace TugasAkhir
{
    partial class Core
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
            this.judul = new System.Windows.Forms.Panel();
            this.panelsoal = new System.Windows.Forms.Panel();
            this.soal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jawaban3 = new System.Windows.Forms.RadioButton();
            this.jawaban2 = new System.Windows.Forms.RadioButton();
            this.jawaban1 = new System.Windows.Forms.RadioButton();
            this.nextbutton = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Panel();
            this.undip = new System.Windows.Forms.Panel();
            this.panelsoal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.BackColor = System.Drawing.Color.Transparent;
            this.judul.BackgroundImage = global::TugasAkhir.Properties.Resources.TextJudul;
            this.judul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.judul.Location = new System.Drawing.Point(429, 12);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(212, 129);
            this.judul.TabIndex = 0;
            // 
            // panelsoal
            // 
            this.panelsoal.BackColor = System.Drawing.Color.Transparent;
            this.panelsoal.BackgroundImage = global::TugasAkhir.Properties.Resources.Soal;
            this.panelsoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsoal.Controls.Add(this.soal);
            this.panelsoal.Location = new System.Drawing.Point(116, 158);
            this.panelsoal.Name = "panelsoal";
            this.panelsoal.Size = new System.Drawing.Size(832, 132);
            this.panelsoal.TabIndex = 1;
            // 
            // soal
            // 
            this.soal.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soal.ForeColor = System.Drawing.Color.LimeGreen;
            this.soal.Location = new System.Drawing.Point(22, 21);
            this.soal.Name = "soal";
            this.soal.Size = new System.Drawing.Size(790, 91);
            this.soal.TabIndex = 0;
            this.soal.Text = "Soal";
            this.soal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TugasAkhir.Properties.Resources.Jawaban3text;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.jawaban3);
            this.panel1.Controls.Add(this.jawaban2);
            this.panel1.Controls.Add(this.jawaban1);
            this.panel1.Location = new System.Drawing.Point(116, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 162);
            this.panel1.TabIndex = 2;
            // 
            // jawaban3
            // 
            this.jawaban3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jawaban3.Location = new System.Drawing.Point(17, 119);
            this.jawaban3.Name = "jawaban3";
            this.jawaban3.Size = new System.Drawing.Size(795, 37);
            this.jawaban3.TabIndex = 2;
            this.jawaban3.TabStop = true;
            this.jawaban3.Text = "jawaban3";
            this.jawaban3.UseVisualStyleBackColor = true;
            // 
            // jawaban2
            // 
            this.jawaban2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jawaban2.Location = new System.Drawing.Point(17, 63);
            this.jawaban2.Name = "jawaban2";
            this.jawaban2.Size = new System.Drawing.Size(795, 37);
            this.jawaban2.TabIndex = 1;
            this.jawaban2.TabStop = true;
            this.jawaban2.Text = "jawaban2";
            this.jawaban2.UseVisualStyleBackColor = true;
            // 
            // jawaban1
            // 
            this.jawaban1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jawaban1.Location = new System.Drawing.Point(17, 7);
            this.jawaban1.Name = "jawaban1";
            this.jawaban1.Size = new System.Drawing.Size(795, 37);
            this.jawaban1.TabIndex = 0;
            this.jawaban1.TabStop = true;
            this.jawaban1.Text = "jawaban1";
            this.jawaban1.UseVisualStyleBackColor = true;
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.Color.Transparent;
            this.nextbutton.BackgroundImage = global::TugasAkhir.Properties.Resources.next;
            this.nextbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbutton.Location = new System.Drawing.Point(410, 498);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(247, 58);
            this.nextbutton.TabIndex = 3;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            this.nextbutton.MouseLeave += new System.EventHandler(this.nextbutton_MouseLeave);
            this.nextbutton.MouseHover += new System.EventHandler(this.nextbutton_MouseHover);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::TugasAkhir.Properties.Resources.exit;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(1027, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 7;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // undip
            // 
            this.undip.BackColor = System.Drawing.Color.Transparent;
            this.undip.BackgroundImage = global::TugasAkhir.Properties.Resources.Logo_Undip;
            this.undip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undip.Location = new System.Drawing.Point(997, 493);
            this.undip.Name = "undip";
            this.undip.Size = new System.Drawing.Size(55, 63);
            this.undip.TabIndex = 12;
            // 
            // Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasAkhir.Properties.Resources.BGLandscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 568);
            this.Controls.Add(this.undip);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelsoal);
            this.Controls.Add(this.judul);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Core";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Core";
            this.panelsoal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel judul;
        private System.Windows.Forms.Panel panelsoal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton jawaban3;
        private System.Windows.Forms.RadioButton jawaban2;
        private System.Windows.Forms.RadioButton jawaban1;
        private System.Windows.Forms.Label soal;
        private System.Windows.Forms.Panel nextbutton;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.Panel undip;
    }
}