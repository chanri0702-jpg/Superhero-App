namespace PRG_282_Project
{
    partial class MainMenuForm
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
            this.btnToSubmitForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToSubmitForm
            // 
            this.btnToSubmitForm.Location = new System.Drawing.Point(49, 31);
            this.btnToSubmitForm.Name = "btnToSubmitForm";
            this.btnToSubmitForm.Size = new System.Drawing.Size(128, 23);
            this.btnToSubmitForm.TabIndex = 0;
            this.btnToSubmitForm.Text = "Add New Student";
            this.btnToSubmitForm.UseVisualStyleBackColor = true;
            this.btnToSubmitForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToSubmitForm);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToSubmitForm;
    }
}

