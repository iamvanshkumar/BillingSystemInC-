namespace Billing_system
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
            this.title = new System.Windows.Forms.Label();
            this.login_title = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("AlphaMaleModern", 32F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(38, 7);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.MaximumSize = new System.Drawing.Size(554, 30);
            this.title.MinimumSize = new System.Drawing.Size(554, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(554, 30);
            this.title.TabIndex = 0;
            this.title.Text = "PATHOLOGY LAB BILLING SYSTEM";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_title
            // 
            this.login_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.login_title.Location = new System.Drawing.Point(254, 55);
            this.login_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_title.Name = "login_title";
            this.login_title.Size = new System.Drawing.Size(98, 19);
            this.login_title.TabIndex = 3;
            this.login_title.Text = "ADMIN LOGIN";
            this.login_title.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(303, 139);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.MaximumSize = new System.Drawing.Size(141, 22);
            this.txtUser.MinimumSize = new System.Drawing.Size(141, 22);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(141, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(303, 194);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(141, 20);
            this.txtPass.TabIndex = 5;
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_username.Location = new System.Drawing.Point(132, 137);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(128, 18);
            this.label_username.TabIndex = 6;
            this.label_username.Text = "USERNAME :";
            this.label_username.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_password
            // 
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_password.Location = new System.Drawing.Point(132, 194);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(128, 18);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "PASSWORD :";
            this.label_password.Click += new System.EventHandler(this.label4_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.GreenYellow;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(236, 248);
            this.button_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_login.MaximumSize = new System.Drawing.Size(129, 36);
            this.button_login.MinimumSize = new System.Drawing.Size(129, 36);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(129, 36);
            this.button_login.TabIndex = 8;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.login_title);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(691, 405);
            this.MinimumSize = new System.Drawing.Size(616, 405);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label login_title;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
    }
}

