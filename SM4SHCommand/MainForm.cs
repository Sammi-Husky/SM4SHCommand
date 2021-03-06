﻿using Sm4shCommand.GUI;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using WeifenLuo.WinFormsUI.Docking;
using Sm4shCommand.GUI.Editors;
using System.Reflection;

namespace Sm4shCommand
{
    public partial class MainForm : Form
    {
        public static MainForm Instance
        {
            get { return _instance ?? new MainForm(); }
        }
        private static MainForm _instance;
        RecentFileHandler RecentFileHandler;
        internal string OpenTarget { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.Text = $"{Program.AssemblyTitle} {Program.Version} BETA - ";

            // prevents crashing if we dont have any components on mainform
            if (this.components == null)
                this.components = new Container();

            _instance = this;

            RecentFileHandler = new RecentFileHandler(this.components)
            {
                RecentFileToolStripItem = this.recentFilesStripMenuItem
            };
            recentFilesStripMenuItem.DropDownItemClicked += RecentFilesStripMenuItem_DropDownItemClicked;
        }

        public const string FileFilter =
                              "All Supported Files (*.acm, *.fitproj, *.wrkspc)|*.bin;*.fitproj;*.wrkspc|" +
                              "ACMD Script (*.acm)|*.acm|" +
                              "Fighter Project (*.fitproj)|*.fitproj|" +
                              "Project Workspace (*.wrkspc)|*.wrkspc|" +
                              "All Files (*.*)|*.*";

        private OpenFileDialog ofDlg = new OpenFileDialog() { Filter = FileFilter };
        private SaveFileDialog sfDlg = new SaveFileDialog() { Filter = FileFilter };
        private FolderSelectDialog fsDlg = new FolderSelectDialog();

        internal WorkspaceExplorer Explorer { get; set; }
        internal WorkspaceManager WorkspaceManager { get; set; }

        /// <summary>
        /// Opens a file for reading by the application
        /// </summary>
        /// <param name="filename">Path to the file.</param>
        /// <returns>Returns true if successful</returns>
        internal bool OpenFile(string filename)
        {
            try
            {
                switch (filename.Substring(filename.IndexOf('.')))
                {
                    case ".wrkspc":
                        WorkspaceManager.OpenWorkspace(filename);
                        break;
                    case ".fitproj":
                        WorkspaceManager.OpenProject(filename);
                        break;
                }
                RecentFileHandler.AddFile(ofDlg.FileName);
                return true;
            }
            catch (Exception x)
            {
                Util.LogMessage($"Error opening file {filename}: {x.Message}", ConsoleColor.Red);
            }
            return false;
        }
        internal void AddDockedControl(DockContent content, DockState dock)
        {
            content.ShowHint = dock;
            if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
            {
                content.MdiParent = this;
                content.Show();
            }
            else
                content.Show(dockPanel1);
        }
        internal void AddDockedControl(DockContent control, DockPane parent, DockAlignment alignment, double split)
        {
            control.Show(parent, alignment, split);
        }

        //===================================================//
        //              Event Handler Methods                //
        //===================================================//
        private void CloseWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkspaceManager.CloseWorkspace();
        }
        private void RecentFilesStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFile(((RecentFileHandler.FileMenuItem)e.ClickedItem).FileName);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dockPanel1.ActiveContent != null)
                ((EditorBase)dockPanel1.ActiveContent).Save();
        }
        private void ProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var dlg = new NewProjectDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.SelectedTemplate != null)
                    {
                        Project p = dlg.SelectedTemplate.CreateProject(dlg.ProjectFilePath, dlg.ProjectName, WorkspaceManager);
                        if (p != null)
                        {
                            if (!Directory.Exists(Path.Combine(dlg.WorkspacePath, dlg.WorkspaceName)) && dlg.CreateWorkspace)
                            {
                                Directory.CreateDirectory(Path.Combine(dlg.WorkspacePath, dlg.ProjectName));
                                WorkspaceManager.CreateNewWorkspace(dlg.WorkspaceFilePath);
                            }
                            WorkspaceManager.AddProject(p);
                        }
                    }

                    else
                    {
                        MessageBox.Show("An existing project with this name already exists at this location!");
                        return;
                    }
                }
            }
        }
        private void projOpen_Click(object sender, EventArgs e)
        {
            ofDlg.Filter = "All Project files (*.fitproj, *.wrkspc)|*.fitproj; *.wrkspc|" +
                              "Fighter Project (*.fitproj)|*.fitproj|" +
                              "Project Workspace (*.wrkspc)|*.wrkspc|" +
                              "All Files (*.*)|*.*";
            if (ofDlg.ShowDialog() == DialogResult.OK)
            {
                OpenFile(ofDlg.FileName);
            }
        }
        private void AboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var abtBox = new AboutBox();
            abtBox.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Explorer = new WorkspaceExplorer();
            AddDockedControl(Explorer, DockState.DockRight);
            WorkspaceManager = new WorkspaceManager(Explorer);
            WorkspaceManager.OnWorkspaceOpened += WorkspaceManager_OnWorkspaceOpened;
            WorkspaceManager.OnProjectAdded += WorkspaceManager_OnProjectAdded;
            if (!string.IsNullOrEmpty(OpenTarget))
                OpenFile(OpenTarget);
        }

        private void WorkspaceManager_OnProjectAdded(object sender, ProjectAddedEventArgs e)
        {
            cboProject.Items.Add(e.AddedProject);
        }

        private void WorkspaceManager_OnWorkspaceOpened(object sender, WorkspaceOpenedEventArgs e)
        {
            cboProject.Items.Clear();
            foreach (var project in e.OpenedWorkspace.Projects)
            {
                cboProject.Items.Add(project.Value);
            }

            if (cboProject.Items.Count > 0)
                cboProject.SelectedIndex = 0;

            if (!toolStrip1.Enabled)
                toolStrip1.Enabled = true;
        }

        private void FOpen_Click(object sender, EventArgs e)
        {
            if (ofDlg.ShowDialog() == DialogResult.OK)
            {
                OpenFile(ofDlg.FileName);
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            BuildProject(((Project)cboProject.SelectedItem));
        }
        private void BuildProject(Project p)
        {
            Util.LogMessage($"Building project {p.ProjName}");
            WorkspaceManager.CompileFighter(p.Includes.Find(x => x.RealPath.EndsWith(".mlist")).RealPath,
                                            p.Platform,
                                            Path.Combine(p.ProjDirectory, "bin", FIGHTER_GLOBALS.ACMD_DIR));
        }

        private void buildWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Project p in cboProject.Items)
            {
                BuildProject(p);
            }
        }
    }
}