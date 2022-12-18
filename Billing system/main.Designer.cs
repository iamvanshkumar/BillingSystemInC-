namespace Billing_system
{
    partial class main
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
            this.title = new System.Windows.Forms.Label();
            this.bill = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(346, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("AlphaMaleModern", 32F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(32, 20);
            this.title.MaximumSize = new System.Drawing.Size(738, 37);
            this.title.MinimumSize = new System.Drawing.Size(738, 37);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(738, 37);
            this.title.TabIndex = 1;
            this.title.Text = "PATHOLOGY LAB BILLING SYSTEM";
            // 
            // bill
            // 
            this.bill.BackColor = System.Drawing.Color.PaleGreen;
            this.bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bill.Location = new System.Drawing.Point(87, 183);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(259, 88);
            this.bill.TabIndex = 2;
            this.bill.Text = "Billing";
            this.bill.UseVisualStyleBackColor = false;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Exit.Location = new System.Drawing.Point(475, 183);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(259, 88);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Button Exit;
    }
}