namespace WFLoginRegister.Views
{
    partial class RegisterForm
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
            txtNewUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNewPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(47, 66);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(217, 27);
            txtNewUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 1;
            label1.Text = "New Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 122);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(47, 161);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(217, 27);
            txtNewPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(47, 220);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(141, 42);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 288);
            Controls.Add(btnRegister);
            Controls.Add(label2);
            Controls.Add(txtNewPassword);
            Controls.Add(label1);
            Controls.Add(txtNewUsername);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewUsername;
        private Label label1;
        private Label label2;
        private TextBox txtNewPassword;
        private Button btnRegister;
    }
}