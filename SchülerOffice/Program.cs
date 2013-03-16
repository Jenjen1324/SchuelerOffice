using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchülerOffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if(!Directory.Exists(Data.workingDir))
            {
                Directory.CreateDirectory(Data.workingDir);
            }

            if(!File.Exists(Data.markFile))
            {
                FileStream fs = File.Create(Data.markFile);
                fs.Close();
                File.WriteAllText(Data.markFile, "<empty></empty>");
            }

            Data.LoadMarks();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Data.SaveMarks();
        }
    }
}
