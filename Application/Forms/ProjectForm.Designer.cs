
namespace Valax321.DialogueEditor.Forms
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlProjectSettings = new System.Windows.Forms.TabControl();
            this.tabDialogue = new System.Windows.Forms.TabPage();
            this.tabVariables = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.variableListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variablePropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.variableSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabProjectSettings = new System.Windows.Forms.TabPage();
            this.openProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveProjectFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.windowListSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuStrip.SuspendLayout();
            this.tabControlProjectSettings.SuspendLayout();
            this.tabVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.toolStripSeparator1,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator2,
            this.quitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            resources.ApplyResources(this.newMenuItem, "newMenuItem");
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            resources.ApplyResources(this.openMenuItem, "openMenuItem");
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            resources.ApplyResources(this.saveMenuItem, "saveMenuItem");
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            resources.ApplyResources(this.saveAsMenuItem, "saveAsMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            resources.ApplyResources(this.quitMenuItem, "quitMenuItem");
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximizeMenuItem,
            this.minimizeMenuItem,
            this.windowListSeparator});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            resources.ApplyResources(this.windowToolStripMenuItem, "windowToolStripMenuItem");
            // 
            // maximizeMenuItem
            // 
            this.maximizeMenuItem.Name = "maximizeMenuItem";
            resources.ApplyResources(this.maximizeMenuItem, "maximizeMenuItem");
            this.maximizeMenuItem.Click += new System.EventHandler(this.maximizeMenuItem_Click);
            // 
            // minimizeMenuItem
            // 
            this.minimizeMenuItem.Name = "minimizeMenuItem";
            resources.ApplyResources(this.minimizeMenuItem, "minimizeMenuItem");
            this.minimizeMenuItem.Click += new System.EventHandler(this.minimizeMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDocumentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // openDocumentationToolStripMenuItem
            // 
            this.openDocumentationToolStripMenuItem.Name = "openDocumentationToolStripMenuItem";
            resources.ApplyResources(this.openDocumentationToolStripMenuItem, "openDocumentationToolStripMenuItem");
            this.openDocumentationToolStripMenuItem.Click += new System.EventHandler(this.openDocumentationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControlProjectSettings
            // 
            this.tabControlProjectSettings.Controls.Add(this.tabDialogue);
            this.tabControlProjectSettings.Controls.Add(this.tabVariables);
            this.tabControlProjectSettings.Controls.Add(this.tabProjectSettings);
            resources.ApplyResources(this.tabControlProjectSettings, "tabControlProjectSettings");
            this.tabControlProjectSettings.Name = "tabControlProjectSettings";
            this.tabControlProjectSettings.SelectedIndex = 0;
            // 
            // tabDialogue
            // 
            resources.ApplyResources(this.tabDialogue, "tabDialogue");
            this.tabDialogue.Name = "tabDialogue";
            this.tabDialogue.UseVisualStyleBackColor = true;
            // 
            // tabVariables
            // 
            this.tabVariables.Controls.Add(this.splitContainer1);
            this.tabVariables.Controls.Add(this.toolStrip1);
            resources.ApplyResources(this.tabVariables, "tabVariables");
            this.tabVariables.Name = "tabVariables";
            this.tabVariables.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.variableListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.variablePropertyGrid);
            // 
            // variableListView
            // 
            this.variableListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.variableListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn});
            resources.ApplyResources(this.variableListView, "variableListView");
            this.variableListView.HideSelection = false;
            this.variableListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("variableListView.Items")))});
            this.variableListView.MultiSelect = false;
            this.variableListView.Name = "variableListView";
            this.variableListView.ShowItemToolTips = true;
            this.variableListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.variableListView.UseCompatibleStateImageBehavior = false;
            this.variableListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            resources.ApplyResources(this.NameColumn, "NameColumn");
            // 
            // variablePropertyGrid
            // 
            resources.ApplyResources(this.variablePropertyGrid, "variablePropertyGrid");
            this.variablePropertyGrid.Name = "variablePropertyGrid";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.variableSearchTextBox,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // variableSearchTextBox
            // 
            this.variableSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.variableSearchTextBox, "variableSearchTextBox");
            this.variableSearchTextBox.Name = "variableSearchTextBox";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Valax321.DialogueEditor.Properties.Resources.AddIcon;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Valax321.DialogueEditor.Properties.Resources.AddFolder;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Valax321.DialogueEditor.Properties.Resources.Remove;
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // tabProjectSettings
            // 
            resources.ApplyResources(this.tabProjectSettings, "tabProjectSettings");
            this.tabProjectSettings.Name = "tabProjectSettings";
            this.tabProjectSettings.UseVisualStyleBackColor = true;
            // 
            // openProjectFileDialog
            // 
            this.openProjectFileDialog.FileName = "project";
            resources.ApplyResources(this.openProjectFileDialog, "openProjectFileDialog");
            // 
            // saveProjectFileDialog
            // 
            resources.ApplyResources(this.saveProjectFileDialog, "saveProjectFileDialog");
            // 
            // windowListSeparator
            // 
            this.windowListSeparator.Name = "windowListSeparator";
            resources.ApplyResources(this.windowListSeparator, "windowListSeparator");
            // 
            // ProjectForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlProjectSettings);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "ProjectForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectForm_FormClosing);
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.Resize += new System.EventHandler(this.ProjectForm_Resize);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tabControlProjectSettings.ResumeLayout(false);
            this.tabVariables.ResumeLayout(false);
            this.tabVariables.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.TabControl tabControlProjectSettings;
        private System.Windows.Forms.TabPage tabDialogue;
        private System.Windows.Forms.TabPage tabVariables;
        private System.Windows.Forms.TabPage tabProjectSettings;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeMenuItem;
        private System.Windows.Forms.OpenFileDialog openProjectFileDialog;
        public System.Windows.Forms.SaveFileDialog saveProjectFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView variableListView;
        private System.Windows.Forms.PropertyGrid variablePropertyGrid;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox variableSearchTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator windowListSeparator;
    }
}