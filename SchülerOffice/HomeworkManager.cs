using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace SchülerOffice
{
    partial class Form1
    {
        private void button_timetable_edit_Click(object sender, EventArgs e)
        {
            button_timetable_edit.Enabled = false;
            button_timetable_save.Enabled = false;
            LoadTimeTable();
        }

        private void button_timetable_save_Click(object sender, EventArgs e)
        {
            button_timetable_edit.Enabled = false;
            button_timetable_save.Enabled = false;
            SaveTimeTable();
        }

        public void dataGridView_timeTable_CellChanged(object sender, EventArgs e)
        {
            button_timetable_edit.Enabled = true;
            button_timetable_save.Enabled = true;
        }

        void LoadTimeTable()
        {
            dataGridView_timeTable.DataSource = Data.timetable;
        }

        void SaveTimeTable()
        {
            string data = Form1.TimeTableToxml();
            File.WriteAllText(Data.timetableFile, data);
        }

        public static void xmlToTimetable(string file)
        {
            FileStream xmlfs = new FileStream(file, FileMode.Open);
            XmlReader xmlr = XmlReader.Create(xmlfs);

            List<string> current = null;

            while (xmlr.Read())
            {
                if (xmlr.Name == "row" && xmlr.NodeType == XmlNodeType.Element)
                {
                    current = new List<string>();
                }
                else if (xmlr.Name == "item" && xmlr.NodeType == XmlNodeType.Element)
                {
                    string content = xmlr.ReadElementContentAsString();
                    current.Add(content);
                }
                else if (xmlr.Name == "row" && xmlr.NodeType == XmlNodeType.EndElement)
                {
                    Data.timetable.Rows.Add(current);
                }
            }
            xmlfs.Close();
        }

        public static string TimeTableToxml()
        {
            List<Dictionary<string, object>> final_data = new List<Dictionary<string, object>>();
            foreach (DataRow row in Data.timetable.Rows)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                int i = 0;
                foreach (string cell in row.ItemArray)
                {
                    data.Add(String.Format("cell{0}",i.ToString()), cell);
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
                    if (val == null)
                        val = "(empty)";
                    xml.AppendLine(String.Format("  <item key=\"{0}\">{1}</item>", item.Key, val));
                }
                xml.AppendLine(" </row>");
            }
            xml.AppendLine("</timetable>");
            return xml.ToString();
        }
        
    }
}
