namespace StudentsApp.View.Panels
{
    partial class AllStudentsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.ListBoxAndButtonstableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.ApplyChangesButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyAddButton = new System.Windows.Forms.Button();
            this.EducationFormComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.EducationFormLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.TipPanel = new System.Windows.Forms.Panel();
            this.GroupTipLabel = new System.Windows.Forms.Label();
            this.FullNameTipLabel = new System.Windows.Forms.Label();
            this.ListBoxAndButtonstableLayoutPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.SuspendLayout();
            this.SelectedStudentGroupBox.SuspendLayout();
            this.TipPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.HorizontalScrollbar = true;
            this.StudentsListBox.ItemHeight = 15;
            this.StudentsListBox.Location = new System.Drawing.Point(3, 3);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.ScrollAlwaysVisible = true;
            this.StudentsListBox.Size = new System.Drawing.Size(438, 438);
            this.StudentsListBox.TabIndex = 0;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsListBox_SelectedIndexChanged);
            // 
            // ListBoxAndButtonstableLayoutPanel
            // 
            this.ListBoxAndButtonstableLayoutPanel.ColumnCount = 1;
            this.ListBoxAndButtonstableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListBoxAndButtonstableLayoutPanel.Controls.Add(this.StudentsListBox, 0, 0);
            this.ListBoxAndButtonstableLayoutPanel.Controls.Add(this.ButtonsTableLayoutPanel, 0, 1);
            this.ListBoxAndButtonstableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxAndButtonstableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ListBoxAndButtonstableLayoutPanel.Name = "ListBoxAndButtonstableLayoutPanel";
            this.ListBoxAndButtonstableLayoutPanel.RowCount = 2;
            this.ListBoxAndButtonstableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListBoxAndButtonstableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ListBoxAndButtonstableLayoutPanel.Size = new System.Drawing.Size(444, 494);
            this.ListBoxAndButtonstableLayoutPanel.TabIndex = 1;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.DeleteButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditButton, 1, 0);
            this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 447);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(438, 44);
            this.ButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(295, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(140, 38);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(140, 38);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(149, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(140, 38);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.ListBoxAndButtonstableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1010, 500);
            this.MainTableLayoutPanel.TabIndex = 2;
            // 
            // SelectedStudentGroupBoxAndTipLabelTableLayoutPanel
            // 
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.ColumnCount = 1;
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.Controls.Add(this.SelectedStudentGroupBox, 0, 0);
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.Controls.Add(this.TipPanel, 0, 1);
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.Location = new System.Drawing.Point(453, 3);
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.Name = "SelectedStudentGroupBoxAndTipLabelTableLayoutPanel";
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.RowCount = 2;
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.Size = new System.Drawing.Size(554, 494);
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.TabIndex = 3;
            // 
            // SelectedStudentGroupBox
            // 
            this.SelectedStudentGroupBox.Controls.Add(this.ApplyChangesButton);
            this.SelectedStudentGroupBox.Controls.Add(this.CancelButton);
            this.SelectedStudentGroupBox.Controls.Add(this.ApplyAddButton);
            this.SelectedStudentGroupBox.Controls.Add(this.EducationFormComboBox);
            this.SelectedStudentGroupBox.Controls.Add(this.FacultyComboBox);
            this.SelectedStudentGroupBox.Controls.Add(this.GroupTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.EducationFormLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.FacultyLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.GroupLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.IdLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedStudentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedStudentGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectedStudentGroupBox.Name = "SelectedStudentGroupBox";
            this.SelectedStudentGroupBox.Size = new System.Drawing.Size(548, 194);
            this.SelectedStudentGroupBox.TabIndex = 2;
            this.SelectedStudentGroupBox.TabStop = false;
            this.SelectedStudentGroupBox.Text = "Выбранный студент";
            // 
            // ApplyChangesButton
            // 
            this.ApplyChangesButton.Location = new System.Drawing.Point(118, 158);
            this.ApplyChangesButton.Name = "ApplyChangesButton";
            this.ApplyChangesButton.Size = new System.Drawing.Size(123, 23);
            this.ApplyChangesButton.TabIndex = 23;
            this.ApplyChangesButton.Text = "Применить";
            this.ApplyChangesButton.UseVisualStyleBackColor = true;
            this.ApplyChangesButton.Visible = false;
            this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(242, 158);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(123, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyAddButton
            // 
            this.ApplyAddButton.Location = new System.Drawing.Point(118, 158);
            this.ApplyAddButton.Name = "ApplyAddButton";
            this.ApplyAddButton.Size = new System.Drawing.Size(123, 23);
            this.ApplyAddButton.TabIndex = 21;
            this.ApplyAddButton.Text = "Применить";
            this.ApplyAddButton.UseVisualStyleBackColor = true;
            this.ApplyAddButton.Visible = false;
            this.ApplyAddButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // EducationFormComboBox
            // 
            this.EducationFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EducationFormComboBox.Enabled = false;
            this.EducationFormComboBox.FormattingEnabled = true;
            this.EducationFormComboBox.Location = new System.Drawing.Point(118, 131);
            this.EducationFormComboBox.Name = "EducationFormComboBox";
            this.EducationFormComboBox.Size = new System.Drawing.Size(247, 23);
            this.EducationFormComboBox.TabIndex = 19;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.Enabled = false;
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(118, 104);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(247, 23);
            this.FacultyComboBox.TabIndex = 18;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Enabled = false;
            this.GroupTextBox.Location = new System.Drawing.Point(118, 78);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.ReadOnly = true;
            this.GroupTextBox.Size = new System.Drawing.Size(247, 23);
            this.GroupTextBox.TabIndex = 17;
            this.GroupTextBox.TextChanged += new System.EventHandler(this.GroupTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(118, 52);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(247, 23);
            this.IdTextBox.TabIndex = 16;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Enabled = false;
            this.FullNameTextBox.Location = new System.Drawing.Point(118, 22);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.ReadOnly = true;
            this.FullNameTextBox.Size = new System.Drawing.Size(373, 23);
            this.FullNameTextBox.TabIndex = 15;
            this.FullNameTextBox.Text = "\r\n";
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // EducationFormLabel
            // 
            this.EducationFormLabel.AutoSize = true;
            this.EducationFormLabel.Location = new System.Drawing.Point(6, 134);
            this.EducationFormLabel.Name = "EducationFormLabel";
            this.EducationFormLabel.Size = new System.Drawing.Size(104, 15);
            this.EducationFormLabel.TabIndex = 14;
            this.EducationFormLabel.Text = "Форма обучения:";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(44, 106);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(66, 15);
            this.FacultyLabel.TabIndex = 13;
            this.FacultyLabel.Text = "Факультет:";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(61, 80);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(49, 15);
            this.GroupLabel.TabIndex = 12;
            this.GroupLabel.Text = "Группа:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(91, 54);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "ID:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(34, 25);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(78, 15);
            this.FullNameLabel.TabIndex = 10;
            this.FullNameLabel.Text = "Полное имя:";
            // 
            // TipPanel
            // 
            this.TipPanel.Controls.Add(this.GroupTipLabel);
            this.TipPanel.Controls.Add(this.FullNameTipLabel);
            this.TipPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipPanel.Location = new System.Drawing.Point(3, 203);
            this.TipPanel.Name = "TipPanel";
            this.TipPanel.Size = new System.Drawing.Size(548, 288);
            this.TipPanel.TabIndex = 3;
            // 
            // GroupTipLabel
            // 
            this.GroupTipLabel.AutoSize = true;
            this.GroupTipLabel.Location = new System.Drawing.Point(7, 24);
            this.GroupTipLabel.Name = "GroupTipLabel";
            this.GroupTipLabel.Size = new System.Drawing.Size(0, 15);
            this.GroupTipLabel.TabIndex = 21;
            // 
            // FullNameTipLabel
            // 
            this.FullNameTipLabel.AutoSize = true;
            this.FullNameTipLabel.Location = new System.Drawing.Point(7, 0);
            this.FullNameTipLabel.Name = "FullNameTipLabel";
            this.FullNameTipLabel.Size = new System.Drawing.Size(0, 15);
            this.FullNameTipLabel.TabIndex = 20;
            // 
            // AllStudentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(1010, 500);
            this.Name = "AllStudentsControl";
            this.Size = new System.Drawing.Size(1010, 500);
            this.ListBoxAndButtonstableLayoutPanel.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.SelectedStudentGroupBoxAndTipLabelTableLayoutPanel.ResumeLayout(false);
            this.SelectedStudentGroupBox.ResumeLayout(false);
            this.SelectedStudentGroupBox.PerformLayout();
            this.TipPanel.ResumeLayout(false);
            this.TipPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox StudentsListBox;
        private TableLayoutPanel ListBoxAndButtonstableLayoutPanel;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private Button DeleteButton;
        private Button AddButton;
        private Button EditButton;
        private TableLayoutPanel MainTableLayoutPanel;
        private GroupBox SelectedStudentGroupBox;
        private ComboBox EducationFormComboBox;
        private ComboBox FacultyComboBox;
        private TextBox GroupTextBox;
        private TextBox IdTextBox;
        private TextBox FullNameTextBox;
        private Label EducationFormLabel;
        private Label FacultyLabel;
        private Label GroupLabel;
        private Label IdLabel;
        private Label FullNameLabel;
        private Label FullNameTipLabel;
        private Button ApplyAddButton;
        private TableLayoutPanel SelectedStudentGroupBoxAndTipLabelTableLayoutPanel;
        private Panel TipPanel;
        private Label GroupTipLabel;
        private Button CancelButton;
        private Button ApplyChangesButton;
    }
}
