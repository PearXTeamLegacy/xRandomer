using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xRandomer
{
    public class xRandomerPattern
    {
        public xRandomerPattern(string name, string template)
        {
            Template = template;
            Name = name;
        }

        public string Template { get; set; }
        public string Name { get; set; }
    }
}
