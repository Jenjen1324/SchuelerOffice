using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchülerOffice
{
    public class Vocabulary
    {
        public string name;
        public string desc;
        public List<VocWord> words;
        public string author;
        public string date;
        public string fromLang;
        public string toLang;

    }

    public class VocWord
    {
        public string fromName;
        public string toName;
        public string desc;
    }
}
