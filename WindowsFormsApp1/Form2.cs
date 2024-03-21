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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            label1.Text = a.Next(1, 7).ToString();           
            label1.Visible = true;
            Thread.Sleep(1000);
            label1.Visible = false;
            label2.Text = a.Next(1, 7).ToString();
            label2.Visible = true;







        }

      
    }
}
