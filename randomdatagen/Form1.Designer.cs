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
			this.btn_OpenClose = new System.Windows.Forms.Button();
			this.btn_SELECT_Simple = new System.Windows.Forms.Button();
			this.btn_SELECT_Specific = new System.Windows.Forms.Button();
			this.btn_SELECT_Where = new System.Windows.Forms.Button();
			this.btn_SELECT_Limit = new System.Windows.Forms.Button();
			this.btn_SELECT_SubSelect = new System.Windows.Forms.Button();
			this.btn_SELECT_Join = new System.Windows.Forms.Button();
			this.btn_SELECT_Complex = new System.Windows.Forms.Button();
			this.btn_SELECT_VeryComplex = new System.Windows.Forms.Button();
			this.btn_INSERT_Simple = new System.Windows.Forms.Button();
			this.btn_INSERT_Complex = new System.Windows.Forms.Button();
			this.btn_UPDATE_Simple = new System.Windows.Forms.Button();
			this.btn_UPDATE_Complex = new System.Windows.Forms.Button();
			this.btn_Misc = new System.Windows.Forms.Button();
			this.btn_DELETE_Complex = new System.Windows.Forms.Button();
			this.btn_DELETE_Simple = new System.Windows.Forms.Button();
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
			this.richTextBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.richTextBox1.Location = new System.Drawing.Point(12, 50);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(730, 450);
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
			this.btn_GenTables.Location = new System.Drawing.Point(744, 12);
			this.btn_GenTables.Name = "btn_GenTables";
			this.btn_GenTables.Size = new System.Drawing.Size(106, 23);
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
			// btn_OpenClose
			// 
			this.btn_OpenClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_OpenClose.Location = new System.Drawing.Point(856, 12);
			this.btn_OpenClose.Name = "btn_OpenClose";
			this.btn_OpenClose.Size = new System.Drawing.Size(60, 23);
			this.btn_OpenClose.TabIndex = 11;
			this.btn_OpenClose.Text = "<";
			this.btn_OpenClose.UseVisualStyleBackColor = true;
			this.btn_OpenClose.Click += new System.EventHandler(this.btn_OpenClose_Click);
			// 
			// btn_SELECT_Simple
			// 
			this.btn_SELECT_Simple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SELECT_Simple.Location = new System.Drawing.Point(748, 56);
			this.btn_SELECT_Simple.Name = "btn_SELECT_Simple";
			this.btn_SELECT_Simple.Size = new System.Drawing.Size(161, 23);
			this.btn_SELECT_Simple.TabIndex = 12;
			this.btn_SELECT_Simple.Tag = "1";
			this.btn_SELECT_Simple.Text = "Simple SELECT";
			this.btn_SELECT_Simple.UseVisualStyleBackColor = true;
			this.btn_SELECT_Simple.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_SELECT_Specific
			// 
			this.btn_SELECT_Specific.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SELECT_Specific.Location = new System.Drawing.Point(748, 85);
			this.btn_SELECT_Specific.Name = "btn_SELECT_Specific";
			this.btn_SELECT_Specific.Size = new System.Drawing.Size(161, 23);
			this.btn_SELECT_Specific.TabIndex = 13;
			this.btn_SELECT_Specific.Tag = "2";
			this.btn_SELECT_Specific.Text = "SELECT specific columns";
			this.btn_SELECT_Specific.UseVisualStyleBackColor = true;
			this.btn_SELECT_Specific.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_SELECT_Where
			// 
			this.btn_SELECT_Where.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SELECT_Where.Location = new System.Drawing.Point(748, 114);
			this.btn_SELECT_Where.Name = "btn_SELECT_Where";
			this.btn_SELECT_Where.Size = new System.Drawing.Size(161, 23);
			this.btn_SELECT_Where.TabIndex = 14;
			this.btn_SELECT_Where.Tag = "3";
			this.btn_SELECT_Where.Text = "SELECT and WHERE";
			this.btn_SELECT_Where.UseVisualStyleBackColor = true;
			this.btn_SELECT_Where.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_SELECT_Limit
			// 
			this.btn_SELECT_Limit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SELECT_Limit.Location = new System.Drawing.Point(748, 143);
			this.btn_SELECT_Limit.Name = "btn_SELECT_Limit";
			this.btn_SELECT_Limit.Size = new System.Drawing.Size(161, 23);
			this.btn_SELECT_Limit.TabIndex = 15;
			this.btn_SELECT_Limit.Tag = "4";
			this.btn_SELECT_Limit.Text = "SELECT and LIMIT";
			this.btn_SELECT_Limit.UseVisualStyleBackColor = true;
			this.btn_SELECT_Limit.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_SELECT_SubSelect
			// 
			this.btn_SELECT_SubSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SELECT_SubSelect.Location = new System.Drawing.Point(748, 172);
			this.btn_SELECT_SubSelect.Name = "btn_SELECT_SubSelect";
			this.btn_SELECT_SubSelect.Size = new System.Drawing.Size(161, 23);
			this.btn_SELECT_SubSelect.TabIndex = 16;
			this.btn_SELECT_SubSelect.Tag = "5";
			this.btn_SELECT_SubSelect.Text = "SELECT and subSELECT";
			this.btn_SELECT_SubSelect.UseVisualStyleBackColor = true;
			this.btn_SELECT_SubSelect.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_SELECT_Join
			// 
			this.btn_SELECT_Join.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SELECT_Join.Location = new System.Drawing.Point(748, 201);
			this.btn_SELECT_Join.Name = "btn_SELECT_Join";
			this.btn_SELECT_Join.Size = new System.Drawing.Size(161, 23);
			this.btn_SELECT_Join.TabIndex = 17;
			this.btn_SELECT_Join.Tag = "6";
			this.btn_SELECT_Join.Text = "SELECT and JOIN";
			this.btn_SELECT_Join.UseVisualStyleBackColor = true;
			this.btn_SELECT_Join.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_SELECT_Complex
			// 
			this.btn_SELECT_Complex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SELECT_Complex.Location = new System.Drawing.Point(748, 230);
			this.btn_SELECT_Complex.Name = "btn_SELECT_Complex";
			this.btn_SELECT_Complex.Size = new System.Drawing.Size(161, 23);
			this.btn_SELECT_Complex.TabIndex = 18;
			this.btn_SELECT_Complex.Tag = "7";
			this.btn_SELECT_Complex.Text = "Complex SELECT";
			this.btn_SELECT_Complex.UseVisualStyleBackColor = true;
			this.btn_SELECT_Complex.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_SELECT_VeryComplex
			// 
			this.btn_SELECT_VeryComplex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SELECT_VeryComplex.Location = new System.Drawing.Point(748, 259);
			this.btn_SELECT_VeryComplex.Name = "btn_SELECT_VeryComplex";
			this.btn_SELECT_VeryComplex.Size = new System.Drawing.Size(161, 23);
			this.btn_SELECT_VeryComplex.TabIndex = 19;
			this.btn_SELECT_VeryComplex.Tag = "8";
			this.btn_SELECT_VeryComplex.Text = "Very complex SELECT";
			this.btn_SELECT_VeryComplex.UseVisualStyleBackColor = true;
			this.btn_SELECT_VeryComplex.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_INSERT_Simple
			// 
			this.btn_INSERT_Simple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_INSERT_Simple.Location = new System.Drawing.Point(748, 288);
			this.btn_INSERT_Simple.Name = "btn_INSERT_Simple";
			this.btn_INSERT_Simple.Size = new System.Drawing.Size(161, 23);
			this.btn_INSERT_Simple.TabIndex = 20;
			this.btn_INSERT_Simple.Tag = "9";
			this.btn_INSERT_Simple.Text = "Simple INSERT";
			this.btn_INSERT_Simple.UseVisualStyleBackColor = true;
			this.btn_INSERT_Simple.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_INSERT_Complex
			// 
			this.btn_INSERT_Complex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_INSERT_Complex.Location = new System.Drawing.Point(748, 317);
			this.btn_INSERT_Complex.Name = "btn_INSERT_Complex";
			this.btn_INSERT_Complex.Size = new System.Drawing.Size(161, 23);
			this.btn_INSERT_Complex.TabIndex = 21;
			this.btn_INSERT_Complex.Tag = "10";
			this.btn_INSERT_Complex.Text = "Complex INSERT";
			this.btn_INSERT_Complex.UseVisualStyleBackColor = true;
			this.btn_INSERT_Complex.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_UPDATE_Simple
			// 
			this.btn_UPDATE_Simple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_UPDATE_Simple.Location = new System.Drawing.Point(748, 346);
			this.btn_UPDATE_Simple.Name = "btn_UPDATE_Simple";
			this.btn_UPDATE_Simple.Size = new System.Drawing.Size(161, 23);
			this.btn_UPDATE_Simple.TabIndex = 22;
			this.btn_UPDATE_Simple.Tag = "11";
			this.btn_UPDATE_Simple.Text = "Simple UPDATE";
			this.btn_UPDATE_Simple.UseVisualStyleBackColor = true;
			this.btn_UPDATE_Simple.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_UPDATE_Complex
			// 
			this.btn_UPDATE_Complex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_UPDATE_Complex.Location = new System.Drawing.Point(748, 375);
			this.btn_UPDATE_Complex.Name = "btn_UPDATE_Complex";
			this.btn_UPDATE_Complex.Size = new System.Drawing.Size(161, 23);
			this.btn_UPDATE_Complex.TabIndex = 23;
			this.btn_UPDATE_Complex.Tag = "12";
			this.btn_UPDATE_Complex.Text = "Complex UPDATE";
			this.btn_UPDATE_Complex.UseVisualStyleBackColor = true;
			this.btn_UPDATE_Complex.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_Misc
			// 
			this.btn_Misc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Misc.Location = new System.Drawing.Point(748, 462);
			this.btn_Misc.Name = "btn_Misc";
			this.btn_Misc.Size = new System.Drawing.Size(161, 23);
			this.btn_Misc.TabIndex = 26;
			this.btn_Misc.Tag = "15";
			this.btn_Misc.Text = "Misc";
			this.btn_Misc.UseVisualStyleBackColor = true;
			this.btn_Misc.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_DELETE_Complex
			// 
			this.btn_DELETE_Complex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_DELETE_Complex.Location = new System.Drawing.Point(748, 433);
			this.btn_DELETE_Complex.Name = "btn_DELETE_Complex";
			this.btn_DELETE_Complex.Size = new System.Drawing.Size(161, 23);
			this.btn_DELETE_Complex.TabIndex = 25;
			this.btn_DELETE_Complex.Tag = "14";
			this.btn_DELETE_Complex.Text = "Complex DELETE";
			this.btn_DELETE_Complex.UseVisualStyleBackColor = true;
			this.btn_DELETE_Complex.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// btn_DELETE_Simple
			// 
			this.btn_DELETE_Simple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_DELETE_Simple.Location = new System.Drawing.Point(748, 404);
			this.btn_DELETE_Simple.Name = "btn_DELETE_Simple";
			this.btn_DELETE_Simple.Size = new System.Drawing.Size(161, 23);
			this.btn_DELETE_Simple.TabIndex = 24;
			this.btn_DELETE_Simple.Tag = "13";
			this.btn_DELETE_Simple.Text = "Simple DELETE";
			this.btn_DELETE_Simple.UseVisualStyleBackColor = true;
			this.btn_DELETE_Simple.Click += new System.EventHandler(this.btn_CLICK);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 546);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btn_Misc);
			this.Controls.Add(this.btn_DELETE_Complex);
			this.Controls.Add(this.btn_DELETE_Simple);
			this.Controls.Add(this.btn_UPDATE_Complex);
			this.Controls.Add(this.btn_UPDATE_Simple);
			this.Controls.Add(this.btn_INSERT_Complex);
			this.Controls.Add(this.btn_INSERT_Simple);
			this.Controls.Add(this.btn_SELECT_VeryComplex);
			this.Controls.Add(this.btn_SELECT_Complex);
			this.Controls.Add(this.btn_SELECT_Join);
			this.Controls.Add(this.btn_SELECT_SubSelect);
			this.Controls.Add(this.btn_SELECT_Limit);
			this.Controls.Add(this.btn_SELECT_Where);
			this.Controls.Add(this.btn_SELECT_Specific);
			this.Controls.Add(this.btn_SELECT_Simple);
			this.Controls.Add(this.btn_OpenClose);
			this.Controls.Add(this.rb_AllData);
			this.Controls.Add(this.btn_GenTables);
			this.Controls.Add(this.rb_Teacher);
			this.Controls.Add(this.rb_Student);
			this.Controls.Add(this.lbl_info);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
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
		private System.Windows.Forms.Button btn_OpenClose;
		private System.Windows.Forms.Button btn_SELECT_Simple;
		private System.Windows.Forms.Button btn_SELECT_Specific;
		private System.Windows.Forms.Button btn_SELECT_Where;
		private System.Windows.Forms.Button btn_SELECT_Limit;
		private System.Windows.Forms.Button btn_SELECT_SubSelect;
		private System.Windows.Forms.Button btn_SELECT_Join;
		private System.Windows.Forms.Button btn_SELECT_Complex;
		private System.Windows.Forms.Button btn_SELECT_VeryComplex;
		private System.Windows.Forms.Button btn_INSERT_Simple;
		private System.Windows.Forms.Button btn_INSERT_Complex;
		private System.Windows.Forms.Button btn_UPDATE_Simple;
		private System.Windows.Forms.Button btn_UPDATE_Complex;
		private System.Windows.Forms.Button btn_Misc;
		private System.Windows.Forms.Button btn_DELETE_Complex;
		private System.Windows.Forms.Button btn_DELETE_Simple;
	}
}

