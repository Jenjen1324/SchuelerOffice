using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SchülerOffice.VocabManager
{
    public class Vocabulary
    {
        public string name { get; set; }
        public string desc { get; set; }
        public List<VocWord> words { get; set; }
        public string author { get; set; }
        public string date { get; set; }
        public string fromLang { get; set; }
        public string toLang { get; set; }

        public Vocabulary(string name, string desc, List<VocWord> words, string author, string date, string fromLang, string toLang)
        {
            this.name = name;
            this.desc = desc;
            this.words = words;
            this.author = author;
            this.date = date;
            this.fromLang = fromLang;
            this.toLang = toLang;
        }

        public Vocabulary()
        {
            name = "";
            desc = "";
            words = new List<VocWord>();
            author = "";
            date = "";
            fromLang = "";
            toLang = "";
        }

        public static string vocabToXml(Vocabulary voc)
        {
            Type t = typeof(Vocabulary);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<Vocabulary>");
            foreach (var val in t.GetProperties())
            {
                if (val.Name == "words")
                {
                    sb.AppendLine("\t<words>");
                    foreach (VocWord word in voc.words)
                    {
                        sb.AppendLine(
                            String.Format("\t\t<word fromVal=\"{0}\" toVal=\"{1}\" desc=\"{2}\" />",
                            word.fromVal,
                            word.toVal,
                            word.desc
                            ));
                    }
                    sb.AppendLine("\t</words>");
                }
                else
                {
                    sb.AppendLine(
                        String.Format("\t<item key=\"{0}\">{1}</item>",
                        val.Name,
                        val.GetValue(voc).ToString()));
                }
            }
            sb.AppendLine("</Vocabulary>");
            return sb.ToString();
        }

        public static Vocabulary xmlToVocab(string xml)
        {
            StringReader s = new StringReader(xml);
            XmlReader xmlr = XmlReader.Create(s);
            Vocabulary current = null;

            while (xmlr.Read())
            {
                if (xmlr.Name == "Vocabulary" && xmlr.NodeType == XmlNodeType.Element)
                {
                    current = new Vocabulary("","",new List<VocWord>(), "","","","");
                }
                if (xmlr.Name == "item" && xmlr.NodeType == XmlNodeType.Element)
                {
                    string nodekey = xmlr.GetAttribute("key");
                    Type ptype = current.GetType().GetProperty(nodekey).PropertyType;
                    current.GetType().GetProperty(nodekey).SetValue(current,
                        Convert.ChangeType(xmlr.ReadElementContentAsString(),ptype),
                        null);
                }
                if (xmlr.Name == "word")
                {
                    VocWord currentWord = new VocWord(
                        xmlr.GetAttribute("fromVal"), 
                        xmlr.GetAttribute("toVal"), 
                        xmlr.GetAttribute("desc")
                        );
                    current.words.Add(currentWord);
                }
                if (xmlr.Name == "Vocabulary" && xmlr.NodeType == XmlNodeType.EndElement)
                {
                    return current;
                }
            }

            return new Vocabulary();
        }
    }

    public class VocWord
    {
        public string fromVal { get; set; }
        public string toVal { get; set; }
        public string desc { get; set; }

        public bool correct = false;


        public VocWord(string fromVal, string toVal, string desc)
        {
            this.fromVal = fromVal;
            this.toVal = toVal;
            this.desc = desc;
        }
    }
}
