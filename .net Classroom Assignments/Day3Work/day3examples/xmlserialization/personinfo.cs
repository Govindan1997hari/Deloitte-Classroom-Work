using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xmlserialization
{
    [Serializable]
    [XmlRoot]
    public class personinfo
    {
        [XmlElement]
        public string name { get; set; }
        [XmlElement]
        public int age { get; set; }
        public personinfo(string n,int a)
        {
            name = n;
            age = a;
        }
        public personinfo()
        { }
        public void showdata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
        }
    }
}
