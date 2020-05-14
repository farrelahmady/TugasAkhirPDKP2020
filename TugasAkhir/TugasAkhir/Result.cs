using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir
{
    public partial class Result : Form
    {
        string NAMA, NIM, SCORE;

        private void Reload_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            this.Close();
            form1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Result(string nama, string nim, int score)
        {
            NAMA = nama;
            NIM = nim;
            SCORE = score.ToString();
            InitializeComponent();
            this.Nama.Text = NAMA;
            this.nim.Text = "(" + NIM + ")";
            this.Score.Text = SCORE;
        }
    }
}
