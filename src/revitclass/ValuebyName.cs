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
    public class ValuebyName : IExternalCommand
    {

        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            var app = commandData?.Application?.Application;

            ProjectInfo projectInfo = doc.ProjectInformation;
            string errMsg = "";

            List<string> paramList = new List<string>();
            string[] b = new string[3];
            b[0] = "Name";
            b[1] = "Number";
            b[2] = "Status";
            paramList.AddRange(b);

            List<string> valueList = new List<string>();
            string[] c = new string[3];
            c[0] = "Value1";
            c[1] = "Value2";
            c[2] = "Value2";
            valueList.AddRange(c);

            try
            {
                // find our specific shared parameter by Name
                for (int i = 0; i <= paramList.Count - 1; i++)
                {
                    using (Transaction t = new Transaction(doc))
                    {
                        if (t.Start("Set Project Parameter Values") == TransactionStatus.Started)
                        {
                            doc.ProjectInformation.LookupParameter(paramList[i]).Set(valueList[i]);

                            t.Commit();
                        }
                        else
                        {
                            t.RollBack();
                        }
                    }
                }
            }

            // we want to catch it so we can see the problem, otherwise it just silently bails out
            catch (System.Exception e)
            {
                TaskDialog.Show("Errors", e.Message + Environment.NewLine + errMsg);
                throw e;
            }

            return Result.Succeeded;

        }


    }
}




           

           

            
