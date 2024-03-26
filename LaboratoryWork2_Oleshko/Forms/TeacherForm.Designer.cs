namespace LaboratoryWork2_Oleshko.Forms
{
    partial class TeacherForm
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
            this.applicantTabControl = new System.Windows.Forms.TabControl();
            this.applicantTabPage = new System.Windows.Forms.TabPage();
            this.setMarksButton = new System.Windows.Forms.Button();
            this.applicantsDataGridView = new System.Windows.Forms.DataGridView();
            this.applicantIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failedTabPage = new System.Windows.Forms.TabPage();
            this.failedDataGridView = new System.Windows.Forms.DataGridView();
            this.passedTabPage = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantScoreColumng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantTabControl.SuspendLayout();
            this.applicantTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataGridView)).BeginInit();
            this.failedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.failedDataGridView)).BeginInit();
            this.passedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // applicantTabControl
            // 
            this.applicantTabControl.Controls.Add(this.applicantTabPage);
            this.applicantTabControl.Controls.Add(this.failedTabPage);
            this.applicantTabControl.Controls.Add(this.passedTabPage);
            this.applicantTabControl.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicantTabControl.Location = new System.Drawing.Point(12, 77);
            this.applicantTabControl.Name = "applicantTabControl";
            this.applicantTabControl.SelectedIndex = 0;
            this.applicantTabControl.Size = new System.Drawing.Size(776, 404);
            this.applicantTabControl.TabIndex = 0;
            // 
            // applicantTabPage
            // 
            this.applicantTabPage.Controls.Add(this.setMarksButton);
            this.applicantTabPage.Controls.Add(this.applicantsDataGridView);
            this.applicantTabPage.Location = new System.Drawing.Point(4, 26);
            this.applicantTabPage.Name = "applicantTabPage";
            this.applicantTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.applicantTabPage.Size = new System.Drawing.Size(768, 374);
            this.applicantTabPage.TabIndex = 0;
            this.applicantTabPage.Text = "Applicant";
            this.applicantTabPage.UseVisualStyleBackColor = true;
            // 
            // setMarksButton
            // 
            this.setMarksButton.BackColor = System.Drawing.Color.Teal;
            this.setMarksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setMarksButton.FlatAppearance.BorderSize = 0;
            this.setMarksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setMarksButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setMarksButton.ForeColor = System.Drawing.Color.White;
            this.setMarksButton.Location = new System.Drawing.Point(273, 334);
            this.setMarksButton.Name = "setMarksButton";
            this.setMarksButton.Size = new System.Drawing.Size(217, 34);
            this.setMarksButton.TabIndex = 44;
            this.setMarksButton.Text = "Set Marks";
            this.setMarksButton.UseVisualStyleBackColor = false;
            this.setMarksButton.Click += new System.EventHandler(this.setMarksButton_Click);
            // 
            // applicantsDataGridView
            // 
            this.applicantsDataGridView.AllowUserToAddRows = false;
            this.applicantsDataGridView.AllowUserToResizeColumns = false;
            this.applicantsDataGridView.AllowUserToResizeRows = false;
            this.applicantsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.applicantsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applicantsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.applicantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicantIdColumn,
            this.facultyIdColumn,
            this.examIdColumn,
            this.applicantNameColumn,
            this.facultyNameColumn,
            this.examNameColumn,
            this.scoreColumn});
            this.applicantsDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.applicantsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.applicantsDataGridView.MultiSelect = false;
            this.applicantsDataGridView.Name = "applicantsDataGridView";
            this.applicantsDataGridView.ReadOnly = true;
            this.applicantsDataGridView.RowHeadersVisible = false;
            this.applicantsDataGridView.RowHeadersWidth = 51;
            this.applicantsDataGridView.RowTemplate.Height = 24;
            this.applicantsDataGridView.RowTemplate.ReadOnly = true;
            this.applicantsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applicantsDataGridView.Size = new System.Drawing.Size(756, 328);
            this.applicantsDataGridView.TabIndex = 46;
            // 
            // applicantIdColumn
            // 
            this.applicantIdColumn.HeaderText = "Applicant Id";
            this.applicantIdColumn.MinimumWidth = 6;
            this.applicantIdColumn.Name = "applicantIdColumn";
            this.applicantIdColumn.ReadOnly = true;
            this.applicantIdColumn.Visible = false;
            this.applicantIdColumn.Width = 125;
            // 
            // facultyIdColumn
            // 
            this.facultyIdColumn.HeaderText = "Faculty Id";
            this.facultyIdColumn.MinimumWidth = 6;
            this.facultyIdColumn.Name = "facultyIdColumn";
            this.facultyIdColumn.ReadOnly = true;
            this.facultyIdColumn.Visible = false;
            this.facultyIdColumn.Width = 125;
            // 
            // examIdColumn
            // 
            this.examIdColumn.HeaderText = "Exam Id";
            this.examIdColumn.MinimumWidth = 6;
            this.examIdColumn.Name = "examIdColumn";
            this.examIdColumn.ReadOnly = true;
            this.examIdColumn.Visible = false;
            this.examIdColumn.Width = 125;
            // 
            // applicantNameColumn
            // 
            this.applicantNameColumn.HeaderText = "Applicant Name";
            this.applicantNameColumn.MinimumWidth = 6;
            this.applicantNameColumn.Name = "applicantNameColumn";
            this.applicantNameColumn.ReadOnly = true;
            this.applicantNameColumn.Width = 125;
            // 
            // facultyNameColumn
            // 
            this.facultyNameColumn.HeaderText = "Faculty Name";
            this.facultyNameColumn.MinimumWidth = 6;
            this.facultyNameColumn.Name = "facultyNameColumn";
            this.facultyNameColumn.ReadOnly = true;
            this.facultyNameColumn.Width = 125;
            // 
            // examNameColumn
            // 
            this.examNameColumn.HeaderText = "Exam name";
            this.examNameColumn.MinimumWidth = 6;
            this.examNameColumn.Name = "examNameColumn";
            this.examNameColumn.ReadOnly = true;
            this.examNameColumn.Width = 125;
            // 
            // scoreColumn
            // 
            this.scoreColumn.HeaderText = "Score to Pass";
            this.scoreColumn.MinimumWidth = 6;
            this.scoreColumn.Name = "scoreColumn";
            this.scoreColumn.ReadOnly = true;
            this.scoreColumn.Width = 125;
            // 
            // failedTabPage
            // 
            this.failedTabPage.Controls.Add(this.failedDataGridView);
            this.failedTabPage.Location = new System.Drawing.Point(4, 26);
            this.failedTabPage.Name = "failedTabPage";
            this.failedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.failedTabPage.Size = new System.Drawing.Size(768, 374);
            this.failedTabPage.TabIndex = 1;
            this.failedTabPage.Text = "Failed";
            this.failedTabPage.UseVisualStyleBackColor = true;
            // 
            // failedDataGridView
            // 
            this.failedDataGridView.AllowUserToAddRows = false;
            this.failedDataGridView.AllowUserToResizeColumns = false;
            this.failedDataGridView.AllowUserToResizeRows = false;
            this.failedDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.failedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failedDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.failedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.failedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.applicantScoreColumng,
            this.dataGridViewTextBoxColumn8});
            this.failedDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.failedDataGridView.Location = new System.Drawing.Point(3, 6);
            this.failedDataGridView.MultiSelect = false;
            this.failedDataGridView.Name = "failedDataGridView";
            this.failedDataGridView.ReadOnly = true;
            this.failedDataGridView.RowHeadersVisible = false;
            this.failedDataGridView.RowHeadersWidth = 51;
            this.failedDataGridView.RowTemplate.Height = 24;
            this.failedDataGridView.RowTemplate.ReadOnly = true;
            this.failedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.failedDataGridView.Size = new System.Drawing.Size(756, 362);
            this.failedDataGridView.TabIndex = 47;
            // 
            // passedTabPage
            // 
            this.passedTabPage.Controls.Add(this.passedDataGridView);
            this.passedTabPage.Location = new System.Drawing.Point(4, 26);
            this.passedTabPage.Name = "passedTabPage";
            this.passedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.passedTabPage.Size = new System.Drawing.Size(768, 374);
            this.passedTabPage.TabIndex = 2;
            this.passedTabPage.Text = "Passed";
            this.passedTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Applicant Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Faculty Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Exam name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // applicantScoreColumng
            // 
            this.applicantScoreColumng.HeaderText = "Applicant\'s Score";
            this.applicantScoreColumng.MinimumWidth = 70;
            this.applicantScoreColumng.Name = "applicantScoreColumng";
            this.applicantScoreColumng.ReadOnly = true;
            this.applicantScoreColumng.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Score to Pass";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // passedDataGridView
            // 
            this.passedDataGridView.AllowUserToAddRows = false;
            this.passedDataGridView.AllowUserToResizeColumns = false;
            this.passedDataGridView.AllowUserToResizeRows = false;
            this.passedDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.passedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passedDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.passedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9});
            this.passedDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.passedDataGridView.Location = new System.Drawing.Point(6, 6);
            this.passedDataGridView.MultiSelect = false;
            this.passedDataGridView.Name = "passedDataGridView";
            this.passedDataGridView.ReadOnly = true;
            this.passedDataGridView.RowHeadersVisible = false;
            this.passedDataGridView.RowHeadersWidth = 51;
            this.passedDataGridView.RowTemplate.Height = 24;
            this.passedDataGridView.RowTemplate.ReadOnly = true;
            this.passedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passedDataGridView.Size = new System.Drawing.Size(756, 362);
            this.passedDataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Applicant Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Faculty Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Exam name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Applicant\'s Score";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Score to Pass";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.applicantTabControl);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.applicantTabControl.ResumeLayout(false);
            this.applicantTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataGridView)).EndInit();
            this.failedTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.failedDataGridView)).EndInit();
            this.passedTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl applicantTabControl;
        private System.Windows.Forms.TabPage failedTabPage;
        private System.Windows.Forms.TabPage passedTabPage;
        private System.Windows.Forms.TabPage applicantTabPage;
        private System.Windows.Forms.Button setMarksButton;
        private System.Windows.Forms.DataGridView applicantsDataGridView;
        private System.Windows.Forms.DataGridView failedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantScoreColumng;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView passedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}