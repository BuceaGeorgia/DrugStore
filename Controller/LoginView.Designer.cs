namespace Controller
{
    partial class LoginView
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
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(157, 130);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(100, 20);
            this.textpassword.TabIndex = 0;
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(159, 74);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(100, 20);
            this.textuser.TabIndex = 1;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(61, 72);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(92, 22);
            this.lab.TabIndex = 2;
            this.lab.Text = "Username";
            this.lab.Click += new System.EventHandler(this.lab_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.Location = new System.Drawing.Point(61, 127);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(90, 22);
            this.lab2.TabIndex = 3;
            this.lab2.Text = "Password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(223, 178);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(342, 236);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.textpassword);
            this.Name = "LoginView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Button login;
    }
}

