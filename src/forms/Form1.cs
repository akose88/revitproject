using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Opzet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Drives_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        //--------------------------------------------------------------------------------------------
        // Buttons
        //--------------------------------------------------------------------------------------------
        private void NewProject_Click(object sender, EventArgs e)
        {
            if (BrowseText.Text == "")
            {
                MessageBox.Show("Select a Folder", "WARNING");
            }
            else
            {
                ProjectInformation NewProject = new ProjectInformation();
                NewProject.Show();
                this.Hide();
            }
        }

        public void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Browse = new FolderBrowserDialog();
            Browse.RootFolder = Environment.SpecialFolder.MyComputer;
            Browse.Description = "Select Folder";
            Browse.ShowNewFolderButton = true;

            
            if (Browse.ShowDialog() == DialogResult.OK)
            {
                BrowseText.Text = Browse.SelectedPath;
                ListboxShowFiles.Items.Clear();
                string[] Files = Directory.GetFiles(Browse.SelectedPath);
                string[] Dirs = Directory.GetDirectories(Browse.SelectedPath);
                

                foreach (string File in Files)
                {

                    if (File.Contains("rvt"))
                    {
                        ListboxShowFiles.Items.Add(Path.GetFileName(File));
                    }

                }

                foreach (string Dir in Dirs)
                {
                    ListboxShowFiles.Items.Add(Path.GetFileName(Dir));
                }
            }
        }

        public void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            var SelectedFile = BrowseText.Text+ "\\" + ListboxShowFiles.SelectedItem.ToString();
                        
            File.Delete(SelectedFile);
            MessageBox.Show("File is deleted");
            ListboxShowFiles.Items.Clear();
            string[] Files = Directory.GetFiles(BrowseText.Text);
            string[] Dirs = Directory.GetDirectories(BrowseText.Text);

            foreach (string File in Files)
            {

                if (File.Contains("rvt"))
                {
                    ListboxShowFiles.Items.Add(Path.GetFileName(File));
                }

            }

            foreach (string Dir in Dirs)
            {
                ListboxShowFiles.Items.Add(Path.GetFileName(Dir));
            }
        }
    }
}
