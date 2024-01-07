using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          listBox1.Items.Clear();

            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);

            int toplam, temp,i;             
            
            for (int a = s1; a <= s2; a++)
            {
                toplam = 0;
                int sayi = a;

                for (i = sayi; sayi != 0; sayi = sayi / 10)
                {
                    temp = sayi % 10;
                    toplam = toplam * 10 + temp;
                }

                if (i == toplam)                
                    listBox1.Items.Add(a);                
            }     
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
