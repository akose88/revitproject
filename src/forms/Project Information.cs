using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace Opzet
{
   
    public partial class ProjectInformation : Form 
    {
        //---------------------------------------------------------------------------
        //Top
        //---------------------------------------------------------------------------

       //XML file
        public string file = @"C:\Users\Appie\Desktop\projectleiders.xml";
        public static string Xmlfile;

        XmlDocument xdoc = new XmlDocument();

        public ProjectInformation()
        {
            InitializeComponent();
            LoadEnabled();
            this.ComboBox_Discipline.SelectedIndexChanged += new System.EventHandler(this.cbItemChanged);
            
        }

        public string TotalProjectNumber => TextboxReadOnly_ProjectNumber.Text;
        public string OrganizationName => Textbox_OrganizationName.Text;
        public string TotalDescription => Textbox_Description.Text;
        public string FileName => TotalProjectNumber + "_" + Textbox_Description.Text + "_" + Discipline + ".rvt";
        public string FilePath => NewProjects.loc;

        public string Discipline;


        //Set ProjectLeader Combobox
        public void ProjectInformation_Load(object sender, EventArgs e)
        {
            xdoc.Load(@file); // Load XML
            ComboBox_Discipline.Items.Add("Architecture");
            ComboBox_Discipline.Items.Add("Structure");
            ComboBox_Discipline.Items.Add("Construction");
        }

        //************ Textbox Changed ************ 

        private void Textbox_ProjectNumber_TextChanged(object sender, EventArgs e)
        {
            TextboxReadOnly_ProjectNumber.Text = Textbox_ProjectNumber.Text;
        }

        private void Textbox_ProjectNumberSuffix_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ProjectNumberSuffixSep = e.KeyChar;
            if (!Char.IsLetter(ProjectNumberSuffixSep) && ProjectNumberSuffixSep != 8 && ProjectNumberSuffixSep != 13)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value of characters (A - Z)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           xdoc.Load(@file);

            foreach (XmlNode node in xdoc.DocumentElement)
            {
                string name = (node.ChildNodes[0].InnerText);
                string afk = (node.ChildNodes[1].InnerText);

                Dictionary<string, string> afkorting = new Dictionary<string, string>
                {
                    { name, afk }
                };

                if (PlComboBox.Text == name)
                {
                    label9.Text = afk;
                }
            }            
        }


        //************ Keypress ************
        private void Textbox_ProjectNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ProjectNumber = e.KeyChar;
            if (!Char.IsDigit(ProjectNumber) && ProjectNumber != 8 && ProjectNumber != 13)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value of numbers (0-9)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_EditProjectLeader_Click(object sender, EventArgs e)
        {
            Xmlfile = file;
            EditProjectLeader editProjectLeaders = new EditProjectLeader();
            editProjectLeaders.FormClosed += delegate
            {
                xdoc.Load(@file);
            };
            editProjectLeaders.ShowDialog();
        }

        private void PlComboBox_DropDown(object sender, EventArgs e)
        {
            PlComboBox.Items.Clear();
            Comboboxupdater();

        }
 
        void Comboboxupdater()
        {
            foreach (XmlNode node in xdoc.DocumentElement)
            {
                string name = (node.ChildNodes[0].InnerText);
                PlComboBox.Items.Add(name);
            }
        }
        void LoadEnabled()
        {
            //************ Standard load settings ************

            //TextBoxes
            TextboxReadOnly_ProjectNumber.Enabled = false;

            //Labels
            Label_ProjectNumberReadOnly.Enabled = false;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            // this.Close();

            //cbUpdater();
            MessageBox.Show(FileName);
        }

        public event OkPressed OK;

       // public event OkPressed1 OkEvent;
        public delegate void OkPressed();
       // public delegate void OkPressed1();

        private void OK_Button_Click(object sender, EventArgs e)
        {
           // OkEvent();
            OK();
            MessageBox.Show("Document is gecreeërd");
            this.Close();
        }

        private void Textbox_ProjectNumberSuffix_TextChanged(object sender, EventArgs e)
        {
            TextboxReadOnly_ProjectNumber.Clear();
            if (Textbox_ProjectNumberSuffix.Text == "")
            {
                TextboxReadOnly_ProjectNumber.Text = Textbox_ProjectNumber.Text;
            }
            else
            {
                TextboxReadOnly_ProjectNumber.Text = Textbox_ProjectNumber.Text + "-" + Textbox_ProjectNumberSuffix.Text;
            }
        }

        private void ComboBox_Discipline_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }
        void cbItemChanged(object sender, EventArgs e)
        {
            if (ComboBox_Discipline.Text == "Architecture")
            {
                Discipline = "ARC";
            }
            if (ComboBox_Discipline.Text == "Structure")
            {
                Discipline = "STR";
            }
        }
    }
}