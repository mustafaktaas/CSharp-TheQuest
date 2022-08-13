using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuestAlgoProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (label1.Visible)
                    label1.Visible = false;
                else
                    label1.Visible = true;
            }
        }
    }
}
