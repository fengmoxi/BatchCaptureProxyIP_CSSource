using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 批量获取代理IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                textBox1.Text = "100";
            }
            richTextBox1.Text = "正在从接口1获取代理IP，请稍后···";
            var wc = new WebClient();
            var url = "http://www.52sdl.com/api.php?count=" + textBox1.Text + "&prot=" + textBox2.Text + "&yys=" + textBox3.Text + "&pcity=" + textBox4.Text + "&part=" + textBox5.Text + "&br=&dk=";
            var html = wc.DownloadString(url);
            richTextBox1.Text = html;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = textBox1.Text.Length < 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = textBox2.Text.Length < 1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = textBox3.Text.Length < 1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = textBox4.Text.Length < 1;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = textBox5.Text.Length < 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            textBox4.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            textBox5.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                textBox1.Text = "100";
            } 
            richTextBox1.Text = "正在从接口2获取代理IP，请稍后···";
            var wc = new WebClient();
            var url = "http://www.52sdl.com/api.php?count=" + textBox1.Text + "&prot=" + textBox2.Text + "&yys=" + textBox3.Text + "&pcity=" + textBox4.Text + "&part=" + textBox5.Text + "&br=&dk=2";
            var html = wc.DownloadString(url);
            richTextBox1.Text = html;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, richTextBox1.Text);
        }
    }
}
