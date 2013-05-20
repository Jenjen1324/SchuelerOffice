using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchülerOffice
{
    public class Row
    {
        public List<Cell> cells;

        public Row(List<Cell> cells)
        {
            this.cells = cells;
        }
    }

    public class Cell
    {
        public string name;
        public string tag;
        public string toolTip;

        public Cell(string name, string tag, string toolTip)
        {
            this.name = name;
            this.tag = tag;
            this.toolTip = toolTip;
        }
    }

    public class CellInfo
    {
        public string name;
        public string tag;
        public string toolTip;

        public DateTime date;
        public int classTime;

        public List<HomeWork> homework = new List<HomeWork>();

        public CellInfo(DataGridViewCell cell, DateTime monday)
        {
            int day = cell.ColumnIndex - 1;

            this.name = (cell.Value != null ? cell.Value.ToString() : "");
            this.tag = (cell.Tag != null ? cell.Tag.ToString() : "");
            this.toolTip = cell.ToolTipText;
            this.date = monday.AddDays(day);
            this.classTime = cell.RowIndex;

            // Get Homework

            string selectedDay = this.date.ToString("d.MM.yy");

            foreach (HomeWork hw in Data.homework)
            {
                if (hw.date.ToString("d.MM.yy") == selectedDay)
                {
                    if (hw.time == this.classTime)
                    {
                        this.homework.Add(hw);
                    }
                }
            }
        }
    }
}
