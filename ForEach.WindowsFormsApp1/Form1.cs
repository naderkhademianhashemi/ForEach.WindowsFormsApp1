using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ForEach.WindowsFormsApp1
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

        private void Print(string obj)
        {
            MessageBox.Show(obj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var N = new List<string>();
            N.Add("Bruce");
            N.Add("Alfred");
            N.Add("Tim");
            N.Add("Richard");

            N.ForEach(Print);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var N = new List<string>();
            N.Add("Bruce");
            N.Add("Alfred");
            N.Add("Tim");
            N.Add("Richard");
            N.ForEach(name => MessageBox.Show(name));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var N = new List<string>();
            N.Add("Bruce");
            N.Add("Alfred");
            N.Add("Tim");
            N.Add("Richard");
            N.ForEach(delegate (string name)
            {
                MessageBox.Show(name);
            });


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var N = new List<string>();
            N.Add("Bruce");
            N.Add("Alfred");
            N.Add("Tim");
            N.Add("Richard");

            foreach (var item in N)
            {
                MessageBox.Show(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var N = new List<string>();
            N.Add("Bruce");
            N.Add("Alfred");
            N.Add("Tim");
            N.Add("Richard");

            for (int i = 0; i < N.Count; i++)
            {
                MessageBox.Show(N[i]);
            }
        }
    }
}
