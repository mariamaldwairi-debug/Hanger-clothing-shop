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
    public partial class login : Form
    {
        public static string s1 = "";
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            try
            {

                projectdb2DataSetTableAdapters.loginformTableAdapter user = new projectdb2DataSetTableAdapters.loginformTableAdapter();
                projectdb2DataSet.loginformDataTable dt = user.GetDataBy1(usernametxt.Text, passwordtxt.Text);

                
                if (dt.Rows.Count==1)
                {
                    
                    s1 = usernametxt.Text;
                    catalog f2 = new catalog();
                    this.Hide();
                    f2.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("wrong username or password please try again ");
                }
                usernametxt.Text = "";
                passwordtxt.Text = "";

            }
            catch (Exception e2)
            {
                MessageBox.Show("Error somthing went wrong if you are facing a problem please contact us " + e2);
            }

            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            
            


        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Pink;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("if you are having an issues please conact us in our wibsite www.hanger.com or call us in our number 07889921318");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            signin f6 = new signin();
            this.Hide();
            f6.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LavenderBlush;
        }
    }
}
