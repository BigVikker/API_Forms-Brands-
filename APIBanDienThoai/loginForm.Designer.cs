namespace APIBanDienThoai
{
    partial class loginForm
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
            this.label_userName = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(124, 63);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(60, 13);
            this.label_userName.TabIndex = 0;
            this.label_userName.Text = "User Name";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(124, 102);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(30, 13);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "Pass";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(252, 60);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(201, 20);
            this.textBox_userName.TabIndex = 2;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(252, 102);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(201, 20);
            this.textBox_pass.TabIndex = 3;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(225, 152);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "Dang Nhap";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 269);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_userName);
            this.Name = "loginForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_submit;
    }
}