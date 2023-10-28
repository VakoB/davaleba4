using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace დავალება4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            double side_1 = double.Parse(textBox1.Text);
            double side_2 = double.Parse(textBox2.Text);
            double side_3 = double.Parse(textBox3.Text);
            ChildClass childClass = new ChildClass(side_1, side_2, side_3);
            double fartobi = childClass.Partobi();
            double perimetri = childClass.Perimetri();
            label1.Text = "პერიმეტრი: " + perimetri + " ფართობი: " + fartobi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            double fudze = double.Parse(textBox6.Text);
            double simagle = double.Parse(textBox5.Text);
            Martkutxedi martkutxedi = new Martkutxedi(simagle, fudze);
            double result = martkutxedi.Partobi();
            label1.Text = "ფართობი: " + result.ToString();
        }
    }
}
