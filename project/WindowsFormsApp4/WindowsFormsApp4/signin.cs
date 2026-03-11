using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp4
{
    public partial class signin : Form
    {
        
        
            private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Designer\Desktop\project\project\projectdb2.mdb");
        public signin()
        {
            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectdb2DataSet4.loginform' table. You can move, or remove it, as needed.
            this.loginformTableAdapter4.Fill(this.projectdb2DataSet4.loginform);
            
          
            

        }
        private void fillgrid() 
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from loginform", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into loginform values(@user,@pass,@id)", con);
                cmd.Parameters.AddWithValue("@user", usertxt.Text);
                cmd.Parameters.AddWithValue("@pass", passtxt.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("you signed in successfully Go back to log in");
                con.Close();
                fillgrid();

                   
            }
            catch(Exception e2)
            {
                MessageBox.Show("error"+e2);
            }
            

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            login f6 = new login();
            this.Hide();
            f6.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("connection successfully");
                con.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show("error in connection" + e2.ToString());
            }

                  


        }

        private void button5_Click(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete from loginform where userid=@id", con);
                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("records are deleted");
                con.Close();
                fillgrid();


            }
            catch (Exception)
            {
                MessageBox.Show("error in deleting records");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("update loginform set Username=?, [Password]=? where userid=?",con);
                cmd.Parameters.AddWithValue("@user",usertxt.Text);
                cmd.Parameters.AddWithValue("@pass",passtxt.Text);
                cmd.Parameters.AddWithValue("@id",int.Parse(txtid.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("updated successfully");
                con.Close();
                fillgrid();


            }
            catch (Exception e2)
            {
                MessageBox.Show("error" + e2);
            }

        }

        private void signinbtn_MouseMove(object sender, MouseEventArgs e)
        {
            signinbtn.BackColor = Color.Pink;
        }

        private void signinbtn_MouseLeave(object sender, EventArgs e)
        {
            signinbtn.BackColor = Color.LavenderBlush;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Pink;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LavenderBlush;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Pink;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LavenderBlush;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Pink;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.LavenderBlush;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.Pink;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.LavenderBlush;
        }
    }
}
