using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fake_Syskey
{
    public partial class Form2 : Form
    {
        private object radioButon1;

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            radioButton2.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            radioButton3.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
       }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 settingsForm = new Form3();
            settingsForm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            radioButton2.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            radioButton3.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
        }
    }
}
