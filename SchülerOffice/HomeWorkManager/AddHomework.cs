using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchülerOffice.HomeWorkManager
{
    public partial class AddHomework : Form
    {
        public AddHomework(string day, string _class)
        {
            InitializeComponent();

            textBox_addHomework_day.Text = day;
            textBox_addHomework_class.Text = _class;
        }

        public string task
        {
            get { return textBox_addHomework_task.Text; }
        }
    }
}
