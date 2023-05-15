namespace RPContactsUI
{
    partial class Form2
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.textBox_Job = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Job = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.panel_OK_Cancel = new System.Windows.Forms.Panel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.panel_Main.SuspendLayout();
            this.panel_OK_Cancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.textBox_Email);
            this.panel_Main.Controls.Add(this.textBox_Job);
            this.panel_Main.Controls.Add(this.textBox_Name);
            this.panel_Main.Controls.Add(this.label_Email);
            this.panel_Main.Controls.Add(this.label_Job);
            this.panel_Main.Controls.Add(this.label_Name);
            this.panel_Main.Location = new System.Drawing.Point(13, 13);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(259, 91);
            this.panel_Main.TabIndex = 0;
            // 
            // textBox_Job
            // 
            this.textBox_Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Job.Location = new System.Drawing.Point(57, 33);
            this.textBox_Job.Name = "textBox_Job";
            this.textBox_Job.Size = new System.Drawing.Size(187, 22);
            this.textBox_Job.TabIndex = 4;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Name.Location = new System.Drawing.Point(57, 7);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(187, 22);
            this.textBox_Name.TabIndex = 3;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Email.Location = new System.Drawing.Point(3, 62);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(49, 16);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "E-mail:";
            // 
            // label_Job
            // 
            this.label_Job.AutoSize = true;
            this.label_Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Job.Location = new System.Drawing.Point(3, 36);
            this.label_Job.Name = "label_Job";
            this.label_Job.Size = new System.Drawing.Size(34, 16);
            this.label_Job.TabIndex = 1;
            this.label_Job.Text = "Job:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Name.Location = new System.Drawing.Point(3, 10);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(48, 16);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Email.Location = new System.Drawing.Point(57, 59);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(187, 22);
            this.textBox_Email.TabIndex = 5;
            // 
            // panel_OK_Cancel
            // 
            this.panel_OK_Cancel.Controls.Add(this.button_OK);
            this.panel_OK_Cancel.Controls.Add(this.button_Cancel);
            this.panel_OK_Cancel.Location = new System.Drawing.Point(13, 110);
            this.panel_OK_Cancel.Name = "panel_OK_Cancel";
            this.panel_OK_Cancel.Size = new System.Drawing.Size(259, 42);
            this.panel_OK_Cancel.TabIndex = 1;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Cancel.Location = new System.Drawing.Point(57, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_OK.Location = new System.Drawing.Point(169, 3);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 164);
            this.Controls.Add(this.panel_OK_Cancel);
            this.Controls.Add(this.panel_Main);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            this.panel_OK_Cancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Job;
        private System.Windows.Forms.TextBox textBox_Job;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Panel panel_OK_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}