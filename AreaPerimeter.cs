using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class AreaPerimeter : Form
    {
        public AreaPerimeter()
        {
            InitializeComponent();
        }
        int side1, side2, areaRectangle, perimeterRectangle;
        double radius, areaCircle, perimeterCircle;

        private void button1_Click(object sender, EventArgs e)
        {
            
            side1 = Convert.ToInt32(textBox1.Text);
            side2 = Convert.ToInt32(textBox2.Text);
            areaRectangle = side1 * side2;
            perimeterRectangle = 2 * (side1 + side2);
            label8.Text = areaRectangle.ToString() + " cm2";            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = perimeterRectangle.ToString() + " cm";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            radius = Convert.ToDouble(textBox3.Text);
            areaCircle = (double)(Math.PI * radius * radius);
            perimeterCircle = (double)(2 * Math.PI * radius);
            label10.Text = areaCircle.ToString("0.00") + " cm2";            
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            label11.Text = perimeterCircle.ToString("0.00") + " cm";
        }
    }
}
