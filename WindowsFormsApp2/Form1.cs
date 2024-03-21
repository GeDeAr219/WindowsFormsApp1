using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Kullanılacak sayılar
        private Random random = new Random(); // Rastgele sayı üretmek için Random sınıfı kullanılır
        private int spinCount = 0; // Döndürme sayısını takip etmek için bir değişken kullanılır

        public Form1()
        {
            InitializeComponent();
        }

        // Slot makinesi döndürme işlemini gerçekleştirir
        private void Spin()
        {
            spinCount++;

            // Resimleri değiştirecek yerde, sayıları değiştirin
            label1.Text = numbers[random.Next(numbers.Length)].ToString();
            label2.Text = numbers[random.Next(numbers.Length)].ToString();
            label3.Text = numbers[random.Next(numbers.Length)].ToString();

            if (spinCount == 5) // 5 kez döndürdükten sonra
            {
                spinCount = 0;
                tmrSpin.Enabled = false; // Döndürme işlemi durdurulur
                CheckResult(); // Sonuç kontrolü yapılır
            }
        }

       
     

        // Döndürme işlemi devam ederken Spin() metodu çağrılır
        private void tmrSpin_Tick(object sender, EventArgs e)
        {
            Spin();
        }

        // Sonuç kontrolü yapılır
        private void CheckResult()
        {
            if (label1.Text == label2.Text && label2.Text == label3.Text)
            {
                MessageBox.Show("Kazandınız!");
            }
            else
            {
                MessageBox.Show("Kaybettiniz!");
            }
        }
        // Döndürme işlemi başlatılır
        private void btn_Spin_Click(object sender, EventArgs e)
        {
            tmrSpin.Enabled = true; // Döndürme işlemi başlatılır
            spinCount = 0; // Döndürme sayısı sıfırlanır
        }
    }
}
