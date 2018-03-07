using Sm4shCommand.GUI.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sm4shCommand.GUI.Nodes
{
    class GenericTextNode : ProjectFileNode
    {
        public override EditorBase GetEditor()
        {
            var editor = new TextEditor(this) { SyntaxHighlighting = false, Text = this.Text };
            return editor;
        }
    }
}
