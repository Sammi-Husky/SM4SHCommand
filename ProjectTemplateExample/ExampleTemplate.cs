using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Sm4shCommand;

namespace ProjectTemplateExample
{
    public class ExampleTemplate : IProjectTemplate
    {
        public ExampleTemplate()
        {
            DisplayText = "Example Project";
            ProjDescription = "";

            // Set your icon any way you wish, though it is recommended to copy this
            // method which grabs a .png image that has the same filename as the 
            // template .dll itself.
            var dllname = Assembly.GetExecutingAssembly().GetName().Name;
            TemplateIcon = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"{dllname}.png"));
        }
        public string DisplayText { get; set; }
        public string ProjDescription { get; set; }
        public Image TemplateIcon { get; set; }

        public Project CreateProject(string filepath, string name, WorkspaceManager manager)
        {
            throw new NotImplementedException();
        }
    }
}
