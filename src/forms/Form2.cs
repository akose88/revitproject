using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Opzet
{
   
    public partial class ProjectInformation : Form
    {
        //---------------------------------------------------------------------------
        //Top
        //---------------------------------------------------------------------------

       //XML file
        public string file = @"C:\\Users\\Pascal2\\Desktop\\projectleiders.xml";
        XmlDocument xdoc = new XmlDocument();
        
        public ProjectInformation()
        {
            InitializeComponent();
        }

        //Set ProjectLeader Combobox
        public void ProjectInformation_Load(object sender, EventArgs e)
        {
           xdoc.Load(@file);
                    

              foreach (XmlNode node in xdoc.DocumentElement)
              {
                  string name = (node.ChildNodes[0].InnerText);
                  PlComboBox.Items.Add(name);
              }
        }

       
        //Set Label9
        public void PlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           xdoc.Load(@file);

            foreach (XmlNode node in xdoc.DocumentElement)
            {
                string name = (node.ChildNodes[0].InnerText);
                string afk = (node.ChildNodes[1].InnerText);

                
                Dictionary<string, string> afkorting = new Dictionary<string, string>();
                afkorting.Add(name, afk);

                if (PlComboBox.Text == name)
                {
                    label9.Text = afk;
                }
               
            }            
        }
    }
}

