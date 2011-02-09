using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegExMatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateText()
        {
            try
            {
                invalidRegex.SetError(RegExInput, "");
                RegexOptions options = new RegexOptions();
                if (multiline.Checked)
                    options |= RegexOptions.Multiline;
                if (ignoreCase.Checked)
                    options |= RegexOptions.IgnoreCase;
                if (cultureInvariant.Checked)
                    options |= RegexOptions.CultureInvariant;
                if (ECMAScript.Checked)
                    options |= RegexOptions.ECMAScript;
                if (ignorePatternWhitespace.Checked)
                    options |= RegexOptions.IgnorePatternWhitespace;

                Regex reg = new Regex(RegExInput.Text, options);
                if (reg.IsMatch(TextInput.Text))
                    this.BackColor = Color.FromArgb(200, 255, 200);
                else
                    this.BackColor = Color.FromArgb(255, 200, 200);

                matches.Text = "";
                MatchCollection mc = reg.Matches(TextInput.Text);
                int matchMax = 0;
                if (mc.Count > 50)
                {
                    matches.Text = "Matches have been truncated at 50 due to an overly liberal regex\r\n\r\n";
                    matchMax = 50;
                }
                else
                    matchMax = mc.Count;

                for (int i = 0; i < matchMax; i++)
                {
                    matches.Text += "Match: " + mc[i].Value + "\r\n   Groups:\r\n";
                    if (mc[i].Groups.Count < 50)
                        foreach (Group g in mc[i].Groups)
                        {
                            matches.Text += "      - " + g.Value + "\r\n";
                        }
                }

            }
            catch (Exception ex)
            {
                invalidRegex.SetError(RegExInput, ex.Message);
            }
        }

        private void RegExInput_TextChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void multiline_CheckedChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void ignoreCase_CheckedChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void cultureInvariant_CheckedChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void ECMAScript_CheckedChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void ignorePatternWhitespace_CheckedChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
