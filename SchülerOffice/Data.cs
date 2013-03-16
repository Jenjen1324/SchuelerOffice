using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchülerOffice
{
    public static class Data
    {
        internal static string workingDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Schüler Office";
        internal static string markFile = workingDir + "\\marks.xml";

        internal static List<string> classes = new List<string>();

        internal static List<Mark> marks = new List<Mark>();

        internal static void messageBox(string Title,string Message)
        {
            MessageBox.Show(Message, Title);
        }

        internal static void LoadMarks()
        {
            Data.marks = Mark.XmlToMark(Data.markFile);
        }

        internal static void SaveMarks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Mark m in marks)
            {
                sb.AppendLine(Mark.MarkToXml(m));
            }
            File.WriteAllText(Data.markFile, sb.ToString());
        }

        internal static Language lang = new Language();
    }
}
