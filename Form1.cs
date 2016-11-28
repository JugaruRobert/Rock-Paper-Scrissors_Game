using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
        public class Global
        {
            public static int i = 0;
            public static int j = 0;
            public static string str;
            public static string str2;

        }
        private void f_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            p.Visible = false;
            f.Visible = false;
            h.Visible = false;
            p2.Visible = false;
            f2.Visible = false;
            h2.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            Global.str = Global.i.ToString();
            label5.Text = Global.str;
            Global.str2 = Global.j.ToString();
            label6.Text = Global.str2;
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            p.Visible = true;
            f.Visible = false;
            h.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            int rnd = r.Next(1, 4);
            if (rnd == 1)
                p2.Visible = true;
            if (rnd == 2)
                f2.Visible = true;
            if (rnd == 3)
                h2.Visible = true;

            if (p2.Visible == true)
            {
                label8.Visible = true;
                label16.Visible = true;
            }

            
            if ( h2.Visible == true)
            {
                label3.Visible = true;
                Global.j++;
                Global.str2 = Global.j.ToString();
                label6.Text = Global.str2;
                label15.Visible = true;
            }

            if ( f2.Visible == true)
            {
                label7.Visible = true;
                Global.i++;
                Global.str = Global.i.ToString();
                label5.Text = Global.str;
                label14.Visible = true;
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            p.Visible = false;
            f.Visible = true;
            h.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            int rnd = r.Next(1, 4);
            if (rnd == 1)
                p2.Visible = true;
            if (rnd == 2)
                f2.Visible = true;
            if (rnd == 3)
                h2.Visible = true;

            if (f2.Visible == true)
            {
                label8.Visible = true;
                label16.Visible = true;
            }
            if (p2.Visible == true)
            {
                label10.Visible = true;
                Global.j++;
                Global.str2 = Global.j.ToString();
                label6.Text = Global.str2;
                label15.Visible = true;
            }

            if (h2.Visible == true)
            {
                label11.Visible = true;
                Global.i++;
                Global.str = Global.i.ToString();
                label5.Text = Global.str;
                label14.Visible = true;
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            p.Visible = false;
            f.Visible = false;
            h.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            int rnd = r.Next(1, 4);
            if (rnd == 1)
                p2.Visible = true;
            if (rnd == 2)
                f2.Visible = true;
            if (rnd == 3)
                h2.Visible = true;
            if (h2.Visible == true)
            {
                label8.Visible = true;
                label16.Visible = true;
            }
            if (f2.Visible == true)
            {
                label12.Visible = true;
                Global.j++;
                Global.str2 = Global.j.ToString();
                label6.Text = Global.str2;
                label15.Visible = true;
            }

            if (p2.Visible == true)
            {
                label13.Visible = true;
                Global.i++;
                Global.str = Global.i.ToString();
                label5.Text = Global.str;
                label14.Visible = true;
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            p.Visible = false;
            f.Visible = false;
            h.Visible = false;
            p2.Visible = false;
            f2.Visible = false;
            h2.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.Visible = false;
            f.Visible = false;
            h.Visible = false;
            p2.Visible = false;
            f2.Visible = false;
            h2.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            Global.i = 0;
            Global.j = 0;
            Global.str = Global.i.ToString();
            label5.Text = Global.str;
            Global.str2 = Global.j.ToString();
            label6.Text = Global.str2;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
