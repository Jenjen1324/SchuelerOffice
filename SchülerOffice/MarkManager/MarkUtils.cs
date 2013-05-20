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
using SchülerOffice;

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
            textBox_averageMark.Text = Convert.ToString(calculateAverageMark(comboBox_classes.Text));
        }

        private float calculateAverageMark(string _class)
        {
            float averageMark = 0;
            int i = 0;
            foreach (Mark m in Data.marks)
            {
                if (m._class == _class)
                {
                    i++;
                    averageMark = averageMark + m.mark;
                }
            }
            return averageMark / i;
        }

        private void button_calcuteTargetMark_Click(object sender, EventArgs e)
        {
            //WIP
            //throw new NotImplementedException();
            if (textBox_targetMark.Text != "")
            {
                try
                {
                    float target = Convert.ToSingle(textBox_targetMark.Text);
                    if (target > 6 || target < 1)
                    {
                        Data.messageBox("Warnung!", "Ungültige eingabe!");
                    }
                    else
                    {
                        float total = 0;
                        int i = 0;
                        foreach (Mark m in Data.marks)
                        {
                            if (m._class == comboBox_classes.Text)
                            {
                                i++;
                                total = total + m.mark;
                            }
                        }
                        if (i != 0)
                        {
                            float targetMark = target * i + target - total;
                            float[] targetMarks = new float[20];
                            int j = 0;
                            while (targetMark > 6)
                            {
                                total = total + 6;
                                i++;
                                targetMark = target * i + target - total;
                                targetMarks[j] = 6;
                                if (j == 19)
                                {
                                    break;
                                }
                                j++;
                            }
                            targetMarks[j] = targetMark;
                            textBox_requiredMark.Text = "";
                            foreach (float f in targetMarks)
                            {
                                
                                textBox_requiredMark.Text = textBox_requiredMark.Text + Convert.ToString(f) + "\n\r";
                            }
                        }
                    }
                }
                catch
                {
                    Data.messageBox("Warnung!", "Ungültige eingabe!");
                }
            }
        }
    }
}
