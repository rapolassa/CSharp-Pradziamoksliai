using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Langai
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (TextWriter sw = new StreamWriter("C:\\numeriai.txt"))
            {
                foreach (string item in listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            Process.Start("C:\\numeriai.txt");


        }
    }
}
