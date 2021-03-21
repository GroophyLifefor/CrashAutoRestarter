using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CrashAutoRestarter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName(textBox1.Text);  //if server.exe running
            if (pname.Length > 0)
            {
                label1.Text = ("Server Status = " + "up");
                label2.Text = ("Auto Status = " + "not work");
            }
            else
            {
                label1.Text = ("Server Status = " + "down");
                label2.Text = ("Auto Status = " + "not work");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                
                timer1.Enabled = true; //open button
                timer1.Interval = 200;
                label2.Text = ("Auto Status = " + "working");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bruh
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            Process[] pname = Process.GetProcessesByName(textBox1.Text);  //if server.exe running
            if (pname.Length > 0)
            {
                label1.Text = ("Server Status = " + "up");
                
            }
            else
            {
                label1.Text = ("Server Status = " + "down");
                System.Diagnostics.Process.Start(@textBox2.Text + "/" + textBox1.Text);  //start server.exe
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;  //stop button
            label2.Text = ("Auto Status = " + "stopped");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //huh
        }
    }
}