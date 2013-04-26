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
        void UpdateTimeTable()
        {
            foreach (DataGridViewRow row in dataGridView_timeTable.Rows)
            {
                if (row == dataGridView_timeTable.Rows[dataGridView_timeTable.Rows.Count - 1])
                {
                    break;
                }
                dataGridView_timeTable.Rows.Remove(row);
            }
            if (Data.timetable.Count > 0)
            {
                dataGridView_timeTable.Rows.Add(Data.timetable.Count);
                int i = 0;
                int j = 0;
                foreach (Row row in Data.timetable)
                {
                    foreach (Cell c in row.cells)
                    {
                        dataGridView_timeTable.Rows[i].Cells[j].Value = c.name;
                        dataGridView_timeTable.Rows[i].Cells[j].Tag = c.tag;
                        dataGridView_timeTable.Rows[i].Cells[j].ToolTipText = c.toolTip;
                        j++;
                    }
                    i++;
                }
            }
        }

        private void button_timetable_cancel_Click(object sender, EventArgs e)
        {
            button_timetable_cancel.Enabled = false;
            button_timetable_save.Enabled = false;
            UpdateTimeTable();
        }

        private void button_timetable_save_Click(object sender, EventArgs e)
        {
            button_timetable_cancel.Enabled = false;
            button_timetable_save.Enabled = false;
            dataGridView_timeTable.DataSource = Data.timetable;
            Data.timetable.Clear();
            foreach (DataGridViewRow dgvr in dataGridView_timeTable.Rows)
            {
                List<Cell> cells = new List<Cell>();
                foreach (DataGridViewCell cell in dgvr.Cells)
                {
                    Cell c = new Cell(cell.Value.ToString(), cell.Tag.ToString(), cell.ToolTipText);
                    cells.Add(c);
                }
                Row r = new Row(cells);
                Data.timetable.Add(r);
            }
        }

        public void dataGridView_timeTable_CellChanged(object sender, EventArgs e)
        {
            button_timetable_cancel.Enabled = true;
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

        public static string TimeTableToxml()
        {
            
            List<Dictionary<string, object>> final_data = new List<Dictionary<string, object>>();
            foreach (Row row in Data.timetable)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                int i = 0;
                foreach (Cell cell in row.cells)
                {
                    data.Add(String.Format("cell {0}",i.ToString()), cell);
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

        private void button_homework_add_Click(object sender, EventArgs e)
        {

        }

        private void button_homework_remove_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
