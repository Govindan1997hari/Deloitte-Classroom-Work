namespace ADOAssignment
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
            this.lbStudentprofile = new System.Windows.Forms.Label();
            this.lbrollno = new System.Windows.Forms.Label();
            this.tbrollno = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.cbsem = new System.Windows.Forms.ComboBox();
            this.cbdept = new System.Windows.Forms.ComboBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.tbaddrs = new System.Windows.Forms.TextBox();
            this.tbphno = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.lbdob = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.lbdept = new System.Windows.Forms.Label();
            this.lbcourse = new System.Windows.Forms.Label();
            this.lbsem = new System.Windows.Forms.Label();
            this.lbaddrs = new System.Windows.Forms.Label();
            this.lbphno = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.lbshow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbStudentprofile
            // 
            this.lbStudentprofile.AutoSize = true;
            this.lbStudentprofile.Font = new System.Drawing.Font("Modern No. 20", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentprofile.ForeColor = System.Drawing.SystemColors.Window;
            this.lbStudentprofile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbStudentprofile.Location = new System.Drawing.Point(319, 17);
            this.lbStudentprofile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbStudentprofile.Name = "lbStudentprofile";
            this.lbStudentprofile.Size = new System.Drawing.Size(198, 29);
            this.lbStudentprofile.TabIndex = 0;
            this.lbStudentprofile.Text = "Student Profile";
            // 
            // lbrollno
            // 
            this.lbrollno.AutoSize = true;
            this.lbrollno.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrollno.ForeColor = System.Drawing.Color.White;
            this.lbrollno.Location = new System.Drawing.Point(184, 72);
            this.lbrollno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbrollno.Name = "lbrollno";
            this.lbrollno.Size = new System.Drawing.Size(94, 26);
            this.lbrollno.TabIndex = 1;
            this.lbrollno.Text = "Roll No :";
            // 
            // tbrollno
            // 
            this.tbrollno.Location = new System.Drawing.Point(310, 71);
            this.tbrollno.Name = "tbrollno";
            this.tbrollno.Size = new System.Drawing.Size(219, 31);
            this.tbrollno.TabIndex = 2;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(310, 108);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(219, 31);
            this.tbname.TabIndex = 3;
            // 
            // dtpdob
            // 
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(310, 145);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(219, 31);
            this.dtpdob.TabIndex = 4;
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
            this.cbsem.Location = new System.Drawing.Point(310, 293);
            this.cbsem.Name = "cbsem";
            this.cbsem.Size = new System.Drawing.Size(219, 31);
            this.cbsem.TabIndex = 5;
            // 
            // cbdept
            // 
            this.cbdept.FormattingEnabled = true;
            this.cbdept.Items.AddRange(new object[] {
            "Computer Science",
            "Science",
            "Mathematics"});
            this.cbdept.Location = new System.Drawing.Point(310, 219);
            this.cbdept.Name = "cbdept";
            this.cbdept.Size = new System.Drawing.Size(219, 31);
            this.cbdept.TabIndex = 6;
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
            this.cbcourse.Location = new System.Drawing.Point(310, 256);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(219, 31);
            this.cbcourse.TabIndex = 7;
            // 
            // tbaddrs
            // 
            this.tbaddrs.Location = new System.Drawing.Point(310, 330);
            this.tbaddrs.Name = "tbaddrs";
            this.tbaddrs.Size = new System.Drawing.Size(219, 31);
            this.tbaddrs.TabIndex = 8;
            // 
            // tbphno
            // 
            this.tbphno.Location = new System.Drawing.Point(310, 367);
            this.tbphno.Name = "tbphno";
            this.tbphno.Size = new System.Drawing.Size(219, 31);
            this.tbphno.TabIndex = 9;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.White;
            this.lbname.Location = new System.Drawing.Point(193, 109);
            this.lbname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(85, 26);
            this.lbname.TabIndex = 10;
            this.lbname.Text = "Name :";
            // 
            // lbdob
            // 
            this.lbdob.AutoSize = true;
            this.lbdob.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdob.ForeColor = System.Drawing.Color.White;
            this.lbdob.Location = new System.Drawing.Point(122, 149);
            this.lbdob.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdob.Name = "lbdob";
            this.lbdob.Size = new System.Drawing.Size(156, 26);
            this.lbdob.TabIndex = 11;
            this.lbdob.Text = "Date Of Birth :";
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgender.ForeColor = System.Drawing.Color.White;
            this.lbgender.Location = new System.Drawing.Point(181, 186);
            this.lbgender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(97, 26);
            this.lbgender.TabIndex = 12;
            this.lbgender.Text = "Gender :";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.ForeColor = System.Drawing.Color.Red;
            this.rbmale.Location = new System.Drawing.Point(324, 187);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(69, 27);
            this.rbmale.TabIndex = 13;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.ForeColor = System.Drawing.Color.Snow;
            this.rbfemale.Location = new System.Drawing.Point(436, 186);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(93, 27);
            this.rbfemale.TabIndex = 14;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // lbdept
            // 
            this.lbdept.AutoSize = true;
            this.lbdept.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdept.ForeColor = System.Drawing.Color.White;
            this.lbdept.Location = new System.Drawing.Point(125, 220);
            this.lbdept.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdept.Name = "lbdept";
            this.lbdept.Size = new System.Drawing.Size(153, 26);
            this.lbdept.TabIndex = 15;
            this.lbdept.Text = " Department :";
            this.lbdept.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbcourse
            // 
            this.lbcourse.AutoSize = true;
            this.lbcourse.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcourse.ForeColor = System.Drawing.Color.White;
            this.lbcourse.Location = new System.Drawing.Point(188, 256);
            this.lbcourse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbcourse.Name = "lbcourse";
            this.lbcourse.Size = new System.Drawing.Size(90, 26);
            this.lbcourse.TabIndex = 16;
            this.lbcourse.Text = "Course :";
            // 
            // lbsem
            // 
            this.lbsem.AutoSize = true;
            this.lbsem.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsem.ForeColor = System.Drawing.Color.White;
            this.lbsem.Location = new System.Drawing.Point(164, 293);
            this.lbsem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbsem.Name = "lbsem";
            this.lbsem.Size = new System.Drawing.Size(114, 26);
            this.lbsem.TabIndex = 17;
            this.lbsem.Text = "Semester :";
            // 
            // lbaddrs
            // 
            this.lbaddrs.AutoSize = true;
            this.lbaddrs.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddrs.ForeColor = System.Drawing.Color.White;
            this.lbaddrs.Location = new System.Drawing.Point(177, 331);
            this.lbaddrs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbaddrs.Name = "lbaddrs";
            this.lbaddrs.Size = new System.Drawing.Size(101, 26);
            this.lbaddrs.TabIndex = 18;
            this.lbaddrs.Text = "Address :";
            // 
            // lbphno
            // 
            this.lbphno.AutoSize = true;
            this.lbphno.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphno.ForeColor = System.Drawing.Color.White;
            this.lbphno.Location = new System.Drawing.Point(102, 368);
            this.lbphno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbphno.Name = "lbphno";
            this.lbphno.Size = new System.Drawing.Size(176, 26);
            this.lbphno.TabIndex = 19;
            this.lbphno.Text = "Phone Number :";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Azure;
            this.btnadd.Location = new System.Drawing.Point(193, 411);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(105, 36);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "Add New";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Azure;
            this.btnselect.Location = new System.Drawing.Point(304, 411);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(105, 36);
            this.btnselect.TabIndex = 22;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Azure;
            this.btnupdate.Location = new System.Drawing.Point(415, 411);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 36);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Azure;
            this.btndelete.Location = new System.Drawing.Point(526, 411);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 36);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Azure;
            this.btnfind.Location = new System.Drawing.Point(559, 71);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(105, 36);
            this.btnfind.TabIndex = 25;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // lbshow
            // 
            this.lbshow.FormattingEnabled = true;
            this.lbshow.ItemHeight = 23;
            this.lbshow.Location = new System.Drawing.Point(734, 71);
            this.lbshow.Name = "lbshow";
            this.lbshow.Size = new System.Drawing.Size(248, 372);
            this.lbshow.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1596, 811);
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
            this.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudentprofile;
        private System.Windows.Forms.Label lbrollno;
        private System.Windows.Forms.TextBox tbrollno;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.ComboBox cbsem;
        private System.Windows.Forms.ComboBox cbdept;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.TextBox tbaddrs;
        private System.Windows.Forms.TextBox tbphno;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbdob;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Label lbdept;
        private System.Windows.Forms.Label lbcourse;
        private System.Windows.Forms.Label lbsem;
        private System.Windows.Forms.Label lbaddrs;
        private System.Windows.Forms.Label lbphno;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.ListBox lbshow;
    }
}

