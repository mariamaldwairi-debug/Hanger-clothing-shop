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
    public partial class accessories : Form
    {
        public static double accessoriesresult;
        public accessories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            purchase f1 = new purchase();
            this.Hide();
            f1.ShowDialog();
        }
        double costt = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            costt = 0;
            
            calculateCost();
            MessageBox.Show("the cost of the selected accessories is  " + costt);

            
        }
        private void calculateCost()
        {
            double[] accessoriesCost = { 3.50,3.50, 5, 5, 2.90, 1.30,16,7.80 };
            costt = 0;
            foreach (int i in clbaccessories.CheckedIndices)
            {
                if (i >= 0 && i < accessoriesCost.Length)
                {
                    costt += accessoriesCost[i];
                }
            }
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

        private void label9_Click(object sender, EventArgs e)
        {
            topsandsweaters f1 = new topsandsweaters();
            this.Hide();
            f1.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pantsandskirts f1 = new pantsandskirts();
            this.Hide();
            f1.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            jackets f1 = new jackets();
            this.Hide();
            f1.ShowDialog();
        }

        private void accessories_Load(object sender, EventArgs e)
        {

        }

        private void clbaccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            calculateCost();
            accessoriesresult = costt;

            purchase formy = new purchase();
            formy.SetResult(accessoriesresult);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LavenderBlush;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Pink;
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
