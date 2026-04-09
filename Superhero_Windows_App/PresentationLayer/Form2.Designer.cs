namespace PRG_282_Project
{
    partial class NewStudentForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtSuperPower = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtExamScore = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SuperPowerLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ExamScoreLabel = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(161, 81);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(249, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtSuperPower
            // 
            this.txtSuperPower.Location = new System.Drawing.Point(161, 132);
            this.txtSuperPower.Name = "txtSuperPower";
            this.txtSuperPower.Size = new System.Drawing.Size(249, 20);
            this.txtSuperPower.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(161, 186);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(249, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtExamScore
            // 
            this.txtExamScore.Location = new System.Drawing.Point(161, 240);
            this.txtExamScore.Name = "txtExamScore";
            this.txtExamScore.Size = new System.Drawing.Size(249, 20);
            this.txtExamScore.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "StudentName";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(12, 81);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(89, 13);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Student Surname";
            // 
            // SuperPowerLabel
            // 
            this.SuperPowerLabel.AutoSize = true;
            this.SuperPowerLabel.Location = new System.Drawing.Point(12, 132);
            this.SuperPowerLabel.Name = "SuperPowerLabel";
            this.SuperPowerLabel.Size = new System.Drawing.Size(108, 13);
            this.SuperPowerLabel.TabIndex = 7;
            this.SuperPowerLabel.Text = "Student Super Power";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 182);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(66, 13);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = "Student Age";
            // 
            // ExamScoreLabel
            // 
            this.ExamScoreLabel.AutoSize = true;
            this.ExamScoreLabel.Location = new System.Drawing.Point(12, 236);
            this.ExamScoreLabel.Name = "ExamScoreLabel";
            this.ExamScoreLabel.Size = new System.Drawing.Size(104, 13);
            this.ExamScoreLabel.TabIndex = 9;
            this.ExamScoreLabel.Text = "Student Exam Score";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(95, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 57);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ExamScoreLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SuperPowerLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.txtExamScore);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtSuperPower);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "NewStudentForm";
            this.Text = "NewStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtSuperPower;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtExamScore;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label SuperPowerLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label ExamScoreLabel;
        private System.Windows.Forms.Button btnSubmit;
    }
}