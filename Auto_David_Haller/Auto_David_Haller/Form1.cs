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
            groupBox1.Text = "Marke:";
            groupBox1.Text += Marke.Text;
            groupBox1.Text += "\nFarbe:";
            groupBox1.Text += comboBox1.SelectedItem;
            groupBox1.Text += "\nPS:";
            groupBox1.Text += PS.Text;
            groupBox1.Text += "\nTankgröße:";
            groupBox1.Text += Tankgröße.Text;
            groupBox1.Text += "\nVerbrauch:";
            groupBox1.Text += Verbrauch.Text;
            groupBox1.Text += "\nTankinhalt:";
            groupBox1.Text += tanken;
            groupBox1.Text += "l;
             groupBox1.Text += fahren;

            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Tankgröße.Text);
            progressBar1.Maximum = a;
            int b =Convert.ToInt32(tanken.Text);
            progressBar1.Value += b;
        }
    
    }
}
