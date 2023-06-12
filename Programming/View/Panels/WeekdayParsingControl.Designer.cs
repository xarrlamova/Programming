namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
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
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParsingValueTextBox = new System.Windows.Forms.TextBox();
            this.TypeValueForParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingValueTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeValueForParsingLabel);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(599, 349);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
            this.ParseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ParseButton.Location = new System.Drawing.Point(191, 49);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 11;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.BackColor = System.Drawing.Color.Transparent;
            this.ParseLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ParseLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ParseLabel.Location = new System.Drawing.Point(17, 85);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(120, 15);
            this.ParseLabel.TabIndex = 10;
            this.ParseLabel.Text = "Введите день недели";
            // 
            // ParsingValueTextBox
            // 
            this.ParsingValueTextBox.Location = new System.Drawing.Point(17, 49);
            this.ParsingValueTextBox.Name = "ParsingValueTextBox";
            this.ParsingValueTextBox.Size = new System.Drawing.Size(168, 23);
            this.ParsingValueTextBox.TabIndex = 8;
            // 
            // TypeValueForParsingLabel
            // 
            this.TypeValueForParsingLabel.AutoSize = true;
            this.TypeValueForParsingLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TypeValueForParsingLabel.Location = new System.Drawing.Point(17, 30);
            this.TypeValueForParsingLabel.Name = "TypeValueForParsingLabel";
            this.TypeValueForParsingLabel.Size = new System.Drawing.Size(125, 15);
            this.TypeValueForParsingLabel.TabIndex = 9;
            this.TypeValueForParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayParsingGroupBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(599, 349);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox WeekdayParsingGroupBox;
        private Button ParseButton;
        private Label ParseLabel;
        private TextBox ParsingValueTextBox;
        private Label TypeValueForParsingLabel;
    }
}
