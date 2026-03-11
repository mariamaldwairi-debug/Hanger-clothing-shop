
namespace WindowsFormsApp4
{
    partial class signin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.signinbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginformBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectdb2DataSet2 = new WindowsFormsApp4.projectdb2DataSet();
            this.loginformBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.projectdb2DataSet11 = new WindowsFormsApp4.projectdb2DataSet1();
            this.loginformTableAdapter3 = new WindowsFormsApp4.projectdb2DataSet1TableAdapters.loginformTableAdapter();
            this.loginformBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projectdb2DataSet3 = new WindowsFormsApp4.projectdb2DataSet();
            this.loginformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectdb2DataSet1 = new WindowsFormsApp4.projectdb2DataSet();
            this.loginformTableAdapter = new WindowsFormsApp4.projectdb2DataSetTableAdapters.loginformTableAdapter();
            this.loginformTableAdapter1 = new WindowsFormsApp4.projectdb2DataSetTableAdapters.loginformTableAdapter();
            this.loginformTableAdapter2 = new WindowsFormsApp4.projectdb2DataSetTableAdapters.loginformTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginformBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.projectdb2DataSet4 = new WindowsFormsApp4.projectdb2DataSet4();
            this.loginformTableAdapter4 = new WindowsFormsApp4.projectdb2DataSet4TableAdapters.loginformTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Location = new System.Drawing.Point(705, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 728);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creat Your Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter a username : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter a Password : ";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(276, 227);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(100, 27);
            this.usertxt.TabIndex = 6;
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(276, 306);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 27);
            this.passtxt.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1141, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 24);
            this.toolStripDropDownButton1.Text = "Login";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Checked = true;
            this.toolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(129, 24);
            this.toolStripButton1.Text = "Go Back To Login";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Checked = true;
            this.toolStripButton3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton3.Text = "Exit";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // signinbtn
            // 
            this.signinbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.signinbtn.Location = new System.Drawing.Point(201, 381);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(122, 62);
            this.signinbtn.TabIndex = 10;
            this.signinbtn.Text = "Signin ";
            this.signinbtn.UseVisualStyleBackColor = false;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            this.signinbtn.MouseLeave += new System.EventHandler(this.signinbtn_MouseLeave);
            this.signinbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signinbtn_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(716, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // loginformBindingSource1
            // 
            this.loginformBindingSource1.DataMember = "loginform";
            this.loginformBindingSource1.DataSource = this.projectdb2DataSet2;
            // 
            // projectdb2DataSet2
            // 
            this.projectdb2DataSet2.DataSetName = "projectdb2DataSet2";
            this.projectdb2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginformBindingSource3
            // 
            this.loginformBindingSource3.DataMember = "loginform";
            this.loginformBindingSource3.DataSource = this.projectdb2DataSet11;
            // 
            // projectdb2DataSet11
            // 
            this.projectdb2DataSet11.DataSetName = "projectdb2DataSet1";
            this.projectdb2DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginformTableAdapter3
            // 
            this.loginformTableAdapter3.ClearBeforeFill = true;
            // 
            // loginformBindingSource2
            // 
            this.loginformBindingSource2.DataMember = "loginform";
            this.loginformBindingSource2.DataSource = this.projectdb2DataSet3;
            // 
            // projectdb2DataSet3
            // 
            this.projectdb2DataSet3.DataSetName = "projectdb2DataSet3";
            this.projectdb2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginformBindingSource
            // 
            this.loginformBindingSource.DataMember = "loginform";
            this.loginformBindingSource.DataSource = this.projectdb2DataSet1;
            // 
            // projectdb2DataSet1
            // 
            this.projectdb2DataSet1.DataSetName = "projectdb2DataSet1";
            this.projectdb2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginformTableAdapter
            // 
            this.loginformTableAdapter.ClearBeforeFill = true;
            // 
            // loginformTableAdapter1
            // 
            this.loginformTableAdapter1.ClearBeforeFill = true;
            // 
            // loginformTableAdapter2
            // 
            this.loginformTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Location = new System.Drawing.Point(285, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 62);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Location = new System.Drawing.Point(129, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 62);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Location = new System.Drawing.Point(716, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 62);
            this.button4.TabIndex = 15;
            this.button4.Text = "Test Connection";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LavenderBlush;
            this.button5.Location = new System.Drawing.Point(879, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 62);
            this.button5.TabIndex = 16;
            this.button5.Text = "Display Data";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(276, 164);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 27);
            this.txtid.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enter a user id : ";
            // 
            // loginformBindingSource4
            // 
            this.loginformBindingSource4.DataMember = "loginform";
            this.loginformBindingSource4.DataSource = this.projectdb2DataSet4;
            // 
            // projectdb2DataSet4
            // 
            this.projectdb2DataSet4.DataSetName = "projectdb2DataSet4";
            this.projectdb2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginformTableAdapter4
            // 
            this.loginformTableAdapter4.ClearBeforeFill = true;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "signin";
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectdb2DataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private projectdb2DataSet projectdb2DataSet1;
        private System.Windows.Forms.BindingSource loginformBindingSource;
        private projectdb2DataSetTableAdapters.loginformTableAdapter loginformTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button signinbtn;
        private projectdb2DataSet projectdb2DataSet2;
        private System.Windows.Forms.BindingSource loginformBindingSource1;
        private projectdb2DataSetTableAdapters.loginformTableAdapter loginformTableAdapter1;
        private projectdb2DataSet projectdb2DataSet3;
        private System.Windows.Forms.BindingSource loginformBindingSource2;
        private projectdb2DataSetTableAdapters.loginformTableAdapter loginformTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private projectdb2DataSet1 projectdb2DataSet11;
        private System.Windows.Forms.BindingSource loginformBindingSource3;
        private projectdb2DataSet1TableAdapters.loginformTableAdapter loginformTableAdapter3;
        private projectdb2DataSet4 projectdb2DataSet4;
        private System.Windows.Forms.BindingSource loginformBindingSource4;
        private projectdb2DataSet4TableAdapters.loginformTableAdapter loginformTableAdapter4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
    }
}