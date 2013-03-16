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
            data.Add("_class", this._class);
            data.Add("name", this.name);
            data.Add("date", this.date);
            data.Add("mark", this.mark);
            data.Add("note", this.note);

            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<mark>"); // Add some type of name here
            foreach (KeyValuePair<string, object> item in data)
            {
                xml.AppendLine(String.Format("<item key=\"{0}\">{1}</item>", item.Key, item.Value.ToString()));
            }
            foreach (float f in points)
            {
                xml.AppendLine(String.Format("<point>{0}</point>", f));
            }
            xml.AppendLine("</mark>");
            return xml.ToString();
        }

        public List<Mark> XmlToMark(string file)
        {
            throw new NotImplementedException();
            FileStream xmlfs = new FileStream(file, FileMode.Open);
            XmlReader xmlr = XmlReader.Create(xmlfs);

			List<Mark> loaded = new List<Mark>();
			
            Mark current = null;
            List<float> cpoints = new List<float>();

            while (xmlr.Read())
            {
				if(xmlr.Name == "mark" && xmlr.NodeType == XmlNodeType.Element)
				{
					current = new Mark("","",DateTime.Now,0,new float[0],"");
                    cpoints = new List<float>();
				}
				else if(xmlr.Name == "item" && xmlr.NodeType == XmlNodeType.Element)
				{
                    string nodekey = xmlr.GetAttribute("key");
                    Type ptype = current.GetType().GetProperty(nodekey).GetType();
                    current.GetType().GetProperty(nodekey).SetValue(current, Convert.ChangeType(xmlr.ReadElementContentAsString(), ptype), null);
				}
                else if (xmlr.Name == "point" && xmlr.NodeType == XmlNodeType.Element)
                {
                    cpoints.Add(Convert.ToSingle(xmlr.ReadContentAsString()));
                }
                else if (xmlr.Name == "mark" && xmlr.NodeType == XmlNodeType.EndElement)
                {
                    current.points = cpoints.ToArray();
                    loaded.Add(current);
                }
            }
            return loaded;
        }
    }
}
