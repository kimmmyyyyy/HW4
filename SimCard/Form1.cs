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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open an Image File";
            dialog.Filter = "Image Files | *.jpg;*.jpeg;*.png";
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            Form2 frm2 = new Form2(pictureBox1.Image,textBox1, textBox2, comboBox1, dateTimePicker1, textBox3, gender, maskedTextBox1);
            frm2.Show();
        }



    }
}
