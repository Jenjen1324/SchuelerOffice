using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Xml;
using SchülerOffice.VocabManager;
using System.Collections;

namespace SchülerOffice
{
    public static class Data
    {
        internal static string workingDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Schüler Office";
        internal static string markFile = workingDir + "\\marks.xml";
        internal static string timetableFile = workingDir + "\\timetable.xml";
        internal static string homeWorkFile = workingDir + "\\homework.xml";
        internal static string vocabularyFile = workingDir + "\\vocabulary.xml";

        internal static List<string> classes = new List<string>();
        internal static List<Mark> marks;

        internal static List<Row> timetable = new List<Row>();
        internal static List<HomeWork> homework = new List<HomeWork>();

        internal static List<Vocabulary> vocabulary = new List<Vocabulary>();

        internal static Language lang = new Language();

        internal static void messageBox(string Title,string Message)
        {
            MessageBox.Show(Message, Title);
        }

        internal static ArrayList RandomNumbers(int max)
        {
            // Create an ArrayList object that will hold the numbers
            ArrayList lstNumbers = new ArrayList();
            // The Random class will be used to generate numbers
            Random rndNumber = new Random();

            // Generate a random number between 1 and the Max
            int number = rndNumber.Next(1, max + 1);
            // Add this first random number to the list
            lstNumbers.Add(number);
            // Set a count of numbers to 0 to start
            int count = 0;

            do // Repeatedly...
            {
                // ... generate a random number between 1 and the Max
                number = rndNumber.Next(1, max + 1);

                // If the newly generated number in not yet in the list...
                if (!lstNumbers.Contains(number))
                {
                    // ... add it
                    lstNumbers.Add(number);
                }

                // Increase the count
                count++;
            } while (count <= 10 * max); // Do that again

            // Once the list is built, return it
            return lstNumbers;
        }


        internal static void LoadMarks()
        {
            if (File.Exists(Data.markFile))
            {

                Data.marks = Mark.XmlToMark(Data.markFile);

                if (Data.marks != null)
                {
                    foreach (Mark m in Data.marks)
                    {
                        if (!Data.classes.Contains(m._class))
                        {
                            Data.classes.Add(m._class);
                        }
                    }
                }
                else
                {
                    Data.marks = new List<Mark>();
                }
            }
            else
            {
                Data.marks = new List<Mark>();
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
            sb.AppendLine("</marks>");
            File.WriteAllText(Data.markFile, sb.ToString());
        }
        

        internal static void LoadTimeTable()
        {
            string file = Data.timetableFile;
            if (File.Exists(file))
            {
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
        }

        internal static void SaveTimeTable()
        {
            List<Dictionary<string, object>> final_data = new List<Dictionary<string, object>>();
            foreach (Row row in Data.timetable)
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
            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<timetable>");
            foreach (Dictionary<string, object> data in final_data)
            {

                xml.AppendLine(" <row>");
                foreach (KeyValuePair<string, object> item in data)
                {
                    object val = item.Value;
                    xml.AppendLine(String.Format("  <item key=\"{0}\">{1}</item>", item.Key, (val != null ? val : "")));
                }
                xml.AppendLine(" </row>");
            }
            xml.AppendLine("</timetable>");

            File.WriteAllText(Data.timetableFile, xml.ToString());
        }


        internal static void LoadHomeWork()
        {
            string file = Data.homeWorkFile;
            if (File.Exists(file))
            {
                FileStream xmlfs = new FileStream(file, FileMode.Open);
                XmlReader xmlr = XmlReader.Create(xmlfs);

                HomeWork current = null;

                while (xmlr.Read())
                {
                    if (xmlr.Name == "HomeWork" && xmlr.NodeType == XmlNodeType.Element)
                    {
                        current = new HomeWork("", false, 0, DateTime.Now);
                    }
                    else if (xmlr.Name == "item" && xmlr.NodeType == XmlNodeType.Element)
                    {
                        //Get property name
                        string nodekey = xmlr.GetAttribute("key");

                        //load properties in class
                        Type ptype = current.GetType().GetProperty(nodekey).PropertyType;

                        //Set property
                        current.GetType().GetProperty(nodekey).SetValue(
                            //Store in current
                            current,
                            //Cast data in element to property type
                            Convert.ChangeType(
                                xmlr.ReadElementContentAsString(),
                                ptype),
                            //Not used, only for indexed properties. Use null
                            null);
                    }
                    else if (xmlr.Name == "HomeWork" && xmlr.NodeType == XmlNodeType.EndElement)
                    {
                        Data.homework.Add(current);
                    }
                }
                xmlfs.Close();
            }
        }

        internal static void SaveHomeWork()
        {
            List<Dictionary<string, object>> final_data = new List<Dictionary<string, object>>();
            foreach (HomeWork hw in Data.homework)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("text", hw.text);
                data.Add("completet", hw.completet.ToString());
                data.Add("time", hw.time.ToString());
                data.Add("date", hw.date.ToString());
                final_data.Add(data);
            }
            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<HomeWorkList>");
            foreach (Dictionary<string, object> data in final_data)
            {

                xml.AppendLine(" <HomeWork>");
                foreach (KeyValuePair<string, object> item in data)
                {
                    object val = item.Value;
                    xml.AppendLine(String.Format("  <item key=\"{0}\">{1}</item>", item.Key, (val != null ? val : "")));
                }
                xml.AppendLine(" </HomeWork>");
            }
            xml.AppendLine("</HomeWorkList>");

            File.WriteAllText(Data.homeWorkFile, xml.ToString());
        }


        internal static void LoadVocabulary()
        {
            if (File.Exists(vocabularyFile))
            {
                vocabulary = Vocabulary.xmlToVocab(File.ReadAllText(Data.vocabularyFile));
            }
        }

        internal static void SaveVocabulary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<Vocabularies>");
            foreach (Vocabulary voc in Data.vocabulary)
            {
                sb.AppendLine(Vocabulary.vocabToXml(voc));
            }
            sb.AppendLine("</Vocabularies>");
            File.WriteAllText(vocabularyFile, sb.ToString());
        }
    }
}
