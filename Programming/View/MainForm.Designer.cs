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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.RectYTextBox = new System.Windows.Forms.TextBox();
            this.RectXTextBox = new System.Windows.Forms.TextBox();
            this.RectIDTextBox = new System.Windows.Forms.TextBox();
            this.FindMaxWidthButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectWidthLabel = new System.Windows.Forms.Label();
            this.RectColorTextBox = new System.Windows.Forms.TextBox();
            this.RectLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.TableLayoutPanelChild.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsTabControl.Controls.Add(this.ClassesTabPage);
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
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(734, 372);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IDlabel);
            this.RectanglesGroupBox.Controls.Add(this.Ylabel);
            this.RectanglesGroupBox.Controls.Add(this.Xlabel);
            this.RectanglesGroupBox.Controls.Add(this.RectYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectIDTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindMaxWidthButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectLengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(728, 366);
            this.RectanglesGroupBox.TabIndex = 2;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(138, 154);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 15);
            this.IDlabel.TabIndex = 13;
            this.IDlabel.Text = "ID";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(208, 200);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(14, 15);
            this.Ylabel.TabIndex = 12;
            this.Ylabel.Text = "Y";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(136, 200);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(14, 15);
            this.Xlabel.TabIndex = 11;
            this.Xlabel.Text = "X";
            // 
            // RectYTextBox
            // 
            this.RectYTextBox.Location = new System.Drawing.Point(208, 218);
            this.RectYTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectYTextBox.Name = "RectYTextBox";
            this.RectYTextBox.ReadOnly = true;
            this.RectYTextBox.Size = new System.Drawing.Size(62, 23);
            this.RectYTextBox.TabIndex = 10;
            // 
            // RectXTextBox
            // 
            this.RectXTextBox.Location = new System.Drawing.Point(137, 218);
            this.RectXTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectXTextBox.Name = "RectXTextBox";
            this.RectXTextBox.ReadOnly = true;
            this.RectXTextBox.Size = new System.Drawing.Size(62, 23);
            this.RectXTextBox.TabIndex = 9;
            // 
            // RectIDTextBox
            // 
            this.RectIDTextBox.Location = new System.Drawing.Point(137, 172);
            this.RectIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectIDTextBox.Name = "RectIDTextBox";
            this.RectIDTextBox.ReadOnly = true;
            this.RectIDTextBox.Size = new System.Drawing.Size(132, 23);
            this.RectIDTextBox.TabIndex = 8;
            // 
            // FindMaxWidthButton
            // 
            this.FindMaxWidthButton.Location = new System.Drawing.Point(140, 266);
            this.FindMaxWidthButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindMaxWidthButton.Name = "FindMaxWidthButton";
            this.FindMaxWidthButton.Size = new System.Drawing.Size(82, 22);
            this.FindMaxWidthButton.TabIndex = 7;
            this.FindMaxWidthButton.Text = "Find";
            this.FindMaxWidthButton.UseVisualStyleBackColor = true;
            this.FindMaxWidthButton.Click += new System.EventHandler(this.FindMaxWidthButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(137, 109);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(36, 15);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(137, 63);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(44, 15);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Length";
            // 
            // RectWidthLabel
            // 
            this.RectWidthLabel.AutoSize = true;
            this.RectWidthLabel.Location = new System.Drawing.Point(137, 19);
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
            this.RectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(2, 19);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(132, 259);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
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
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
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
        private Label IDlabel;
        private Label Ylabel;
        private Label Xlabel;
        private TextBox RectYTextBox;
        private TextBox RectXTextBox;
        private TextBox RectIDTextBox;
        private Button FindMaxWidthButton;
        private Label ColorLabel;
        private Label LengthLabel;
        private Label RectWidthLabel;
        private TextBox RectColorTextBox;
        private TextBox RectLengthTextBox;
        private TextBox RectWidthTextBox;
        private ListBox RectanglesListBox;
    }
}