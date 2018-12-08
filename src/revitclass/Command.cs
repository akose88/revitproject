#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Opzet;

#endregion

namespace RevitAddin7
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        private Document ActiveDocument { get; set; }

        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            NewProjects newProjects = new NewProjects(); //New Project Dialog
            //ProjectInfo info = ActiveDocument.ProjectInformation; //ProjectInfoClass Revit API
            ProjectInformation information = new ProjectInformation(); // ProjectInformation Dialog

            information.OK += delegate
            {

                var templateFileName = "C:\\Users\\Appie\\Desktop\\TestTemplate.rte";
                var app = commandData?.Application?.Application;
                var activeDoc = app.NewProjectDocument(templateFileName);

                using (TransactionGroup transGroup = new TransactionGroup(activeDoc))
                {
                    transGroup.Start("Transaction Group");
                    using (Transaction firstTrans = new Transaction(activeDoc))
                    {

                        firstTrans.Start("First Transaction");


                        activeDoc.ProjectInformation.Name = "Appie Kose";
                        activeDoc.ProjectInformation.Number = information.TotalProjectNumber;
                        activeDoc.ProjectInformation.BuildingName = "APPIE Tower";
                        activeDoc.ProjectInformation.Author = "Appie";
                        activeDoc.ProjectInformation.IssueDate = "14/08/2018";
                        activeDoc.ProjectInformation.ClientName = "Appie Holding BV";
                        activeDoc.ProjectInformation.Address = "Appie straat 80 te Appiestad";
                        activeDoc.ProjectInformation.Status = "nog niet klaar a hoofd";
                        activeDoc.ProjectInformation.OrganizationName = information.OrganizationName;
                        activeDoc.ProjectInformation.OrganizationDescription = "The best bedrijf doei.";


                        firstTrans.Commit();
                    }
                    transGroup.Assimilate();
                }

                activeDoc.SaveAs(information.FilePath + "\\" + information.FileName);
                commandData.Application.OpenAndActivateDocument(information.FilePath + "\\" + information.FileName);


            };


            newProjects.ProjectInformation = information;
            newProjects.ShowDialog();

            return Result.Succeeded;
          //  UIApplication uiapp = commandData.Application;
            //UIDocument uidoc = uiapp.ActiveUIDocument;
            //var app = commandData?.Application?.Application;
            //var activeDoc = commandData?.Application?.ActiveUIDocument?.Document;
            // const string _template_file_path = @"C:\Users\Appie\Desktop\TestTemplate.rte";

            //if (activeDoc == null)
            //{
            //    var templateFileName = "C:\\Users\\Appie\\Desktop\\TestTemplate.rte";
            //    activeDoc = app.NewProjectDocument(templateFileName);
            //    activeDoc.SaveAs("tmp.rvt");
            //    commandData.Application.OpenAndActivateDocument("tmp.rvt");
            //}

            //using (TransactionGroup transGroup = new TransactionGroup(activeDoc))
            //{
            //    transGroup.Start("Transaction Group");

            //    using (Transaction firstTrans = new Transaction(activeDoc))
            //    {
            //        try
            //        {
            //            firstTrans.Start("First Transaction");

                        

            //            if (activeDoc != null)
            //            {
                          
                            

            //                firstTrans.Commit();
            //            }
            //        }
            //        catch
            //        {
            //            return Result.Failed;
            //        }
            //    }

            //    transGroup.Assimilate();

            //    return Result.Succeeded;
            //}
        }
    }
}
