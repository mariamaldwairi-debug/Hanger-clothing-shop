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
    public partial class catalog : Form
    {
       
        public catalog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cataloglst.SelectedIndex==0)
            {
              
                topsandsweaters f3 = new topsandsweaters();
                this.Hide();
                f3.ShowDialog();
            }
            if (cataloglst.SelectedIndex==1)
            {
                
                pantsandskirts f4 = new pantsandskirts();
                this.Hide();
                f4.ShowDialog();

            }
            if (cataloglst.SelectedIndex==2)
            {
              
                jackets f5 = new jackets();
                this.Hide();
                f5.ShowDialog();

            }
            if (cataloglst.SelectedIndex==3)
            {
                
                accessories f6 = new accessories();
                this.Hide();
                f6.ShowDialog();
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void catalog_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
