using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PearXLib;
using System.IO;
using System.Linq;

namespace xRandomer
{
    public partial class Main : rForm
    {
        public enum Opened
        {
            NONE,
            HELP,
            PATTERNS,
            AUTOGEN
        }
        public void AddPattern(xRandomerPattern pattern)
        {
            if (patterns.Contains(pattern)) return;
            patterns.Add(pattern);
            listPatterns.Items.Add(pattern.Name);
            SavePatterns();
        }
        public void RemovePattern(xRandomerPattern pattern)
        {
            patterns.Remove(pattern);
            listPatterns.Items.Remove(pattern.Name);
            SavePatterns();
        }
        public void SavePatterns()
        {
            List<string> l = new List<string>();
            foreach (xRandomerPattern pat in patterns)
            {
                l.Add(pat.Name + ":xRandomerSeparator:" + pat.Template);
            }
            File.WriteAllLines(Program.Path + "patterns.xrandomer", l.ToArray());
        }

        public void RestorePatterns()
        {
            foreach (xRandomerPattern pat in patterns)
            {
                RemovePattern(pat);
            }
            AddPattern(new xRandomerPattern("Password", "%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%"));
            AddPattern(new xRandomerPattern("Password (hard)", "%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%"));
            AddPattern(new xRandomerPattern("Pin-Code", "%num%%num%%num%%num%"));
            AddPattern(new xRandomerPattern("Digital Key", "%RANDWS%%RANDWS%%RANDWS%%RANDWS%-%RANDWS%%RANDWS%%RANDWS%%RANDWS%-%RANDWS%%RANDWS%%RANDWS%%RANDWS%-%RANDWS%%RANDWS%%RANDWS%%RANDWS%"));
        }

        public void LoadPatterns()
        {
            string[] l = File.ReadAllLines(Program.Path + "patterns.xrandomer");
            foreach (string s in l)
            {
                string[] a = s.Split(new string[] { ":xRandomerSeparator:" }, StringSplitOptions.None);
                AddPattern(new xRandomerPattern(a[0], a[1]));
            }
        }

        public List<xRandomerPattern> patterns = new List<xRandomerPattern>();
        public Opened opened = Opened.NONE;
        public XRUtils utils = new XRUtils();

        public Main()
        {
            InitializeComponent();
            UpdateGUI(Opened.NONE);
        }

        private void boxGenerated_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            boxGenerated.Text = RandomUtils.ByTemplate(boxTemplate.Text, Program.rand);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(boxGenerated.Text))
                Clipboard.SetText(boxGenerated.Text);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            UpdateGUI(opened == Opened.NONE ? Opened.HELP : Opened.NONE);
        }

        public void UpdateGUI(Opened o)
        {
            Size = new Size(862, 184);
            opened = o;
            switch (o)
            {
                case Opened.NONE:
                    Size = new Size(573, 184);
                    lblHelp.Visible = false;
                    panelPatterns.Visible = false;
                    panelAutogen.Visible = false;
                    break;
                case Opened.HELP:
                    lblHelp.Visible = true;
                    break;
                case Opened.PATTERNS:
                    panelPatterns.Visible = true;
                    break;
                case Opened.AUTOGEN:
                    panelAutogen.Visible = true;
                    break;
            }
        }

        private void btnTemplates_Click(object sender, EventArgs e)
        {
            UpdateGUI(opened == Opened.NONE ? Opened.PATTERNS : Opened.NONE);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(Program.Path + "patterns.xrandomer"))
            {
                RestorePatterns();
            }
            else
                LoadPatterns();
        }

        private void listPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPatterns.SelectedItem == null) return;

            boxTemplate.Text = patterns[listPatterns.SelectedIndex].Template;
        }

        private void btnDelPattern_Click(object sender, EventArgs e)
        {
            RemovePattern(patterns[listPatterns.SelectedIndex]);
        }

        private void btnAddPattern_Click(object sender, EventArgs e)
        {
            new AddPatternForm().ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAutogen_Click(object sender, EventArgs e)
        {
            UpdateGUI(opened == Opened.NONE ? Opened.AUTOGEN : Opened.NONE);
        }

        private void btnStartAutogen_Click(object sender, EventArgs e)
        {
            bwAutogen.RunWorkerAsync();
        }

        private void btnStopAutogen_Click(object sender, EventArgs e)
        {
            if (bwAutogen.IsBusy)
                utils.CancelAutogen = true;
            lblWorking.Visible = false;
        }

        private void bwAutogen_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new MethodInvoker(() => lblWorking.Visible = true));
            utils.Autogenerate(boxTemplate.Text, Convert.ToInt64(boxAutogenCount.Text));
        }

        private void bwAutogen_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Invoke(new MethodInvoker(() => lblWorking.Visible = false));
        }

        private void boxAutogenCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PXL.isNumberKey(e))
            {
                e.Handled = true;
            }
        }
    }
}
