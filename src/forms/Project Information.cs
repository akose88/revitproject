using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using forms.Providers;

namespace forms
{
    public partial class ProjectInformation : Form 
    {
       //XML file
        public string file = @"C:\Users\Appie\Desktop\projectleiders.xml";
        public static string Xmlfile;

        XmlDocument xdoc = new XmlDocument();

        public ProjectInformation()
        {
            InitializeComponent();
            ProviderMethod.LoadEnabled(TextboxReadOnly_ProjectNumber, false);
            ProviderMethod.LoadEnabled(Label_ProjectNumberReadOnly, false);
            this.ComboBox_Discipline.SelectedIndexChanged += new EventHandler(this.CbItemChanged);
        }

        public string TotalProjectNumber => TextboxReadOnly_ProjectNumber.Text;
        public string OrganizationName => Textbox_OrganizationName.Text;
        public string ProjectName => textbox_projectname.Text;
        public string OrganizationDesc => textbox_orgdesc.Text;
        public string TotalDescription => Textbox_Description.Text;
        public string BuildingName => textbox_buildingname.Text;
        public string FileName => $"{TotalProjectNumber}_{Textbox_Description.Text}_{Discipline}.rvt";
        public string FilePath => NewProjects.loc;
        public string Discipline;
        public string ClientName => textbox_clientname.Text;
        public string Project_adress => textbox_ProjectAdress.Text;
        public string Projectleider => PlComboBox.Text;

        //Set ProjectLeader Combobox
        public void ProjectInformation_Load(object sender, EventArgs e)
        {
            xdoc.Load(@file); // Load XML
            ProviderMethod.SetCbTypes(ComboBox_Discipline);
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
                var message = "Please enter a valid value of characters (A - Z)";
                var title = "Information";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void PlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           xdoc.Load(@file);

            foreach (XmlNode node in xdoc.DocumentElement)
            {
                string name = (node.ChildNodes[0].InnerText);
                string afk = (node.ChildNodes[1].InnerText);

                Dictionary<string, string> afkorting = new Dictionary<string, string>{{ name, afk }};

                if (PlComboBox.Text == name){label9.Text = afk;}
            }            
        }

        //************ Keypress ************
        private void Textbox_ProjectNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ProjectNumber = e.KeyChar;
            if (!Char.IsDigit(ProjectNumber) && ProjectNumber != 8 && ProjectNumber != 13)
            {
                e.Handled = true;
                var message = "Please enter a valid value of numbers (0-9)";
                var title = "Information";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ProviderMethod.Comboboxupdater(xdoc, PlComboBox);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FileName);
        }

        public event OkPressed OK;
        public delegate void OkPressed();

        private void OK_Button_Click(object sender, EventArgs e)
        {
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
                TextboxReadOnly_ProjectNumber.Text = $"{Textbox_ProjectNumber.Text}-{Textbox_ProjectNumberSuffix.Text}";
            }
        }

        void CbItemChanged(object sender, EventArgs e)
        {
            ProviderMethod.CbDicipline(ComboBox_Discipline, "Architecture", "ARC");
            ProviderMethod.CbDicipline(ComboBox_Discipline, "Structure", "STR");
            ProviderMethod.CbDicipline(ComboBox_Discipline, "Construction", "CON");
            ProviderMethod.CbDicipline(ComboBox_Discipline, "Coordination", "COO");
        }
    }
}