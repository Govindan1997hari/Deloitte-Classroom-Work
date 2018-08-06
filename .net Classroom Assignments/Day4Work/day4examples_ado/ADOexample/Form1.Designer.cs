namespace ADOexample
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
            this.components = new System.ComponentModel.Container();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblpreference = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.trainingDBDataSet = new ADOexample.TrainingDBDataSet();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerShoppingTableAdapter = new ADOexample.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.trainingDBDataSet1 = new ADOexample.TrainingDBDataSet1();
            this.registerShoppingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerShoppingTableAdapter1 = new ADOexample.TrainingDBDataSet1TableAdapters.RegisterShoppingTableAdapter();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(40, 37);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(111, 22);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter Name   :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(40, 72);
            this.lblgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(121, 22);
            this.lblgender.TabIndex = 1;
            this.lblgender.Text = "Select Gender   :";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(40, 105);
            this.lblmembership.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(155, 22);
            this.lblmembership.TabIndex = 2;
            this.lblmembership.Text = "Select Membership   :";
            // 
            // lblpreference
            // 
            this.lblpreference.AutoSize = true;
            this.lblpreference.Location = new System.Drawing.Point(40, 141);
            this.lblpreference.Name = "lblpreference";
            this.lblpreference.Size = new System.Drawing.Size(210, 22);
            this.lblpreference.TabIndex = 3;
            this.lblpreference.Text = "Select Shopping Preference   :";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(40, 362);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(96, 22);
            this.lblcod.TabIndex = 4;
            this.lblcod.Text = "Prefer COD?";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(40, 418);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(136, 22);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Enter Password   :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(321, 34);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 29);
            this.txtname.TabIndex = 6;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(321, 68);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(200, 30);
            this.cbgender.TabIndex = 7;
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(321, 102);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(53, 26);
            this.rbfree.TabIndex = 8;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(458, 102);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(57, 26);
            this.rbpaid.TabIndex = 9;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "Geans",
            "T-Shirts",
            "School Bags",
            "Travel Bags",
            "Shoes",
            "Shirts"});
            this.clbshop.Location = new System.Drawing.Point(321, 141);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(200, 148);
            this.clbshop.TabIndex = 10;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(321, 361);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(52, 26);
            this.cbcod.TabIndex = 11;
            this.cbcod.Text = "cod";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(321, 415);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(200, 29);
            this.txtpassword.TabIndex = 12;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(321, 475);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(200, 32);
            this.btnregister.TabIndex = 13;
            this.btnregister.Text = "register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(44, 475);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(200, 32);
            this.btnselect.TabIndex = 14;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 22;
            this.lbselect.Location = new System.Drawing.Point(614, 34);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(547, 400);
            this.lbselect.TabIndex = 15;
            // 
            // cbid
            // 
            this.cbid.DataSource = this.registerShoppingBindingSource1;
            this.cbid.DisplayMember = "name";
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(321, -2);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(200, 30);
            this.cbid.TabIndex = 16;
            this.cbid.ValueMember = "Id";
            this.cbid.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(558, 475);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(201, 32);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // trainingDBDataSet1
            // 
            this.trainingDBDataSet1.DataSetName = "TrainingDBDataSet1";
            this.trainingDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerShoppingBindingSource1
            // 
            this.registerShoppingBindingSource1.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource1.DataSource = this.trainingDBDataSet1;
            // 
            // registerShoppingTableAdapter1
            // 
            this.registerShoppingTableAdapter1.ClearBeforeFill = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(794, 475);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(201, 32);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1596, 741);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblpreference);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblpreference;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Button btndelete;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private TrainingDBDataSet1 trainingDBDataSet1;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource1;
        private TrainingDBDataSet1TableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter1;
        private System.Windows.Forms.Button btnupdate;
    }
}

