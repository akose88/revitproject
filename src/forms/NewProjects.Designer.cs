namespace Opzet
{
    partial class NewProjects
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
            this.Listbox_ListboxShowFiles = new System.Windows.Forms.ListBox();
            this.Button_NewProject = new System.Windows.Forms.Button();
            this.Textbox_BrowseText = new System.Windows.Forms.TextBox();
            this.Button_BrowseFolderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_DeleteProject = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Listbox_ListboxShowFiles
            // 
            this.Listbox_ListboxShowFiles.FormattingEnabled = true;
            this.Listbox_ListboxShowFiles.ItemHeight = 16;
            this.Listbox_ListboxShowFiles.Location = new System.Drawing.Point(20, 97);
            this.Listbox_ListboxShowFiles.Margin = new System.Windows.Forms.Padding(4);
            this.Listbox_ListboxShowFiles.Name = "Listbox_ListboxShowFiles";
            this.Listbox_ListboxShowFiles.Size = new System.Drawing.Size(839, 388);
            this.Listbox_ListboxShowFiles.TabIndex = 2;
            // 
            // Button_NewProject
            // 
            this.Button_NewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_NewProject.Location = new System.Drawing.Point(895, 90);
            this.Button_NewProject.Margin = new System.Windows.Forms.Padding(4);
            this.Button_NewProject.Name = "Button_NewProject";
            this.Button_NewProject.Size = new System.Drawing.Size(156, 36);
            this.Button_NewProject.TabIndex = 3;
            this.Button_NewProject.Text = "New Project";
            this.Button_NewProject.UseVisualStyleBackColor = true;
            this.Button_NewProject.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // Textbox_BrowseText
            // 
            this.Textbox_BrowseText.AllowDrop = true;
            this.Textbox_BrowseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Textbox_BrowseText.Location = new System.Drawing.Point(168, 58);
            this.Textbox_BrowseText.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_BrowseText.Name = "Textbox_BrowseText";
            this.Textbox_BrowseText.ReadOnly = true;
            this.Textbox_BrowseText.Size = new System.Drawing.Size(639, 26);
            this.Textbox_BrowseText.TabIndex = 4;
            // 
            // Button_BrowseFolderButton
            // 
            this.Button_BrowseFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_BrowseFolderButton.Location = new System.Drawing.Point(816, 58);
            this.Button_BrowseFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.Button_BrowseFolderButton.Name = "Button_BrowseFolderButton";
            this.Button_BrowseFolderButton.Size = new System.Drawing.Size(44, 28);
            this.Button_BrowseFolderButton.TabIndex = 5;
            this.Button_BrowseFolderButton.Text = "...";
            this.Button_BrowseFolderButton.UseVisualStyleBackColor = true;
            this.Button_BrowseFolderButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Directory";
            // 
            // Button_DeleteProject
            // 
            this.Button_DeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_DeleteProject.Location = new System.Drawing.Point(895, 133);
            this.Button_DeleteProject.Margin = new System.Windows.Forms.Padding(4);
            this.Button_DeleteProject.Name = "Button_DeleteProject";
            this.Button_DeleteProject.Size = new System.Drawing.Size(156, 34);
            this.Button_DeleteProject.TabIndex = 7;
            this.Button_DeleteProject.Text = "Delete Project";
            this.Button_DeleteProject.UseVisualStyleBackColor = true;
            this.Button_DeleteProject.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_Close.Location = new System.Drawing.Point(895, 175);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(156, 34);
            this.Button_Close.TabIndex = 8;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // NewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_DeleteProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_BrowseFolderButton);
            this.Controls.Add(this.Textbox_BrowseText);
            this.Controls.Add(this.Button_NewProject);
            this.Controls.Add(this.Listbox_ListboxShowFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewProjects";
            this.Text = "New Projects";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Listbox_ListboxShowFiles;
        private System.Windows.Forms.Button Button_NewProject;
        private System.Windows.Forms.TextBox Textbox_BrowseText;
        private System.Windows.Forms.Button Button_BrowseFolderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_DeleteProject;
        private System.Windows.Forms.Button Button_Close;
    }
}

