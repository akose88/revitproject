namespace Opzet
{
    partial class ProjectInformation
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
            this.components = new System.ComponentModel.Container();
            this.Label_ProjectNumber = new System.Windows.Forms.Label();
            this.Textbox_ProjectNumber = new System.Windows.Forms.TextBox();
            this.Label_Description = new System.Windows.Forms.Label();
            this.Textbox_Description = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_ProjectNumberSuffix = new System.Windows.Forms.Label();
            this.Textbox_ProjectNumberSuffix = new System.Windows.Forms.TextBox();
            this.ComboBox_Discipline = new System.Windows.Forms.ComboBox();
            this.Label_Discipline = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_EditProjectLeader = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.PlComboBox = new System.Windows.Forms.ComboBox();
            this.Textbox_OrganizationName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TextboxReadOnly_ProjectNumber = new System.Windows.Forms.TextBox();
            this.ProjectLeader = new System.Windows.Forms.Label();
            this.Label_OrganizationDescription = new System.Windows.Forms.Label();
            this.Label_ProjectName = new System.Windows.Forms.Label();
            this.Label_Organization = new System.Windows.Forms.Label();
            this.Label_BuildingName = new System.Windows.Forms.Label();
            this.Label_ProjectNumberReadOnly = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ToolTip_ProjectNumberSeperator = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_ProjectNumber
            // 
            this.Label_ProjectNumber.AutoSize = true;
            this.Label_ProjectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_ProjectNumber.Location = new System.Drawing.Point(12, 28);
            this.Label_ProjectNumber.Name = "Label_ProjectNumber";
            this.Label_ProjectNumber.Size = new System.Drawing.Size(106, 17);
            this.Label_ProjectNumber.TabIndex = 1;
            this.Label_ProjectNumber.Text = "Project Number";
            // 
            // Textbox_ProjectNumber
            // 
            this.Textbox_ProjectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Textbox_ProjectNumber.Location = new System.Drawing.Point(186, 26);
            this.Textbox_ProjectNumber.Name = "Textbox_ProjectNumber";
            this.Textbox_ProjectNumber.Size = new System.Drawing.Size(256, 23);
            this.Textbox_ProjectNumber.TabIndex = 0;
            this.Textbox_ProjectNumber.TextChanged += new System.EventHandler(this.Textbox_ProjectNumber_TextChanged);
            this.Textbox_ProjectNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_ProjectNumber_KeyPress);
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Description.Location = new System.Drawing.Point(12, 83);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(79, 17);
            this.Label_Description.TabIndex = 1;
            this.Label_Description.Text = "Description";
            // 
            // Textbox_Description
            // 
            this.Textbox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Textbox_Description.Location = new System.Drawing.Point(186, 81);
            this.Textbox_Description.Name = "Textbox_Description";
            this.Textbox_Description.Size = new System.Drawing.Size(256, 23);
            this.Textbox_Description.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_ProjectNumberSuffix);
            this.groupBox1.Controls.Add(this.Textbox_ProjectNumberSuffix);
            this.groupBox1.Controls.Add(this.Textbox_ProjectNumber);
            this.groupBox1.Controls.Add(this.ComboBox_Discipline);
            this.groupBox1.Controls.Add(this.Textbox_Description);
            this.groupBox1.Controls.Add(this.Label_Discipline);
            this.groupBox1.Controls.Add(this.Label_ProjectNumber);
            this.groupBox1.Controls.Add(this.Label_Description);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name";
            // 
            // Label_ProjectNumberSuffix
            // 
            this.Label_ProjectNumberSuffix.AutoSize = true;
            this.Label_ProjectNumberSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_ProjectNumberSuffix.Location = new System.Drawing.Point(12, 55);
            this.Label_ProjectNumberSuffix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_ProjectNumberSuffix.Name = "Label_ProjectNumberSuffix";
            this.Label_ProjectNumberSuffix.Size = new System.Drawing.Size(144, 17);
            this.Label_ProjectNumberSuffix.TabIndex = 4;
            this.Label_ProjectNumberSuffix.Text = "Project Number Suffix";
            // 
            // Textbox_ProjectNumberSuffix
            // 
            this.Textbox_ProjectNumberSuffix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Textbox_ProjectNumberSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Textbox_ProjectNumberSuffix.Location = new System.Drawing.Point(186, 53);
            this.Textbox_ProjectNumberSuffix.Margin = new System.Windows.Forms.Padding(2);
            this.Textbox_ProjectNumberSuffix.Name = "Textbox_ProjectNumberSuffix";
            this.Textbox_ProjectNumberSuffix.Size = new System.Drawing.Size(256, 23);
            this.Textbox_ProjectNumberSuffix.TabIndex = 1;
            this.Textbox_ProjectNumberSuffix.TextChanged += new System.EventHandler(this.Textbox_ProjectNumberSuffix_TextChanged);
            this.Textbox_ProjectNumberSuffix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_ProjectNumberSuffix_KeyPress);
            // 
            // ComboBox_Discipline
            // 
            this.ComboBox_Discipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Discipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboBox_Discipline.FormattingEnabled = true;
            this.ComboBox_Discipline.Location = new System.Drawing.Point(186, 108);
            this.ComboBox_Discipline.Name = "ComboBox_Discipline";
            this.ComboBox_Discipline.Size = new System.Drawing.Size(256, 24);
            this.ComboBox_Discipline.TabIndex = 4;
            this.ComboBox_Discipline.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Discipline_SelectedIndexChanged);
            // 
            // Label_Discipline
            // 
            this.Label_Discipline.AutoSize = true;
            this.Label_Discipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Discipline.Location = new System.Drawing.Point(12, 111);
            this.Label_Discipline.Name = "Label_Discipline";
            this.Label_Discipline.Size = new System.Drawing.Size(68, 17);
            this.Label_Discipline.TabIndex = 1;
            this.Label_Discipline.Text = "Discipline";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_EditProjectLeader);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.PlComboBox);
            this.groupBox2.Controls.Add(this.Textbox_OrganizationName);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.TextboxReadOnly_ProjectNumber);
            this.groupBox2.Controls.Add(this.ProjectLeader);
            this.groupBox2.Controls.Add(this.Label_OrganizationDescription);
            this.groupBox2.Controls.Add(this.Label_ProjectName);
            this.groupBox2.Controls.Add(this.Label_Organization);
            this.groupBox2.Controls.Add(this.Label_BuildingName);
            this.groupBox2.Controls.Add(this.Label_ProjectNumberReadOnly);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 229);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Information";
            // 
            // Button_EditProjectLeader
            // 
            this.Button_EditProjectLeader.Location = new System.Drawing.Point(444, 164);
            this.Button_EditProjectLeader.Margin = new System.Windows.Forms.Padding(2);
            this.Button_EditProjectLeader.Name = "Button_EditProjectLeader";
            this.Button_EditProjectLeader.Size = new System.Drawing.Size(34, 23);
            this.Button_EditProjectLeader.TabIndex = 5;
            this.Button_EditProjectLeader.Text = "...";
            this.Button_EditProjectLeader.UseVisualStyleBackColor = true;
            this.Button_EditProjectLeader.Click += new System.EventHandler(this.Button_EditProjectLeader_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox7.Location = new System.Drawing.Point(186, 51);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(256, 23);
            this.textBox7.TabIndex = 1;
            // 
            // PlComboBox
            // 
            this.PlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PlComboBox.FormattingEnabled = true;
            this.PlComboBox.Location = new System.Drawing.Point(186, 164);
            this.PlComboBox.Name = "PlComboBox";
            this.PlComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlComboBox.Size = new System.Drawing.Size(256, 24);
            this.PlComboBox.Sorted = true;
            this.PlComboBox.TabIndex = 6;
            this.PlComboBox.DropDown += new System.EventHandler(this.PlComboBox_DropDown);
            this.PlComboBox.SelectedIndexChanged += new System.EventHandler(this.PlComboBox_SelectedIndexChanged);
            // 
            // Textbox_OrganizationName
            // 
            this.Textbox_OrganizationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Textbox_OrganizationName.Location = new System.Drawing.Point(186, 22);
            this.Textbox_OrganizationName.Name = "Textbox_OrganizationName";
            this.Textbox_OrganizationName.Size = new System.Drawing.Size(256, 23);
            this.Textbox_OrganizationName.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(186, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(256, 23);
            this.textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox5.Location = new System.Drawing.Point(186, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(256, 23);
            this.textBox5.TabIndex = 4;
            // 
            // TextboxReadOnly_ProjectNumber
            // 
            this.TextboxReadOnly_ProjectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextboxReadOnly_ProjectNumber.Location = new System.Drawing.Point(186, 106);
            this.TextboxReadOnly_ProjectNumber.Name = "TextboxReadOnly_ProjectNumber";
            this.TextboxReadOnly_ProjectNumber.ReadOnly = true;
            this.TextboxReadOnly_ProjectNumber.Size = new System.Drawing.Size(256, 23);
            this.TextboxReadOnly_ProjectNumber.TabIndex = 3;
            this.TextboxReadOnly_ProjectNumber.TabStop = false;
            // 
            // ProjectLeader
            // 
            this.ProjectLeader.AutoSize = true;
            this.ProjectLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProjectLeader.Location = new System.Drawing.Point(12, 171);
            this.ProjectLeader.Name = "ProjectLeader";
            this.ProjectLeader.Size = new System.Drawing.Size(101, 17);
            this.ProjectLeader.TabIndex = 1;
            this.ProjectLeader.Text = "Project Leader";
            // 
            // Label_OrganizationDescription
            // 
            this.Label_OrganizationDescription.AutoSize = true;
            this.Label_OrganizationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_OrganizationDescription.Location = new System.Drawing.Point(12, 57);
            this.Label_OrganizationDescription.Name = "Label_OrganizationDescription";
            this.Label_OrganizationDescription.Size = new System.Drawing.Size(164, 17);
            this.Label_OrganizationDescription.TabIndex = 1;
            this.Label_OrganizationDescription.Text = "Organization Description";
            // 
            // Label_ProjectName
            // 
            this.Label_ProjectName.AutoSize = true;
            this.Label_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_ProjectName.Location = new System.Drawing.Point(12, 142);
            this.Label_ProjectName.Name = "Label_ProjectName";
            this.Label_ProjectName.Size = new System.Drawing.Size(93, 17);
            this.Label_ProjectName.TabIndex = 1;
            this.Label_ProjectName.Text = "Project Name";
            // 
            // Label_Organization
            // 
            this.Label_Organization.AutoSize = true;
            this.Label_Organization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Organization.Location = new System.Drawing.Point(12, 28);
            this.Label_Organization.Name = "Label_Organization";
            this.Label_Organization.Size = new System.Drawing.Size(130, 17);
            this.Label_Organization.TabIndex = 1;
            this.Label_Organization.Text = "Organization Name";
            // 
            // Label_BuildingName
            // 
            this.Label_BuildingName.AutoSize = true;
            this.Label_BuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_BuildingName.Location = new System.Drawing.Point(12, 86);
            this.Label_BuildingName.Name = "Label_BuildingName";
            this.Label_BuildingName.Size = new System.Drawing.Size(99, 17);
            this.Label_BuildingName.TabIndex = 1;
            this.Label_BuildingName.Text = "Building Name";
            // 
            // Label_ProjectNumberReadOnly
            // 
            this.Label_ProjectNumberReadOnly.AutoSize = true;
            this.Label_ProjectNumberReadOnly.BackColor = System.Drawing.SystemColors.Control;
            this.Label_ProjectNumberReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_ProjectNumberReadOnly.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_ProjectNumberReadOnly.Location = new System.Drawing.Point(12, 113);
            this.Label_ProjectNumberReadOnly.Name = "Label_ProjectNumberReadOnly";
            this.Label_ProjectNumberReadOnly.Size = new System.Drawing.Size(106, 17);
            this.Label_ProjectNumberReadOnly.TabIndex = 1;
            this.Label_ProjectNumberReadOnly.Text = "Project Number";
            // 
            // OK_Button
            // 
            this.OK_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OK_Button.Location = new System.Drawing.Point(533, 21);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 3;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cancel_Button.Location = new System.Drawing.Point(533, 50);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "label9";
            // 
            // ToolTip_ProjectNumberSeperator
            // 
            this.ToolTip_ProjectNumberSeperator.AutomaticDelay = 100;
            this.ToolTip_ProjectNumberSeperator.AutoPopDelay = 1000;
            this.ToolTip_ProjectNumberSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ToolTip_ProjectNumberSeperator.InitialDelay = 150;
            this.ToolTip_ProjectNumberSeperator.IsBalloon = true;
            this.ToolTip_ProjectNumberSeperator.ReshowDelay = 30;
            this.ToolTip_ProjectNumberSeperator.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_ProjectNumberSeperator.ToolTipTitle = "Project Number Seperator";
            // 
            // ProjectInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProjectInformation";
            this.Text = "Project Information";
            this.Load += new System.EventHandler(this.ProjectInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ProjectNumber;
        private System.Windows.Forms.TextBox Textbox_ProjectNumber;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.TextBox Textbox_Description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBox_Discipline;
        private System.Windows.Forms.Label Label_Discipline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox Textbox_OrganizationName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TextboxReadOnly_ProjectNumber;
        private System.Windows.Forms.Label Label_OrganizationDescription;
        private System.Windows.Forms.Label Label_ProjectName;
        private System.Windows.Forms.Label Label_Organization;
        private System.Windows.Forms.Label Label_BuildingName;
        private System.Windows.Forms.Label Label_ProjectNumberReadOnly;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label ProjectLeader;
        private System.Windows.Forms.ComboBox PlComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Label_ProjectNumberSuffix;
        private System.Windows.Forms.TextBox Textbox_ProjectNumberSuffix;
        private System.Windows.Forms.ToolTip ToolTip_ProjectNumberSeperator;
        private System.Windows.Forms.Button Button_EditProjectLeader;
    }
}