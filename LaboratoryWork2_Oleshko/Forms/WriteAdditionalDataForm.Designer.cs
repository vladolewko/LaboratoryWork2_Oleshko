namespace LaboratoryWork2_Oleshko.Forms
{
    partial class WriteAdditionalDataForm
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
            this.lastNameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.firstNameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.continueButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTextField
            // 
            this.lastNameTextField.Depth = 0;
            this.lastNameTextField.Hint = "";
            this.lastNameTextField.Location = new System.Drawing.Point(329, 135);
            this.lastNameTextField.MaxLength = 32767;
            this.lastNameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastNameTextField.Name = "lastNameTextField";
            this.lastNameTextField.PasswordChar = '\0';
            this.lastNameTextField.SelectedText = "";
            this.lastNameTextField.SelectionLength = 0;
            this.lastNameTextField.SelectionStart = 0;
            this.lastNameTextField.Size = new System.Drawing.Size(309, 28);
            this.lastNameTextField.TabIndex = 45;
            this.lastNameTextField.TabStop = false;
            this.lastNameTextField.UseSystemPasswordChar = false;
            // 
            // firstNameTextField
            // 
            this.firstNameTextField.Depth = 0;
            this.firstNameTextField.Hint = "";
            this.firstNameTextField.Location = new System.Drawing.Point(329, 80);
            this.firstNameTextField.MaxLength = 32767;
            this.firstNameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstNameTextField.Name = "firstNameTextField";
            this.firstNameTextField.PasswordChar = '\0';
            this.firstNameTextField.SelectedText = "";
            this.firstNameTextField.SelectionLength = 0;
            this.firstNameTextField.SelectionStart = 0;
            this.firstNameTextField.Size = new System.Drawing.Size(309, 28);
            this.firstNameTextField.TabIndex = 44;
            this.firstNameTextField.TabStop = false;
            this.firstNameTextField.UseSystemPasswordChar = false;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(151, 126);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(216, 46);
            this.lastNameLabel.TabIndex = 43;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(151, 71);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(216, 46);
            this.firstNameLabel.TabIndex = 42;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneNumberTextField
            // 
            this.phoneNumberTextField.Depth = 0;
            this.phoneNumberTextField.Hint = "";
            this.phoneNumberTextField.Location = new System.Drawing.Point(329, 247);
            this.phoneNumberTextField.MaxLength = 32767;
            this.phoneNumberTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneNumberTextField.Name = "phoneNumberTextField";
            this.phoneNumberTextField.PasswordChar = '\0';
            this.phoneNumberTextField.SelectedText = "";
            this.phoneNumberTextField.SelectionLength = 0;
            this.phoneNumberTextField.SelectionStart = 0;
            this.phoneNumberTextField.Size = new System.Drawing.Size(309, 28);
            this.phoneNumberTextField.TabIndex = 49;
            this.phoneNumberTextField.TabStop = false;
            this.phoneNumberTextField.UseSystemPasswordChar = false;
            this.phoneNumberTextField.Visible = false;
            // 
            // emailTextField
            // 
            this.emailTextField.Depth = 0;
            this.emailTextField.Hint = "";
            this.emailTextField.Location = new System.Drawing.Point(329, 192);
            this.emailTextField.MaxLength = 32767;
            this.emailTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailTextField.Name = "emailTextField";
            this.emailTextField.PasswordChar = '\0';
            this.emailTextField.SelectedText = "";
            this.emailTextField.SelectionLength = 0;
            this.emailTextField.SelectionStart = 0;
            this.emailTextField.Size = new System.Drawing.Size(309, 28);
            this.emailTextField.TabIndex = 48;
            this.emailTextField.TabStop = false;
            this.emailTextField.UseSystemPasswordChar = false;
            this.emailTextField.Visible = false;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(151, 238);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(216, 46);
            this.phoneNumberLabel.TabIndex = 47;
            this.phoneNumberLabel.Text = "Phone Number:";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phoneNumberLabel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(151, 183);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(216, 46);
            this.emailLabel.TabIndex = 46;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Visible = false;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(151, 183);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(216, 46);
            this.dateOfBirthLabel.TabIndex = 50;
            this.dateOfBirthLabel.Text = "Date of birth:";
            this.dateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateOfBirthLabel.Visible = false;
            // 
            // dateOfBirthTimePicker
            // 
            this.dateOfBirthTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthTimePicker.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthTimePicker.Location = new System.Drawing.Point(329, 188);
            this.dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            this.dateOfBirthTimePicker.Size = new System.Drawing.Size(273, 32);
            this.dateOfBirthTimePicker.TabIndex = 51;
            this.dateOfBirthTimePicker.Visible = false;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Teal;
            this.continueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueButton.FlatAppearance.BorderSize = 0;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(12, 205);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(122, 56);
            this.continueButton.TabIndex = 52;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 84);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(122, 115);
            this.pictureBox.TabIndex = 53;
            this.pictureBox.TabStop = false;
            // 
            // WriteAdditionalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 292);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.dateOfBirthTimePicker);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.phoneNumberTextField);
            this.Controls.Add(this.emailTextField);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameTextField);
            this.Controls.Add(this.firstNameTextField);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "WriteAdditionalDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Write Additional Data";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField lastNameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField firstNameTextField;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField phoneNumberTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailTextField;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthTimePicker;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}