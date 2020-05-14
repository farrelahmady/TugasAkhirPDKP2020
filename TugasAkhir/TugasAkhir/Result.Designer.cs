namespace TugasAkhir
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.Judul = new System.Windows.Forms.Panel();
            this.congrats = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.nim = new System.Windows.Forms.Label();
            this.yourscorelabel = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Panel();
            this.Reload = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.undip = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Judul
            // 
            this.Judul.BackColor = System.Drawing.Color.Transparent;
            this.Judul.BackgroundImage = global::TugasAkhir.Properties.Resources.TextJudul;
            resources.ApplyResources(this.Judul, "Judul");
            this.Judul.Name = "Judul";
            // 
            // congrats
            // 
            resources.ApplyResources(this.congrats, "congrats");
            this.congrats.BackColor = System.Drawing.Color.Transparent;
            this.congrats.Name = "congrats";
            // 
            // Nama
            // 
            this.Nama.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Nama, "Nama");
            this.Nama.Name = "Nama";
            // 
            // nim
            // 
            this.nim.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.nim, "nim");
            this.nim.Name = "nim";
            // 
            // yourscorelabel
            // 
            this.yourscorelabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.yourscorelabel, "yourscorelabel");
            this.yourscorelabel.Name = "yourscorelabel";
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Score, "Score");
            this.Score.Name = "Score";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::TugasAkhir.Properties.Resources.exit;
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Name = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.Transparent;
            this.Reload.BackgroundImage = global::TugasAkhir.Properties.Resources.Reload;
            resources.ApplyResources(this.Reload, "Reload");
            this.Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload.Name = "Reload";
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // undip
            // 
            this.undip.BackColor = System.Drawing.Color.Transparent;
            this.undip.BackgroundImage = global::TugasAkhir.Properties.Resources.Logo_Undip;
            resources.ApplyResources(this.undip, "undip");
            this.undip.Name = "undip";
            // 
            // Result
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasAkhir.Properties.Resources.BackGround2;
            this.Controls.Add(this.undip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.yourscorelabel);
            this.Controls.Add(this.nim);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.congrats);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.Score);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Judul;
        private System.Windows.Forms.Label congrats;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label nim;
        private System.Windows.Forms.Label yourscorelabel;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.Panel Reload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel undip;
    }
}