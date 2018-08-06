using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace xmlserialization
{
    class serialize
    {
        FileStream fs = null;
        public void savedata(personinfo pi)
        {
            try
            {
                fs = new FileStream(@"C:\files\personinfo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(personinfo));
                xs.Serialize(fs, pi);
                Console.WriteLine("Data serialized");
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        public personinfo getdata()
        {
            personinfo pi = null;
            try
            {
                fs = new FileStream("c:\\files\\personinfo.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(personinfo));
                pi = (personinfo)xs.Deserialize(fs);
                Console.WriteLine("Successfully deserialized");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
            return pi;
        }
    }
}
