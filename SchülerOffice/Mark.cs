using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace SchülerOffice
{
    public class Mark
    {
        public string _class { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public Single mark { get; set; }
        public Single[] points { get; set; }
        public string note { get; set; }

        public Mark(string _class, string name, DateTime date, Single mark, Single[] points, string note)
        {
            this._class = _class;
            this.name = name;
            this.date = date;
            this.mark = mark;
            this.points = points;
            this.note = note;
        }

        public static string MarkToXml(Mark mark)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("_class", mark._class);
            data.Add("name", mark.name);
            data.Add("date", mark.date);
            data.Add("mark", mark.mark);
            data.Add("note", mark.note);

            StringBuilder xml = new StringBuilder();
            xml.AppendLine(" <mark>");
            foreach (KeyValuePair<string, object> item in data)
            {
                xml.AppendLine(String.Format("  <item key=\"{0}\">{1}</item>", item.Key, item.Value.ToString()));
            }
            foreach (float f in mark.points)
            {
                xml.AppendLine(String.Format("  <point>{0}</point>", f));
            }
            xml.AppendLine(" </mark>");
            return xml.ToString();
        }

        public static List<Mark> XmlToMark(string file)
        {
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
                    var properties = current.GetType().GetProperties();
                    Type ptype = current.GetType().GetProperty(nodekey).PropertyType;
                    current.GetType().GetProperty(nodekey).SetValue(current, Convert.ChangeType(xmlr.ReadElementContentAsString(), ptype), null);
				}
                else if (xmlr.Name == "point" && xmlr.NodeType == XmlNodeType.Element)
                {
                    cpoints.Add(Convert.ToSingle(xmlr.ReadElementContentAsString()));
                }
                else if (xmlr.Name == "mark" && xmlr.NodeType == XmlNodeType.EndElement)
                {
                    current.points = cpoints.ToArray();
                    loaded.Add(current);
                }
            }
            xmlfs.Close();
            return loaded;
        }
    }
}
