﻿using System;
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

            if(!Directory.Exists(Data.workingDir))
            {
                Directory.CreateDirectory(Data.workingDir);
            }

            if(!File.Exists(Data.markFile))
            {
                File.WriteAllText(Data.markFile, "<empty></empty>");
            }

            if (!File.Exists(Data.timetableFile))
            {
                File.WriteAllText(Data.timetableFile, "<empty></empty>");
            }

            Data.LoadMarks();

            Application.Run(new Form1());

            Data.SaveMarks();
        }
    }
}
