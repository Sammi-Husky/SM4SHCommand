using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
using Sm4shCommand.GUI.Nodes;
using System.Security.Cryptography;
using System.IO;
using System;
using FastColoredTextBoxNS;

namespace Sm4shCommand.GUI.Editors
{
    public partial class TextEditor : EditorBase
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private FileInfo TargetFile { get; set; }
        public bool SyntaxHighlighting
        {
            get { return ITS_EDITOR1.SyntaxHighlighting; }
            set { ITS_EDITOR1.SyntaxHighlighting = value;}
        }

        private void ITS_EDITOR1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ITS_EDITOR1.IsChanged && HasChanges == false)
            {
                HasChanges = true;
                this.Text += "*";
            }
        }

        public TextEditor(ProjectExplorerNode node) : this()
        {
            LinkedNode = node;
            TargetFile = (FileInfo)node.Tag;
            using (StreamReader reader = File.OpenText(TargetFile.FullName))
            {
                this.ITS_EDITOR1.Text = reader.ReadToEnd();
            }

            // dont count setting text as changed
            ITS_EDITOR1.IsChanged = false;
            this.ITS_EDITOR1.TextChanged += ITS_EDITOR1_TextChanged;
        }

        public void SetAutocomplete(string[] autocomplete)
        {
            ITS_EDITOR1.SetAutocomplete(autocomplete);
        }
        public void SetAutocomplete(AutocompleteItem[] autocomplete)
        {
            ITS_EDITOR1.SetAutocomplete(autocomplete);
        }

        /// <summary>
        /// Saves file.
        /// </summary>
        /// <returns>Returns true if error occured.</returns>
        public override bool Save()
        {
            Save(TargetFile.FullName);
            return false;
        }

        /// <summary>
        /// Saves file to specified location.
        /// </summary>
        /// <param name="filename">The filename to save the file to.</param>
        /// <returns>Returns true if error occured.</returns>
        public override bool Save(string filename)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(filename))
                {
                    writer.Write(this.ITS_EDITOR1.Text);
                }

                if (this.Text.EndsWith("*") || this.HasChanges)
                {
                    this.Text = this.Text.Remove(this.Text.Length - 1);
                    HasChanges = false;
                }

                return false;

            }
            catch (Exception e)
            {
                Util.LogMessage(e.Message, ConsoleColor.Red);
                return true;
            }
        }
    }
}
