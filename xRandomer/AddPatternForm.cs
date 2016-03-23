using System.Drawing;

namespace xRandomer
{
    public partial class AddPatternForm : rForm
    {
        public AddPatternForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            PatternUtils.AddPattern(new xRandomerPattern(boxName.Text, boxTemplate.Text), ref Program.ins);
            Close();
        }
    }
}
