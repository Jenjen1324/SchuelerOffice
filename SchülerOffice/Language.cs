using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchülerOffice
{
    class Language
    {
        

        public string somestring { get; set; }

        public string classes { get; set; }

        public string marks { get; set; }

        public string mark { get; set; }

        public string markDate { get; set; }

        public string markName { get; set; }

        public string markNote { get; set; }

        public string markPoints { get; set; }

        public static Language LoadFromFile(string file)
        {
            throw new NotImplementedException();
        }
    }
}
