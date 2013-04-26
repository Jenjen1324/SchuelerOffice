using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Xml;

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
        internal static List<HomeWork> homework = new List<HomeWork>();

        internal static Language lang = new Language();

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
        

        internal static void LoadTimeTable()
        {
            string file = Data.timetableFile;
            FileStream xmlfs = new FileStream(file, FileMode.Open);
            XmlReader xmlr = XmlReader.Create(xmlfs);

            List<Cell> current = null;

            while (xmlr.Read())
            {
                if (xmlr.Name == "row" && xmlr.NodeType == XmlNodeType.Element)
                {
                    current = new List<Cell>();
                }
                else if (xmlr.Name == "item" && xmlr.NodeType == XmlNodeType.Element)
                {
                    string content = xmlr.ReadElementContentAsString();
                    Cell c = new Cell(content, null, content);
                    current.Add(c);
                }
                else if (xmlr.Name == "row" && xmlr.NodeType == XmlNodeType.EndElement)
                {
                    Row r = new Row(current);
                    Data.timetable.Add(r);
                }
            }
            xmlfs.Close();
        }

        internal static void SaveTimeTable()
        {
            List<Dictionary<string, object>> final_data = new List<Dictionary<string, object>>();
            foreach (Row row in Data.timetable)
            {
                if (row != Data.timetable[Data.timetable.Count - 1])
                {
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    int i = 0;
                    foreach (Cell cell in row.cells)
                    {
                        data.Add(String.Format("cell {0}", i.ToString()), cell.name);
                        i++;
                    }
                    final_data.Add(data);
                }
            }
            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<timetable>");
            foreach (Dictionary<string, object> data in final_data)
            {

                xml.AppendLine(" <row>");
                foreach (KeyValuePair<string, object> item in data)
                {
                    object val = item.Value;
                    if (val == null)
                        val = "(empty)";
                    xml.AppendLine(String.Format("  <item key=\"{0}\">{1}</item>", item.Key, val));
                }
                xml.AppendLine(" </row>");
            }
            xml.AppendLine("</timetable>");

            File.WriteAllText(Data.timetableFile, xml.ToString());
        }
    }
}
