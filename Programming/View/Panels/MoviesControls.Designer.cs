namespace Programming.View.Panels
{
    partial class MoviesControls
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
            this.FilmGroupBox = new System.Windows.Forms.GroupBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.FindMaxFilmRatingButton = new System.Windows.Forms.Button();
            this.FilmRatingTextBox = new System.Windows.Forms.TextBox();
            this.FilmGenreTextBox = new System.Windows.Forms.TextBox();
            this.FilmYearTextBox = new System.Windows.Forms.TextBox();
            this.FilmDurationTextBox = new System.Windows.Forms.TextBox();
            this.FilmNameTextBox = new System.Windows.Forms.TextBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.FilmGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilmGroupBox
            // 
            this.FilmGroupBox.Controls.Add(this.RatingLabel);
            this.FilmGroupBox.Controls.Add(this.GenreLabel);
            this.FilmGroupBox.Controls.Add(this.YearLabel);
            this.FilmGroupBox.Controls.Add(this.DurationLabel);
            this.FilmGroupBox.Controls.Add(this.filmNameLabel);
            this.FilmGroupBox.Controls.Add(this.FindMaxFilmRatingButton);
            this.FilmGroupBox.Controls.Add(this.FilmRatingTextBox);
            this.FilmGroupBox.Controls.Add(this.FilmGenreTextBox);
            this.FilmGroupBox.Controls.Add(this.FilmYearTextBox);
            this.FilmGroupBox.Controls.Add(this.FilmDurationTextBox);
            this.FilmGroupBox.Controls.Add(this.FilmNameTextBox);
            this.FilmGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilmGroupBox.Name = "FilmGroupBox";
            this.FilmGroupBox.Size = new System.Drawing.Size(693, 408);
            this.FilmGroupBox.TabIndex = 5;
            this.FilmGroupBox.TabStop = false;
            this.FilmGroupBox.Text = "Films";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RatingLabel.Location = new System.Drawing.Point(144, 200);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 15);
            this.RatingLabel.TabIndex = 26;
            this.RatingLabel.Text = "Rating";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GenreLabel.Location = new System.Drawing.Point(143, 154);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(38, 15);
            this.GenreLabel.TabIndex = 25;
            this.GenreLabel.Text = "Genre";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.YearLabel.Location = new System.Drawing.Point(144, 110);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 15);
            this.YearLabel.TabIndex = 24;
            this.YearLabel.Text = "Year";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DurationLabel.Location = new System.Drawing.Point(144, 62);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(53, 15);
            this.DurationLabel.TabIndex = 23;
            this.DurationLabel.Text = "Duration";
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.AutoSize = true;
            this.filmNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.filmNameLabel.Location = new System.Drawing.Point(144, 18);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(39, 15);
            this.filmNameLabel.TabIndex = 22;
            this.filmNameLabel.Text = "Name";
            // 
            // FindMaxFilmRatingButton
            // 
            this.FindMaxFilmRatingButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FindMaxFilmRatingButton.Location = new System.Drawing.Point(143, 265);
            this.FindMaxFilmRatingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindMaxFilmRatingButton.Name = "FindMaxFilmRatingButton";
            this.FindMaxFilmRatingButton.Size = new System.Drawing.Size(132, 22);
            this.FindMaxFilmRatingButton.TabIndex = 21;
            this.FindMaxFilmRatingButton.Text = "Find";
            this.FindMaxFilmRatingButton.UseVisualStyleBackColor = true;
            this.FindMaxFilmRatingButton.Click += new System.EventHandler(this.FindMaxFilmRatingButton_Click);
            // 
            // FilmRatingTextBox
            // 
            this.FilmRatingTextBox.Location = new System.Drawing.Point(143, 216);
            this.FilmRatingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmRatingTextBox.Name = "FilmRatingTextBox";
            this.FilmRatingTextBox.Size = new System.Drawing.Size(132, 23);
            this.FilmRatingTextBox.TabIndex = 20;
            this.FilmRatingTextBox.TextChanged += new System.EventHandler(this.FilmRatingTextBox_TextChanged);
            // 
            // FilmGenreTextBox
            // 
            this.FilmGenreTextBox.Location = new System.Drawing.Point(143, 171);
            this.FilmGenreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmGenreTextBox.Name = "FilmGenreTextBox";
            this.FilmGenreTextBox.Size = new System.Drawing.Size(132, 23);
            this.FilmGenreTextBox.TabIndex = 19;
            this.FilmGenreTextBox.TextChanged += new System.EventHandler(this.FilmGenreTextBox_TextChanged);
            // 
            // FilmYearTextBox
            // 
            this.FilmYearTextBox.Location = new System.Drawing.Point(144, 127);
            this.FilmYearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmYearTextBox.Name = "FilmYearTextBox";
            this.FilmYearTextBox.Size = new System.Drawing.Size(132, 23);
            this.FilmYearTextBox.TabIndex = 18;
            this.FilmYearTextBox.TextChanged += new System.EventHandler(this.FilmYearTextBox_TextChanged);
            // 
            // FilmDurationTextBox
            // 
            this.FilmDurationTextBox.Location = new System.Drawing.Point(143, 79);
            this.FilmDurationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmDurationTextBox.Name = "FilmDurationTextBox";
            this.FilmDurationTextBox.Size = new System.Drawing.Size(132, 23);
            this.FilmDurationTextBox.TabIndex = 17;
            this.FilmDurationTextBox.TextChanged += new System.EventHandler(this.FilmDurationTextBox_TextChanged);
            // 
            // FilmNameTextBox
            // 
            this.FilmNameTextBox.Location = new System.Drawing.Point(143, 35);
            this.FilmNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmNameTextBox.Name = "FilmNameTextBox";
            this.FilmNameTextBox.Size = new System.Drawing.Size(132, 23);
            this.FilmNameTextBox.TabIndex = 16;
            this.FilmNameTextBox.TextChanged += new System.EventHandler(this.FilmNameTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.IntegralHeight = false;
            this.FilmsListBox.ItemHeight = 15;
            this.FilmsListBox.Location = new System.Drawing.Point(6, 18);
            this.FilmsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(132, 269);
            this.FilmsListBox.TabIndex = 15;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // MoviesControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilmGroupBox);
            this.Name = "MoviesControls";
            this.Size = new System.Drawing.Size(693, 408);
            this.FilmGroupBox.ResumeLayout(false);
            this.FilmGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox FilmGroupBox;
        private Label RatingLabel;
        private Label GenreLabel;
        private Label YearLabel;
        private Label DurationLabel;
        private Label filmNameLabel;
        private Button FindMaxFilmRatingButton;
        private TextBox FilmRatingTextBox;
        private TextBox FilmGenreTextBox;
        private TextBox FilmYearTextBox;
        private TextBox FilmDurationTextBox;
        private TextBox FilmNameTextBox;
        private ListBox FilmsListBox;
    }
}
