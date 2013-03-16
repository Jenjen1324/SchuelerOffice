using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace SchülerOffice
{
    class Mark
    {
        public string _class;
        public string name;
        public DateTime date;
        public Single mark;
        public Single[] points;
        public string note;

        public Mark(string _class, string name, DateTime date, Single mark, Single[] points, string note)
        {
            this._class = _class;
            this.name = name;
            this.date = date;
            this.mark = mark;
            this.points = points;
            this.note = note;
        }

        public string MarkToXml(Mark mark)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("class", this._class);
            data.Add("name", this.name);
            data.Add("date", this.date);
            data.Add("mark", this.mark);
            data.Add("points", this.points);
            data.Add("note", this.note);

            StringBuilder xml = new StringBuilder();
            xml.AppendLine(String.Format("<node name=\"{0}\">", "Mark")); // Add some type of name here
            foreach (KeyValuePair<string,object> item in data)
            {
                xml.AppendLine(String.Format("<item key=\"{0}\">{1}</item>", item.Key, item.Value.ToString()));
            }
            xml.AppendLine("</node>");
            return xml.ToString();
        }

        public Mark XmlToMark(string file)
        {
            throw new NotImplementedException();
            FileStream xmlfs = new FileStream(file, FileMode.Open);
            XmlReader xmlr = XmlReader.Create(xmlfs);

            Mark current = null;
            while (xmlr.Read())
            {
                // Need some work
            }
        }
    }
}
