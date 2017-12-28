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
            StartupDirectory = AppDomain.CurrentDomain.BaseDirectory;
            MyDocumentsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SM4SHCommand");
            DefaultProjectDirectory = Path.Combine(MyDocumentsDirectory, "Projects");

            var types = new List<IProjectTemplate>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.GetInterfaces().Contains(typeof(IProjectTemplate)))
                {
                    types.Add((IProjectTemplate)Activator.CreateInstance(t));
                }
            }
            foreach(var path in Directory.EnumerateFiles(Path.Combine(StartupDirectory, "ProjectTemplates")))
            {
                if (!path.EndsWith(".dll"))
                    break;

                Assembly a = Assembly.LoadFile(path);
                foreach(var t in a.GetTypes())
                {
                    if (t.GetInterfaces().Contains(typeof(IProjectTemplate)))
                    {
                        types.Add((IProjectTemplate)Activator.CreateInstance(t));
                    }
                }
            }
            ProjectTemplates = types.ToArray();
        }
        internal static readonly string StartupDirectory;
        internal static readonly string DefaultProjectDirectory;
        internal static readonly string MyDocumentsDirectory;
        internal static IProjectTemplate[] ProjectTemplates { get; set; }
    }
}
