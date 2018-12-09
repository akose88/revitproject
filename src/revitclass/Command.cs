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
                    var category = GetCategory(activeDoc.Settings.Categories, "Project Information");
                    
                    CategorySet cats = app.Create.NewCategorySet();
                   cats.Insert(category);

                    RawCreateProjectParameter(app, information.Projectleider, ParameterType.Text, true,
                        cats, BuiltInParameterGroup.PG_IDENTITY_DATA, true);
                }
             
                activeDoc.SaveAs(file);
                commandData.Application.OpenAndActivateDocument(file);
            };
            newProjects.ProjectInformation = information;
            newProjects.ShowDialog();
            return Result.Succeeded;
        }

        private Category GetCategory(Categories categories, string name)
        {
            foreach (Category category in categories)
            {
                if (category.Name == name) return category;
            }
            return null;
        }
        public void RawCreateProjectParameter(Application app, string name, ParameterType type, bool visible, CategorySet cats, BuiltInParameterGroup group, bool inst)
        {
            string oriFile = app.SharedParametersFilename;
            string tempFile = Path.GetTempFileName() + ".txt";
            using (File.Create(tempFile)) { }
            app.SharedParametersFilename = tempFile;

            cats.Insert()
            var defOptions = new ExternalDefinitionCreationOptions(name, type)
            {
                Visible = visible,
            };
            ExternalDefinition def = app.OpenSharedParameterFile().Groups.Create("TemporaryDefintionGroup").Definitions.Create(defOptions) as ExternalDefinition;

            app.SharedParametersFilename = oriFile;
            File.Delete(tempFile);

            Autodesk.Revit.DB.Binding binding = app.Create.NewTypeBinding(cats);
            if (inst) binding = app.Create.NewInstanceBinding(cats);

            BindingMap map = ActiveDocument.ParameterBindings;
            if (!map.Insert(def, binding, group))
            {
                Trace.WriteLine($"Failed to create Project parameter '{name}' :(");
            }
        }

        public static void RawCreateProjectParameter1(Application app, string name, ParameterType type, bool visible, CategorySet cats, BuiltInParameterGroup group, bool inst)
        {
            //InternalDefinition def = new InternalDefinition();
            //Definition def = new Definition();

            string oriFile = app.SharedParametersFilename;
            string tempFile = Path.GetTempFileName() + ".txt";
            using (File.Create(tempFile)) { }
            app.SharedParametersFilename = tempFile;
           // ExternalDefinition def = app.OpenSharedParameterFile().Groups.Create("TemporaryDefintionGroup").Definitions.Create(defOptions) as ExternalDefinition;

          ExternalDefinition def = app.OpenSharedParameterFile().Groups.Create("TemporaryDefintionGroup").Definitions.Create(name, type, visible) as ExternalDefinition;

            app.SharedParametersFilename = oriFile;
            File.Delete(tempFile);

            Autodesk.Revit.DB.Binding binding = app.Create.NewTypeBinding(cats);
            if (inst) binding = app.Create.NewInstanceBinding(cats);

            BindingMap map = (new UIApplication(app)).ActiveUIDocument.Document.ParameterBindings;
            map.Insert(def, binding, group);
        }




    }
}
