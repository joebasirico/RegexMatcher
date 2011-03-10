namespace RegExMatcher
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.RegExInput = new System.Windows.Forms.TextBox();
			this.TextInput = new System.Windows.Forms.TextBox();
			this.multiline = new System.Windows.Forms.CheckBox();
			this.ignorePatternWhitespace = new System.Windows.Forms.CheckBox();
			this.ECMAScript = new System.Windows.Forms.CheckBox();
			this.cultureInvariant = new System.Windows.Forms.CheckBox();
			this.ignoreCase = new System.Windows.Forms.CheckBox();
			this.matches = new System.Windows.Forms.TextBox();
			this.invalidRegex = new System.Windows.Forms.ErrorProvider(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TreatEachLineAsInput = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.invalidRegex)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// RegExInput
			// 
			this.RegExInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.RegExInput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegExInput.Location = new System.Drawing.Point(12, 12);
			this.RegExInput.Name = "RegExInput";
			this.RegExInput.Size = new System.Drawing.Size(819, 20);
			this.RegExInput.TabIndex = 0;
			this.RegExInput.Text = "^.+$";
			this.RegExInput.TextChanged += new System.EventHandler(this.RegExInput_TextChanged);
			// 
			// TextInput
			// 
			this.TextInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextInput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextInput.Location = new System.Drawing.Point(0, 0);
			this.TextInput.Multiline = true;
			this.TextInput.Name = "TextInput";
			this.TextInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextInput.Size = new System.Drawing.Size(608, 299);
			this.TextInput.TabIndex = 1;
			this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
			// 
			// multiline
			// 
			this.multiline.AutoSize = true;
			this.multiline.Location = new System.Drawing.Point(25, 4);
			this.multiline.Name = "multiline";
			this.multiline.Size = new System.Drawing.Size(64, 17);
			this.multiline.TabIndex = 2;
			this.multiline.Text = "Multiline";
			this.multiline.UseVisualStyleBackColor = true;
			this.multiline.CheckedChanged += new System.EventHandler(this.multiline_CheckedChanged);
			// 
			// ignorePatternWhitespace
			// 
			this.ignorePatternWhitespace.AutoSize = true;
			this.ignorePatternWhitespace.Location = new System.Drawing.Point(25, 96);
			this.ignorePatternWhitespace.Name = "ignorePatternWhitespace";
			this.ignorePatternWhitespace.Size = new System.Drawing.Size(153, 17);
			this.ignorePatternWhitespace.TabIndex = 3;
			this.ignorePatternWhitespace.Text = "Ignore Pattern Whitespace";
			this.ignorePatternWhitespace.UseVisualStyleBackColor = true;
			this.ignorePatternWhitespace.CheckedChanged += new System.EventHandler(this.ignorePatternWhitespace_CheckedChanged);
			// 
			// ECMAScript
			// 
			this.ECMAScript.AutoSize = true;
			this.ECMAScript.Location = new System.Drawing.Point(25, 73);
			this.ECMAScript.Name = "ECMAScript";
			this.ECMAScript.Size = new System.Drawing.Size(83, 17);
			this.ECMAScript.TabIndex = 4;
			this.ECMAScript.Text = "ECMAScript";
			this.ECMAScript.UseVisualStyleBackColor = true;
			this.ECMAScript.CheckedChanged += new System.EventHandler(this.ECMAScript_CheckedChanged);
			// 
			// cultureInvariant
			// 
			this.cultureInvariant.AutoSize = true;
			this.cultureInvariant.Location = new System.Drawing.Point(25, 50);
			this.cultureInvariant.Name = "cultureInvariant";
			this.cultureInvariant.Size = new System.Drawing.Size(100, 17);
			this.cultureInvariant.TabIndex = 5;
			this.cultureInvariant.Text = "CultureInvariant";
			this.cultureInvariant.UseVisualStyleBackColor = true;
			this.cultureInvariant.CheckedChanged += new System.EventHandler(this.cultureInvariant_CheckedChanged);
			// 
			// ignoreCase
			// 
			this.ignoreCase.AutoSize = true;
			this.ignoreCase.Location = new System.Drawing.Point(25, 27);
			this.ignoreCase.Name = "ignoreCase";
			this.ignoreCase.Size = new System.Drawing.Size(83, 17);
			this.ignoreCase.TabIndex = 6;
			this.ignoreCase.Text = "Ignore Case";
			this.ignoreCase.UseVisualStyleBackColor = true;
			this.ignoreCase.CheckedChanged += new System.EventHandler(this.ignoreCase_CheckedChanged);
			// 
			// matches
			// 
			this.matches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.matches.BackColor = System.Drawing.Color.White;
			this.matches.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.matches.Location = new System.Drawing.Point(3, 142);
			this.matches.Multiline = true;
			this.matches.Name = "matches";
			this.matches.ReadOnly = true;
			this.matches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.matches.Size = new System.Drawing.Size(200, 154);
			this.matches.TabIndex = 7;
			// 
			// invalidRegex
			// 
			this.invalidRegex.ContainerControl = this;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(13, 39);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.TextInput);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.TreatEachLineAsInput);
			this.splitContainer1.Panel2.Controls.Add(this.multiline);
			this.splitContainer1.Panel2.Controls.Add(this.matches);
			this.splitContainer1.Panel2.Controls.Add(this.ignorePatternWhitespace);
			this.splitContainer1.Panel2.Controls.Add(this.ignoreCase);
			this.splitContainer1.Panel2.Controls.Add(this.ECMAScript);
			this.splitContainer1.Panel2.Controls.Add(this.cultureInvariant);
			this.splitContainer1.Size = new System.Drawing.Size(818, 299);
			this.splitContainer1.SplitterDistance = 608;
			this.splitContainer1.TabIndex = 8;
			// 
			// TreatEachLineAsInput
			// 
			this.TreatEachLineAsInput.AutoSize = true;
			this.TreatEachLineAsInput.Location = new System.Drawing.Point(25, 119);
			this.TreatEachLineAsInput.Name = "TreatEachLineAsInput";
			this.TreatEachLineAsInput.Size = new System.Drawing.Size(177, 17);
			this.TreatEachLineAsInput.TabIndex = 8;
			this.TreatEachLineAsInput.Text = "Treat Each Line as a New Input";
			this.TreatEachLineAsInput.UseVisualStyleBackColor = true;
			this.TreatEachLineAsInput.CheckedChanged += new System.EventHandler(this.TreatEachLineAsInput_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 360);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.RegExInput);
			this.Name = "Form1";
			this.Text = "RegEx Tester";
			((System.ComponentModel.ISupportInitialize)(this.invalidRegex)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegExInput;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.CheckBox multiline;
        private System.Windows.Forms.CheckBox ignorePatternWhitespace;
        private System.Windows.Forms.CheckBox ECMAScript;
        private System.Windows.Forms.CheckBox cultureInvariant;
        private System.Windows.Forms.CheckBox ignoreCase;
        private System.Windows.Forms.TextBox matches;
        private System.Windows.Forms.ErrorProvider invalidRegex;
        private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.CheckBox TreatEachLineAsInput;
    }
}

