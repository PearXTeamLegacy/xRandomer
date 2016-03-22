using System;
using System.IO;
using System.Windows.Forms;
using PearXLib;

namespace xRandomer
{
    static class Program
    {
        public static string Path = d.pxDir + "/xRandomer/";
        public static Main ins;
        public static Random rand = new Random();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Directory.CreateDirectory(Path);
            if (args.Length == 2)
            {
                long l;
                if (long.TryParse(args[1], out l))
                {
                    new XRUtils().Autogenerate(args[0], l);
                }
            }
            else if (args.Length == 1)
            {
                Console.WriteLine(RandomUtils.ByTemplate(args[0], rand));
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ins = new Main();
                Application.Run(ins);
            }
        }
    }
}
