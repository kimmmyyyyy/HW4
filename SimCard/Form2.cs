using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCard
{
    public partial class Form2 : Form
    {
        private Image img;
        private TextBox t1;
        private TextBox t2;
        private ComboBox c1;
        private DateTimePicker d1;
        private TextBox t3;
        private MaskedTextBox m1;
        private string gender;

        public Form2(Image p1, TextBox p2, TextBox p3, ComboBox p4, DateTimePicker p5, TextBox p6, string g1, MaskedTextBox p9)
        {
            InitializeComponent();
            img = p1;
            t1 = p2;
            t2 = p3;
            c1 = p4;
            d1 = p5;
            t3 = p6;
            m1 = p9;
            gender = g1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
            textBox1.Text = t1.Text;
            textBox2.Text = t2.Text;
            comboBox1.Text = c1.Text;
            dateTimePicker1.Value = d1.Value;
            textBox3.Text = t3.Text;
            maskedTextBox1.Text = m1.Text;
            if(gender == "Male")
            {
                radioButton1.Checked = true;
            }
            else if(gender == "Female")
            {
                radioButton2.Checked = true;
            }
            radioButton1.AutoCheck = false;
            radioButton2.AutoCheck = false;

            dateTimePicker1.Enabled = false;

             Form1 frm1 = new Form1();
            frm1.Close();
        }
    }
}
