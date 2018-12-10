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
using RevitAddin7.TransactionManager;
using System.Linq;
using System.IO;
using BuildingCoder;
using System.Linq;
using System.Text;

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
                ActiveDocument = activeDoc;
                var date = DateTime.Now.ToString("dd/MM/yyyy");

                using (new TransactionManager.TransactionManager(activeDoc))
                {
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
                    // activeDoc.GetElement("").GetParameters("")[0].SetValueString("");
                    if (activeDoc == null)
                    {
                        throw new ArgumentNullException("doc");
                    }

                    if (activeDoc.IsFamilyDocument)
                    {
                        throw new Exception("doc can not be a family document.");
                    }

                    List<ProjectParameterData> result = new List<ProjectParameterData>();

                    BindingMap map = activeDoc.ParameterBindings;
                    DefinitionBindingMapIterator it
                      = map.ForwardIterator();
                    it.Reset();
                    while (it.MoveNext())
                    {
                        ProjectParameterData newProjectParameterData = new ProjectParameterData();

                        newProjectParameterData.Definition = it.Key;
                        newProjectParameterData.Name = it.Key.Name;
                        newProjectParameterData.Binding = it.Current
                          as ElementBinding;

                        result.Add(newProjectParameterData);
                        
                    }
                }
             
                activeDoc.SaveAs(file);
                commandData.Application.OpenAndActivateDocument(file);
            };
            newProjects.ProjectInformation = information;
            newProjects.ShowDialog();
            return Result.Succeeded;
        }
        class ProjectParameterData
        {
            public Definition Definition = null;
            public ElementBinding Binding = null;
            public string Name = null;                // Needed because accsessing the Definition later may produce an error.
            public bool IsSharedStatusKnown = false;  // Will probably always be true when the data is gathered
            public bool IsShared = false;
            public string GUID = null;
        }
        
    }
}
