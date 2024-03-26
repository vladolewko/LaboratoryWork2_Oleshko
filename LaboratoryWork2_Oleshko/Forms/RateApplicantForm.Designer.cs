namespace LaboratoryWork2_Oleshko.Forms
{
    partial class RateApplicantForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.applicantAnswerLabel = new System.Windows.Forms.Label();
            this.correctAnswerLabel = new System.Windows.Forms.Label();
            this.rateTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.markLabel = new System.Windows.Forms.Label();
            this.rateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(12, 70);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(507, 46);
            this.questionLabel.TabIndex = 36;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // applicantAnswerLabel
            // 
            this.applicantAnswerLabel.BackColor = System.Drawing.Color.Transparent;
            this.applicantAnswerLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicantAnswerLabel.Location = new System.Drawing.Point(12, 132);
            this.applicantAnswerLabel.Name = "applicantAnswerLabel";
            this.applicantAnswerLabel.Size = new System.Drawing.Size(507, 46);
            this.applicantAnswerLabel.TabIndex = 37;
            this.applicantAnswerLabel.Text = "Applicant answer";
            this.applicantAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.BackColor = System.Drawing.Color.Transparent;
            this.correctAnswerLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswerLabel.Location = new System.Drawing.Point(12, 192);
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(382, 46);
            this.correctAnswerLabel.TabIndex = 38;
            this.correctAnswerLabel.Text = "Correct answer";
            this.correctAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateTextField
            // 
            this.rateTextField.Depth = 0;
            this.rateTextField.Hint = "";
            this.rateTextField.Location = new System.Drawing.Point(122, 266);
            this.rateTextField.MaxLength = 32767;
            this.rateTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.rateTextField.Name = "rateTextField";
            this.rateTextField.PasswordChar = '\0';
            this.rateTextField.SelectedText = "";
            this.rateTextField.SelectionLength = 0;
            this.rateTextField.SelectionStart = 0;
            this.rateTextField.Size = new System.Drawing.Size(252, 28);
            this.rateTextField.TabIndex = 42;
            this.rateTextField.TabStop = false;
            this.rateTextField.UseSystemPasswordChar = false;
            this.rateTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateTextField_KeyPress);
            // 
            // markLabel
            // 
            this.markLabel.BackColor = System.Drawing.Color.Transparent;
            this.markLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markLabel.Location = new System.Drawing.Point(12, 258);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(66, 46);
            this.markLabel.TabIndex = 43;
            this.markLabel.Text = "Mark:";
            this.markLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateButton
            // 
            this.rateButton.BackColor = System.Drawing.Color.Teal;
            this.rateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rateButton.FlatAppearance.BorderSize = 0;
            this.rateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rateButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateButton.ForeColor = System.Drawing.Color.White;
            this.rateButton.Location = new System.Drawing.Point(108, 404);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(217, 34);
            this.rateButton.TabIndex = 45;
            this.rateButton.Text = "Rate";
            this.rateButton.UseVisualStyleBackColor = false;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // RateApplicantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.rateButton);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.rateTextField);
            this.Controls.Add(this.correctAnswerLabel);
            this.Controls.Add(this.applicantAnswerLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "RateApplicantForm";
            this.Text = "Rate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label applicantAnswerLabel;
        private System.Windows.Forms.Label correctAnswerLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField rateTextField;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Button rateButton;
    }
}