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
        private void UpdateList()
        {
            treeView_mark.Nodes.Clear();
            foreach (string s in Data.classes)
            {
                TreeNode node = new TreeNode(s);
                node.ToolTipText = s;
                node.Tag = "Parent";
                int i = 0;
                foreach (Mark m in Data.marks)
                {
                    if (m._class == s)
                    {
                        TreeNode n = new TreeNode(m.name);
                        n.ToolTipText = m.date.ToString();
                        n.Tag = i;
                        node.Nodes.Add(n);
                    }
                    i++;
                }
                treeView_mark.Nodes.Add(node);
            }
        }

        private void button_mark_calculateMark_Click(object sender, EventArgs e)
        {
            float mark;
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
                UpdateList();
            }
        }

        private void button_mark_deleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView_mark.SelectedNode.Tag.ToString() == "Parent")
                {
                    if (MessageBox.Show(String.Format("Bist du dir sicher dass du das Fach {0} löschen willst?", treeView_mark.SelectedNode.Text), "Warnung", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (Mark m in Data.marks)
                        {
                            if (m._class == treeView_mark.SelectedNode.ToString())
                            {
                                Data.marks.Remove(m);
                            }
                        }
                        Data.classes.Remove(treeView_mark.SelectedNode.ToString());
                    }
                }
                else
                {
                    if (MessageBox.Show(String.Format("Bist du dir sicher dass du die Note {0} löschen willst?", treeView_mark.SelectedNode.Text), "Warnung", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Mark m = Data.marks[Convert.ToInt32(treeView_mark.SelectedNode.Tag)];
                        Data.marks.Remove(m);
                    }
                }
                UpdateList();
            }
            catch
            {
                
            }
            // Needs work
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
                    if (treeView_mark.SelectedNode.Tag.ToString() != "Parent")
                    {
                        Data.messageBox("Warnung", "Kein Fach gewählt");
                        return;
                    }
                    else
                    {
                        _class = treeView_mark.SelectedNode.Text;
                    }
                }
                catch
                {
                    Data.messageBox("Warnung", "Kein Fach gewählt!");
                    return;
                }
                string _name = textBox_mark_name.Text;
                DateTime _date = Convert.ToDateTime(dateTimePicker_mark.Text);
                float _mark = Convert.ToSingle(textBox_mark_mark.Text);
                float[] _points = new float[] {Convert.ToSingle(textBox_mark_points.Text), Convert.ToSingle(textBox_mark_mpoints.Text)};
                string _note = textBox_mark_note.Text;
                Mark m = new Mark(_class,_name,_date,_mark,_points,_note);
                Data.marks.Add(m);
                UpdateList();
            }
        }

        private void treeView_mark_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Mark m = Data.marks[(int)treeView_mark.SelectedNode.Tag];
                textBox_mark_name.Text = m.name;
                dateTimePicker_mark.Text = m.date.ToString();
                textBox_mark_mark.Text = m.mark.ToString();
                textBox_mark_points.Text = m.points[0].ToString();
                textBox_mark_mpoints.Text = m.points[1].ToString();
                textBox_mark_note.Text = m.note;
            }
            catch
            {

            }
        }
    }
}
