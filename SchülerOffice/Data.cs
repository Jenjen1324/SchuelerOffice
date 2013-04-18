using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace SchülerOffice
{
    public static class Data
    {
        internal static string workingDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Schüler Office";
        internal static string markFile = workingDir + "\\marks.xml";
        internal static string timetableFile = workingDir + "\\timetable.xml";

        internal static List<string> classes = new List<string>();
        internal static List<Mark> marks = new List<Mark>();

        internal static List<Row> timetable = new List<Row>();

        internal static void messageBox(string Title,string Message)
        {
            MessageBox.Show(Message, Title);
        }

        internal static void LoadMarks()
        {
            Data.marks = Mark.XmlToMark(Data.markFile);
            foreach(Mark m in Data.marks)
            {
                if(!Data.classes.Contains(m._class))
                {
                    Data.classes.Add(m._class);
                }
            }
        }

        internal static void SaveMarks()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<marks>");
            foreach (Mark m in marks)
            {
                sb.AppendLine(Mark.MarkToXml(m));
            }
            if(!sb.ToString().Contains('<'))
            {
                sb.AppendLine("<empty></empty>");
            }
            sb.AppendLine("</marks>");
            File.WriteAllText(Data.markFile, sb.ToString());
        }
        internal static Language lang = new Language();
    }
}
