namespace randomdatagen
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
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_info = new System.Windows.Forms.Label();
			this.rb_Student = new System.Windows.Forms.RadioButton();
			this.rb_Teacher = new System.Windows.Forms.RadioButton();
			this.btn_GenTables = new System.Windows.Forms.Button();
			this.rb_AllData = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Generate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(91, 14);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(74, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(171, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "lines";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(12, 50);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(904, 450);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Location = new System.Drawing.Point(12, 511);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Copy";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(93, 516);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Generated: ";
			// 
			// lbl_info
			// 
			this.lbl_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_info.AutoSize = true;
			this.lbl_info.Location = new System.Drawing.Point(162, 516);
			this.lbl_info.Name = "lbl_info";
			this.lbl_info.Size = new System.Drawing.Size(13, 13);
			this.lbl_info.TabIndex = 6;
			this.lbl_info.Text = "0";
			// 
			// rb_Student
			// 
			this.rb_Student.AutoSize = true;
			this.rb_Student.Checked = true;
			this.rb_Student.Location = new System.Drawing.Point(222, 15);
			this.rb_Student.Name = "rb_Student";
			this.rb_Student.Size = new System.Drawing.Size(62, 17);
			this.rb_Student.TabIndex = 7;
			this.rb_Student.TabStop = true;
			this.rb_Student.Text = "Student";
			this.rb_Student.UseVisualStyleBackColor = true;
			// 
			// rb_Teacher
			// 
			this.rb_Teacher.AutoSize = true;
			this.rb_Teacher.Location = new System.Drawing.Point(290, 15);
			this.rb_Teacher.Name = "rb_Teacher";
			this.rb_Teacher.Size = new System.Drawing.Size(65, 17);
			this.rb_Teacher.TabIndex = 8;
			this.rb_Teacher.Text = "Teacher";
			this.rb_Teacher.UseVisualStyleBackColor = true;
			// 
			// btn_GenTables
			// 
			this.btn_GenTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_GenTables.Location = new System.Drawing.Point(773, 12);
			this.btn_GenTables.Name = "btn_GenTables";
			this.btn_GenTables.Size = new System.Drawing.Size(143, 23);
			this.btn_GenTables.TabIndex = 9;
			this.btn_GenTables.Text = "Generate Tables";
			this.btn_GenTables.UseVisualStyleBackColor = true;
			this.btn_GenTables.Click += new System.EventHandler(this.btn_GenTables_Click);
			// 
			// rb_AllData
			// 
			this.rb_AllData.AutoSize = true;
			this.rb_AllData.Location = new System.Drawing.Point(361, 14);
			this.rb_AllData.Name = "rb_AllData";
			this.rb_AllData.Size = new System.Drawing.Size(62, 17);
			this.rb_AllData.TabIndex = 10;
			this.rb_AllData.Text = "All Data";
			this.rb_AllData.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 546);
			this.Controls.Add(this.rb_AllData);
			this.Controls.Add(this.btn_GenTables);
			this.Controls.Add(this.rb_Teacher);
			this.Controls.Add(this.rb_Student);
			this.Controls.Add(this.lbl_info);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_info;
		private System.Windows.Forms.RadioButton rb_Student;
		private System.Windows.Forms.RadioButton rb_Teacher;
		private System.Windows.Forms.Button btn_GenTables;
		private System.Windows.Forms.RadioButton rb_AllData;
	}
}

