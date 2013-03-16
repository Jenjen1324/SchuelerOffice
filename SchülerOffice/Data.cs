using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchülerOffice
{
    public static class Data
    {
        internal static List<string> classes = new List<string>();

        internal static List<Mark> marks = new List<Mark>();

        internal static void messageBox(string Title,string Message)
        {
            MessageBox.Show(Message, Title);
        }

        internal static Language lang = new Language();
    }
}
