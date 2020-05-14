using Questioner;
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
    public partial class Core : Form
    {
        string NAMA, NIM;
        int[] number;
        int i = 0;
        int score = 0;

        public Core(string nama, string nim)
        {
            NAMA = nama;
            NIM = nim;
            InitializeComponent();
            isiData();
            Soal();
        }

        private void Soal()
        {
            this.jawaban1.Checked = false;
            this.jawaban2.Checked = false;
            this.jawaban3.Checked = false;
            if (number[i] == 1)
            {
                this.soal.Text = "Siapakah koordinator Praktikum DKP 2020 ?";
                this.jawaban1.Text = "Daromy Darojat";
                this.jawaban2.Text = "Tangguh Tri Prasetyo";
                this.jawaban3.Text = "Alvin Zulham Firdananta";


            }
            else if (number[i] == 2)
            {
                this.soal.Text = "Bahasa Pemrograman apa saja yang digunakan pada Praktikum DKP 2020?";
                this.jawaban1.Text = "Python, Java, PHP, C#";
                this.jawaban2.Text = "C#, Python, Javascript, PHP";
                this.jawaban3.Text = "HTML, C++, Java, Kotlin";

            }
            else if (number[i] == 3)
            {
                this.soal.Text = "Aplikasi apa yang digunakan untuk menuliskan bahasa pemrograma C# yang dianjurkan oleh Asisten Praktikum pada Praktikum DKP 2020 ?";
                this.jawaban1.Text = "Visual Studio Code";
                this.jawaban2.Text = "Microsoft Visual Studio";
                this.jawaban3.Text = "Notepad++";

            }
            else if (number[i] == 4)
            {
                this.soal.Text = "System.out.println merupakan salah satu perintah yang ada di bahasa pemrograman...";
                this.jawaban1.Text = "Python";
                this.jawaban2.Text = "C#";
                this.jawaban3.Text = "Java";

            }
            else if (number[i] == 5)
            {
                this.soal.Text = "Apa saja jenis perulangan yang biasa digunakan dalam programming pada umumnya"; ;
                this.jawaban1.Text = "For, While, Do while";
                this.jawaban2.Text = "For, if else, Setter";
                this.jawaban3.Text = "Class, While, WPF ";

            }
            else if (number[i] == 6)
            {
                this.soal.Text = "Materi apa yang terdapat pada Modul 4 Praktikum DKP 2020 ?";
                this.jawaban1.Text = "Setter and Getter";
                this.jawaban2.Text = "Array, Variable, Tipe Data";
                this.jawaban3.Text = "Function and Method";

            }
            else if (number[i] == 7)
            {
                this.soal.Text = "'salah satu sistem pengontrol versi (Version Control System) pada proyek perangkat lunak yang diciptakan oleh Linus Torvalds' Merupakan pengertian dari...";
                this.jawaban1.Text = "Setter";
                this.jawaban2.Text = "Git";
                this.jawaban3.Text = "GUI";

            }
            else if (number[i] == 8)
            {
                this.soal.Text = "Siapakah Asisten Praktikum pada Modul 6 ?";
                this.jawaban1.Text = "Muhammad Hanif Atthariq dan Alvin Zulham Firdananta";
                this.jawaban2.Text = "Daniel Felix Nainggolan dan Firsta Adi Pradana";
                this.jawaban3.Text = "Tangguh Tri Prasetyo dan Erika Clara Simanjutak";

            }
            else if (number[i] == 9)
            {
                this.soal.Text = "Materi apa yang terdapat pada Modul 2 ?";
                this.jawaban1.Text = "Class and Constructor";
                this.jawaban2.Text = "Github";
                this.jawaban3.Text = "Pengkondisian";

            }
            else if (number[i] == 10)
            {
                this.soal.Text = "Apa nama GUI yang dapat digunakan pada Python pada Praktikum DKP 2020 ?";
                this.jawaban1.Text = "Sublime";
                this.jawaban2.Text = "Xamarin";
                this.jawaban3.Text = "IronPython";

            }
        }
        private void kunci()
        {
            if (number[i] == 1)
            {
                if (this.jawaban2.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 2)
            {
                if (this.jawaban1.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 3)
            {
                if (this.jawaban2.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 4)
            {
                if (this.jawaban3.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 5)
            {
                if (this.jawaban1.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 6)
            {
                if (this.jawaban3.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 7)
            {
                if (this.jawaban2.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 8)
            {
                if (this.jawaban1.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 9)
            {
                if (this.jawaban3.Checked)
                {
                    score = score + 20;
                }
            }
            else if (number[i] == 10)
            {
                if (this.jawaban3.Checked)
                {
                    score = score + 20;
                }
            }
        }
        private void isiData()
        {
            Data_acak ambil = new Data_acak();
            number = ambil.data();
        }

        private void nextbutton_MouseHover(object sender, EventArgs e)
        {
            
            if(i > 3)
            {
                this.nextbutton.BackgroundImage = global::TugasAkhir.Properties.Resources.donehowver;
            }
            else
            {
                this.nextbutton.BackgroundImage = global::TugasAkhir.Properties.Resources.nexthowver;
            }

        }
        private void nextbutton_MouseLeave(object sender, EventArgs e)
        {
            if (i > 3)
            {
                this.nextbutton.BackgroundImage = global::TugasAkhir.Properties.Resources.done;
            }
            else
            {
                this.nextbutton.BackgroundImage = global::TugasAkhir.Properties.Resources.next;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            kunci();
            i++;
            if (i == 5)
            {
                Result form3 = new Result(NAMA, NIM , score);
                form3.Show();
                this.Hide();
            }
            if (i > 3)
            {
                this.nextbutton.BackgroundImage = global::TugasAkhir.Properties.Resources.done;
            }

            Soal();
        }


    }
}
