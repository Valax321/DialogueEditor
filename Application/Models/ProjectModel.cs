using System.Linq;
using System.Windows.Forms;
using Valax321.DialogueEditor.Forms;
using Valax321.DialogueEditor.Project;
using Valax321.DialogueEditor.Properties;

namespace Valax321.DialogueEditor.Models
{
    public class ProjectModel : IFormModel
    {
        private DialogueProject _project;
        private readonly ProjectForm _form;

        public ProjectModel(ProjectForm form)
        {
            _form = form;
            NewProject();
        }

        public bool ProjectDirty => _project.IsDirty;

        private void SyncForm()
        {
            var path = _project.Path;
            if (path.IsNullOrEmpty())
                path = Strings.UntitledProjectName;
            if (ProjectDirty)
                path += "*";
            _form.Text = string.Format(Strings.ProjectFormWindowTitle, path);
        }

        public void NewProject()
        {
            _project = new DialogueProject();
            SyncForm();
        }

        public bool OpenProject(string path)
        {
            var project = DialogueProject.FromJson(path);
            if (project is null)
                return false;

            _project = project;
            _project.Path = path;

            SyncForm();

            return true;
        }

        public void Save()
        {
            if (_project.Path.IsNullOrEmpty())
            {
                var result = _form.saveProjectFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _project.Path = _form.saveProjectFileDialog.FileName;
                    _project.MarkDirty();
                }
            }

            if (ProjectDirty)
            {
                _project.SaveToFile(_project.Path);
                SyncForm();
            }
        }

        public bool PromptSave()
        {
            if (ProjectDirty)
            {
                var result = MessageBox.Show(Strings.ProjectPromptSaveMessage, Strings.ProjectPromptSaveCaption,
                    MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        Save();
                        return true;
                    case DialogResult.No:
                        return true;
                    case DialogResult.Cancel:
                        return false;
                }
            }

            return true;
        }
    }
}