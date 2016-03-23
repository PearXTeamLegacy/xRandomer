using System.Drawing;
using PearXLib.Engine.Flat;
using xRandomer.Properties;

namespace xRandomer
{
    public class rForm : FlatForm
    {
        public rForm()
        {
            Font = new Font("Yanone Kaffeesatz", 20.25F);
            MaximizeBox = false;
            Icon = Resources.xricon;
        }
    }
}
