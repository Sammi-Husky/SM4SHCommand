using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sm4shCommand.GUI
{
    public partial class FITDDialog : Form
    {
        public FITDDialog()
        {
            InitializeComponent();
        }

        public string MTablePath
        {
            get { return txtMtable.Text; }
            set
            {
                txtMtable.Text = value; buildArgs();
            }
        }
        public string MotionFolder
        {
            get { return txtMotion.Text; }
            set
            {
                txtMotion.Text = value; buildArgs();
            }
        }
        public string OutputDirectory
        {
            get { return txtOutput.Text; }
            set
            {
                txtOutput.Text = value; buildArgs();
            }
        }
        public string DictionaryPath
        {
            get { return txtDictionary.Text; }
            set
            {
                txtDictionary.Text = value; buildArgs();
            }
        }
        public string CommandLineArgs { get; set; }

        public FITDDialog(string fighterFolder, string output) : this()
        {
            MTablePath = Util.CanonicalizePath(Path.Combine(fighterFolder, "script/animcmd/body/motion.mtable"));
            MotionFolder = Util.CanonicalizePath(Path.Combine(fighterFolder, "motion"));
            OutputDirectory = output;

            if (File.Exists(MTablePath))
            {
                string args = $"\"{MTablePath}\" -o \"{OutputDirectory}\"";

                if (Directory.Exists(MotionFolder))
                {
                    args += $" -m \"{MotionFolder}\"";
                    txtMotion.Text = MotionFolder;
                }

                txtMtable.Text = MTablePath;
                txtCommandLineArgs.Text = args;
            }
            txtOutput.Text = OutputDirectory;
        }

        private string buildArgs()
        {
            var args = $"\"{MTablePath}\" -o \"{OutputDirectory}\" -m \"{MotionFolder}\"";
            if (chkUseDictionary.Checked)
                args += $" -e \"{DictionaryPath}\"";
            return args;
        }
        private void chkAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            txtCommandLineArgs.Enabled = true;
            txtDictionary.Enabled = txtMotion.Enabled =
            txtMtable.Enabled = txtOutput.Enabled = false;
        }

        private void chkSimple_CheckedChanged(object sender, EventArgs e)
        {
            txtCommandLineArgs.Enabled = false;
            txtMotion.Enabled = txtMtable.Enabled = txtOutput.Enabled = true;

            txtDictionary.Enabled = chkUseDictionary.Checked;
        }

        private void chkUseDictionary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseDictionary.Checked)
                txtDictionary.Enabled = true;
            else
                txtDictionary.Enabled = false;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            OutputDirectory = ((TextBox)sender).Text;
        }

        private void txtMotion_TextChanged(object sender, EventArgs e)
        {
            MotionFolder = ((TextBox)sender).Text;
        }

        private void txtMtable_TextChanged(object sender, EventArgs e)
        {
            MTablePath = ((TextBox)sender).Text;
        }

        private void txtDictionary_TextChanged(object sender, EventArgs e)
        {
            DictionaryPath = ((TextBox)sender).Text;
        }

        private void txtCommandLineArgs_TextChanged(object sender, EventArgs e)
        {
            CommandLineArgs = ((TextBox)sender).Text;
        }
    }
}
