
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace Opzet
{
    public partial class EditProjectLeader : Form
    {
        public EditProjectLeader()
        {
            InitializeComponent();
        }

        private void EditProjectLeader_Load(object sender, EventArgs e)
        {
            DataSet PL = new DataSet();
            //Read and copy to Gridview
            PL.ReadXml(ProjectInformation.Xmlfile);
            DataGridView_ProjectLeaders.DataSource = PL;
            DataGridView_ProjectLeaders.DataMember = "Projectleider";

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@ProjectInformation.Xmlfile);
            //Xml node
            XmlNodeList nodelist = xdoc.SelectNodes("Projectleiders/Projectleider");
        }

        private void Button_AddProjectLeader_Click(object sender, EventArgs e)
        {
            DataSet PL = new DataSet
            {
                DataSetName = "Projectleiders" //DataSet Name
            };
            DataTable Projectleider = new DataTable
            {
                TableName = "Projectleider" //Table Name
            };

            // add Column
            foreach (DataGridViewColumn column in DataGridView_ProjectLeaders.Columns)
            {
                Projectleider.Columns.Add(column.DataPropertyName, column.ValueType);
            }
            // add Rows
            foreach (DataGridViewRow row in DataGridView_ProjectLeaders.Rows)
            {
                DataRow row1 = Projectleider.NewRow();
                for (int i = 0; i < DataGridView_ProjectLeaders.ColumnCount; i++)
                row1[i] = row.Cells[i].Value ?? DBNull.Value;

                if (NotEmpty(row1))
                    Projectleider.Rows.Add(row1);
            }

            //Copy from datatable to dataset
            PL.Tables.Add(Projectleider);
            PL.WriteXml(ProjectInformation.Xmlfile);

            this.Close();
        }

        private bool NotEmpty(DataRow row1)
        {
            return row1.ItemArray[0] is string && row1.ItemArray[1] is string;
        }
    }
}

