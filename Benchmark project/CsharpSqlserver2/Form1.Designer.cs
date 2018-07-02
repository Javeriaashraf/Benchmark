namespace CsharpSqlserver2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StudentNameText = new System.Windows.Forms.TextBox();
            this.FatherNameText = new System.Windows.Forms.TextBox();
            this.StudentNumber1 = new System.Windows.Forms.TextBox();
            this.StudentNumber2 = new System.Windows.Forms.TextBox();
            this.ReferanceNametext = new System.Windows.Forms.TextBox();
            this.ReferanceNumberText = new System.Windows.Forms.TextBox();
            this.ProgramText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label9 = new System.Windows.Forms.Label();
            this.GRnumtext = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentNameText
            // 
            this.StudentNameText.BackColor = System.Drawing.Color.White;
            this.StudentNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameText.Location = new System.Drawing.Point(265, 112);
            this.StudentNameText.Name = "StudentNameText";
            this.StudentNameText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentNameText.Size = new System.Drawing.Size(361, 29);
            this.StudentNameText.TabIndex = 0;
            this.StudentNameText.Click += new System.EventHandler(this.inputText);
            this.StudentNameText.TextChanged += new System.EventHandler(this.StudentNameText_TextChanged);
            // 
            // FatherNameText
            // 
            this.FatherNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherNameText.Location = new System.Drawing.Point(265, 160);
            this.FatherNameText.Name = "FatherNameText";
            this.FatherNameText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FatherNameText.Size = new System.Drawing.Size(361, 29);
            this.FatherNameText.TabIndex = 1;
            this.FatherNameText.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.inputText);
            // 
            // StudentNumber1
            // 
            this.StudentNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNumber1.Location = new System.Drawing.Point(265, 208);
            this.StudentNumber1.Name = "StudentNumber1";
            this.StudentNumber1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentNumber1.Size = new System.Drawing.Size(361, 29);
            this.StudentNumber1.TabIndex = 2;
            this.StudentNumber1.Click += new System.EventHandler(this.inputText);
            this.StudentNumber1.TextChanged += new System.EventHandler(this.StudentNumber1_TextChanged);
            // 
            // StudentNumber2
            // 
            this.StudentNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNumber2.Location = new System.Drawing.Point(265, 256);
            this.StudentNumber2.Name = "StudentNumber2";
            this.StudentNumber2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentNumber2.Size = new System.Drawing.Size(361, 29);
            this.StudentNumber2.TabIndex = 3;
            this.StudentNumber2.Click += new System.EventHandler(this.inputText);
            // 
            // ReferanceNametext
            // 
            this.ReferanceNametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferanceNametext.Location = new System.Drawing.Point(265, 304);
            this.ReferanceNametext.Name = "ReferanceNametext";
            this.ReferanceNametext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReferanceNametext.Size = new System.Drawing.Size(361, 29);
            this.ReferanceNametext.TabIndex = 4;
            this.ReferanceNametext.Click += new System.EventHandler(this.inputText);
            this.ReferanceNametext.TextChanged += new System.EventHandler(this.inputText);
            // 
            // ReferanceNumberText
            // 
            this.ReferanceNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferanceNumberText.Location = new System.Drawing.Point(265, 352);
            this.ReferanceNumberText.Name = "ReferanceNumberText";
            this.ReferanceNumberText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReferanceNumberText.Size = new System.Drawing.Size(361, 29);
            this.ReferanceNumberText.TabIndex = 5;
            this.ReferanceNumberText.Click += new System.EventHandler(this.inputText);
            this.ReferanceNumberText.TextChanged += new System.EventHandler(this.inputText);
            // 
            // ProgramText
            // 
            this.ProgramText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramText.Location = new System.Drawing.Point(265, 450);
            this.ProgramText.Name = "ProgramText";
            this.ProgramText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgramText.Size = new System.Drawing.Size(361, 29);
            this.ProgramText.TabIndex = 7;
            this.ProgramText.Click += new System.EventHandler(this.inputText);
            this.ProgramText.TextChanged += new System.EventHandler(this.inputText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name";
            this.label1.Click += new System.EventHandler(this.labelClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Father\'s Name";
            this.label2.Click += new System.EventHandler(this.labelClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student\'s Mobile Numer";
            this.label3.Click += new System.EventHandler(this.labelClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student\'s Mobile Number\r\n(optional)";
            this.label4.Click += new System.EventHandler(this.labelClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Referance Name";
            this.label5.Click += new System.EventHandler(this.labelClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Referance Mobile Number";
            this.label6.Click += new System.EventHandler(this.labelClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date of Admission";
            this.label7.Click += new System.EventHandler(this.labelClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Program";
            this.label8.Click += new System.EventHandler(this.labelClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 400);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(361, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(173, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 55);
            this.label10.TabIndex = 10;
            this.label10.Text = "Registration";
            this.label10.Click += new System.EventHandler(this.labelClick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(502, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save and Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Insert);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(725, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 750);
            this.vScrollBar1.TabIndex = 31;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "GR. No.";
            // 
            // GRnumtext
            // 
            this.GRnumtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRnumtext.Location = new System.Drawing.Point(265, 487);
            this.GRnumtext.Name = "GRnumtext";
            this.GRnumtext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GRnumtext.Size = new System.Drawing.Size(361, 29);
            this.GRnumtext.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(44, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GRnumtext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentNumber2);
            this.Controls.Add(this.ProgramText);
            this.Controls.Add(this.StudentNumber1);
            this.Controls.Add(this.ReferanceNumberText);
            this.Controls.Add(this.ReferanceNametext);
            this.Controls.Add(this.FatherNameText);
            this.Controls.Add(this.StudentNameText);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.enable);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentNameText;
        private System.Windows.Forms.TextBox FatherNameText;
        private System.Windows.Forms.TextBox StudentNumber1;
        private System.Windows.Forms.TextBox StudentNumber2;
        private System.Windows.Forms.TextBox ReferanceNametext;
        private System.Windows.Forms.TextBox ReferanceNumberText;
        private System.Windows.Forms.TextBox ProgramText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GRnumtext;
        private System.Windows.Forms.Button button2;
    }
}

