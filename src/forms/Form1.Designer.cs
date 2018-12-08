namespace Opzet
{
    partial class Form1
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
            this.ListboxShowFiles = new System.Windows.Forms.ListBox();
            this.NewProject = new System.Windows.Forms.Button();
            this.BrowseText = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListboxShowFiles
            // 
            this.ListboxShowFiles.FormattingEnabled = true;
            this.ListboxShowFiles.Location = new System.Drawing.Point(15, 79);
            this.ListboxShowFiles.Name = "ListboxShowFiles";
            this.ListboxShowFiles.Size = new System.Drawing.Size(630, 316);
            this.ListboxShowFiles.TabIndex = 2;
            // 
            // NewProject
            // 
            this.NewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewProject.Location = new System.Drawing.Point(671, 73);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(117, 29);
            this.NewProject.TabIndex = 3;
            this.NewProject.Text = "New Project";
            this.NewProject.UseVisualStyleBackColor = true;
            this.NewProject.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // BrowseText
            // 
            this.BrowseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BrowseText.Location = new System.Drawing.Point(126, 47);
            this.BrowseText.Name = "BrowseText";
            this.BrowseText.ReadOnly = true;
            this.BrowseText.Size = new System.Drawing.Size(480, 23);
            this.BrowseText.TabIndex = 4;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BrowseButton.Location = new System.Drawing.Point(612, 47);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(33, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Directory";
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteProjectButton.Location = new System.Drawing.Point(671, 108);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(117, 28);
            this.DeleteProjectButton.TabIndex = 7;
            this.DeleteProjectButton.Text = "Delete Project";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteProjectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.BrowseText);
            this.Controls.Add(this.NewProject);
            this.Controls.Add(this.ListboxShowFiles);
            this.Name = "Form1";
            this.Text = "New Projects";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListboxShowFiles;
        private System.Windows.Forms.Button NewProject;
        private System.Windows.Forms.TextBox BrowseText;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteProjectButton;
    }
}

