namespace stern_it
{
    partial class Reading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reading));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AnswerTxt = new System.Windows.Forms.RichTextBox();
            this.labl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.MailTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.PriorityTxt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-223, -28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Answer:";
            // 
            // AnswerTxt
            // 
            this.AnswerTxt.Location = new System.Drawing.Point(359, 39);
            this.AnswerTxt.Name = "AnswerTxt";
            this.AnswerTxt.ReadOnly = true;
            this.AnswerTxt.Size = new System.Drawing.Size(545, 171);
            this.AnswerTxt.TabIndex = 8;
            this.AnswerTxt.Text = "";
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(12, 144);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(96, 25);
            this.labl.TabIndex = 9;
            this.labl.Text = "Telephone:";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(82, 42);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.ReadOnly = true;
            this.NameTxt.Size = new System.Drawing.Size(150, 31);
            this.NameTxt.TabIndex = 10;
            // 
            // MailTxt
            // 
            this.MailTxt.Location = new System.Drawing.Point(68, 92);
            this.MailTxt.Name = "MailTxt";
            this.MailTxt.ReadOnly = true;
            this.MailTxt.Size = new System.Drawing.Size(197, 31);
            this.MailTxt.TabIndex = 11;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(115, 141);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.ReadOnly = true;
            this.PhoneTxt.Size = new System.Drawing.Size(150, 31);
            this.PhoneTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Priority:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Decription:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(359, 279);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(530, 178);
            this.descriptionTxt.TabIndex = 16;
            this.descriptionTxt.Text = "";
            this.descriptionTxt.TextChanged += new System.EventHandler(this.descriptionTxt_TextChanged);
            // 
            // PriorityTxt
            // 
            this.PriorityTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityTxt.FormattingEnabled = true;
            this.PriorityTxt.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.PriorityTxt.Location = new System.Drawing.Point(87, 279);
            this.PriorityTxt.Name = "PriorityTxt";
            this.PriorityTxt.Size = new System.Drawing.Size(163, 33);
            this.PriorityTxt.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-56, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "IT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "User:";
            // 
            // Reading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 557);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriorityTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.MailTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.AnswerTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reading";
            this.Text = "Reading";
            this.Load += new System.EventHandler(this.Reading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox AnswerTxt;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox MailTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.ComboBox PriorityTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}