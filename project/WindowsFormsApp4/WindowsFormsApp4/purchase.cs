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
    public partial class purchase : Form

    {
        


        public purchase()
        {
            InitializeComponent();
            
            
          
            label2.Text = $"the final amount you have to pay is : {topsandsweaters.result + pantsandskirts.secondresult+jackets.jacketresult+accessories.accessoriesresult}";
            
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }
        public void SetResult(double result)
        {
           
            
        }
       

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            catalog f1 = new catalog();
            this.Hide();
            f1.ShowDialog();
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("your order will come in 14 days and "+label2.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("your order will come in 14 days and " + label2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
