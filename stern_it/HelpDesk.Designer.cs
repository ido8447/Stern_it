namespace stern_it
{
    partial class HelpDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDesk));
            this.TitleLb = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.PriorityLb = new System.Windows.Forms.Label();
            this.PriorityTxt = new System.Windows.Forms.ComboBox();
            this.DescriptionLb = new System.Windows.Forms.Label();
            this.descriptionTXT = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Location = new System.Drawing.Point(75, 106);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(53, 25);
            this.TitleLb.TabIndex = 0;
            this.TitleLb.Text = "Title: ";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(134, 106);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(220, 31);
            this.TitleTxt.TabIndex = 1;
            // 
            // PriorityLb
            // 
            this.PriorityLb.AutoSize = true;
            this.PriorityLb.Location = new System.Drawing.Point(422, 103);
            this.PriorityLb.Name = "PriorityLb";
            this.PriorityLb.Size = new System.Drawing.Size(72, 25);
            this.PriorityLb.TabIndex = 2;
            this.PriorityLb.Text = "Priority:";
            // 
            // PriorityTxt
            // 
            this.PriorityTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityTxt.FormattingEnabled = true;
            this.PriorityTxt.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.PriorityTxt.Location = new System.Drawing.Point(500, 103);
            this.PriorityTxt.Name = "PriorityTxt";
            this.PriorityTxt.Size = new System.Drawing.Size(220, 33);
            this.PriorityTxt.TabIndex = 3;
            // 
            // DescriptionLb
            // 
            this.DescriptionLb.AutoSize = true;
            this.DescriptionLb.Location = new System.Drawing.Point(25, 165);
            this.DescriptionLb.Name = "DescriptionLb";
            this.DescriptionLb.Size = new System.Drawing.Size(106, 25);
            this.DescriptionLb.TabIndex = 4;
            this.DescriptionLb.Text = "Description:";
            this.DescriptionLb.Click += new System.EventHandler(this.DescriptionLb_Click);
            // 
            // descriptionTXT
            // 
            this.descriptionTXT.Location = new System.Drawing.Point(134, 165);
            this.descriptionTXT.Multiline = true;
            this.descriptionTXT.Name = "descriptionTXT";
            this.descriptionTXT.Size = new System.Drawing.Size(586, 235);
            this.descriptionTXT.TabIndex = 5;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(608, 472);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(112, 34);
            this.SubmitBtn.TabIndex = 6;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(134, 472);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(112, 34);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hello:";
            // 
            // NameEmail
            // 
            this.NameEmail.AutoSize = true;
            this.NameEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameEmail.Location = new System.Drawing.Point(90, 30);
            this.NameEmail.Name = "NameEmail";
            this.NameEmail.Size = new System.Drawing.Size(22, 30);
            this.NameEmail.TabIndex = 17;
            this.NameEmail.Text = "-";
            // 
            // HelpDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 535);
            this.Controls.Add(this.NameEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.descriptionTXT);
            this.Controls.Add(this.DescriptionLb);
            this.Controls.Add(this.PriorityTxt);
            this.Controls.Add(this.PriorityLb);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.TitleLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpDesk";
            this.Text = "Help Desk";
            this.Load += new System.EventHandler(this.HelpDesk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.Label PriorityLb;
        private System.Windows.Forms.ComboBox PriorityTxt;
        private System.Windows.Forms.Label DescriptionLb;
        private System.Windows.Forms.TextBox descriptionTXT;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
       // private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameEmail;
    }
}