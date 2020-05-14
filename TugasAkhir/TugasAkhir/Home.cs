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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void StartButton_MouseHover(object sender, EventArgs e)
        {
            this.Start.BackgroundImage = global::TugasAkhir.Properties.Resources.StartButton2;
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            this.Start.BackgroundImage = global::TugasAkhir.Properties.Resources.StartButton1;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string nama, nim;
            nama = this.textboxNama.Text;
            nim = this.textboxNIM.Text;
            bool anyname = nim.All(char.IsDigit);
            if (this.textboxNama.Text == "" || this.textboxNIM.Text == "")
            {
                MessageBox.Show("Nama dan NIM harus diisi !");
            }
            else if (anyname == false)
            {
                MessageBox.Show("Saya yakin NIM anda harusnya berupa angka !");
            }
            else
            {
                Core form2 = new Core(nama, nim);
                form2.Show();
                this.Hide();
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
