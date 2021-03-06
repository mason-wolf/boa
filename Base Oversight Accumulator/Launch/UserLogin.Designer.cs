﻿namespace Base_Oversight_Accumulator
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.MaskedTextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.FailedLoginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerAddressField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(91, 166);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(116, 25);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(95, 223);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 25);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameField
            // 
            this.UsernameField.Location = new System.Drawing.Point(245, 161);
            this.UsernameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(376, 31);
            this.UsernameField.TabIndex = 2;
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(245, 219);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(376, 31);
            this.PasswordField.TabIndex = 3;
            this.PasswordField.UseSystemPasswordChar = true;
            this.PasswordField.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PasswordField_MaskInputRejected);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(508, 315);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(112, 40);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FailedLoginLabel
            // 
            this.FailedLoginLabel.AutoSize = true;
            this.FailedLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.FailedLoginLabel.Location = new System.Drawing.Point(250, 263);
            this.FailedLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FailedLoginLabel.Name = "FailedLoginLabel";
            this.FailedLoginLabel.Size = new System.Drawing.Size(325, 25);
            this.FailedLoginLabel.TabIndex = 5;
            this.FailedLoginLabel.Text = "Incorrect username or password.";
            this.FailedLoginLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server:";
            // 
            // ServerAddressField
            // 
            this.ServerAddressField.Location = new System.Drawing.Point(245, 106);
            this.ServerAddressField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServerAddressField.Name = "ServerAddressField";
            this.ServerAddressField.Size = new System.Drawing.Size(188, 31);
            this.ServerAddressField.TabIndex = 7;
            this.ServerAddressField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 398);
            this.Controls.Add(this.ServerAddressField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FailedLoginLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BOA Version 0.4 Beta";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.MaskedTextBox PasswordField;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label FailedLoginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerAddressField;
    }
}