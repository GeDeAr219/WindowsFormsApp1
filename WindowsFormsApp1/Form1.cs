using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Random rand = new Random();
        public int spin = 0;
        public int cüzdan = 5000;

        public string r1,r2,r3,r4,r5;
        

        public Form1()
        {
            InitializeComponent();
        }
        private void spint()
        {
            
            spin++;

            r1 = GetRandomImage(rand);
            r2 = GetRandomImage(rand);
            r3 = GetRandomImage(rand);
            r4 = GetRandomImage(rand);
            r5 = GetRandomImage(rand);

            resim1.Image = Image.FromFile(r1);
            resim2.Image = Image.FromFile(r2);
            resim3.Image = Image.FromFile(r3);
            resim4.Image = Image.FromFile(r4);
            resim5.Image = Image.FromFile(r5);
            if (spin == 10 )
            {
                spin = 0;
                timer1.Enabled = false;
                CheckResult();
            }
            if (cüzdan == 0)
            {
                MessageBox.Show("paranız kalmamıştır");
                this.Hide();
            }

        }
        
        private string GetRandomImage(Random rand)
        {
            // Resimlerin bulunduğu klasörün yolunu belirtin
            string path = "C:\\Users\\ardic\\OneDrive\\Masaüstü\\sloth makinesi\\WindowsFormsApp1\\images";
            string[] files = Directory.GetFiles(path, "*.jpg");

            // Rastgele bir resim seçin
            string file = files[rand.Next(files.Length)];
            return file;

        }

           
        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Döndürme işlemi başlatılır
            spin= 0; // Döndürme sayısı sıfırlanır
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spint();
        }

        private void CheckResult()
        {
            if (r1==r2 && r2==r3 &&r3==r4 &&r4==r5)
            {
                MessageBox.Show("kazandınız");
                cüzdan += 1000;
                label2.Text = $"{cüzdan}";
            }
            
            else 
            { 
                MessageBox.Show("kaybettiniz");
                cüzdan-=100;
                label2.Text = $"{cüzdan}";


            }
        }

        private void resim5_Click(object sender, EventArgs e)
        {

        }
    }
}
