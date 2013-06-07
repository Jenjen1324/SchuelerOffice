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
        public Single pointsGot { get; set; }
        public Single pointsMax { get; set; }
        public string note { get; set; }

        public Mark(string _class, string name, DateTime date, Single mark, float GottenPoints, float MaxPoints, string note)
        {
            this._class = _class;
            this.name = name;
            this.date = date;
            this.mark = mark;
            this.pointsGot = GottenPoints;
            this.pointsMax = MaxPoints;
            this.note = note;
        }

        public static string MarkToXml(Mark mark)
        {
            //Load type
            Type t = typeof(Mark);
            
            //Init builder
            StringBuilder xml = new StringBuilder();
            //Start mark node
            xml.AppendLine("\t<mark>");

            //Loop through each property in class
            foreach (var property in t.GetProperties())
            {
                //Store property in xml
                xml.AppendLine(
                    String.Format("\t\t<item key=\"{0}\">{1}</item>",
                    //Name of property
                    property.Name,
                    //Gets value from instance and converts to string
                    property.GetValue(mark,null).ToString()));
            }
            xml.AppendLine("\t</mark>");
            return xml.ToString();
        }

        public static List<Mark> XmlToMark(string file)
        {
            //Check if file exists
            if (File.Exists(file))
            {
                //-------------Read file---------------------

                //Open streams
                FileStream xmlfs = new FileStream(file, FileMode.Open);
                XmlReader xmlr = XmlReader.Create(xmlfs);

                //Create empty list to hold loaded marks
                List<Mark> loaded = new List<Mark>();

                //Initialize storing vars
                Mark current = null;

                //Begin read loop
                while (xmlr.Read())
                {
                    if (xmlr.Name == "mark" && xmlr.NodeType == XmlNodeType.Element)
                    {
                        current = new Mark("", "", DateTime.Now, 0, 0, 0, "");
                    }
                    else if (xmlr.Name == "item" && xmlr.NodeType == XmlNodeType.Element)
                    {
                        //Get property name
                        string nodekey = xmlr.GetAttribute("key");

                        //load properties in class
                        Type ptype = current.GetType().GetProperty(nodekey).PropertyType;

                        //Set property
                        current.GetType().GetProperty(nodekey).SetValue(
                            //Store in current
                            current,
                            //Cast data in element to property type
                            Convert.ChangeType(
                                xmlr.ReadElementContentAsString(),
                                ptype),
                            //Not used, only for indexed properties. Use null
                            null);
                    }
                    else if (xmlr.Name == "mark" && xmlr.NodeType == XmlNodeType.EndElement)
                    {
                        loaded.Add(current);
                    }
                }
                xmlfs.Close();
                return loaded;
            }
            else
            {
                return null;
            }
        }
    }

    public class _class
    {
        int[][] index { get; set; }
        string Text { get; set; }
        string Desc { get; set; }
        //string 
    }
}
