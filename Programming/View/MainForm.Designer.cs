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
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueIntTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.EnumValuesListBox = new System.Windows.Forms.ListBox();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.AllEnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.TableLayoutPanelChild.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(582, 461);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.TableLayoutPanel);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(574, 433);
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
            this.TableLayoutPanel.Size = new System.Drawing.Size(568, 427);
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
            this.TableLayoutPanelChild.Location = new System.Drawing.Point(0, 213);
            this.TableLayoutPanelChild.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelChild.Name = "TableLayoutPanelChild";
            this.TableLayoutPanelChild.RowCount = 1;
            this.TableLayoutPanelChild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelChild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelChild.Size = new System.Drawing.Size(568, 214);
            this.TableLayoutPanelChild.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(278, 208);
            this.WeekdayParsingGroupBox.TabIndex = 0;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(287, 3);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(278, 208);
            this.SeasonHandleGroupBox.TabIndex = 1;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
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
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(562, 207);
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
            this.ValueIntTextBox.TextChanged += new System.EventHandler(this.ValueIntTextBox_TextChanged);
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
            this.EnumValuesListBox.Size = new System.Drawing.Size(136, 149);
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
            this.AllEnumsListBox.Size = new System.Drawing.Size(136, 149);
            this.AllEnumsListBox.TabIndex = 0;
            this.AllEnumsListBox.SelectedIndexChanged += new System.EventHandler(this.AllEnumsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 461);
            this.Controls.Add(this.EnumsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanelChild.ResumeLayout(false);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
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
    }
}