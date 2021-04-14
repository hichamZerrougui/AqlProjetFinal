using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqlProjet_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formm1 = new Form2();
            formm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formm3 = new Form3();
            formm3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 formm4 = new Form4();
            formm4.ShowDialog();
        }
    }
}
