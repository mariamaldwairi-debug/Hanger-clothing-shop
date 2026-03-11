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
    public partial class jackets : Form
    {
        public static double jacketresult;
        public jackets()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            catalog f1 = new catalog();
            this.Hide();
            f1.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        double costt = 0;
        private void calculateCost()
        {
            double[] jacketCost = { 20, 15.75, 20, 14.99, 17.50, 25 };
            costt = 0;
            foreach (int i in clbjacket.CheckedIndices)
            {
                if (i >= 0 && i < jacketCost.Length)
                {
                    costt += jacketCost[i];
                }
            }
        }
        private void intialbillbtn_Click(object sender, EventArgs e)
        {
            costt = 0;
            
            calculateCost();
            MessageBox.Show("the cost of the selected jackets is  " + costt);

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            accessories f1 = new accessories();
            this.Hide();
            f1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            purchase f1 = new purchase();
            this.Hide();
            f1.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            topsandsweaters f1 = new topsandsweaters();
            this.Hide();
            f1.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pantsandskirts f1 = new pantsandskirts();
            this.Hide();
            f1.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            accessories f1 = new accessories();
            this.Hide();
            f1.ShowDialog();
        }

        private void clbjacket_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            calculateCost();
            jacketresult = costt;

            purchase formy = new purchase();
            formy.SetResult(jacketresult);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LavenderBlush;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Pink;
        }

        private void intialbillbtn_MouseLeave(object sender, EventArgs e)
        {
            intialbillbtn.BackColor = Color.LavenderBlush;
        }

        private void intialbillbtn_MouseMove(object sender, MouseEventArgs e)
        {
            intialbillbtn.BackColor = Color.Pink;
        }

        private void jackets_Load(object sender, EventArgs e)
        {

        }
    }
}
