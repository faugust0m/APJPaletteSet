using Autodesk.Aec.DatabaseServices;
using Autodesk.Aec.Project;
using Autodesk.AutoCAD.DatabaseServices;
using System;
using System.Windows.Forms;

namespace APJPaletteSet
{
    public class MyProject
    {
        public static string CurrentProject()
        {
            ProjectBaseManager projectManager = ProjectBaseServices.Service.ProjectManager;
            string activeProj = projectManager.CurrentProjectFileName.Name.ToString();

            return activeProj;
        }
        public static Project GetProject()
        {
            ProjectBaseManager projectManager = ProjectBaseServices.Service.ProjectManager;
            Project activeProj = projectManager.OpenProject(OpenMode.ForRead, projectManager.CurrentProjectFileName.Path);
            
            return activeProj;
        }        
        public static string GetDetailValue(int _prop, int _pair)
        {
            try
            {
                Project activeProj = GetProject();
                ProjectStringProperty stringProp = (ProjectStringProperty)activeProj.Configuration.StringProperties[_prop];
                StringPair strPair = (StringPair)stringProp.StringPairs[_pair];

                return strPair.Right;
            }
            catch (ArgumentOutOfRangeException)
            {
                return "";
            }
        }
        public static string GetDetailValue(Control textbox)
        {
            try
            {
                //Recebe o controle e determina propriedade e par pelo seu nome;
                string _textboxname = textbox.Name.ToString();
            string [] _textsplit = _textboxname.Split('_');
            int _prop = int.Parse(_textsplit[1]);
            int _pair = int.Parse(_textsplit[2]);

            Project activeProj = GetProject();
            ProjectStringProperty stringProp = (ProjectStringProperty)activeProj.Configuration.StringProperties[_prop];
            StringPair strPair = (StringPair)stringProp.StringPairs[_pair];

            return strPair.Right;
            }
            catch (ArgumentOutOfRangeException)
            {
                return "";
            }
        }
        public static void SetDetailValue(int _prop, int _pair, string _right)
        {
            try
            {
                ProjectBaseManager projectManager = ProjectBaseServices.Service.ProjectManager;
                Project activeProj = projectManager.OpenProject(OpenMode.ForRead, projectManager.CurrentProjectFileName.Path);

                projectManager.UpgradeOpen(activeProj);

                ProjectStringProperty stringProp = (ProjectStringProperty)activeProj.Configuration.StringProperties[_prop];
                StringPair strPair = (StringPair)stringProp.StringPairs[_pair];

                string _left = strPair.Left;

                StringPair newPair = new StringPair(_left, _right);

                stringProp.StringPairs.RemoveAt(_pair);
                stringProp.StringPairs.Insert(_pair, newPair);

                if (activeProj.IsUpdateProjectFileNeeded)
            {
                    ProjectFile prjFile = new ProjectFile(activeProj);
                    prjFile.DrawingFullPath = ProjectBaseServices.Service.ProjectManager.CurrentProjectFileName.Path;
                    bool b = activeProj.UpdateFile(prjFile);
                    activeProj.UpdateProjectInformationInDwg(prjFile);
                }
                bool isGoodSave = projectManager.SaveProject(activeProj);
                projectManager.DowngradeOpen(activeProj);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Esse projeto não foi criado com o template do\n" +
                    "Pacote de Personalização AutoCAD Architecture.\n" +
                    "\n" +
                    "Crie um novo projeto a partir de um template do pacote.",
                    "Pacote de Personalização AutoCAD Architecture");
            }
        }
    }
}