using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto_David_Haller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
        
        class Auto
        {
           public string Automarke;
           
           public int PS;

           
            public void Info()
            {
                
                
            }
           }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Text = Marke.Text;
            groupBox1.Text += comboBox1.SelectedItem;
            }
    
    }
}
