using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchülerOffice
{
    partial class Form1
    {
        private void UpdateClasses()
        {
            listBox_mark_classes.Items.Clear();
            foreach (string s in Data.classes)
            {
                listBox_mark_classes.Items.Add(s);
            }
        }

        private void UpdateMarks()
        {
            listBox_mark_marks.Items.Clear();
            foreach (Mark m in Data.marks)
            {
                listBox_mark_marks.Items.Add(m.name);
            }
        }
        private void button_mark_calculateMark_Click(object sender, EventArgs e)
        {
            Single mark;
            try
            {
                mark = Convert.ToSingle(textBox_mark_points.Text) / Convert.ToSingle(textBox_mark_mpoints.Text) * 5 + 1;
                if (mark > 6)
                {
                    Data.messageBox("Warnung", "Ungültige eingabe von punkten");
                }
                else
                {
                    textBox_mark_mark.Text = mark.ToString();
                }
            }
            catch
            {
                Data.messageBox("Warnung", "Ungültige eingabe von punkten");
            }
        }

        private void button_mark_addClass_Click(object sender, EventArgs e)
        {
            AddClass ac = new AddClass();
            if(ac.ShowDialog() == DialogResult.OK)
            {
                Data.classes.Add(ac.name);
                UpdateClasses();
            }
        }

        private void button_mark_deleteClass_Click(object sender, EventArgs e)
        {
            if(listBox_mark_classes.SelectedIndex > -1)
            {
                Data.classes.Remove(listBox_mark_classes.SelectedItem.ToString());
            }
            UpdateClasses();
        }

        private void monthCalendar_mark_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_mark_date.Text = monthCalendar_mark_date.SelectionStart.ToString("dd.MM.yyyy");
            monthCalendar_mark_date.Visible = false;
        }

        private void textBox_mark_date_Click(object sender, EventArgs e)
        {
            monthCalendar_mark_date.Visible = true;
        }

        private void button_mark_add_Click(object sender, EventArgs e)
        {
            if (textBox_mark_mark.Text == "")
            {
                Data.messageBox("Warnung", "Es wurde keine note eingetragen!");
            }
            else
            {
                string _class;
                try
                {
                    _class = listBox_mark_classes.SelectedItem.ToString();
                }
                catch
                {
                    Data.messageBox("Warnung", "Kein Fach gewählt!");
                    return;
                }
                string _name = textBox_mark_name.Text;
                DateTime _date = Convert.ToDateTime(textBox_mark_date.Text);
                Single _mark = Convert.ToSingle(textBox_mark_mark.Text);
                Single[] _points = new Single[] {Convert.ToSingle(textBox_mark_points.Text), Convert.ToSingle(textBox_mark_mpoints.Text)};
                string _note = textBox_mark_note.Text;
                Mark m = new Mark(_class,_name,_date,_mark,_points,_note);
                Data.marks.Add(m);
                UpdateMarks();
            }
        }
    }
}
