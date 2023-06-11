namespace Programming.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelChild = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParsingValueTextBox = new System.Windows.Forms.TextBox();
            this.TypeValueForParsingLabel = new System.Windows.Forms.Label();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueIntTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.EnumValuesListBox = new System.Windows.Forms.ListBox();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.AllEnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelClasses = new System.Windows.Forms.TableLayoutPanel();
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.RectIDTextBox = new System.Windows.Forms.TextBox();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.RectYTextBox = new System.Windows.Forms.TextBox();
            this.RectXTextBox = new System.Windows.Forms.TextBox();
            this.FindMaxWidthButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectWidthLabel = new System.Windows.Forms.Label();
            this.RectColorTextBox = new System.Windows.Forms.TextBox();
            this.RectLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.BelowRectInfoLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesHeightLabel = new System.Windows.Forms.Label();
            this.RectanglesWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesYLabel = new System.Windows.Forms.Label();
            this.RectanglesXLabel = new System.Windows.Forms.Label();
            this.RectanglesIdLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RectInfoListBox = new System.Windows.Forms.ListBox();
            this.RectPanel = new System.Windows.Forms.Panel();
            this.DeleteRectButton = new System.Windows.Forms.Button();
            this.AddRectButton = new System.Windows.Forms.Button();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.TableLayoutPanelChild.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.TableLayoutPanelClasses.SuspendLayout();
            this.FilmGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsTabControl.Controls.Add(this.ClassesTabPage);
            this.EnumsTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(742, 400);
            this.EnumsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.EnumsTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.TableLayoutPanel);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(734, 372);
            this.EnumsTabPage.TabIndex = 1;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Controls.Add(this.TableLayoutPanelChild, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.EnumerationsGroupBox, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(728, 366);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // TableLayoutPanelChild
            // 
            this.TableLayoutPanelChild.ColumnCount = 2;
            this.TableLayoutPanelChild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelChild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelChild.Controls.Add(this.WeekdayParsingGroupBox, 0, 0);
            this.TableLayoutPanelChild.Controls.Add(this.SeasonHandleGroupBox, 1, 0);
            this.TableLayoutPanelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelChild.Location = new System.Drawing.Point(0, 183);
            this.TableLayoutPanelChild.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelChild.Name = "TableLayoutPanelChild";
            this.TableLayoutPanelChild.RowCount = 1;
            this.TableLayoutPanelChild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelChild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelChild.Size = new System.Drawing.Size(728, 183);
            this.TableLayoutPanelChild.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingValueTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeValueForParsingLabel);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(358, 177);
            this.WeekdayParsingGroupBox.TabIndex = 0;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
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
            this.TypeValueForParsingLabel.Location = new System.Drawing.Point(17, 30);
            this.TypeValueForParsingLabel.Name = "TypeValueForParsingLabel";
            this.TypeValueForParsingLabel.Size = new System.Drawing.Size(125, 15);
            this.TypeValueForParsingLabel.TabIndex = 9;
            this.TypeValueForParsingLabel.Text = "Type value for parsing:";
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(367, 3);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(358, 177);
            this.SeasonHandleGroupBox.TabIndex = 1;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(15, 49);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(168, 23);
            this.SeasonComboBox.TabIndex = 15;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(189, 49);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 14;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(15, 30);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.ChooseSeasonLabel.TabIndex = 13;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.ValueIntTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumerationsGroupBox.Controls.Add(this.AllEnumsListBox);
            this.EnumerationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(722, 177);
            this.EnumerationsGroupBox.TabIndex = 1;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // ValueIntTextBox
            // 
            this.ValueIntTextBox.Location = new System.Drawing.Point(334, 42);
            this.ValueIntTextBox.Name = "ValueIntTextBox";
            this.ValueIntTextBox.Size = new System.Drawing.Size(136, 23);
            this.ValueIntTextBox.TabIndex = 0;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(334, 24);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 7;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(170, 24);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ChooseValueLabel.TabIndex = 3;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // EnumValuesListBox
            // 
            this.EnumValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumValuesListBox.FormattingEnabled = true;
            this.EnumValuesListBox.IntegralHeight = false;
            this.EnumValuesListBox.ItemHeight = 15;
            this.EnumValuesListBox.Location = new System.Drawing.Point(170, 42);
            this.EnumValuesListBox.Name = "EnumValuesListBox";
            this.EnumValuesListBox.Size = new System.Drawing.Size(136, 119);
            this.EnumValuesListBox.TabIndex = 2;
            this.EnumValuesListBox.SelectedIndexChanged += new System.EventHandler(this.EnumValuesListBox_SelectedIndexChanged);
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(6, 24);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(121, 15);
            this.ChooseEnumerationLabel.TabIndex = 1;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // AllEnumsListBox
            // 
            this.AllEnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AllEnumsListBox.FormattingEnabled = true;
            this.AllEnumsListBox.IntegralHeight = false;
            this.AllEnumsListBox.ItemHeight = 15;
            this.AllEnumsListBox.Location = new System.Drawing.Point(6, 42);
            this.AllEnumsListBox.Name = "AllEnumsListBox";
            this.AllEnumsListBox.Size = new System.Drawing.Size(136, 119);
            this.AllEnumsListBox.TabIndex = 0;
            this.AllEnumsListBox.SelectedIndexChanged += new System.EventHandler(this.AllEnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.TableLayoutPanelClasses);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(734, 372);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelClasses
            // 
            this.TableLayoutPanelClasses.ColumnCount = 2;
            this.TableLayoutPanelClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelClasses.Controls.Add(this.FilmGroupBox, 1, 0);
            this.TableLayoutPanelClasses.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.TableLayoutPanelClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelClasses.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelClasses.Name = "TableLayoutPanelClasses";
            this.TableLayoutPanelClasses.RowCount = 1;
            this.TableLayoutPanelClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelClasses.Size = new System.Drawing.Size(728, 366);
            this.TableLayoutPanelClasses.TabIndex = 3;
            // 
            // FilmGroupBox
            // 
            this.FilmGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.FilmGroupBox.Location = new System.Drawing.Point(367, 3);
            this.FilmGroupBox.Name = "FilmGroupBox";
            this.FilmGroupBox.Size = new System.Drawing.Size(358, 360);
            this.FilmGroupBox.TabIndex = 4;
            this.FilmGroupBox.TabStop = false;
            this.FilmGroupBox.Text = "Films";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(144, 200);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 15);
            this.RatingLabel.TabIndex = 26;
            this.RatingLabel.Text = "Rating";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(143, 154);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(38, 15);
            this.GenreLabel.TabIndex = 25;
            this.GenreLabel.Text = "Genre";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(144, 110);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 15);
            this.YearLabel.TabIndex = 24;
            this.YearLabel.Text = "Year";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(144, 62);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(53, 15);
            this.DurationLabel.TabIndex = 23;
            this.DurationLabel.Text = "Duration";
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.AutoSize = true;
            this.filmNameLabel.Location = new System.Drawing.Point(144, 18);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(39, 15);
            this.filmNameLabel.TabIndex = 22;
            this.filmNameLabel.Text = "Name";
            // 
            // FindMaxFilmRatingButton
            // 
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
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged_1);
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IDlabel);
            this.RectanglesGroupBox.Controls.Add(this.RectIDTextBox);
            this.RectanglesGroupBox.Controls.Add(this.Ylabel);
            this.RectanglesGroupBox.Controls.Add(this.Xlabel);
            this.RectanglesGroupBox.Controls.Add(this.RectYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindMaxWidthButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectLengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 2);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(358, 362);
            this.RectanglesGroupBox.TabIndex = 2;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(140, 201);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 15);
            this.IDlabel.TabIndex = 18;
            this.IDlabel.Text = "ID";
            // 
            // RectIDTextBox
            // 
            this.RectIDTextBox.Location = new System.Drawing.Point(138, 217);
            this.RectIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectIDTextBox.Name = "RectIDTextBox";
            this.RectIDTextBox.ReadOnly = true;
            this.RectIDTextBox.Size = new System.Drawing.Size(132, 23);
            this.RectIDTextBox.TabIndex = 17;
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(208, 155);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(14, 15);
            this.Ylabel.TabIndex = 16;
            this.Ylabel.Text = "Y";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(140, 155);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(14, 15);
            this.Xlabel.TabIndex = 15;
            this.Xlabel.Text = "X";
            // 
            // RectYTextBox
            // 
            this.RectYTextBox.Location = new System.Drawing.Point(208, 172);
            this.RectYTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectYTextBox.Name = "RectYTextBox";
            this.RectYTextBox.ReadOnly = true;
            this.RectYTextBox.Size = new System.Drawing.Size(62, 23);
            this.RectYTextBox.TabIndex = 14;
            // 
            // RectXTextBox
            // 
            this.RectXTextBox.Location = new System.Drawing.Point(138, 172);
            this.RectXTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectXTextBox.Name = "RectXTextBox";
            this.RectXTextBox.ReadOnly = true;
            this.RectXTextBox.Size = new System.Drawing.Size(62, 23);
            this.RectXTextBox.TabIndex = 13;
            // 
            // FindMaxWidthButton
            // 
            this.FindMaxWidthButton.Location = new System.Drawing.Point(138, 266);
            this.FindMaxWidthButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindMaxWidthButton.Name = "FindMaxWidthButton";
            this.FindMaxWidthButton.Size = new System.Drawing.Size(132, 22);
            this.FindMaxWidthButton.TabIndex = 7;
            this.FindMaxWidthButton.Text = "Find";
            this.FindMaxWidthButton.UseVisualStyleBackColor = true;
            this.FindMaxWidthButton.Click += new System.EventHandler(this.FindMaxWidthButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(140, 111);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(36, 15);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(140, 63);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(44, 15);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Length";
            // 
            // RectWidthLabel
            // 
            this.RectWidthLabel.AutoSize = true;
            this.RectWidthLabel.Location = new System.Drawing.Point(140, 19);
            this.RectWidthLabel.Name = "RectWidthLabel";
            this.RectWidthLabel.Size = new System.Drawing.Size(39, 15);
            this.RectWidthLabel.TabIndex = 4;
            this.RectWidthLabel.Text = "Width";
            // 
            // RectColorTextBox
            // 
            this.RectColorTextBox.Location = new System.Drawing.Point(138, 128);
            this.RectColorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectColorTextBox.Name = "RectColorTextBox";
            this.RectColorTextBox.Size = new System.Drawing.Size(132, 23);
            this.RectColorTextBox.TabIndex = 3;
            this.RectColorTextBox.TextChanged += new System.EventHandler(this.RectColorTextBox_TextChanged);
            // 
            // RectLengthTextBox
            // 
            this.RectLengthTextBox.Location = new System.Drawing.Point(138, 80);
            this.RectLengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectLengthTextBox.Name = "RectLengthTextBox";
            this.RectLengthTextBox.Size = new System.Drawing.Size(132, 23);
            this.RectLengthTextBox.TabIndex = 2;
            this.RectLengthTextBox.TextChanged += new System.EventHandler(this.RectLengthTextBox_TextChanged);
            // 
            // RectWidthTextBox
            // 
            this.RectWidthTextBox.Location = new System.Drawing.Point(138, 36);
            this.RectWidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectWidthTextBox.Name = "RectWidthTextBox";
            this.RectWidthTextBox.Size = new System.Drawing.Size(132, 23);
            this.RectWidthTextBox.TabIndex = 1;
            this.RectWidthTextBox.TextChanged += new System.EventHandler(this.RectWidthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.IntegralHeight = false;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(2, 19);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(132, 269);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.BelowRectInfoLabel);
            this.RectanglesTabPage.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesHeightLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesWidthLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesYLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesXLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesIdLabel);
            this.RectanglesTabPage.Controls.Add(this.HeightTextBox);
            this.RectanglesTabPage.Controls.Add(this.WidthTextBox);
            this.RectanglesTabPage.Controls.Add(this.YTextBox);
            this.RectanglesTabPage.Controls.Add(this.XTextBox);
            this.RectanglesTabPage.Controls.Add(this.IdTextBox);
            this.RectanglesTabPage.Controls.Add(this.RectInfoListBox);
            this.RectanglesTabPage.Controls.Add(this.RectPanel);
            this.RectanglesTabPage.Controls.Add(this.DeleteRectButton);
            this.RectanglesTabPage.Controls.Add(this.AddRectButton);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 24);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(734, 372);
            this.RectanglesTabPage.TabIndex = 3;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // BelowRectInfoLabel
            // 
            this.BelowRectInfoLabel.AutoSize = true;
            this.BelowRectInfoLabel.Location = new System.Drawing.Point(6, 11);
            this.BelowRectInfoLabel.Name = "BelowRectInfoLabel";
            this.BelowRectInfoLabel.Size = new System.Drawing.Size(67, 15);
            this.BelowRectInfoLabel.TabIndex = 8;
            this.BelowRectInfoLabel.Text = "Rectangles:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(8, 211);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRectangleLabel.TabIndex = 9;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesHeightLabel
            // 
            this.RectanglesHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesHeightLabel.AutoSize = true;
            this.RectanglesHeightLabel.Location = new System.Drawing.Point(8, 337);
            this.RectanglesHeightLabel.Name = "RectanglesHeightLabel";
            this.RectanglesHeightLabel.Size = new System.Drawing.Size(46, 15);
            this.RectanglesHeightLabel.TabIndex = 10;
            this.RectanglesHeightLabel.Text = "Height:";
            // 
            // RectanglesWidthLabel
            // 
            this.RectanglesWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesWidthLabel.AutoSize = true;
            this.RectanglesWidthLabel.Location = new System.Drawing.Point(12, 312);
            this.RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            this.RectanglesWidthLabel.Size = new System.Drawing.Size(42, 15);
            this.RectanglesWidthLabel.TabIndex = 11;
            this.RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesYLabel
            // 
            this.RectanglesYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesYLabel.AutoSize = true;
            this.RectanglesYLabel.Location = new System.Drawing.Point(37, 287);
            this.RectanglesYLabel.Name = "RectanglesYLabel";
            this.RectanglesYLabel.Size = new System.Drawing.Size(17, 15);
            this.RectanglesYLabel.TabIndex = 12;
            this.RectanglesYLabel.Text = "Y:";
            // 
            // RectanglesXLabel
            // 
            this.RectanglesXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesXLabel.AutoSize = true;
            this.RectanglesXLabel.Location = new System.Drawing.Point(37, 262);
            this.RectanglesXLabel.Name = "RectanglesXLabel";
            this.RectanglesXLabel.Size = new System.Drawing.Size(17, 15);
            this.RectanglesXLabel.TabIndex = 13;
            this.RectanglesXLabel.Text = "X:";
            // 
            // RectanglesIdLabel
            // 
            this.RectanglesIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesIdLabel.AutoSize = true;
            this.RectanglesIdLabel.Location = new System.Drawing.Point(34, 237);
            this.RectanglesIdLabel.Name = "RectanglesIdLabel";
            this.RectanglesIdLabel.Size = new System.Drawing.Size(20, 15);
            this.RectanglesIdLabel.TabIndex = 14;
            this.RectanglesIdLabel.Text = "Id:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightTextBox.Location = new System.Drawing.Point(60, 334);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(110, 23);
            this.HeightTextBox.TabIndex = 23;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthTextBox.Location = new System.Drawing.Point(60, 309);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(110, 23);
            this.WidthTextBox.TabIndex = 22;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // YTextBox
            // 
            this.YTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YTextBox.Location = new System.Drawing.Point(60, 284);
            this.YTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(110, 23);
            this.YTextBox.TabIndex = 21;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // XTextBox
            // 
            this.XTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XTextBox.Location = new System.Drawing.Point(60, 259);
            this.XTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(110, 23);
            this.XTextBox.TabIndex = 20;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdTextBox.Location = new System.Drawing.Point(60, 234);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(110, 23);
            this.IdTextBox.TabIndex = 15;
            // 
            // RectInfoListBox
            // 
            this.RectInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectInfoListBox.FormattingEnabled = true;
            this.RectInfoListBox.ItemHeight = 15;
            this.RectInfoListBox.Location = new System.Drawing.Point(6, 34);
            this.RectInfoListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectInfoListBox.Name = "RectInfoListBox";
            this.RectInfoListBox.Size = new System.Drawing.Size(266, 139);
            this.RectInfoListBox.TabIndex = 16;
            this.RectInfoListBox.SelectedIndexChanged += new System.EventHandler(this.RectInfoListBox_SelectedIndexChanged);
            // 
            // RectPanel
            // 
            this.RectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectPanel.Location = new System.Drawing.Point(290, 7);
            this.RectPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectPanel.Name = "RectPanel";
            this.RectPanel.Size = new System.Drawing.Size(420, 350);
            this.RectPanel.TabIndex = 19;
            // 
            // DeleteRectButton
            // 
            this.DeleteRectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRectButton.Location = new System.Drawing.Point(171, 181);
            this.DeleteRectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteRectButton.Name = "DeleteRectButton";
            this.DeleteRectButton.Size = new System.Drawing.Size(27, 22);
            this.DeleteRectButton.TabIndex = 18;
            this.DeleteRectButton.Text = "-";
            this.DeleteRectButton.UseVisualStyleBackColor = true;
            this.DeleteRectButton.Click += new System.EventHandler(this.DeleteRectButton_Click);
            // 
            // AddRectButton
            // 
            this.AddRectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRectButton.Location = new System.Drawing.Point(60, 181);
            this.AddRectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRectButton.Name = "AddRectButton";
            this.AddRectButton.Size = new System.Drawing.Size(27, 22);
            this.AddRectButton.TabIndex = 17;
            this.AddRectButton.Text = "+";
            this.AddRectButton.UseVisualStyleBackColor = true;
            this.AddRectButton.Click += new System.EventHandler(this.AddRectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 400);
            this.Controls.Add(this.EnumsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanelChild.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.TableLayoutPanelClasses.ResumeLayout(false);
            this.FilmGroupBox.ResumeLayout(false);
            this.FilmGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage EnumsTabPage;
        private TableLayoutPanel TableLayoutPanel;
        private TableLayoutPanel TableLayoutPanelChild;
        private GroupBox EnumerationsGroupBox;
        private Label ChooseEnumerationLabel;
        private ListBox AllEnumsListBox;
        private Label IntValueLabel;
        private Label ChooseValueLabel;
        private ListBox EnumValuesListBox;
        private TextBox ValueIntTextBox;
        private GroupBox WeekdayParsingGroupBox;
        private GroupBox SeasonHandleGroupBox;
        private TextBox ParsingValueTextBox;
        private Label TypeValueForParsingLabel;
        private Button ParseButton;
        private Label ParseLabel;
        private Button GoButton;
        private Label ChooseSeasonLabel;
        private ComboBox SeasonComboBox;
        private TabPage ClassesTabPage;
        private GroupBox RectanglesGroupBox;
        private Button FindMaxWidthButton;
        private Label ColorLabel;
        private Label LengthLabel;
        private Label RectWidthLabel;
        private TextBox RectColorTextBox;
        private TextBox RectLengthTextBox;
        private TextBox RectWidthTextBox;
        private ListBox RectanglesListBox;
        private TableLayoutPanel TableLayoutPanelClasses;
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
        private Label Ylabel;
        private Label Xlabel;
        private TextBox RectYTextBox;
        private TextBox RectXTextBox;
        private Label IDlabel;
        private TextBox RectIDTextBox;
        private TabPage RectanglesTabPage;
        private Label BelowRectInfoLabel;
        private Label SelectedRectangleLabel;
        private Label RectanglesHeightLabel;
        private Label RectanglesWidthLabel;
        private Label RectanglesYLabel;
        private Label RectanglesXLabel;
        private Label RectanglesIdLabel;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private TextBox IdTextBox;
        private ListBox RectInfoListBox;
        private Panel RectPanel;
        private Button DeleteRectButton;
        private Button AddRectButton;
    }
}