namespace StudentsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.allStudentsControl1 = new StudentsApp.View.Panels.AllStudentsControl();
            this.SuspendLayout();
            // 
            // allStudentsControl1
            // 
            this.allStudentsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allStudentsControl1.Location = new System.Drawing.Point(0, 0);
            this.allStudentsControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allStudentsControl1.MinimumSize = new System.Drawing.Size(1000, 500);
            this.allStudentsControl1.Name = "allStudentsControl1";
            this.allStudentsControl1.Size = new System.Drawing.Size(1000, 507);
            this.allStudentsControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 507);
            this.Controls.Add(this.allStudentsControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1010, 544);
            this.Name = "MainForm";
            this.Text = "Students App";
            this.ResumeLayout(false);

        }

        #endregion

        private View.Panels.AllStudentsControl allStudentsControl1;
    }
}