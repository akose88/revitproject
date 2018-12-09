using System.Windows.Forms;
using System.Xml;


namespace forms.Providers
{
    public static class ProviderMethod
    {
       
        public static void Comboboxupdater(XmlDocument xdoc, ComboBox comboBox)
        {
            foreach (XmlNode node in xdoc.DocumentElement)
            {
                string name = (node.ChildNodes[0].InnerText);
                comboBox.Items.Add(name);
            }
        }

        public static void CbDicipline(ComboBox comboBox,string text, string discipline)
        {
            if (comboBox.Text == text)
            {
               var Discipline = discipline;
            }
        }


        public static void LoadEnabled(TextBox textbox,bool status)
        {
            textbox.Enabled = status;
        }

        public static void LoadEnabled(Label label, bool status)
        {
            label.Enabled = status;
        }

        public static void SetCbTypes(ComboBox combobox)
        {
            combobox.DataSource = new[]{
            "Architecture",
            "Structure",
            "Construction",
            "Coordination"
        };

        }
    }
}
