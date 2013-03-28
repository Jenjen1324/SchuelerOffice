using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SchülerOffice
{
    partial class Form1
    {
        void constructTimeTable()
        {
            DataGridViewColumn colTime = new DataGridViewColumn();
            DataGridViewColumn colMon = new DataGridViewColumn();
            DataGridViewColumn colTue = new DataGridViewColumn();
            DataGridViewColumn colWed = new DataGridViewColumn();
            DataGridViewColumn colThu = new DataGridViewColumn();
            DataGridViewColumn colFri = new DataGridViewColumn();
            DataGridViewColumn colSat = new DataGridViewColumn();
            DataGridViewColumn colSun = new DataGridViewColumn();
            colTime.Name = "Time:";
            colTime.Width = 61;
            colMon.Name = "Monday";
            colTue.Name = "Tuesday";
            colWed.Name = "Wednesday";
            colThu.Name = "Thursday";
            colFri.Name = "Friday";
            colSat.Name = "Saturday";
            colSun.Name = "Sunday";
            dataGridView_timeTable.Columns.Add(colTime);
            dataGridView_timeTable.Columns.Add(colMon);
            dataGridView_timeTable.Columns.Add(colTue);
            dataGridView_timeTable.Columns.Add(colWed);
            dataGridView_timeTable.Columns.Add(colThu);
            dataGridView_timeTable.Columns.Add(colFri);
            dataGridView_timeTable.Columns.Add(colSat);
            dataGridView_timeTable.Columns.Add(colSun);
            dataGridView_timeTable.RowHeadersVisible = false;
        }
        
    }
}
