using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Langai
{
    public partial class langas : Form
    {
        public langas()
        {
            InitializeComponent();
        }

       Form2 frm = new Form2();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           
                if(textBox1.Text.Length == 9 || (textBox1.Text.StartsWith("+") && textBox1.Text.Length == 12))
                {
                
                
                frm.listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                

                    
                }else
                MessageBox.Show("Blogas formatas");
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void langas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
