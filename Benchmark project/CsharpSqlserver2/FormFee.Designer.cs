namespace CsharpSqlserver2
{
    partial class FormFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFee));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FeeInput = new System.Windows.Forms.TextBox();
            this.Fees = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.Label();
            this.StudentIDInput = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admission Fee",
            "1st Month Fee",
            "2nd Month Fee",
            "3rd Month Fee",
            "4th Month Fee",
            "4th Month Fee",
            "5th Month Fee",
            "6th Month Fee",
            "7th Month Fee",
            "8th Month Fee",
            "9th Month Fee",
            "10th Month Fee",
            "11th Month Fee",
            "12th Month Fee",
            "13th Month Fee",
            "14th Month Fee",
            "15th Month Fee",
            "16th Month Fee",
            "17th Month Fee",
            "18th Month Fee",
            "19th Month Fee",
            "20th Month Fee",
            "21st Month Fee",
            "22nd Month Fee",
            "23rd Month Fee",
            "24th Month Fee",
            "Examination Fee",
            "Certificate Fee",
            "Security Deposit"});
            this.comboBox1.Location = new System.Drawing.Point(282, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 32);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Month";
            // 
            // FeeInput
            // 
            this.FeeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeInput.Location = new System.Drawing.Point(282, 357);
            this.FeeInput.Name = "FeeInput";
            this.FeeInput.Size = new System.Drawing.Size(210, 29);
            this.FeeInput.TabIndex = 3;
            // 
            // Fees
            // 
            this.Fees.AutoSize = true;
            this.Fees.BackColor = System.Drawing.Color.Transparent;
            this.Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees.Location = new System.Drawing.Point(132, 359);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(94, 24);
            this.Fees.TabIndex = 3;
            this.Fees.Text = "Enter Fee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FeeSubmission);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.BackColor = System.Drawing.Color.Transparent;
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(132, 169);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(91, 24);
            this.StudentID.TabIndex = 6;
            this.StudentID.Text = "StudentID";
            // 
            // StudentIDInput
            // 
            this.StudentIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDInput.Location = new System.Drawing.Point(282, 169);
            this.StudentIDInput.Name = "StudentIDInput";
            this.StudentIDInput.Size = new System.Drawing.Size(210, 29);
            this.StudentIDInput.TabIndex = 0;
            this.StudentIDInput.TextChanged += new System.EventHandler(this.StudentIDInput_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(69, 524);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // FormFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 584);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.StudentIDInput);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fees);
            this.Controls.Add(this.FeeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFee";
            this.Load += new System.EventHandler(this.FormFee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FeeInput;
        private System.Windows.Forms.Label Fees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.TextBox StudentIDInput;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}