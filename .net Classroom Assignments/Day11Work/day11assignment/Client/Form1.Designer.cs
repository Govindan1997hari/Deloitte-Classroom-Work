namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcardno = new System.Windows.Forms.TextBox();
            this.tbcvvno = new System.Windows.Forms.TextBox();
            this.tbamt = new System.Windows.Forms.TextBox();
            this.tbnwithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CVV number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // tbcardno
            // 
            this.tbcardno.Location = new System.Drawing.Point(376, 99);
            this.tbcardno.Name = "tbcardno";
            this.tbcardno.Size = new System.Drawing.Size(100, 20);
            this.tbcardno.TabIndex = 3;
            // 
            // tbcvvno
            // 
            this.tbcvvno.Location = new System.Drawing.Point(376, 172);
            this.tbcvvno.Name = "tbcvvno";
            this.tbcvvno.Size = new System.Drawing.Size(100, 20);
            this.tbcvvno.TabIndex = 4;
            // 
            // tbamt
            // 
            this.tbamt.Location = new System.Drawing.Point(376, 239);
            this.tbamt.Name = "tbamt";
            this.tbamt.Size = new System.Drawing.Size(100, 20);
            this.tbamt.TabIndex = 5;
            // 
            // tbnwithdraw
            // 
            this.tbnwithdraw.Location = new System.Drawing.Point(292, 318);
            this.tbnwithdraw.Name = "tbnwithdraw";
            this.tbnwithdraw.Size = new System.Drawing.Size(75, 23);
            this.tbnwithdraw.TabIndex = 6;
            this.tbnwithdraw.Text = "WithDraw";
            this.tbnwithdraw.UseVisualStyleBackColor = true;
            this.tbnwithdraw.Click += new System.EventHandler(this.tbnwithdraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 428);
            this.Controls.Add(this.tbnwithdraw);
            this.Controls.Add(this.tbamt);
            this.Controls.Add(this.tbcvvno);
            this.Controls.Add(this.tbcardno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcardno;
        private System.Windows.Forms.TextBox tbcvvno;
        private System.Windows.Forms.TextBox tbamt;
        private System.Windows.Forms.Button tbnwithdraw;
    }
}

