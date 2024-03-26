namespace LaboratoryWork2_Oleshko.Forms
{
    partial class RegistrationForm
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
            this.seePasswordCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.amITeacherCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.guideLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // seePasswordCheckBox
            // 
            this.seePasswordCheckBox.AutoSize = true;
            this.seePasswordCheckBox.Depth = 0;
            this.seePasswordCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.seePasswordCheckBox.Location = new System.Drawing.Point(165, 303);
            this.seePasswordCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.seePasswordCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.seePasswordCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.seePasswordCheckBox.Name = "seePasswordCheckBox";
            this.seePasswordCheckBox.Ripple = true;
            this.seePasswordCheckBox.Size = new System.Drawing.Size(139, 30);
            this.seePasswordCheckBox.TabIndex = 38;
            this.seePasswordCheckBox.Text = "See password";
            this.seePasswordCheckBox.UseVisualStyleBackColor = true;
            this.seePasswordCheckBox.CheckedChanged += new System.EventHandler(this.seePasswordCheckBox_CheckedChanged);
            // 
            // passwordTextField
            // 
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Hint = "";
            this.passwordTextField.Location = new System.Drawing.Point(244, 162);
            this.passwordTextField.MaxLength = 32767;
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(212, 28);
            this.passwordTextField.TabIndex = 37;
            this.passwordTextField.TabStop = false;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // loginTextField
            // 
            this.loginTextField.Depth = 0;
            this.loginTextField.Hint = "";
            this.loginTextField.Location = new System.Drawing.Point(244, 113);
            this.loginTextField.MaxLength = 32767;
            this.loginTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.PasswordChar = '\0';
            this.loginTextField.SelectedText = "";
            this.loginTextField.SelectionLength = 0;
            this.loginTextField.SelectionStart = 0;
            this.loginTextField.Size = new System.Drawing.Size(212, 28);
            this.loginTextField.TabIndex = 36;
            this.loginTextField.TabStop = false;
            this.loginTextField.UseSystemPasswordChar = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(22, 150);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(216, 46);
            this.passwordLabel.TabIndex = 35;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(22, 104);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(216, 46);
            this.loginLabel.TabIndex = 34;
            this.loginLabel.Text = "Login:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // repeatPasswordTextField
            // 
            this.repeatPasswordTextField.Depth = 0;
            this.repeatPasswordTextField.Hint = "";
            this.repeatPasswordTextField.Location = new System.Drawing.Point(244, 210);
            this.repeatPasswordTextField.MaxLength = 32767;
            this.repeatPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.repeatPasswordTextField.Name = "repeatPasswordTextField";
            this.repeatPasswordTextField.PasswordChar = '*';
            this.repeatPasswordTextField.SelectedText = "";
            this.repeatPasswordTextField.SelectionLength = 0;
            this.repeatPasswordTextField.SelectionStart = 0;
            this.repeatPasswordTextField.Size = new System.Drawing.Size(212, 28);
            this.repeatPasswordTextField.TabIndex = 40;
            this.repeatPasswordTextField.TabStop = false;
            this.repeatPasswordTextField.UseSystemPasswordChar = false;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(22, 198);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(216, 46);
            this.confirmPasswordLabel.TabIndex = 39;
            this.confirmPasswordLabel.Text = "Confirm password:";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amITeacherCheckBox
            // 
            this.amITeacherCheckBox.AutoSize = true;
            this.amITeacherCheckBox.Depth = 0;
            this.amITeacherCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.amITeacherCheckBox.Location = new System.Drawing.Point(244, 258);
            this.amITeacherCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.amITeacherCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.amITeacherCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.amITeacherCheckBox.Name = "amITeacherCheckBox";
            this.amITeacherCheckBox.Ripple = true;
            this.amITeacherCheckBox.Size = new System.Drawing.Size(142, 30);
            this.amITeacherCheckBox.TabIndex = 41;
            this.amITeacherCheckBox.Text = "Am I Teacher?";
            this.amITeacherCheckBox.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Teal;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(97, 336);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(268, 34);
            this.registerButton.TabIndex = 42;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginLinkLabel
            // 
            this.loginLinkLabel.AutoSize = true;
            this.loginLinkLabel.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLinkLabel.Location = new System.Drawing.Point(208, 373);
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.Size = new System.Drawing.Size(39, 17);
            this.loginLinkLabel.TabIndex = 45;
            this.loginLinkLabel.TabStop = true;
            this.loginLinkLabel.Text = "Login";
            this.loginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLabel_LinkClicked);
            // 
            // guideLinkLabel
            // 
            this.guideLinkLabel.AutoSize = true;
            this.guideLinkLabel.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideLinkLabel.Location = new System.Drawing.Point(445, 373);
            this.guideLinkLabel.Name = "guideLinkLabel";
            this.guideLinkLabel.Size = new System.Drawing.Size(14, 17);
            this.guideLinkLabel.TabIndex = 46;
            this.guideLinkLabel.TabStop = true;
            this.guideLinkLabel.Text = "?";
            this.guideLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guideLinkLabel_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 403);
            this.Controls.Add(this.guideLinkLabel);
            this.Controls.Add(this.loginLinkLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.amITeacherCheckBox);
            this.Controls.Add(this.repeatPasswordTextField);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.seePasswordCheckBox);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.loginTextField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox seePasswordCheckBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField repeatPasswordTextField;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private MaterialSkin.Controls.MaterialCheckBox amITeacherCheckBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.LinkLabel loginLinkLabel;
        private System.Windows.Forms.LinkLabel guideLinkLabel;
    }
}