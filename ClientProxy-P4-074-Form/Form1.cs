using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_074_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soal_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(1, 2);
            tambah.Text = "1 + 2";
            jawaban1.Text = hasilTambah.ToString();
            double hasilKurang = obj.Kurang(3, 2);
            kurang.Text = "3 - 2";
            jawaban2.Text = hasilKurang.ToString();
            double hasilKali = obj.Kali(2, 2);
            kali.Text = "2 x 2";
            jawaban3.Text = hasilKali.ToString();
            double hasilBagi = obj.Bagi(2, 2);
            bagi.Text = "2 : 2";
            jawaban4.Text = hasilBagi.ToString();

            ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();
            a.X = 7;
            a.Y = 8;

            b.X = 5;
            b.Y = 6;
            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));
            //Console.WriteLine("Hasil Koordinat " + jarak);
            //Console.ReadLine();
            koor.Text = "Hasil koordinat";
            jawaban5.Text = jarak.ToString();
        }
    }
}
