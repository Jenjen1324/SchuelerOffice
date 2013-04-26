using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchülerOffice
{
    public class HomeWork
    {
        /// <summary>
        /// What the homework is about
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Wheter the homework is completet or not
        /// </summary>
        public bool completet { get; set; }

        /// <summary>
        /// Which class is choosen
        /// (Count from the y axis)
        /// </summary>
        public int time { get; set; }
        /// <summary>
        /// Which day is choosen
        /// (Count from the x axis)
        /// </summary>
        public int day { get; set; }

        public HomeWork(string text, bool completet, int time, int day)
        {
            this.text = text;
            this.completet = completet;
            this.time = time;
            this.day = day;
        }
    }
}
