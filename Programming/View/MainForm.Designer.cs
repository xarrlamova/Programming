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
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.allEnumerationsControl1 = new Programming.View.Panels.AllEnumerationsControl();
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
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.TableLayoutPanelChild.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
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
            resources.ApplyResources(this.EnumsTabControl, "EnumsTabControl");
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.TableLayoutPanel);
            resources.ApplyResources(this.EnumsTabPage, "EnumsTabPage");
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel
            // 
            resources.ApplyResources(this.TableLayoutPanel, "TableLayoutPanel");
            this.TableLayoutPanel.Controls.Add(this.TableLayoutPanelChild, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.allEnumerationsControl1, 0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            // 
            // TableLayoutPanelChild
            // 
            resources.ApplyResources(this.TableLayoutPanelChild, "TableLayoutPanelChild");
            this.TableLayoutPanelChild.Controls.Add(this.SeasonHandleGroupBox, 1, 0);
            this.TableLayoutPanelChild.Controls.Add(this.weekdayParsingControl1, 0, 0);
            this.TableLayoutPanelChild.Name = "TableLayoutPanelChild";
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            resources.ApplyResources(this.SeasonHandleGroupBox, "SeasonHandleGroupBox");
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.TabStop = false;
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.SeasonComboBox, "SeasonComboBox");
            this.SeasonComboBox.Name = "SeasonComboBox";
            // 
            // GoButton
            // 
            resources.ApplyResources(this.GoButton, "GoButton");
            this.GoButton.Name = "GoButton";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChooseSeasonLabel
            // 
            resources.ApplyResources(this.ChooseSeasonLabel, "ChooseSeasonLabel");
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            // 
            // allEnumerationsControl1
            // 
            resources.ApplyResources(this.allEnumerationsControl1, "allEnumerationsControl1");
            this.allEnumerationsControl1.Name = "allEnumerationsControl1";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.TableLayoutPanelClasses);
            resources.ApplyResources(this.ClassesTabPage, "ClassesTabPage");
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelClasses
            // 
            resources.ApplyResources(this.TableLayoutPanelClasses, "TableLayoutPanelClasses");
            this.TableLayoutPanelClasses.Controls.Add(this.FilmGroupBox, 1, 0);
            this.TableLayoutPanelClasses.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.TableLayoutPanelClasses.Name = "TableLayoutPanelClasses";
            // 
            // FilmGroupBox
            // 
            resources.ApplyResources(this.FilmGroupBox, "FilmGroupBox");
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
            this.FilmGroupBox.Name = "FilmGroupBox";
            this.FilmGroupBox.TabStop = false;
            // 
            // RatingLabel
            // 
            resources.ApplyResources(this.RatingLabel, "RatingLabel");
            this.RatingLabel.Name = "RatingLabel";
            // 
            // GenreLabel
            // 
            resources.ApplyResources(this.GenreLabel, "GenreLabel");
            this.GenreLabel.Name = "GenreLabel";
            // 
            // YearLabel
            // 
            resources.ApplyResources(this.YearLabel, "YearLabel");
            this.YearLabel.Name = "YearLabel";
            // 
            // DurationLabel
            // 
            resources.ApplyResources(this.DurationLabel, "DurationLabel");
            this.DurationLabel.Name = "DurationLabel";
            // 
            // filmNameLabel
            // 
            resources.ApplyResources(this.filmNameLabel, "filmNameLabel");
            this.filmNameLabel.Name = "filmNameLabel";
            // 
            // FindMaxFilmRatingButton
            // 
            resources.ApplyResources(this.FindMaxFilmRatingButton, "FindMaxFilmRatingButton");
            this.FindMaxFilmRatingButton.Name = "FindMaxFilmRatingButton";
            this.FindMaxFilmRatingButton.UseVisualStyleBackColor = true;
            this.FindMaxFilmRatingButton.Click += new System.EventHandler(this.FindMaxFilmRatingButton_Click);
            // 
            // FilmRatingTextBox
            // 
            resources.ApplyResources(this.FilmRatingTextBox, "FilmRatingTextBox");
            this.FilmRatingTextBox.Name = "FilmRatingTextBox";
            this.FilmRatingTextBox.TextChanged += new System.EventHandler(this.FilmRatingTextBox_TextChanged);
            // 
            // FilmGenreTextBox
            // 
            resources.ApplyResources(this.FilmGenreTextBox, "FilmGenreTextBox");
            this.FilmGenreTextBox.Name = "FilmGenreTextBox";
            this.FilmGenreTextBox.TextChanged += new System.EventHandler(this.FilmGenreTextBox_TextChanged);
            // 
            // FilmYearTextBox
            // 
            resources.ApplyResources(this.FilmYearTextBox, "FilmYearTextBox");
            this.FilmYearTextBox.Name = "FilmYearTextBox";
            this.FilmYearTextBox.TextChanged += new System.EventHandler(this.FilmYearTextBox_TextChanged);
            // 
            // FilmDurationTextBox
            // 
            resources.ApplyResources(this.FilmDurationTextBox, "FilmDurationTextBox");
            this.FilmDurationTextBox.Name = "FilmDurationTextBox";
            this.FilmDurationTextBox.TextChanged += new System.EventHandler(this.FilmDurationTextBox_TextChanged);
            // 
            // FilmNameTextBox
            // 
            resources.ApplyResources(this.FilmNameTextBox, "FilmNameTextBox");
            this.FilmNameTextBox.Name = "FilmNameTextBox";
            this.FilmNameTextBox.TextChanged += new System.EventHandler(this.FilmNameTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            resources.ApplyResources(this.FilmsListBox, "FilmsListBox");
            this.FilmsListBox.Name = "FilmsListBox";
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
            resources.ApplyResources(this.RectanglesGroupBox, "RectanglesGroupBox");
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.TabStop = false;
            // 
            // IDlabel
            // 
            resources.ApplyResources(this.IDlabel, "IDlabel");
            this.IDlabel.Name = "IDlabel";
            // 
            // RectIDTextBox
            // 
            resources.ApplyResources(this.RectIDTextBox, "RectIDTextBox");
            this.RectIDTextBox.Name = "RectIDTextBox";
            this.RectIDTextBox.ReadOnly = true;
            // 
            // Ylabel
            // 
            resources.ApplyResources(this.Ylabel, "Ylabel");
            this.Ylabel.Name = "Ylabel";
            // 
            // Xlabel
            // 
            resources.ApplyResources(this.Xlabel, "Xlabel");
            this.Xlabel.Name = "Xlabel";
            // 
            // RectYTextBox
            // 
            resources.ApplyResources(this.RectYTextBox, "RectYTextBox");
            this.RectYTextBox.Name = "RectYTextBox";
            this.RectYTextBox.ReadOnly = true;
            // 
            // RectXTextBox
            // 
            resources.ApplyResources(this.RectXTextBox, "RectXTextBox");
            this.RectXTextBox.Name = "RectXTextBox";
            this.RectXTextBox.ReadOnly = true;
            // 
            // FindMaxWidthButton
            // 
            resources.ApplyResources(this.FindMaxWidthButton, "FindMaxWidthButton");
            this.FindMaxWidthButton.Name = "FindMaxWidthButton";
            this.FindMaxWidthButton.UseVisualStyleBackColor = true;
            this.FindMaxWidthButton.Click += new System.EventHandler(this.FindMaxWidthButton_Click);
            // 
            // ColorLabel
            // 
            resources.ApplyResources(this.ColorLabel, "ColorLabel");
            this.ColorLabel.Name = "ColorLabel";
            // 
            // LengthLabel
            // 
            resources.ApplyResources(this.LengthLabel, "LengthLabel");
            this.LengthLabel.Name = "LengthLabel";
            // 
            // RectWidthLabel
            // 
            resources.ApplyResources(this.RectWidthLabel, "RectWidthLabel");
            this.RectWidthLabel.Name = "RectWidthLabel";
            // 
            // RectColorTextBox
            // 
            resources.ApplyResources(this.RectColorTextBox, "RectColorTextBox");
            this.RectColorTextBox.Name = "RectColorTextBox";
            this.RectColorTextBox.TextChanged += new System.EventHandler(this.RectColorTextBox_TextChanged);
            // 
            // RectLengthTextBox
            // 
            resources.ApplyResources(this.RectLengthTextBox, "RectLengthTextBox");
            this.RectLengthTextBox.Name = "RectLengthTextBox";
            this.RectLengthTextBox.TextChanged += new System.EventHandler(this.RectLengthTextBox_TextChanged);
            // 
            // RectWidthTextBox
            // 
            resources.ApplyResources(this.RectWidthTextBox, "RectWidthTextBox");
            this.RectWidthTextBox.Name = "RectWidthTextBox";
            this.RectWidthTextBox.TextChanged += new System.EventHandler(this.RectWidthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            resources.ApplyResources(this.RectanglesListBox, "RectanglesListBox");
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            resources.ApplyResources(this.RectanglesTabPage, "RectanglesTabPage");
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            resources.ApplyResources(this.rectanglesCollisionControl1, "rectanglesCollisionControl1");
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            // 
            // weekdayParsingControl1
            // 
            resources.ApplyResources(this.weekdayParsingControl1, "weekdayParsingControl1");
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumsTabControl);
            this.Name = "MainForm";
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanelChild.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.TableLayoutPanelClasses.ResumeLayout(false);
            this.FilmGroupBox.ResumeLayout(false);
            this.FilmGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage EnumsTabPage;
        private TableLayoutPanel TableLayoutPanel;
        private TableLayoutPanel TableLayoutPanelChild;
        private GroupBox SeasonHandleGroupBox;
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
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.AllEnumerationsControl allEnumerationsControl1;
        private Panels.WeekdayParsingControl weekdayParsingControl1;
    }
}