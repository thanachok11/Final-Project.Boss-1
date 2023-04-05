using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Boss
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        public string price;
        public string code;
        public string pay; 
        public string money;
       
        private void Print_Load(object sender, EventArgs e)
        {
            textBox1.Text = price;
            textBox2.Text = code;
            textBox3.Text = pay;
            textBox4.Text = money;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
