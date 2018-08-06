namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lbshow = new System.Windows.Forms.ListBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lbphno = new System.Windows.Forms.Label();
            this.lbaddrs = new System.Windows.Forms.Label();
            this.lbsem = new System.Windows.Forms.Label();
            this.lbcourse = new System.Windows.Forms.Label();
            this.lbdept = new System.Windows.Forms.Label();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.lbgender = new System.Windows.Forms.Label();
            this.lbdob = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.tbphno = new System.Windows.Forms.TextBox();
            this.tbaddrs = new System.Windows.Forms.TextBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.cbdept = new System.Windows.Forms.ComboBox();
            this.cbsem = new System.Windows.Forms.ComboBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbrollno = new System.Windows.Forms.TextBox();
            this.lbrollno = new System.Windows.Forms.Label();
            this.lbStudentprofile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbshow
            // 
            this.lbshow.FormattingEnabled = true;
            this.lbshow.ItemHeight = 17;
            this.lbshow.Location = new System.Drawing.Point(947, 102);
            this.lbshow.Margin = new System.Windows.Forms.Padding(4);
            this.lbshow.Name = "lbshow";
            this.lbshow.Size = new System.Drawing.Size(329, 480);
            this.lbshow.TabIndex = 52;
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Azure;
            this.btnfind.Location = new System.Drawing.Point(713, 102);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(140, 47);
            this.btnfind.TabIndex = 51;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Azure;
            this.btndelete.Location = new System.Drawing.Point(669, 547);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(140, 47);
            this.btndelete.TabIndex = 50;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Azure;
            this.btnupdate.Location = new System.Drawing.Point(521, 547);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(140, 47);
            this.btnupdate.TabIndex = 49;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Azure;
            this.btnselect.Location = new System.Drawing.Point(373, 547);
            this.btnselect.Margin = new System.Windows.Forms.Padding(4);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(140, 47);
            this.btnselect.TabIndex = 48;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Azure;
            this.btnadd.Location = new System.Drawing.Point(225, 547);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(140, 47);
            this.btnadd.TabIndex = 47;
            this.btnadd.Text = "Add New";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbphno
            // 
            this.lbphno.AutoSize = true;
            this.lbphno.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphno.ForeColor = System.Drawing.Color.White;
            this.lbphno.Location = new System.Drawing.Point(104, 490);
            this.lbphno.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbphno.Name = "lbphno";
            this.lbphno.Size = new System.Drawing.Size(176, 26);
            this.lbphno.TabIndex = 46;
            this.lbphno.Text = "Phone Number :";
            // 
            // lbaddrs
            // 
            this.lbaddrs.AutoSize = true;
            this.lbaddrs.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddrs.ForeColor = System.Drawing.Color.White;
            this.lbaddrs.Location = new System.Drawing.Point(204, 442);
            this.lbaddrs.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbaddrs.Name = "lbaddrs";
            this.lbaddrs.Size = new System.Drawing.Size(101, 26);
            this.lbaddrs.TabIndex = 45;
            this.lbaddrs.Text = "Address :";
            // 
            // lbsem
            // 
            this.lbsem.AutoSize = true;
            this.lbsem.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsem.ForeColor = System.Drawing.Color.White;
            this.lbsem.Location = new System.Drawing.Point(187, 392);
            this.lbsem.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbsem.Name = "lbsem";
            this.lbsem.Size = new System.Drawing.Size(114, 26);
            this.lbsem.TabIndex = 44;
            this.lbsem.Text = "Semester :";
            // 
            // lbcourse
            // 
            this.lbcourse.AutoSize = true;
            this.lbcourse.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcourse.ForeColor = System.Drawing.Color.White;
            this.lbcourse.Location = new System.Drawing.Point(219, 344);
            this.lbcourse.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbcourse.Name = "lbcourse";
            this.lbcourse.Size = new System.Drawing.Size(90, 26);
            this.lbcourse.TabIndex = 43;
            this.lbcourse.Text = "Course :";
            // 
            // lbdept
            // 
            this.lbdept.AutoSize = true;
            this.lbdept.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdept.ForeColor = System.Drawing.Color.White;
            this.lbdept.Location = new System.Drawing.Point(135, 297);
            this.lbdept.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbdept.Name = "lbdept";
            this.lbdept.Size = new System.Drawing.Size(153, 26);
            this.lbdept.TabIndex = 42;
            this.lbdept.Text = " Department :";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.ForeColor = System.Drawing.Color.Snow;
            this.rbfemale.Location = new System.Drawing.Point(549, 252);
            this.rbfemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(66, 21);
            this.rbfemale.TabIndex = 41;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.ForeColor = System.Drawing.Color.Red;
            this.rbmale.Location = new System.Drawing.Point(400, 254);
            this.rbmale.Margin = new System.Windows.Forms.Padding(4);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(54, 21);
            this.rbmale.TabIndex = 40;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgender.ForeColor = System.Drawing.Color.White;
            this.lbgender.Location = new System.Drawing.Point(209, 252);
            this.lbgender.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(97, 26);
            this.lbgender.TabIndex = 39;
            this.lbgender.Text = "Gender :";
            // 
            // lbdob
            // 
            this.lbdob.AutoSize = true;
            this.lbdob.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdob.ForeColor = System.Drawing.Color.White;
            this.lbdob.Location = new System.Drawing.Point(131, 204);
            this.lbdob.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbdob.Name = "lbdob";
            this.lbdob.Size = new System.Drawing.Size(156, 26);
            this.lbdob.TabIndex = 38;
            this.lbdob.Text = "Date Of Birth :";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.White;
            this.lbname.Location = new System.Drawing.Point(225, 152);
            this.lbname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(85, 26);
            this.lbname.TabIndex = 37;
            this.lbname.Text = "Name :";
            // 
            // tbphno
            // 
            this.tbphno.Location = new System.Drawing.Point(381, 489);
            this.tbphno.Margin = new System.Windows.Forms.Padding(4);
            this.tbphno.Name = "tbphno";
            this.tbphno.Size = new System.Drawing.Size(291, 24);
            this.tbphno.TabIndex = 36;
            // 
            // tbaddrs
            // 
            this.tbaddrs.Location = new System.Drawing.Point(381, 441);
            this.tbaddrs.Margin = new System.Windows.Forms.Padding(4);
            this.tbaddrs.Name = "tbaddrs";
            this.tbaddrs.Size = new System.Drawing.Size(291, 24);
            this.tbaddrs.TabIndex = 35;
            // 
            // cbcourse
            // 
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "B.Sc.Computer Science",
            "B.C.Applications",
            "B.Sc.Physics",
            "B.Sc.Chemistry",
            "B.Sc.Mathematics"});
            this.cbcourse.Location = new System.Drawing.Point(381, 344);
            this.cbcourse.Margin = new System.Windows.Forms.Padding(4);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(291, 25);
            this.cbcourse.TabIndex = 34;
            // 
            // cbdept
            // 
            this.cbdept.FormattingEnabled = true;
            this.cbdept.Items.AddRange(new object[] {
            "Computer Science",
            "Science",
            "Mathematics"});
            this.cbdept.Location = new System.Drawing.Point(381, 296);
            this.cbdept.Margin = new System.Windows.Forms.Padding(4);
            this.cbdept.Name = "cbdept";
            this.cbdept.Size = new System.Drawing.Size(291, 25);
            this.cbdept.TabIndex = 33;
            // 
            // cbsem
            // 
            this.cbsem.FormattingEnabled = true;
            this.cbsem.Items.AddRange(new object[] {
            "Semester - I",
            "Semester - II",
            "Semester - III",
            "Semester - IV",
            "Semester - V",
            "Semester - VI"});
            this.cbsem.Location = new System.Drawing.Point(381, 392);
            this.cbsem.Margin = new System.Windows.Forms.Padding(4);
            this.cbsem.Name = "cbsem";
            this.cbsem.Size = new System.Drawing.Size(291, 25);
            this.cbsem.TabIndex = 32;
            // 
            // dtpdob
            // 
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(381, 199);
            this.dtpdob.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(291, 24);
            this.dtpdob.TabIndex = 31;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(381, 150);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(291, 24);
            this.tbname.TabIndex = 30;
            // 
            // tbrollno
            // 
            this.tbrollno.Location = new System.Drawing.Point(381, 102);
            this.tbrollno.Margin = new System.Windows.Forms.Padding(4);
            this.tbrollno.Name = "tbrollno";
            this.tbrollno.Size = new System.Drawing.Size(291, 24);
            this.tbrollno.TabIndex = 29;
            // 
            // lbrollno
            // 
            this.lbrollno.AutoSize = true;
            this.lbrollno.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrollno.ForeColor = System.Drawing.Color.White;
            this.lbrollno.Location = new System.Drawing.Point(213, 103);
            this.lbrollno.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbrollno.Name = "lbrollno";
            this.lbrollno.Size = new System.Drawing.Size(94, 26);
            this.lbrollno.TabIndex = 28;
            this.lbrollno.Text = "Roll No :";
            // 
            // lbStudentprofile
            // 
            this.lbStudentprofile.AutoSize = true;
            this.lbStudentprofile.Font = new System.Drawing.Font("Modern No. 20", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentprofile.ForeColor = System.Drawing.SystemColors.Window;
            this.lbStudentprofile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbStudentprofile.Location = new System.Drawing.Point(393, 31);
            this.lbStudentprofile.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbStudentprofile.Name = "lbStudentprofile";
            this.lbStudentprofile.Size = new System.Drawing.Size(198, 29);
            this.lbStudentprofile.TabIndex = 27;
            this.lbStudentprofile.Text = "Student Profile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1329, 606);
            this.Controls.Add(this.lbshow);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbphno);
            this.Controls.Add(this.lbaddrs);
            this.Controls.Add(this.lbsem);
            this.Controls.Add(this.lbcourse);
            this.Controls.Add(this.lbdept);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.lbgender);
            this.Controls.Add(this.lbdob);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.tbphno);
            this.Controls.Add(this.tbaddrs);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.cbdept);
            this.Controls.Add(this.cbsem);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbrollno);
            this.Controls.Add(this.lbrollno);
            this.Controls.Add(this.lbStudentprofile);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbshow;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lbphno;
        private System.Windows.Forms.Label lbaddrs;
        private System.Windows.Forms.Label lbsem;
        private System.Windows.Forms.Label lbcourse;
        private System.Windows.Forms.Label lbdept;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.Label lbdob;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbphno;
        private System.Windows.Forms.TextBox tbaddrs;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.ComboBox cbdept;
        private System.Windows.Forms.ComboBox cbsem;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbrollno;
        private System.Windows.Forms.Label lbrollno;
        private System.Windows.Forms.Label lbStudentprofile;
    }
}

