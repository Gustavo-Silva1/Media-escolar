using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_media_escolar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {

                double n1, n2, n3, media;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                n3 = Convert.ToDouble(textBox3.Text);
                media = (n1 + n2 + n3) / 3;
                textBox4.Text = media.ToString();
            }
        
             catch
            {

                MessageBox.Show("Use somente valores numéricos, caso o aluno não tenha nota digite:  0" , "Media Escolar",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
