namespace CourierProject
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login_button1 = new System.Windows.Forms.Button();
            this.signup_button1 = new System.Windows.Forms.Button();
            this.cnictextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 3;
            // 
            // login_button1
            // 
            this.login_button1.Location = new System.Drawing.Point(296, 202);
            this.login_button1.Name = "login_button1";
            this.login_button1.Size = new System.Drawing.Size(75, 23);
            this.login_button1.TabIndex = 4;
            this.login_button1.Text = "LOGIN";
            this.login_button1.UseVisualStyleBackColor = true;
            this.login_button1.Click += new System.EventHandler(this.login_button1_Click);
            // 
            // signup_button1
            // 
            this.signup_button1.Location = new System.Drawing.Point(409, 202);
            this.signup_button1.Name = "signup_button1";
            this.signup_button1.Size = new System.Drawing.Size(75, 23);
            this.signup_button1.TabIndex = 5;
            this.signup_button1.Text = "SIGNUP";
            this.signup_button1.UseVisualStyleBackColor = true;
            this.signup_button1.Click += new System.EventHandler(this.signup_button1_Click);
            // 
            // cnictextbox
            // 
            this.cnictextbox.Location = new System.Drawing.Point(275, 75);
            this.cnictextbox.Name = "cnictextbox";
            this.cnictextbox.Size = new System.Drawing.Size(222, 20);
            this.cnictextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNIC";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 278);
            this.Controls.Add(this.cnictextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signup_button1);
            this.Controls.Add(this.login_button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button login_button1;
        private System.Windows.Forms.Button signup_button1;
        private System.Windows.Forms.TextBox cnictextbox;
        private System.Windows.Forms.Label label3;
    }
}