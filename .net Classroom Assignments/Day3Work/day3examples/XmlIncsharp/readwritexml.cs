using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlIncsharp
{
    class readwritexml
    {
        List<bookinfo> blist = new List<bookinfo>();
        public readwritexml()
        {
            blist.Add(new bookinfo { bookid = 1, title = "malgudi days", category = "story", price = 350 });
            blist.Add(new bookinfo { bookid = 1, title = "science vs real life", category = "fictional", price = 500 });
            blist.Add(new bookinfo { bookid = 1, title = "c programming", category = "technology", price = 700 });
        }
        public void writexml()
        {
            XmlWriter w = XmlWriter.Create("c:\\Files\\bookinfo.xml");
            w.WriteStartDocument();
            w.WriteStartElement("bookinfo");
            foreach (var b in blist)
            {
                w.WriteStartElement("books");
                w.WriteAttributeString("bookid", b.bookid.ToString());
                w.WriteStartElement("Description");
                w.WriteElementString("title", b.title);
                w.WriteElementString("category", b.category);
                w.WriteEndElement();//closes description
                w.WriteElementString("price", b.price.ToString());
                w.WriteEndElement();//closes books
            }
            w.WriteEndElement();//closes bookinfo
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("xml created");
        }
        public void readxml()
        {
            XElement xe = XElement.Load("c:\\files\\bookinfo.xml");
            var data = xe.Elements();
            foreach (var d in data)
                Console.WriteLine(d);
            Console.WriteLine("***********");
            //read element data
            foreach (var d in data)
                Console.WriteLine(d.Element("Description").Element("title").Value + " " + d.Element("price").Value);
            Console.WriteLine("***********");
            var data2 = from t in xe.Elements("books")
                        where (int)t.Element("price") > 500
                        select t;
            foreach (var d in data2)
                Console.WriteLine(d);
        }
    }
}
