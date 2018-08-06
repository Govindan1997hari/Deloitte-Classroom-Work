using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Q3
{
    class readwirte
    {
        List<computerinfo> cinfo = new List<computerinfo>();
        public readwirte()
        {
            cinfo.Add(new computerinfo { item = "MotherBoard", manufacturer = "ASUS", model = "P3B-F", cost = 123.00 });
            cinfo.Add(new computerinfo { item = "Video card", manufacturer = "ATI", model = "ALL-in-Wonder Pro", cost = 160.00 });
            cinfo.Add(new computerinfo { item = "Sound card", manufacturer = "Creative Labs", model = "Sound Blaster Live", cost = 80.00 });
            cinfo.Add(new computerinfo { item = "inch Monitor", manufacturer = "LG Electronics", model = "995E", cost = 290.00 });
        }
        public void writefile()
        {
            XmlWriter x = XmlWriter.Create("c:\\files\\computerinfo.xml");
            x.WriteStartDocument();
            x.WriteStartElement("PARTS");
            foreach (var b in cinfo)
            {
                x.WriteStartElement("PART");
                x.WriteElementString("ITEM", b.item);
                x.WriteElementString("MANUFACTURER", b.manufacturer);
                x.WriteElementString("MODEL", b.model);
                x.WriteElementString("COST", b.cost.ToString());
                x.WriteEndElement();//end of "part"
            }
            x.WriteEndElement();//end of "parts"
            x.WriteEndDocument();
            x.Close();
            Console.WriteLine("Xml file Created");
        }
        public void readfile()
        {
            XElement ex=new XElement.load()
        }
    }
}
