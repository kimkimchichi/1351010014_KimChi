using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1351010014_KimChi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btnAdd = new Button();
            btnAdd.Text = "Add";
            Button btnMul = new Button();
            btnMul.Text = "Multily";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
            }
        }
    }
}
