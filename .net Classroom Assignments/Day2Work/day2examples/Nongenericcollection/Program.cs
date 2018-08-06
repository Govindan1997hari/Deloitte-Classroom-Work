using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nongenericcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(12);
            a1.Add("hello world");
            a1.Add('d');
            Console.WriteLine("after adding");
            foreach (object t in a1)
                Console.WriteLine(t);
            a1.Insert(0, "new data");
            a1.Insert(2, "anbother daya");
            Console.WriteLine("after inserting");
            foreach (object t in a1)
                Console.WriteLine(t);
            a1.Remove(12);
            a1.RemoveAt(2);
            Console.WriteLine("after removing");
            foreach (object t in a1)
                Console.WriteLine(t);
            Console.WriteLine("specific data:" + a1[1]);
            Hashtable ht = new Hashtable();
            ht.Add("IN", "INDIA");
            ht.Add("US", "AMERICA");
            ht.Add("UK", "UNITED KINGDOM");
            //ht.Add("IN", "BHARAT"); throws runtime exception as key has to be unique data
            IDictionaryEnumerator ide = ht.GetEnumerator();
            while(ide.MoveNext())
            {
                Console.WriteLine(ide.Key + "," + ide.Value);
            }
            List<string> cities = new List<string>();
            cities.Add("mysore");
            cities.Add("mumbai");
            cities.Add("chennai");
            cities.Add("karnataka");
            foreach (string t in cities)
                Console.WriteLine(t);
            Dictionary<string, string> country = new Dictionary<string, string>();
            country.Add("in", "india");
            country.Add("us", "America");
            //foreach (KeyValuePair<string,string> kvp in country) ;
            //{
               // Console.WriteLine(kvp.key + "," + kvp.value);
           // }
        }
    }
}
