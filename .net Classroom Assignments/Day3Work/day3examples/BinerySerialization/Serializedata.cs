using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace BinerySerialization
{
    class Serializedata
    {
        FileStream file = null;
        public void savedata(PersonInfo pi)
        {
            try
            {
                file = new FileStream("C:\\files\\PersonInfo.bin", FileMode.Create, FileAccess.Write);
                BinaryFormatter format = new BinaryFormatter();
                format.Serialize(file, pi);
                Console.WriteLine("data serialized");
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                file.Close();
            }
        }
        public PersonInfo getdata()
        {
            PersonInfo ps = null;
            try
            {
                file = new FileStream("C:\\files\\PersonInfo.bin", FileMode.Open , FileAccess.Read);
                BinaryFormatter format = new BinaryFormatter();
                ps=(PersonInfo)format.Deserialize(file);
                
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                file.Close();
            }
            return ps;
        }
    }
}
