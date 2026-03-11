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
    
    public partial class pantsandskirts : Form
    {
        
        public static double secondresult;
        public pantsandskirts()
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
            catalog f1 = new catalog();
            this.Hide();
            f1.ShowDialog();
        }
        private void calculateCost()
        {
            double[] pantCost = { 7.90, 11, 9.80, 13, 10.70, 11.30 };
            costt = 0;
            foreach (int i in skirtclb.CheckedIndices)
            {
                if (i >= 0 && i < pantCost.Length)
                {
                    costt += pantCost[i];
                }
            }
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        double costt = 0;
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            calculateCost();
            secondresult = costt;
                


            purchase form1 = new purchase();
            form1.SetResult(secondresult);
        

            }

        private void intialbillbtn_Click(object sender, EventArgs e)
        {
            costt = 0;
            
            calculateCost();
            MessageBox.Show("the cost of the selected pants and skirts is  " + costt);

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            purchase f1 = new purchase();
            this.Hide();
            f1.ShowDialog();

            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            jackets f1 = new jackets();
            this.Hide();
            f1.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            topsandsweaters f1 = new topsandsweaters();
            this.Hide();
            f1.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
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
        
        private void pantsandskirts_Load(object sender, EventArgs e)
        {
            
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
