using System.IO;
using PearXLib;
using System;

namespace xRandomer
{
    public class XRUtils
    {
        public bool CancelAutogen;

        public void Autogenerate(string gen, long count)
        {
            string s = PXL.GetDateTimeNow();
            for (long i = 0; i < count; i++)
            {
                if (CancelAutogen)
                {
                    CancelAutogen = false;
                    return;
                }
                File.AppendAllText(Program.Path + "AutoGen_" + s + ".txt", RandomUtils.ByTemplate(gen, Program.rand) + "\n");
            }
        }
    }
}
