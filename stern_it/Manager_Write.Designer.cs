namespace stern_it
{
    partial class Manager_Write
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
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.StatusTxt = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AnswerTxt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.CusNameTxt = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PhoneNumTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Answer to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(350, 40);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ReadOnly = true;
            this.descriptionTxt.Size = new System.Drawing.Size(648, 237);
            this.descriptionTxt.TabIndex = 4;
            this.descriptionTxt.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desctiption:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Last Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Status:";
            // 
            // StatusTxt
            // 
            this.StatusTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusTxt.FormattingEnabled = true;
            this.StatusTxt.Items.AddRange(new object[] {
            "pending",
            "close",
            "done"});
            this.StatusTxt.Location = new System.Drawing.Point(82, 372);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(167, 33);
            this.StatusTxt.TabIndex = 17;
            this.StatusTxt.SelectedIndexChanged += new System.EventHandler(this.StatusTxt_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "Answer:";
            // 
            // AnswerTxt
            // 
            this.AnswerTxt.Location = new System.Drawing.Point(350, 372);
            this.AnswerTxt.Name = "AnswerTxt";
            this.AnswerTxt.Size = new System.Drawing.Size(648, 248);
            this.AnswerTxt.TabIndex = 19;
            this.AnswerTxt.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "First Name:";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(112, 457);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(173, 31);
            this.NameTxt.TabIndex = 22;
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(112, 43);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.ReadOnly = true;
            this.FirstNameTxt.Size = new System.Drawing.Size(82, 31);
            this.FirstNameTxt.TabIndex = 23;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(112, 88);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.ReadOnly = true;
            this.LastNameTxt.Size = new System.Drawing.Size(150, 31);
            this.LastNameTxt.TabIndex = 24;
            // 
            // CusNameTxt
            // 
            this.CusNameTxt.Location = new System.Drawing.Point(160, 131);
            this.CusNameTxt.Name = "CusNameTxt";
            this.CusNameTxt.ReadOnly = true;
            this.CusNameTxt.Size = new System.Drawing.Size(150, 31);
            this.CusNameTxt.TabIndex = 25;
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(123, 170);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.ReadOnly = true;
            this.IdTxt.Size = new System.Drawing.Size(71, 31);
            this.IdTxt.TabIndex = 26;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(77, 213);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.ReadOnly = true;
            this.EmailTxt.Size = new System.Drawing.Size(185, 31);
            this.EmailTxt.TabIndex = 27;
            // 
            // PhoneNumTxt
            // 
            this.PhoneNumTxt.Location = new System.Drawing.Point(154, 252);
            this.PhoneNumTxt.Name = "PhoneNumTxt";
            this.PhoneNumTxt.ReadOnly = true;
            this.PhoneNumTxt.Size = new System.Drawing.Size(156, 31);
            this.PhoneNumTxt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "IT:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Manager_Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 632);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNumTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.CusNameTxt);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnswerTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Manager_Write";
            this.ShowIcon = false;
            this.Text = "Manager_Write";
            this.Load += new System.EventHandler(this.Manager_Write_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox StatusTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox AnswerTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox CusNameTxt;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PhoneNumTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}