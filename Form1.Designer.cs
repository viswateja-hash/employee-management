namespace Employee_management_System
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
            this.Admin1 = new System.Windows.Forms.Label();
            this.Password1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.RichTextBox();
            this.Password = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin1
            // 
            this.Admin1.AutoSize = true;
            this.Admin1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin1.Location = new System.Drawing.Point(202, 251);
            this.Admin1.Name = "Admin1";
            this.Admin1.Size = new System.Drawing.Size(111, 37);
            this.Admin1.TabIndex = 6;
            this.Admin1.Text = "Admin";
            // 
            // Password1
            // 
            this.Password1.AutoSize = true;
            this.Password1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password1.Location = new System.Drawing.Point(187, 336);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(152, 37);
            this.Password1.TabIndex = 7;
            this.Password1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Management System";
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Cyan;
            this.Admin.Location = new System.Drawing.Point(384, 251);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(212, 42);
            this.Admin.TabIndex = 9;
            this.Admin.Text = "";
            this.Admin.TextChanged += new System.EventHandler(this.Admin_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Cyan;
            this.Password.Location = new System.Drawing.Point(384, 331);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(212, 42);
            this.Password.TabIndex = 10;
            this.Password.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Employee_management_System.Properties.Resources.icon31;
            this.pictureBox1.Location = new System.Drawing.Point(301, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(291, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(291, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(776, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.Admin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Admin1;
        private System.Windows.Forms.Label Password1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Admin;
        private System.Windows.Forms.RichTextBox Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

