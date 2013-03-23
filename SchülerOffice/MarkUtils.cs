using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SchülerOffice
{
    public partial class MarkUtils : Form
    {
        public MarkUtils()
        {
            InitializeComponent();
            foreach (string s in Data.classes)
            {
                comboBox_classes.Items.Add(s);
            }
            comboBox_classes.SelectedIndex = 0;
        }

        private void comboBox_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart_marks.Series[0].Points.Clear();
            int i = 0;
            foreach ( Mark m in Data.marks)
            {
                if(m._class == comboBox_classes.SelectedItem.ToString())
                {
                    DataPoint dp = new DataPoint();
                    dp.XValue = i;
                    dp.YValues = new double[] {m.mark};

                    chart_marks.Series[0].Points.Add(dp);
                    i++;
                }
            }
        }
    }
}
