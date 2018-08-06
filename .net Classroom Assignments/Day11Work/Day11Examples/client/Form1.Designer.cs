namespace client
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
            this.tbnum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnum2 = new System.Windows.Forms.TextBox();
            this.btniis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnum1
            // 
            this.tbnum1.Location = new System.Drawing.Point(152, 12);
            this.tbnum1.Name = "tbnum1";
            this.tbnum1.Size = new System.Drawing.Size(100, 20);
            this.tbnum1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Num 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter num2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbnum2
            // 
            this.tbnum2.Location = new System.Drawing.Point(152, 54);
            this.tbnum2.Name = "tbnum2";
            this.tbnum2.Size = new System.Drawing.Size(100, 20);
            this.tbnum2.TabIndex = 3;
            // 
            // btniis
            // 
            this.btniis.Location = new System.Drawing.Point(102, 143);
            this.btniis.Name = "btniis";
            this.btniis.Size = new System.Drawing.Size(75, 23);
            this.btniis.TabIndex = 4;
            this.btniis.Text = "IIS Hosting";
            this.btniis.UseVisualStyleBackColor = true;
            this.btniis.Click += new System.EventHandler(this.btniis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Self Hosting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btniis);
            this.Controls.Add(this.tbnum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnum2;
        private System.Windows.Forms.Button btniis;
        private System.Windows.Forms.Button button1;
    }
}

