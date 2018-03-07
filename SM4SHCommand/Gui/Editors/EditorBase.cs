using Sm4shCommand.GUI.Nodes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Sm4shCommand.GUI.Editors
{
    public abstract class EditorBase : DockContent
    {
        public EditorBase()
        {
            this.FormClosing += EditorBase_FormClosing;
        }

        private void EditorBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasChanges)
            {
                DialogResult res = MessageBox.Show($"{this.Text} has changed! Save changes?",
                            "Save",
                            MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                    Save();
                else if (res == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        public bool HasChanges { get; set; }

        public abstract bool Save();
        public abstract bool Save(string filename);

        public ProjectExplorerNode LinkedNode { get; set; }
    }
}
