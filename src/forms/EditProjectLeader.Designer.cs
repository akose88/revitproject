namespace Opzet
{
    partial class EditProjectLeader
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
            this.Label_XmlPath = new System.Windows.Forms.Label();
            this.DataGridView_ProjectLeaders = new System.Windows.Forms.DataGridView();
            this.Button_EditProjectLeader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ProjectLeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_XmlPath
            // 
            this.Label_XmlPath.AutoSize = true;
            this.Label_XmlPath.Location = new System.Drawing.Point(9, 16);
            this.Label_XmlPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_XmlPath.Name = "Label_XmlPath";
            this.Label_XmlPath.Size = new System.Drawing.Size(78, 13);
            this.Label_XmlPath.TabIndex = 0;
            this.Label_XmlPath.Text = "Label_XmlPath";
            this.Label_XmlPath.Visible = false;
            // 
            // DataGridView_ProjectLeaders
            // 
            this.DataGridView_ProjectLeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ProjectLeaders.Location = new System.Drawing.Point(9, 57);
            this.DataGridView_ProjectLeaders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView_ProjectLeaders.Name = "DataGridView_ProjectLeaders";
            this.DataGridView_ProjectLeaders.RowTemplate.Height = 24;
            this.DataGridView_ProjectLeaders.Size = new System.Drawing.Size(350, 186);
            this.DataGridView_ProjectLeaders.TabIndex = 1;
            // 
            // Button_EditProjectLeader
            // 
            this.Button_EditProjectLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_EditProjectLeader.Location = new System.Drawing.Point(146, 266);
            this.Button_EditProjectLeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_EditProjectLeader.Name = "Button_EditProjectLeader";
            this.Button_EditProjectLeader.Size = new System.Drawing.Size(56, 25);
            this.Button_EditProjectLeader.TabIndex = 2;
            this.Button_EditProjectLeader.Text = "Edit";
            this.Button_EditProjectLeader.UseVisualStyleBackColor = true;
            this.Button_EditProjectLeader.Click += new System.EventHandler(this.Button_AddProjectLeader_Click);
            // 
            // EditProjectLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 302);
            this.Controls.Add(this.Button_EditProjectLeader);
            this.Controls.Add(this.DataGridView_ProjectLeaders);
            this.Controls.Add(this.Label_XmlPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditProjectLeader";
            this.Text = "Edit Projectleaders XML file";
            this.Load += new System.EventHandler(this.EditProjectLeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ProjectLeaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_XmlPath;
        private System.Windows.Forms.DataGridView DataGridView_ProjectLeaders;
        private System.Windows.Forms.Button Button_EditProjectLeader;
    }
}