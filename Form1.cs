using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int s1, s2, s3, s4, s5;
            s1 = rd.Next(10, 50);
            s2 = rd.Next(80, 90);
            s3 = rd.Next(10, 80);
            s4 = rd.Next(50, 930);
            s5 = rd.Next(82, 422);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            label5.Text = s5.ToString();
        }
    }
}
