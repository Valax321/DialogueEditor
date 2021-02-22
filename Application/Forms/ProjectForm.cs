using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NLog;
using Valax321.DialogueEditor.Models;
using Valax321.DialogueEditor.Properties;

namespace Valax321.DialogueEditor.Forms
{
    public partial class ProjectForm : Form
    {
        private const string HelpUrl = "https://github.com/Valax321/DialogueEditor/wiki";

        private static Logger Logger = LogManager.GetCurrentClassLogger();

        private ProjectModel Model { get; }

        public ProjectForm()
        {
            InitializeComponent();
            Logger.Info("Created project form");
            Model = new ProjectModel(this);

            var imageList = new ImageList
            {
                ColorDepth = ColorDepth.Depth32Bit, 
                ImageSize = new Size(32, 32)
            };

            imageList.Images.AddRange(Resources.DialogueIcon, Resources.Variables, Resources.SettingsIcon);

            tabControlProjectSettings.ImageList = imageList;
            tabDialogue.ImageIndex = 0;
            tabVariables.ImageIndex = 1;
            tabProjectSettings.ImageIndex = 2;
        }

        private void LoadFormSettings()
        {
            Logger.Info("Loading Project Form settings");
            if (!Settings.Default.ProjectWindowSize.IsEmpty)
                Size = Settings.Default.ProjectWindowSize;
            if (!Settings.Default.ProjectWindowPos.IsNegative())
                Location = Settings.Default.ProjectWindowPos;
            WindowState = Settings.Default.ProjectWindowMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void SaveFormSettings()
        {
            Logger.Info("Saving Project Form settings");
            Settings.Default.ProjectWindowPos = Location;
            Settings.Default.ProjectWindowSize = Size;
            Settings.Default.ProjectWindowMaximized = WindowState == FormWindowState.Maximized;
            Settings.Default.Save();
        }

        #region Menu Events

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            if (!Model.PromptSave())
                return;

            Model.NewProject();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (!Model.PromptSave())
                return;

            var result = openProjectFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                Model.OpenProject(openProjectFileDialog.FileName);
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (Model.ProjectDirty)
                Model.Save();
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBoxForm();
            about.ShowDialog(this);
        }

        private void openDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(HelpUrl);
        }

        #endregion

        #region Window Events

        private void maximizeMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized);
        }

        private void minimizeMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ProjectForm_Resize(object sender, EventArgs e)
        {
            maximizeMenuItem.Checked = WindowState == FormWindowState.Maximized;
        }

        private void ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Model.PromptSave())
            {
                e.Cancel = true;
                return;
            }

            SaveFormSettings();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            LoadFormSettings();
        }

        #endregion
    }
}
