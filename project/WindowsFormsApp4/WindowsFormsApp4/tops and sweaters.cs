using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class topsandsweaters : Form
    {
        public static double result;
        
        public topsandsweaters()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            purchase f1 = new purchase();
            this.Hide();
            f1.ShowDialog();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        double cost = 0;
        private void sweaterclb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            calculateCost();
            result = cost;


            purchase secondForm = new purchase();
            secondForm.SetResult(result);
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cost = 0;
            
            calculateCost();
            MessageBox.Show("the cost of the selected sweaters is  " + cost);
            


        }
            private void calculateCost()
        {
            double [] SweateCost = { 4, 6, 11, 4, 6.70, 10.99 };
            cost = 0;
            foreach(int i in sweaterclb.CheckedIndices )
            {
                if(i>=0 && i< SweateCost.Length)
                {
                    cost += SweateCost[i];
                }
            }
        }



            private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            catalog f1 = new catalog();
            this.Hide();
            f1.ShowDialog();

        }

        private void toolStripLabel2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void topsandsweaters_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            pantsandskirts f1 = new pantsandskirts();
            this.Hide();
            f1.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pantsandskirts f1 = new pantsandskirts();
            this.Hide();
            f1.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            jackets f1 = new jackets();
            this.Hide();
            f1.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            accessories f1 = new accessories();
            this.Hide();
            f1.ShowDialog();
        }

        private void intialbillbtn_MouseLeave(object sender, EventArgs e)
        {
            intialbillbtn.BackColor = Color.LavenderBlush;
        }

        private void intialbillbtn_MouseMove(object sender, MouseEventArgs e)
        {
            intialbillbtn.BackColor = Color.Pink;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LavenderBlush;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Pink;
        }
    }
    }
    
