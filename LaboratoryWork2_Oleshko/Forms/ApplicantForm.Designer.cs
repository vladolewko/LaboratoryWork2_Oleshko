namespace LaboratoryWork2_Oleshko.Forms
{
    partial class ApplicantForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.passExamsButton = new System.Windows.Forms.Button();
            this.facultiesDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreToPassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // passExamsButton
            // 
            this.passExamsButton.BackColor = System.Drawing.Color.Teal;
            this.passExamsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passExamsButton.FlatAppearance.BorderSize = 0;
            this.passExamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passExamsButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passExamsButton.ForeColor = System.Drawing.Color.White;
            this.passExamsButton.Location = new System.Drawing.Point(209, 414);
            this.passExamsButton.Name = "passExamsButton";
            this.passExamsButton.Size = new System.Drawing.Size(217, 34);
            this.passExamsButton.TabIndex = 44;
            this.passExamsButton.Text = "Pass Exams";
            this.passExamsButton.UseVisualStyleBackColor = false;
            this.passExamsButton.Click += new System.EventHandler(this.passExamsButton_Click);
            // 
            // facultiesDataGridView
            // 
            this.facultiesDataGridView.AllowUserToAddRows = false;
            this.facultiesDataGridView.AllowUserToResizeColumns = false;
            this.facultiesDataGridView.AllowUserToResizeRows = false;
            this.facultiesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.facultiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facultiesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facultiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.facultiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.ExamId,
            this.facultyNameColumn,
            this.scoreToPassColumn,
            this.examColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.facultiesDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.facultiesDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.facultiesDataGridView.Location = new System.Drawing.Point(12, 80);
            this.facultiesDataGridView.MultiSelect = false;
            this.facultiesDataGridView.Name = "facultiesDataGridView";
            this.facultiesDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facultiesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.facultiesDataGridView.RowHeadersVisible = false;
            this.facultiesDataGridView.RowHeadersWidth = 51;
            this.facultiesDataGridView.RowTemplate.Height = 24;
            this.facultiesDataGridView.RowTemplate.ReadOnly = true;
            this.facultiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facultiesDataGridView.Size = new System.Drawing.Size(600, 160);
            this.facultiesDataGridView.TabIndex = 45;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            this.idColumn.Width = 125;
            // 
            // ExamId
            // 
            this.ExamId.HeaderText = "ExamId";
            this.ExamId.MinimumWidth = 6;
            this.ExamId.Name = "ExamId";
            this.ExamId.ReadOnly = true;
            this.ExamId.Visible = false;
            this.ExamId.Width = 125;
            // 
            // facultyNameColumn
            // 
            this.facultyNameColumn.HeaderText = "Faculty Name";
            this.facultyNameColumn.MinimumWidth = 175;
            this.facultyNameColumn.Name = "facultyNameColumn";
            this.facultyNameColumn.ReadOnly = true;
            this.facultyNameColumn.Width = 175;
            // 
            // scoreToPassColumn
            // 
            this.scoreToPassColumn.HeaderText = "Score to Pass";
            this.scoreToPassColumn.MinimumWidth = 6;
            this.scoreToPassColumn.Name = "scoreToPassColumn";
            this.scoreToPassColumn.ReadOnly = true;
            this.scoreToPassColumn.Width = 125;
            // 
            // examColumn
            // 
            this.examColumn.HeaderText = "Exam";
            this.examColumn.MinimumWidth = 150;
            this.examColumn.Name = "examColumn";
            this.examColumn.ReadOnly = true;
            this.examColumn.Width = 150;
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(12, 80);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(600, 204);
            this.messageLabel.TabIndex = 46;
            this.messageLabel.Text = "Message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApplicantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.passExamsButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.facultiesDataGridView);
            this.Name = "ApplicantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculties";
            ((System.ComponentModel.ISupportInitialize)(this.facultiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button passExamsButton;
        private System.Windows.Forms.DataGridView facultiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreToPassColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examColumn;
        private System.Windows.Forms.Label messageLabel;
    }
}