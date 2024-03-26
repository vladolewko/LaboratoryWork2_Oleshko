namespace LaboratoryWork2_Oleshko.Forms
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
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.seePasswordCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.guideLinkLabel = new System.Windows.Forms.LinkLabel();
            this.amITeacherCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // passwordTextField
            // 
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Hint = "";
            this.passwordTextField.Location = new System.Drawing.Point(137, 156);
            this.passwordTextField.MaxLength = 32767;
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(212, 28);
            this.passwordTextField.TabIndex = 41;
            this.passwordTextField.TabStop = false;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // loginTextField
            // 
            this.loginTextField.Depth = 0;
            this.loginTextField.Hint = "";
            this.loginTextField.Location = new System.Drawing.Point(137, 92);
            this.loginTextField.MaxLength = 32767;
            this.loginTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.PasswordChar = '\0';
            this.loginTextField.SelectedText = "";
            this.loginTextField.SelectionLength = 0;
            this.loginTextField.SelectionStart = 0;
            this.loginTextField.Size = new System.Drawing.Size(212, 28);
            this.loginTextField.TabIndex = 40;
            this.loginTextField.TabStop = false;
            this.loginTextField.UseSystemPasswordChar = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 147);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(216, 46);
            this.passwordLabel.TabIndex = 39;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(12, 92);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(216, 46);
            this.loginLabel.TabIndex = 38;
            this.loginLabel.Text = "Login:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seePasswordCheckBox
            // 
            this.seePasswordCheckBox.AutoSize = true;
            this.seePasswordCheckBox.Depth = 0;
            this.seePasswordCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.seePasswordCheckBox.Location = new System.Drawing.Point(125, 240);
            this.seePasswordCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.seePasswordCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.seePasswordCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.seePasswordCheckBox.Name = "seePasswordCheckBox";
            this.seePasswordCheckBox.Ripple = true;
            this.seePasswordCheckBox.Size = new System.Drawing.Size(139, 30);
            this.seePasswordCheckBox.TabIndex = 42;
            this.seePasswordCheckBox.Text = "See password";
            this.seePasswordCheckBox.UseVisualStyleBackColor = true;
            this.seePasswordCheckBox.CheckedChanged += new System.EventHandler(this.seePasswordCheckBox_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Teal;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(89, 273);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(217, 40);
            this.loginButton.TabIndex = 43;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLinkLabel.Location = new System.Drawing.Point(164, 316);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(55, 17);
            this.registerLinkLabel.TabIndex = 44;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Register";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // guideLinkLabel
            // 
            this.guideLinkLabel.AutoSize = true;
            this.guideLinkLabel.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideLinkLabel.Location = new System.Drawing.Point(356, 316);
            this.guideLinkLabel.Name = "guideLinkLabel";
            this.guideLinkLabel.Size = new System.Drawing.Size(14, 17);
            this.guideLinkLabel.TabIndex = 45;
            this.guideLinkLabel.TabStop = true;
            this.guideLinkLabel.Text = "?";
            this.guideLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guideLinkLabel_LinkClicked);
            // 
            // amITeacherCheckBox
            // 
            this.amITeacherCheckBox.AutoSize = true;
            this.amITeacherCheckBox.Depth = 0;
            this.amITeacherCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.amITeacherCheckBox.Location = new System.Drawing.Point(125, 210);
            this.amITeacherCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.amITeacherCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.amITeacherCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.amITeacherCheckBox.Name = "amITeacherCheckBox";
            this.amITeacherCheckBox.Ripple = true;
            this.amITeacherCheckBox.Size = new System.Drawing.Size(142, 30);
            this.amITeacherCheckBox.TabIndex = 46;
            this.amITeacherCheckBox.Text = "Am I Teacher?";
            this.amITeacherCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 342);
            this.Controls.Add(this.amITeacherCheckBox);
            this.Controls.Add(this.guideLinkLabel);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.seePasswordCheckBox);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.loginTextField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private MaterialSkin.Controls.MaterialCheckBox seePasswordCheckBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.LinkLabel guideLinkLabel;
        private MaterialSkin.Controls.MaterialCheckBox amITeacherCheckBox;
    }
}