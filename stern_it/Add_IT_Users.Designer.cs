namespace stern_it
{
    partial class Add_IT_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_IT_Users));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.FirstNameLb = new System.Windows.Forms.Label();
            this.LastNameLb = new System.Windows.Forms.Label();
            this.EmailLb = new System.Windows.Forms.Label();
            this.PasswordLb = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteLb = new System.Windows.Forms.Button();
            this.LoadTableBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.DataTables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTables)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(1020, 529);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(112, 34);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(177, 19);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(200, 31);
            this.FirstNameTxt.TabIndex = 3;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(177, 56);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(200, 31);
            this.LastNameTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(177, 93);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(200, 31);
            this.EmailTxt.TabIndex = 5;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(177, 130);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(200, 31);
            this.PasswordTxt.TabIndex = 6;
            // 
            // FirstNameLb
            // 
            this.FirstNameLb.AutoSize = true;
            this.FirstNameLb.Location = new System.Drawing.Point(12, 19);
            this.FirstNameLb.Name = "FirstNameLb";
            this.FirstNameLb.Size = new System.Drawing.Size(101, 25);
            this.FirstNameLb.TabIndex = 7;
            this.FirstNameLb.Text = "First Name:";
            // 
            // LastNameLb
            // 
            this.LastNameLb.AutoSize = true;
            this.LastNameLb.Location = new System.Drawing.Point(12, 56);
            this.LastNameLb.Name = "LastNameLb";
            this.LastNameLb.Size = new System.Drawing.Size(99, 25);
            this.LastNameLb.TabIndex = 8;
            this.LastNameLb.Text = "Last Name:";
            // 
            // EmailLb
            // 
            this.EmailLb.AutoSize = true;
            this.EmailLb.Location = new System.Drawing.Point(12, 93);
            this.EmailLb.Name = "EmailLb";
            this.EmailLb.Size = new System.Drawing.Size(58, 25);
            this.EmailLb.TabIndex = 9;
            this.EmailLb.Text = "Email:";
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(12, 130);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(91, 25);
            this.PasswordLb.TabIndex = 10;
            this.PasswordLb.Text = "Password:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(139, 260);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(119, 34);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteLb
            // 
            this.DeleteLb.Location = new System.Drawing.Point(14, 260);
            this.DeleteLb.Name = "DeleteLb";
            this.DeleteLb.Size = new System.Drawing.Size(119, 34);
            this.DeleteLb.TabIndex = 13;
            this.DeleteLb.Text = "Delete";
            this.DeleteLb.UseVisualStyleBackColor = true;
            this.DeleteLb.Click += new System.EventHandler(this.DeleteLb_Click);
            // 
            // LoadTableBtn
            // 
            this.LoadTableBtn.Location = new System.Drawing.Point(709, 529);
            this.LoadTableBtn.Name = "LoadTableBtn";
            this.LoadTableBtn.Size = new System.Drawing.Size(112, 34);
            this.LoadTableBtn.TabIndex = 14;
            this.LoadTableBtn.Text = "Load Table";
            this.LoadTableBtn.UseVisualStyleBackColor = true;
            this.LoadTableBtn.Click += new System.EventHandler(this.UsersITBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 226);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "id (delete\\update):";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(177, 204);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(200, 31);
            this.IdTxt.TabIndex = 21;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(265, 259);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 34);
            this.updateBtn.TabIndex = 22;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telephone:";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(177, 167);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(200, 31);
            this.PhoneTxt.TabIndex = 24;
            // 
            // DataTables
            // 
            this.DataTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTables.Location = new System.Drawing.Point(395, 12);
            this.DataTables.Name = "DataTables";
            this.DataTables.RowHeadersWidth = 62;
            this.DataTables.Size = new System.Drawing.Size(737, 491);
            this.DataTables.TabIndex = 1;
            this.DataTables.Text = "dataGridView1";
            this.DataTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTables_CellContentClick);
            // 
            // Add_IT_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 575);
            this.Controls.Add(this.DataTables);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadTableBtn);
            this.Controls.Add(this.DeleteLb);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PasswordLb);
            this.Controls.Add(this.EmailLb);
            this.Controls.Add(this.LastNameLb);
            this.Controls.Add(this.FirstNameLb);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.CloseBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_IT_Users";
            this.Text = "IT_Users";
            this.Load += new System.EventHandler(this.Add_IT_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label FirstNameLb;
        private System.Windows.Forms.Label LastNameLb;
        private System.Windows.Forms.Label EmailLb;
        private System.Windows.Forms.Label PasswordLb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteLb;
        private System.Windows.Forms.Button LoadTableBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.DataGridView DataTables;
    }
}