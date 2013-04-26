using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
