#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using forms;

#endregion

namespace RevitAddin7
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        private Document ActiveDocument { get; set; }
        //private ParameterElement projectleider { get; set; }

        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            NewProjects newProjects = new NewProjects(); 
            ProjectInformation information = new ProjectInformation(); // ProjectInformation Dialog

            information.OK += delegate
            {
                var templateFileName = @"C:\Users\Appie\Desktop\TestTemplate.rte";
                var file = $"{information.FilePath}\\{information.FileName}";
                var app = commandData?.Application?.Application;
                var activeDoc = app.NewProjectDocument(templateFileName);
                var date = DateTime.Now.ToString("dd/MM/yyyy");

                using (TransactionGroup transGroup = new TransactionGroup(activeDoc))
                {
                    transGroup.Start("Transaction Group");
                    using (Transaction firstTrans = new Transaction(activeDoc))
                    {
                        firstTrans.Start("First Transaction");

                        activeDoc.ProjectInformation.Name = information.ProjectName;
                        activeDoc.ProjectInformation.Number = information.TotalProjectNumber;
                        activeDoc.ProjectInformation.BuildingName = information.BuildingName;
                        activeDoc.ProjectInformation.Author = Environment.UserName;
                        activeDoc.ProjectInformation.IssueDate = date;
                        activeDoc.ProjectInformation.ClientName = information.ClientName;
                        activeDoc.ProjectInformation.Address = information.Project_adress;
                        activeDoc.ProjectInformation.Status = "Concept";
                        activeDoc.ProjectInformation.OrganizationName = information.OrganizationName;
                        activeDoc.ProjectInformation.OrganizationDescription = information.OrganizationDesc;

                        firstTrans.Commit();
                    }
                    transGroup.Assimilate();
                }
                activeDoc.SaveAs(file);
                commandData.Application.OpenAndActivateDocument(file);
            };

            newProjects.ProjectInformation = information;
            newProjects.ShowDialog();

            return Result.Succeeded;
         
        }
    }
}
