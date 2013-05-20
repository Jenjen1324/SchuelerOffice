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
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            InitializeStandardFiles();

            Data.LoadMarks();
            Data.LoadTimeTable();
            Data.LoadHomeWork();
            Data.LoadVocabulary();

            bool running = true;

            while (running)
            {
                //try
                //{
                    Application.Run(new Form1());
                    running = false;
                //}
                //catch (Exception e)
                /*{
                    MessageBox.Show(String.Format("An error has occured! Details: {0}", e.Message));
                }*/
            }

            Data.SaveMarks();
            Data.SaveTimeTable();
            Data.SaveHomeWork();
            Data.SaveVocabulary();
        }

        private static void InitializeStandardFiles()
        {
            if (!Directory.Exists(Data.workingDir))
            {
                Directory.CreateDirectory(Data.workingDir);
            }

            if (!File.Exists(Data.timetableFile))
            {
                File.WriteAllText(Data.timetableFile, "<empty></empty>");
            }
        }
    }
}
