using System;
using System.Collections.Generic;
using System.IO;

namespace xRandomer
{
    public class PatternUtils
    {

        public static void AddPattern(xRandomerPattern pattern, ref xRandomer m)
        {
            if (m.Patterns.Contains(pattern)) return;
            m.Patterns.Add(pattern);
            m.listPatterns.Items.Add(pattern.Name);
            SavePatterns(ref m);
        }
        public static void RemovePattern(xRandomerPattern pattern, ref xRandomer m)
        {
            m.Patterns.Remove(pattern);
            m.listPatterns.Items.Remove(pattern.Name);
            SavePatterns(ref m);
        }
        public static void SavePatterns(ref xRandomer m)
        {
            List<string> l = new List<string>();
            foreach (xRandomerPattern pat in m.Patterns)
            {
                l.Add(pat.Name + ":xRandomerSeparator:" + pat.Template);
            }
            File.WriteAllLines(Program.Path + "patterns.xrandomer", l.ToArray());
        }

        public static void RestorePatterns(ref xRandomer m)
        {
            foreach (xRandomerPattern pat in m.Patterns)
            {
                RemovePattern(pat, ref m);
            }
            AddPattern(new xRandomerPattern("Password", "%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%"), ref m);
            AddPattern(new xRandomerPattern("Password (hard)", "%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%"), ref m);
            AddPattern(new xRandomerPattern("Pin-Code", "%num%%num%%num%%num%"), ref m);
            AddPattern(new xRandomerPattern("Digital Key", "%RANDWS%%RANDWS%%RANDWS%%RANDWS%-%RANDWS%%RANDWS%%RANDWS%%RANDWS%-%RANDWS%%RANDWS%%RANDWS%%RANDWS%-%RANDWS%%RANDWS%%RANDWS%%RANDWS%"), ref m);
        }

        public static void LoadPatterns(ref xRandomer m)
        {
            string[] l = File.ReadAllLines(Program.Path + "patterns.xrandomer");
            foreach (string s in l)
            {
                string[] a = s.Split(new string[] { ":xRandomerSeparator:" }, StringSplitOptions.None);
                AddPattern(new xRandomerPattern(a[0], a[1]), ref m);
            }
        }
    }
}
