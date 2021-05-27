namespace stern_it
{
    partial class Add_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Users));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadTableBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.DataTables = new System.Windows.Forms.DataGridView();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.lV = new System.Windows.Forms.Label();
            this.CustomerNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTables)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 226);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LoadTableBtn
            // 
            this.LoadTableBtn.Location = new System.Drawing.Point(649, 509);
            this.LoadTableBtn.Name = "LoadTableBtn";
            this.LoadTableBtn.Size = new System.Drawing.Size(112, 34);
            this.LoadTableBtn.TabIndex = 14;
            this.LoadTableBtn.Text = "Load Table";
            this.LoadTableBtn.UseVisualStyleBackColor = true;
            this.LoadTableBtn.Click += new System.EventHandler(this.UsersITBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 272);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(119, 34);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteLb_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(137, 272);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(119, 34);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(157, 123);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(217, 31);
            this.PasswordTxt.TabIndex = 6;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(157, 86);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(217, 31);
            this.EmailTxt.TabIndex = 5;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(157, 49);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(217, 31);
            this.LastNameTxt.TabIndex = 4;
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(157, 12);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(217, 31);
            this.FirstNameTxt.TabIndex = 3;
            // 
            // DataTables
            // 
            this.DataTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTables.Location = new System.Drawing.Point(380, 16);
            this.DataTables.Name = "DataTables";
            this.DataTables.RowHeadersWidth = 62;
            this.DataTables.Size = new System.Drawing.Size(752, 487);
            this.DataTables.TabIndex = 1;
            this.DataTables.Text = "dataGridView1";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(973, 509);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(112, 34);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // lV
            // 
            this.lV.AutoSize = true;
            this.lV.Location = new System.Drawing.Point(6, 160);
            this.lV.Name = "lV";
            this.lV.Size = new System.Drawing.Size(145, 25);
            this.lV.TabIndex = 17;
            this.lV.Text = "Customer Name:";
            // 
            // CustomerNameTxt
            // 
            this.CustomerNameTxt.Location = new System.Drawing.Point(157, 160);
            this.CustomerNameTxt.Name = "CustomerNameTxt";
            this.CustomerNameTxt.Size = new System.Drawing.Size(217, 31);
            this.CustomerNameTxt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "id (delete\\update):";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(157, 235);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(217, 31);
            this.IdTxt.TabIndex = 21;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(262, 272);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 34);
            this.updateBtn.TabIndex = 22;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Telephone:";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(157, 198);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(217, 31);
            this.PhoneTxt.TabIndex = 24;
            // 
            // Add_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 555);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerNameTxt);
            this.Controls.Add(this.lV);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DataTables);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.LoadTableBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadTableBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.DataGridView DataTables;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label lV;
        private System.Windows.Forms.TextBox CustomerNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneTxt;
    }
}