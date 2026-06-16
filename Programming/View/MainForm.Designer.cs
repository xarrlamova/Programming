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
            this.WeekdayParsingControl = new Programming.View.Panels.WeekdayParsingControl();
            this.SeasonsControl = new Programming.View.Panels.SeasonsControl();
            this.allEnumerationsControl1 = new Programming.View.Panels.AllEnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelClasses = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesControl = new Programming.View.Panels.RectanglesControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.MoviesControls = new Programming.View.Panels.MoviesControls();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.TableLayoutPanelChild.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.TableLayoutPanelClasses.SuspendLayout();
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
            this.TableLayoutPanelChild.Controls.Add(this.WeekdayParsingControl, 0, 0);
            this.TableLayoutPanelChild.Controls.Add(this.SeasonsControl, 1, 0);
            this.TableLayoutPanelChild.Name = "TableLayoutPanelChild";
            // 
            // WeekdayParsingControl
            // 
            resources.ApplyResources(this.WeekdayParsingControl, "WeekdayParsingControl");
            this.WeekdayParsingControl.Name = "WeekdayParsingControl";
            // 
            // SeasonsControl
            // 
            resources.ApplyResources(this.SeasonsControl, "SeasonsControl");
            this.SeasonsControl.Name = "SeasonsControl";
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
            this.TableLayoutPanelClasses.Controls.Add(this.RectanglesControl, 0, 0);
            this.TableLayoutPanelClasses.Controls.Add(this.MoviesControls, 1, 0);
            this.TableLayoutPanelClasses.Name = "TableLayoutPanelClasses";
            // 
            // RectanglesControl
            // 
            resources.ApplyResources(this.RectanglesControl, "RectanglesControl");
            this.RectanglesControl.Name = "RectanglesControl";
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RectanglesCollisionControl);
            resources.ApplyResources(this.RectanglesTabPage, "RectanglesTabPage");
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesCollisionControl
            // 
            resources.ApplyResources(this.RectanglesCollisionControl, "RectanglesCollisionControl");
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            // 
            // MoviesControls
            // 
            resources.ApplyResources(this.MoviesControls, "MoviesControls");
            this.MoviesControls.Name = "MoviesControls";
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
            this.ClassesTabPage.ResumeLayout(false);
            this.TableLayoutPanelClasses.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage EnumsTabPage;
        private TableLayoutPanel TableLayoutPanel;
        private TableLayoutPanel TableLayoutPanelChild;
        private TabPage ClassesTabPage;
        private TableLayoutPanel TableLayoutPanelClasses;
        private TabPage RectanglesTabPage;
        private Panels.RectanglesCollisionControl RectanglesCollisionControl;
        private Panels.AllEnumerationsControl allEnumerationsControl1;
        private Panels.WeekdayParsingControl WeekdayParsingControl;
        private Panels.SeasonsControl SeasonsControl;
        private Panels.RectanglesControl RectanglesControl;
        private Panels.MoviesControls MoviesControls;
    }
}