using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eqqq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            int x = Convert.ToInt32(textBox1.Text);
            try
            {
            double y = (2 * x - 7) / Math.Sqrt(3 * x + 21);
            textBox5.Text = y.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Processing failed: {ex.Message}");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            int x = Convert.ToInt32(textBox4.Text);
            try
            {
            double y1 = (2 * x - 7) / Math.Sqrt(3 * x + 21);
            textBox8.Text = y1.ToString();
            double y2 = Math.Sqrt(x / (x - 1));
            textBox9.Text = y2.ToString();
            double y3 = ((x + 1) / (x - 1)) + Math.Sqrt(Math.Pow(x, 2));
            textBox10.Text = y3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Processing failed: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            int x = Convert.ToInt32(textBox2.Text);
            try
            {
            double y = Math.Sqrt(x/(x-1));
            textBox6.Text = y.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Processing failed: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            int x = Convert.ToInt32(textBox3.Text);
            try
            {
            double y = ((x+1)/(x-1))+Math.Sqrt(Math.Pow(x,2));
            textBox7.Text = y.ToString();   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Processing failed: {ex.Message}");
            }
        }
    }
}
