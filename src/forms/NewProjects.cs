using System;
using System.Windows.Forms;
using System.IO;

namespace forms
{
    public partial class NewProjects : Form
    {
        public ProjectInformation ProjectInformation { get; set; }

        public static string loc;
        public NewProjects()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------
        // Buttons
        //--------------------------------------------------------------------------------------------
        
        private void NewProject_Click(object sender, EventArgs e)
        {
            if (Textbox_BrowseText.Text == "")
            {
                MessageBox.Show("Select a Folder", "Select a Folder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.Hide();
                loc = Textbox_BrowseText.Text;
                ProjectInformation.ShowDialog();
            }
        }
       
        public void BrowseButton_Click(object sender, EventArgs e)
        {
            var Browse = new FolderBrowserDialog
            {
                Description = "Select Folder",
                ShowNewFolderButton = true
            };

            if (Textbox_BrowseText.Text == "") 
            {
                Browse.RootFolder = Environment.SpecialFolder.MyComputer;
            }
            else
            {
                Browse.SelectedPath = Textbox_BrowseText.Text;

            }

            if (Browse.ShowDialog() == DialogResult.OK)
            {
                Textbox_BrowseText.Text = Browse.SelectedPath;
                Listbox_ListboxShowFiles.Items.Clear();
                string[] Files = Directory.GetFiles(Browse.SelectedPath);
                string[] Dirs = Directory.GetDirectories(Browse.SelectedPath);

                foreach (string File in Files)
                {
                    if (Path.GetExtension(File) == ".rvt")
                    {
                        Listbox_ListboxShowFiles.Items.Add(Path.GetFileName(File));
                    }
                }

                foreach (string Dir in Dirs)
                {
                    Listbox_ListboxShowFiles.Items.Add(Path.GetFileName(Dir));
                }
            }
        }

        //***************** Delete File *****************
        public void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            var SelectedFile = Listbox_ListboxShowFiles.SelectedItem;
            var SelectedFilePath = Textbox_BrowseText.Text;

            if (SelectedFile == null) //Checks if a file is selected from the listbox
            {
                MessageBox.Show("No file selected", "Delete File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string message = "Are you sure you want to delete this file?";
                string title = "Delete File";
                DialogResult DeleteFile = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DeleteFile == DialogResult.Yes)
                {
                    File.Delete(SelectedFilePath + "\\"+ SelectedFile); //Deletes the selected file
                    MessageBox.Show("File is deleted", "Delete File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Rebuild the Listbox
                Listbox_ListboxShowFiles.Items.Clear();
                string[] Files = Directory.GetFiles(Textbox_BrowseText.Text);
                string[] Dirs = Directory.GetDirectories(Textbox_BrowseText.Text);

                foreach (string File in Files)
                {
                    if (Path.GetExtension(File) == ".rvt")
                    {
                        Listbox_ListboxShowFiles.Items.Add(Path.GetFileName(File));
                    }
                }

                foreach (string Dir in Dirs)
                {
                    Listbox_ListboxShowFiles.Items.Add(Path.GetFileName(Dir));
                }
            }
        }

        //***************** Close Button *****************
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

