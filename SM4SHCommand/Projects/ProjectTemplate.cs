using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Sm4shCommand
{
    public interface IProjectTemplate
    {
        /// <summary>
        /// The Display Name of the Template
        /// </summary>
        string DisplayText { get; set; }

        /// <summary>
        /// The Display Description of the template
        /// </summary>
        string ProjDescription { get; set; }

        /// <summary>
        /// Icon associated with the Template
        /// </summary>
        Image TemplateIcon { get; set; }

        /// <summary>
        /// Handles the creation of the project structure.
        /// </summary>
        /// <param name="filepath">Filepath to create the project file at</param>
        /// <param name="name">Name of the project</param>
        /// <param name="manager">Workspace Manager this project is associated with</param>
        /// <returns>The processed project.</returns>
        Project CreateProject(string filepath, string name, WorkspaceManager manager);
    }

    public class EmptyProjectTemplate : IProjectTemplate
    {
        public EmptyProjectTemplate()
        {
            DisplayText = "New Empty Project";
            ProjDescription = "Creates a new Empty Project";
        }

        public string DisplayText { get; set; }
        public string ProjDescription { get; set; }
        public Image TemplateIcon { get; set; }

        public Project CreateProject(string filepath, string name, WorkspaceManager manager)
        {
            var p = new FitProj
            {
                ProjFilepath = filepath,
                ProjName = name,
                Platform = ProjPlatform.WiiU,
                ToolVer = Program.Version,
                GameVer = "1.1.7",
                ProjectGuid = Guid.NewGuid()
            };

            return p;
        }
    }
}
