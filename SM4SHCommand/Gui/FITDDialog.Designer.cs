namespace Sm4shCommand.GUI
{
    partial class FITDDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAdvanced = new System.Windows.Forms.RadioButton();
            this.chkSimple = new System.Windows.Forms.RadioButton();
            this.chkUseDictionary = new System.Windows.Forms.CheckBox();
            this.btnBrowseDictionary = new System.Windows.Forms.Button();
            this.txtCommandLineArgs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDictionary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnBrowseMotion = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMotion = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBrowseMtable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMtable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAdvanced);
            this.groupBox1.Controls.Add(this.chkSimple);
            this.groupBox1.Controls.Add(this.chkUseDictionary);
            this.groupBox1.Controls.Add(this.btnBrowseDictionary);
            this.groupBox1.Controls.Add(this.txtCommandLineArgs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDictionary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBrowseOutput);
            this.groupBox1.Controls.Add(this.btnBrowseMotion);
            this.groupBox1.Controls.Add(this.btnOkay);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtMotion);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.btnBrowseMtable);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMtable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 266);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // chkAdvanced
            // 
            this.chkAdvanced.AutoSize = true;
            this.chkAdvanced.Location = new System.Drawing.Point(141, 126);
            this.chkAdvanced.Name = "chkAdvanced";
            this.chkAdvanced.Size = new System.Drawing.Size(74, 17);
            this.chkAdvanced.TabIndex = 13;
            this.chkAdvanced.Text = "Advanced";
            this.chkAdvanced.UseVisualStyleBackColor = true;
            this.chkAdvanced.CheckedChanged += new System.EventHandler(this.chkAdvanced_CheckedChanged);
            // 
            // chkSimple
            // 
            this.chkSimple.AutoSize = true;
            this.chkSimple.Checked = true;
            this.chkSimple.Location = new System.Drawing.Point(79, 125);
            this.chkSimple.Name = "chkSimple";
            this.chkSimple.Size = new System.Drawing.Size(56, 17);
            this.chkSimple.TabIndex = 13;
            this.chkSimple.TabStop = true;
            this.chkSimple.Text = "Simple";
            this.chkSimple.UseVisualStyleBackColor = true;
            this.chkSimple.CheckedChanged += new System.EventHandler(this.chkSimple_CheckedChanged);
            // 
            // chkUseDictionary
            // 
            this.chkUseDictionary.AutoSize = true;
            this.chkUseDictionary.Location = new System.Drawing.Point(288, 126);
            this.chkUseDictionary.Name = "chkUseDictionary";
            this.chkUseDictionary.Size = new System.Drawing.Size(167, 17);
            this.chkUseDictionary.TabIndex = 12;
            this.chkUseDictionary.Text = "Use External Event Dictionary";
            this.chkUseDictionary.UseVisualStyleBackColor = true;
            this.chkUseDictionary.CheckedChanged += new System.EventHandler(this.chkUseDictionary_CheckedChanged);
            // 
            // btnBrowseDictionary
            // 
            this.btnBrowseDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDictionary.Location = new System.Drawing.Point(461, 99);
            this.btnBrowseDictionary.Name = "btnBrowseDictionary";
            this.btnBrowseDictionary.Size = new System.Drawing.Size(27, 25);
            this.btnBrowseDictionary.TabIndex = 11;
            this.btnBrowseDictionary.Text = "...";
            this.btnBrowseDictionary.UseVisualStyleBackColor = true;
            // 
            // txtCommandLineArgs
            // 
            this.txtCommandLineArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandLineArgs.Enabled = false;
            this.txtCommandLineArgs.Location = new System.Drawing.Point(19, 178);
            this.txtCommandLineArgs.Name = "txtCommandLineArgs";
            this.txtCommandLineArgs.Size = new System.Drawing.Size(469, 20);
            this.txtCommandLineArgs.TabIndex = 10;
            this.txtCommandLineArgs.TextChanged += new System.EventHandler(this.txtCommandLineArgs_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Command Line Options:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDictionary
            // 
            this.txtDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDictionary.Enabled = false;
            this.txtDictionary.Location = new System.Drawing.Point(79, 100);
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.Size = new System.Drawing.Size(376, 20);
            this.txtDictionary.TabIndex = 10;
            this.txtDictionary.TextChanged += new System.EventHandler(this.txtDictionary_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dictionary:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(461, 18);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(27, 25);
            this.btnBrowseOutput.TabIndex = 8;
            this.btnBrowseOutput.Text = "...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            // 
            // btnBrowseMotion
            // 
            this.btnBrowseMotion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMotion.Location = new System.Drawing.Point(461, 46);
            this.btnBrowseMotion.Name = "btnBrowseMotion";
            this.btnBrowseMotion.Size = new System.Drawing.Size(27, 25);
            this.btnBrowseMotion.TabIndex = 8;
            this.btnBrowseMotion.Text = "...";
            this.btnBrowseMotion.UseVisualStyleBackColor = true;
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkay.Location = new System.Drawing.Point(345, 229);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 25);
            this.btnOkay.TabIndex = 6;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(426, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtMotion
            // 
            this.txtMotion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotion.Location = new System.Drawing.Point(79, 46);
            this.txtMotion.Name = "txtMotion";
            this.txtMotion.Size = new System.Drawing.Size(376, 20);
            this.txtMotion.TabIndex = 1;
            this.txtMotion.TextChanged += new System.EventHandler(this.txtMotion_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(79, 18);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(376, 20);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnBrowseMtable
            // 
            this.btnBrowseMtable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMtable.Location = new System.Drawing.Point(461, 73);
            this.btnBrowseMtable.Name = "btnBrowseMtable";
            this.btnBrowseMtable.Size = new System.Drawing.Size(27, 25);
            this.btnBrowseMtable.TabIndex = 3;
            this.btnBrowseMtable.Text = "...";
            this.btnBrowseMtable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Motion Folder:";
            // 
            // txtMtable
            // 
            this.txtMtable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMtable.Location = new System.Drawing.Point(79, 74);
            this.txtMtable.Name = "txtMtable";
            this.txtMtable.Size = new System.Drawing.Size(376, 20);
            this.txtMtable.TabIndex = 2;
            this.txtMtable.TextChanged += new System.EventHandler(this.txtMtable_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mtable File:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FITDDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 266);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "FITDDialog";
            this.ShowIcon = false;
            this.Text = "FITD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMotion;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBrowseMtable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Button btnBrowseMotion;
        private System.Windows.Forms.RadioButton chkAdvanced;
        private System.Windows.Forms.RadioButton chkSimple;
        private System.Windows.Forms.CheckBox chkUseDictionary;
        private System.Windows.Forms.Button btnBrowseDictionary;
        private System.Windows.Forms.TextBox txtCommandLineArgs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDictionary;
        private System.Windows.Forms.Label label3;
    }
}