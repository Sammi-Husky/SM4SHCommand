using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Sm4shCommand
{
    public static class GLOBALS
    {
        static GLOBALS()
        {
            StartupDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);
            MyDocumentsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SM4SHCommand");
            DefaultProjectDirectory = Path.Combine(MyDocumentsDirectory, "Projects");
            ProjectTemplatesDirectory = Path.Combine(StartupDirectory, "ProjectTemplates");
            var types = new List<IProjectTemplate>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.GetInterfaces().Contains(typeof(IProjectTemplate)))
                {
                    types.Add((IProjectTemplate)Activator.CreateInstance(t));
                }
            }
            if (Directory.Exists(ProjectTemplatesDirectory))
            {
                foreach (var path in Directory.EnumerateFiles(ProjectTemplatesDirectory))
                {
                    if (!path.EndsWith(".dll"))
                        break;

                    Assembly a = Assembly.LoadFile(path);
                    foreach (var t in a.GetTypes())
                    {
                        if (t.GetInterfaces().Contains(typeof(IProjectTemplate)))
                        {
                            types.Add((IProjectTemplate)Activator.CreateInstance(t));
                        }
                    }
                }
                ProjectTemplates = types.ToArray();
            }

        }


        internal static readonly string StartupDirectory;
        internal static readonly string DefaultProjectDirectory;
        internal static readonly string MyDocumentsDirectory;
        internal static readonly string ProjectTemplatesDirectory;

        internal static IProjectTemplate[] ProjectTemplates { get; set; }
    }

    public static class FIGHTER_GLOBALS
    {
        public static string ACMD_DIR { get { return "script/animcmd"; } }
        public static string MSC_DIR { get { return "script/msc"; } }
        public static string AI_DIR { get { return "script/ai"; } }

        public static string MOTION_DIR { get { return "motion"; } }
    }
}
