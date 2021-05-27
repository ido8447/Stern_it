namespace stern_it
{
    partial class read_write
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(read_write));
            this.Next = new System.Windows.Forms.Button();
            this.WriteRB = new System.Windows.Forms.RadioButton();
            this.ReadRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(718, 626);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(107, 36);
            this.Next.TabIndex = 0;
            this.Next.Text = "Enter";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // WriteRB
            // 
            this.WriteRB.AutoSize = true;
            this.WriteRB.Location = new System.Drawing.Point(11, 581);
            this.WriteRB.Name = "WriteRB";
            this.WriteRB.Size = new System.Drawing.Size(79, 29);
            this.WriteRB.TabIndex = 1;
            this.WriteRB.TabStop = true;
            this.WriteRB.Text = "Write";
            this.WriteRB.UseVisualStyleBackColor = true;
            // 
            // ReadRB
            // 
            this.ReadRB.AutoSize = true;
            this.ReadRB.Location = new System.Drawing.Point(11, 627);
            this.ReadRB.Name = "ReadRB";
            this.ReadRB.Size = new System.Drawing.Size(76, 29);
            this.ReadRB.TabIndex = 2;
            this.ReadRB.TabStop = true;
            this.ReadRB.Text = "Read";
            this.ReadRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write: The request\r\n\r\nRead: The answer - add id:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(949, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 566);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(831, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "load table";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 629);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 31);
            this.textBox1.TabIndex = 7;
            // 
            // read_write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 671);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadRB);
            this.Controls.Add(this.WriteRB);
            this.Controls.Add(this.Next);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "read_write";
            this.Text = "read_write";
            this.Load += new System.EventHandler(this.read_write_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.RadioButton WriteRB;
        private System.Windows.Forms.RadioButton ReadRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}