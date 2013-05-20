using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml;

using SchülerOffice.HomeWorkManager;
using System.Drawing;

namespace SchülerOffice
{
    partial class Form1
    {
        private void UpdateTimeTable()
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
                foreach (Row row in Data.timetable)
                {
                    int j = 0;
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
            Data.timetable.Clear();
            foreach (DataGridViewRow dgvr in dataGridView_timeTable.Rows)
            {
                if (dgvr != dataGridView_timeTable.Rows[dataGridView_timeTable.Rows.Count - 1])
                {
                    List<Cell> cells = new List<Cell>();
                    foreach (DataGridViewCell cell in dgvr.Cells)
                    {
                        Cell c;
                        if (cell.Value == null)
                        {
                            c = new Cell("", "", "");
                        }
                        else
                        {
                            c = new Cell(cell.Value.ToString(), "", cell.ToolTipText);
                        }
                        cells.Add(c);
                    }
                    Row r = new Row(cells);
                    Data.timetable.Add(r);
                }
            }
        }

        private void dataGridView_timeTable_CellChanged(object sender, EventArgs e)
        {
            button_timetable_cancel.Enabled = true;
            button_timetable_save.Enabled = true;
        }

        private void dataGridView_timeTable_SelectionChanged(object sender, EventArgs e)
        {
            CellInfo cell = new CellInfo(dataGridView_timeTable.SelectedCells[0],getMonday(dateTimePicker1.Value));
            checkedListBox_homework.Items.Clear();

            foreach (HomeWork hw in cell.homework)
            {
                checkedListBox_homework.Items.Add(hw.text, hw.completet);
            }
        }

        private void checkedListBox_homework_itemChecked(object sender, EventArgs e)
        {
            CellInfo cell = new CellInfo(dataGridView_timeTable.SelectedCells[0], getMonday(dateTimePicker1.Value));
            string selection = checkedListBox_homework.SelectedItem.ToString();
            CheckState checkstate = checkedListBox_homework.GetItemCheckState(checkedListBox_homework.SelectedIndex);
            bool state = (checkstate == CheckState.Checked ? true : false);

            foreach (HomeWork hw in cell.homework)
            {
                if (hw.text == selection)
                {
                    Data.homework.Remove(hw);
                    hw.completet = state;
                    Data.homework.Add(hw);
                    displayHomework();
                }
            }
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

            DateTime monday = getMonday(dateTimePicker1.Value);

            if (dataGridView_timeTable.SelectedCells[0].ColumnIndex != 0)
            {
                int day = dataGridView_timeTable.SelectedCells[0].ColumnIndex - 1;

                DateTime selectedDay = monday.AddDays(day);

                AddHomework ah = new AddHomework(selectedDay.DayOfWeek.ToString() + " " + selectedDay.Date.ToString("d.MM.yy"), (dataGridView_timeTable.SelectedCells[0].Value != null ? dataGridView_timeTable.SelectedCells[0].Value.ToString() : ""));
                if (ah.ShowDialog() == DialogResult.OK)
                {
                    HomeWork hw = new HomeWork(ah.task, false, dataGridView_timeTable.SelectedCells[0].RowIndex, selectedDay);
                    Data.homework.Add(hw);
                    displayHomework();
                }
            }
        }

        private void button_homework_remove_Click(object sender, EventArgs e)
        {
            CellInfo cell = new CellInfo(dataGridView_timeTable.SelectedCells[0], getMonday(dateTimePicker1.Value));
            string selection = checkedListBox_homework.SelectedItem.ToString();
            foreach (HomeWork hw in cell.homework)
            {
                if (hw.text == selection)
                {
                    Data.homework.Remove(hw);

                    displayHomework();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo ci = System.Threading.Thread.CurrentThread.CurrentCulture;
            int weekNo = ci.Calendar.GetWeekOfYear(dateTimePicker1.Value,
            ci.DateTimeFormat.CalendarWeekRule,
            ci.DateTimeFormat.FirstDayOfWeek);

            // Put dates on dataGridView
            label_week.Text = "Woche: " + weekNo.ToString();
            DateTime dt = getMonday(dateTimePicker1.Value);
            dataGridView_timeTable.Columns[1].HeaderText = "Montag " + getDate(dt);
            dataGridView_timeTable.Columns[2].HeaderText = "Dienstag " + getDate(dt.AddDays(1));
            dataGridView_timeTable.Columns[3].HeaderText = "Mittwoch " + getDate(dt.AddDays(2));
            dataGridView_timeTable.Columns[4].HeaderText = "Donnerstag " + getDate(dt.AddDays(3));
            dataGridView_timeTable.Columns[5].HeaderText = "Freitag " + getDate(dt.AddDays(4));

            displayHomework();
        }

        private void displayHomework()
        {
            foreach (DataGridViewRow row in dataGridView_timeTable.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            DateTime monday = getMonday(dateTimePicker1.Value);

            for (int i = 0; i < 5; i++)
            {
                foreach (HomeWork hw in Data.homework)
                {
                    if (getDate(hw.date) == getDate(monday.AddDays(i)))
                    {
                        DataGridViewCell cell = dataGridView_timeTable.Rows[hw.time].Cells[i + 1];
                        if (hw.completet && cell.Style.BackColor != Color.Red)
                        {
                            cell.Style.BackColor = Color.Green;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void button_homework_dateDec_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-7);
        }

        private void button_homework_dateInc_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(7);
        }

        private DateTime getMonday(DateTime dt)
        {
            int delta = DayOfWeek.Monday - dateTimePicker1.Value.DayOfWeek;
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                return dateTimePicker1.Value.AddDays(-6);
            }

            return dateTimePicker1.Value.AddDays(delta);
        }

        private string getDate(DateTime dt)
        {
            return dt.ToString("d.MM.yy");
        }
    }
}
